using Microsoft.EntityFrameworkCore;


using NUnit.Framework.Legacy;


using OnlineQuizApplicationAPI.DTO;


using OnlineQuizApplicationAPI.Models;


using OnlineQuizApplicationAPI;
using OnlineQuizApplicationAPI.Services;


using static OnlineQuizApplicationAPI.DTO.AccountAdminDTO;

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


    public void AddUserTest()


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


    public void AddAdminTest()


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


    public void DeleteAccountTest()


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

        var result = _service.DeleteAccount(account.AccountId);

        ClassicAssert.IsTrue(result);


        ClassicAssert.IsNull(_context.Accounts.FirstOrDefault(a => a.AccountId == account.AccountId));


    }
}


