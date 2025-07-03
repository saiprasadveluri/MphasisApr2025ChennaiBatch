using Microsoft.EntityFrameworkCore;
using NUnit.Framework.Legacy;
using OnlineQuizAPI.DTO;
using OnlineQuizAPI.Model;
using QuizAPI;
using static OnlineQuizAPI.DTO.AccountAdmin;

[TestFixture]
public class ServicesAPITests
{
    private QuizDbContext _context;
    private ServicesAPI _service;

    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<QuizDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        _context = new QuizDbContext(options);
        _context.Database.EnsureCreated();
        _service = new ServicesAPI(_context);
    }

    [TearDown]
    public void Cleanup()
    {
        _context.Database.EnsureDeleted();
        _context.Dispose();
    }

    [Test]
    public void AddUser_ShouldAddUserToDatabase()
    {
        var userDto = new AccountUserDTO
        {
            UserName = "John",
            ContactNo = "1234567890",
            Email = "john@example.com",
            Password = "securepwd"
        };

        var result = _service.AddUser(userDto);

        ClassicAssert.IsTrue(result, "AddUser should return true on successful save.");

        var userInDb = _context.UserInfos.Include(u => u.accountData).FirstOrDefault();
        ClassicAssert.IsNotNull(userInDb, "UserInfo should be added to the database.");
        ClassicAssert.AreEqual(userDto.UserName, userInDb.UserName);
        ClassicAssert.AreEqual(userDto.ContactNo, userInDb.ContactNo);
        ClassicAssert.AreEqual(userDto.Email, userInDb.accountData.Email);
        ClassicAssert.AreEqual(userDto.Password, userInDb.accountData.Password);
    }
    [Test]
    public void AddAdmin_ShouldAddAdminToDatabase()
    {
        var adminDto = new AccountAdminDTO
        {
            AdminName = "Admin One",
            ContactNo = "9999999999",
            Email = "admin@example.com",
            Password = "admin123"
        };

        var result = _service.AddAdmin(adminDto);

        ClassicAssert.IsTrue(result);
        var adminInDb = _context.AdminInfos.Include(a => a.userData).FirstOrDefault();
        ClassicAssert.IsNotNull(adminInDb);
        ClassicAssert.AreEqual(adminDto.AdminName, adminInDb.AdminName);
        ClassicAssert.AreEqual(adminDto.Email, adminInDb.userData.Email);
    }
    [Test]
    public void DeleteAccount_ShouldDeleteAccount_WhenAccountExists()
    {
        var account = new Account
        {
            AccountId = Guid.NewGuid(),
            Email = "test@test.com",
            Password = "pwd",
            Role = "User"
        };
        _context.Accounts.Add(account);
        _context.SaveChanges();

        var result = _service.DeleteUser(account.AccountId);

        ClassicAssert.IsTrue(result);
        ClassicAssert.IsNull(_context.Accounts.FirstOrDefault(a => a.AccountId == account.AccountId));
    }
    [Test]
    public void DeleteAdmin_ShouldDeleteAdmin_WhenAdminExists()
    {
        var accountId = Guid.NewGuid();

        // Step 1: Add account
        var account = new Account
        {
            AccountId = accountId,
            Email = "admin@test.com",
            Password = "pass123",
            Role = "Admin"
        };
        _context.Accounts.Add(account);

        // Step 2: Add AdminInfo linked to the account
        var admin = new AdminInfo
        {
            AdminId = Guid.NewGuid(),
            AdminName = "Test Admin",
            ContactNo = "12345",
            AccountId = accountId
        };
        _context.AdminInfos.Add(admin);

        _context.SaveChanges();

        // Step 3: Delete the account (which also deletes AdminInfo due to cascade)
        var result = _service.DeleteUser(accountId);

        // Step 4: Assert
        ClassicAssert.IsTrue(result);
        ClassicAssert.IsNull(_context.Accounts.FirstOrDefault(a => a.AccountId == accountId));
        ClassicAssert.IsNull(_context.AdminInfos.FirstOrDefault(a => a.AccountId == accountId)); // ✅ Now expecting null
    }

    [Test]
    public void GetAllUsers_ShouldReturnAllUsersAsDTOs()
    {
        _context.UserInfos.AddRange(
            new UserInfo { UserId = Guid.NewGuid(), UserName = "User1", ContactNo = "11111" },
            new UserInfo { UserId = Guid.NewGuid(), UserName = "User2", ContactNo = "22222" }
        );
        _context.SaveChanges();

        var result = _service.GetAllUsers();

        ClassicAssert.AreEqual(2, result.Count);
        ClassicAssert.IsTrue(result.Any(u => u.UserName == "User1"));
        ClassicAssert.IsTrue(result.Any(u => u.UserName == "User2"));
    }
    [Test]
    public void GetUserById_ShouldReturnUserWithAccountDetails()
    {
        var accountId = Guid.NewGuid();

        var user = new UserInfo
        {
            UserId = Guid.NewGuid(),
            UserName = "TestUser",
            ContactNo = "999",
            AccountId = accountId, // ✅ Set the FK manually
            accountData = new Account
            {
                AccountId = accountId,
                Email = "test@user.com",
                Password = "pwd",
                Role = "User" // ✅ Add role if it's required in model
            }
        };

        _context.UserInfos.Add(user);
        _context.SaveChanges();

        var result = _service.GetUserById(user.UserId);

        ClassicAssert.IsNotNull(result);
        ClassicAssert.AreEqual(user.UserName, result.UserName);
        ClassicAssert.AreEqual(user.accountData.Email, result.Email);
    }
    [Test]
    public void GetAdminById_ShouldReturnAdminWithAccountDetails()
    {
        var admin = new AdminInfo
        {
            AdminId = Guid.NewGuid(),
            AdminName = "SuperAdmin",
            ContactNo = "123456",
            userData = new Account
            {
                AccountId = Guid.NewGuid(),
                Email = "admin@test.com",
                Password = "adminpwd",
                Role = "Admin"  // ✅ Add this line
            }
        };
        _context.AdminInfos.Add(admin);
        _context.SaveChanges();

        var result = _service.GetAdminById(admin.userData.AccountId);

        ClassicAssert.IsNotNull(result);
        ClassicAssert.AreEqual(admin.AdminName, result.AdminName);
        ClassicAssert.AreEqual(admin.userData.Email, result.Email);
    }
    [Test]
    public void GetAllUsers_ShouldReturnAllUserBasicDetails()
    {
        var userId = Guid.NewGuid();
        var accountId = Guid.NewGuid();

        _context.UserInfos.Add(new UserInfo
        {
            UserId = userId,
            UserName = "AccountUser",
            ContactNo = "456",
            AccountId = accountId,
            accountData = new Account
            {
                AccountId = accountId,
                Email = "user@example.com",   // ✅ Required field
                Password = "test",
                Role = "User"
            }
        });
        _context.SaveChanges();

        var result = _service.GetAllUsers();

        ClassicAssert.AreEqual(1, result.Count);
        ClassicAssert.AreEqual("AccountUser", result[0].UserName);
        ClassicAssert.AreEqual("456", result[0].ContactNo);
        ClassicAssert.AreEqual(accountId, result[0].AccountId);
        ClassicAssert.AreEqual(userId, result[0].UserId);
    }
    [Test]
    public void GetCategoryByName_ShouldReturnCategoryDTO_WhenExists()
    {
        var category = new Category
        {
            CategoryId = Guid.NewGuid(),
            CategoryName = "Tech"
        };
        _context.Category.Add(category);
        _context.SaveChanges();

        var result = _service.GetCategoryByName("Tech");

        ClassicAssert.IsNotNull(result);
        ClassicAssert.AreEqual(category.CategoryId, result.CategoryId);
    }
    [Test]
    public void GetAllAdmins_ShouldReturnAllAdmins()
    {
        _context.AdminInfos.Add(new AdminInfo
        {
            AdminId = Guid.NewGuid(),
            AdminName = "AdminX",
            ContactNo = "888",
            AccountId = Guid.NewGuid()
        });
        _context.SaveChanges();

        var result = _service.GetAllAdmins();

        ClassicAssert.AreEqual(1, result.Count);
        ClassicAssert.AreEqual("AdminX", result[0].AdminName);
    }
    [Test]
    public void GetAllAccountDetails_ShouldReturnAllAccounts()
    {
        _context.Accounts.AddRange(
            new Account { AccountId = Guid.NewGuid(), Email = "user1@test.com", Password = "pass1", Role = "User" },
            new Account { AccountId = Guid.NewGuid(), Email = "admin1@test.com", Password = "admin1", Role = "Admin" }
        );
        _context.SaveChanges();

        var result = _service.GetAllAcountDetails();

        ClassicAssert.AreEqual(2, result.Count);
        ClassicAssert.IsTrue(result.Any(a => a.Role == "User"));
        ClassicAssert.IsTrue(result.Any(a => a.Role == "Admin"));
    }
    [Test]
    public void GetAllTopicsByCategory_ShouldReturnAllTopicsForCategory()
    {
        var categoryId = Guid.NewGuid();

        _context.Topics.AddRange(
            new Topics { TopicId = Guid.NewGuid(), TopicName = "OOP", CategoryId = categoryId },
            new Topics { TopicId = Guid.NewGuid(), TopicName = "Data Structures", CategoryId = categoryId }
        );
        _context.SaveChanges();

        var result = _service.GetAllTopicsByCategory(categoryId);

        ClassicAssert.AreEqual(2, result.Count);
        ClassicAssert.IsTrue(result.Any(t => t.TopicName == "OOP"));
    }
    [Test]
    public void GetQuestionsByTopicId_ShouldReturnMatchingQuestion()
    {
        var topicId = Guid.NewGuid(); // ✅ create a topic ID
        var questionId = Guid.NewGuid();

        _context.Questions.Add(new Questions
        {
            QuestionId = questionId,
            QuestionText = "What is C#?",
            TopicId = topicId,
            Options = new List<Options>
        {
            new Options { OptionId = Guid.NewGuid(), OptionText = "A programming language", Answer = 1 },
            new Options { OptionId = Guid.NewGuid(), OptionText = "A fruit", Answer = 0 },
            new Options { OptionId = Guid.NewGuid(), OptionText = "A game", Answer = 0 },
            new Options { OptionId = Guid.NewGuid(), OptionText = "An OS", Answer = 0 }
        }
        });

        _context.SaveChanges();

        var result = _service.GetQuestionWithOptionByTopics(topicId); // ✅ pass correct TopicId

        ClassicAssert.AreEqual(1, result.Count);
        ClassicAssert.AreEqual("What is C#?", result.First().QuestionText);
        ClassicAssert.AreEqual(4, result.First().Options.Count);
        ClassicAssert.IsTrue(result.First().Options.Any(o => o.Answer == 1));
    }
    [Test]
    public void GetAllQuestionsWithOptions_ShouldReturnQuestionsAndOptions()
    {
        var questionId = Guid.NewGuid();
        _context.Questions.Add(new Questions
        {
            QuestionId = questionId,
            QuestionText = "2 + 2 = ?",
            TopicId = Guid.NewGuid(),
            Options = new List<Options>
        {
            new Options { OptionId = Guid.NewGuid(), OptionText = "4", Answer = 1 },
            new Options { OptionId = Guid.NewGuid(), OptionText = "5", Answer = 0 }
        }
        });
        _context.SaveChanges();

        var result = _service.GetAllQuestionsWithOptions();

        ClassicAssert.AreEqual(1, result.Count);
        ClassicAssert.AreEqual(2, result[0].Options.Count);
    }
        [Test]
        public void GetQuestionWithOptionByTopics_ShouldReturnQuestionsByTopic()
        {
            var topicId = Guid.NewGuid();
            _context.Questions.Add(new Questions
            {
                QuestionId = Guid.NewGuid(),
                QuestionText = "What is polymorphism?",
                TopicId = topicId,
                Options = new List<Options>
        {
            new Options { OptionId = Guid.NewGuid(), OptionText = "OOP concept", Answer = 1 },
            new Options { OptionId = Guid.NewGuid(), OptionText = "Not sure", Answer = 0 }
        }
            });
            _context.SaveChanges();

            var result = _service.GetQuestionWithOptionByTopics(topicId);

            ClassicAssert.AreEqual(1, result.Count);
            ClassicAssert.AreEqual("What is polymorphism?", result[0].QuestionText);
            ClassicAssert.AreEqual(2, result[0].Options.Count);
        }
    }
