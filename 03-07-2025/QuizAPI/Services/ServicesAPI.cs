using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using OnlineQuizApp.Models;
using QuizAPI.DTO;
using QuizAPI.Models;

namespace QuizAPI
{
    public class ServicesAPI
    {
        public QuizDbContext context;
        public ServicesAPI(QuizDbContext ctx)
        {
            context = ctx;
        }
        //Register User
        public bool AddUser(AccountUserDTO user)
        {
            UserInfo userInfo = new UserInfo();
            userInfo.UserId = Guid.NewGuid();
            userInfo.UserName = user.UserName;
            userInfo.ContactNo = user.ContactNo;
            Account account = new Account();
            account.AccountId = Guid.NewGuid();
            account.Email = user.Email;
            account.Password = user.Password;
            account.Role = "User";
            userInfo.accountData = account;
            context.UserInfos.Add(userInfo);
            int Res = context.SaveChanges();
            if (Res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Get user details
        public List<UserInfoDTO> GetAllUsers()
        {
            List<UserInfoDTO> res = (from obj in context.UserInfos
                                     select new UserInfoDTO
                                     {
                                         UserId = obj.UserId,
                                         AccountId = obj.AccountId,
                                         UserName = obj.UserName,
                                         ContactNo = obj.ContactNo
                                     }).ToList();
            return res;
        }
        //get list of user data from the admin side
        public List<GetAccountUserDTO> GetAllUserAccounts()
        {
            List<GetAccountUserDTO> res = (from obj in context.UserInfos
                                           select new GetAccountUserDTO
                                           {
                                               UserId = obj.UserId,
                                               AccountId = obj.AccountId,
                                               UserName = obj.UserName,
                                               ContactNo = obj.ContactNo,
                                               Email = obj.accountData.Email,
                                               Password = obj.accountData.Password
                                           }).ToList();
            return res;
        }
        //get user data by id from the user side
        public List<GetAccountUserDTO> GetUserById(Guid id)//For user action
        {
            List<GetAccountUserDTO> res = context.UserInfos.Where(c => c.UserId == id).Select(obj => new GetAccountUserDTO
            {
                UserId = obj.UserId,
                AccountId = obj.AccountId,
                UserName = obj.UserName,
                ContactNo = obj.ContactNo,
                Email = obj.accountData.Email,
                Password = obj.accountData.Password

            }).ToList();

            return res;
        }
        //Delete user
        public bool DeleteUser(Guid id)
        {
            var res = context.Accounts.Where(u => u.AccountId == id).FirstOrDefault();
            if (res != null)
            {
                context.Accounts.Remove(res);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        //Admin Registeration
        public bool AddAdmin(AccountAdminDTO admin)
        {
            AdminInfo adminInfo = new AdminInfo();
            adminInfo.AdminId = Guid.NewGuid();
            adminInfo.AdminName = admin.AdminName;
            adminInfo.ContactNo = admin.ContactNo;
            Account account = new Account();
            account.AccountId = Guid.NewGuid();
            account.Email = admin.Email;
            account.Password = admin.Password;
            account.Role = "Admin";
            adminInfo.userData = account;
            context.AdminInfos.Add(adminInfo);
            int Res = context.SaveChanges();
            if (Res > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Get all Admins
        public List<AdminInfoDTO> GetAllAdmins()
        {
            List<AdminInfoDTO> res = (from obj in context.AdminInfos
                                      select new AdminInfoDTO
                                      {
                                          AdminId = obj.AdminId,
                                          AccountId = obj.AccountId,
                                          AdminName = obj.AdminName,
                                          ContactNo = obj.ContactNo
                                      }).ToList();
            return res;
        }
        //get admin by id
        public GetAccountAdminDTO GetAdminById(Guid id)
        {
            GetAccountAdminDTO res = context.AdminInfos.Where(c => c.AccountId == id).Select(obj => new GetAccountAdminDTO
            {
                AdminId = obj.AdminId,
                AccountId = obj.AccountId,
                AdminName = obj.AdminName,
                ContactNo = obj.ContactNo,
                Email = obj.userData.Email,
                Password = obj.userData.Password

            }).FirstOrDefault();

            return res;
        }
        //Get all accounts
        public List<AccountDTO> GetAllAcountDetails()
        {
            List<AccountDTO> res = (from obj in context.Accounts
                                    select new AccountDTO
                                    {
                                        AccountId = obj.AccountId,
                                        Email = obj.Email,
                                        Password = obj.Password,
                                        Role = obj.Role
                                    }).ToList();
            return res;
        }
        //Add Categories
        public bool AddCategoryWithTopics(CategoryWithTopicsDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.CategoryName) || dto.Topics == null) return false;
            try
            {
                Category category = new Category();
                category.CategoryId = Guid.NewGuid();
                category.CategoryName = dto.CategoryName;
                category.technologies = dto.Topics.Select(t => new Topics
                {
                    TopicId = Guid.NewGuid(),
                    TopicName = t.TopicName,

                }).ToList();
                context.Category.Add(category);
                int Res = context.SaveChanges();
                if (Res > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }
        
        //Adding Question with options Services
        public bool AddQuestionsWithOptions(QuestionOptionsDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.QuestionText) || dto.Options == null || dto.Options.Count < 4)
            {
                return false;
            }
            if (dto.Options.Count(o => o.Answer == 1) != 1)
            {
                return false;
            }
            try
            {
                Questions question = new Questions();
                question.QuestionId = Guid.NewGuid();
                question.QuestionText = dto.QuestionText;
                question.TopicId = dto.TopicId;
                question.Options = dto.Options.Select(o => new Options
                {
                    OptionId = Guid.NewGuid(),
                    OptionText = o.OptionText,
                    Answer = o.Answer
                }).ToList();
                context.Questions.Add(question);
                context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }
        //get questions and options
        public List<GetQuestionWithOptionsDTO> GetAllQuestionsWithOptions()
        {
            List<GetQuestionWithOptionsDTO> result = context.Questions.Include(q => q.Options).Select(q => new GetQuestionWithOptionsDTO

            {
                QuestionId =q.QuestionId,
                QuestionText = q.QuestionText,

                TopicId = q.TopicId,

                Options = q.Options.Select(o => new GetOptionsDTO

                {
                    OptionId=o.OptionId,
                    OptionText = o.OptionText,

                    Answer = o.Answer

                }).ToList()

            }).ToList();

            return result;

        }
        //get questions with options by topic id
        public List<GetQuestionWithOptionsDTO> GetQuestionWithOptionByTopics(Guid id)
        {
            List<GetQuestionWithOptionsDTO> result = context.Questions.Where(c => c.TopicId == id).Select(obj => new GetQuestionWithOptionsDTO
            {
                QuestionId = obj.QuestionId,
                QuestionText = obj.QuestionText,
                TopicId = obj.TopicId,
                Options = obj.Options.Select(o => new GetOptionsDTO
                {
                    OptionId = o.OptionId,
                    OptionText = o.OptionText,
                    Answer = o.Answer
                }).ToList()

            }).ToList();
            return result;
        }
        //Add quiz by admin side

        public bool AddQuizwithQuestionsByCategory(QuizQuestionsDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.QuizTitle) || string.IsNullOrWhiteSpace(dto.CategoryName))
            {
                return false;
            }
            try
            {
                Quiz quiz = new Quiz();
                quiz.QuizId = Guid.NewGuid();
                quiz.QuizTitle = dto.QuizTitle;
                quiz.CategoryName = dto.CategoryName;
                quiz.Duration = dto.Duration;
                quiz.ScheduleTime = dto.ScheduleTime;
                quiz.Questions = new List<Questions>();
                GetCategoryDTO Categories = GetCategoryByName(dto.CategoryName);
                List<GetTopicsDTO> Topics = GetAllTopicsByCategory(Categories.CategoryId);
                List<GetQuestionWithOptionsDTO> allQuestions = new List<GetQuestionWithOptionsDTO>();
                foreach (GetTopicsDTO topic in Topics)
                {
                    List<GetQuestionWithOptionsDTO> List = GetQuestionWithOptionByTopics(topic.TopicId);
                    allQuestions.AddRange(List);
                    foreach (var questionDTO in allQuestions)
                    {

                        Questions questionEntity = context.Questions.FirstOrDefault(q => q.QuestionId == questionDTO.QuestionId);
                        if (questionEntity != null)
                        {
                            quiz.Questions.Add(questionEntity);
                        }
                    }
                }
                context.Quizs.Add(quiz);
                int Res = context.SaveChanges();
                if (Res > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public GetCategoryDTO GetCategoryByName(string CategoryName)
        {
            GetCategoryDTO result = context.Category.Where(t => t.CategoryName == CategoryName).Select(obj => new GetCategoryDTO
            {
                CategoryId = obj.CategoryId,
                CategoryName = obj.CategoryName,
            }).FirstOrDefault();
            return result;
        }
        public List<GetTopicsDTO> GetAllTopicsByCategory(Guid id)
        {
            List<GetTopicsDTO> result = context.Topics.Where(t => t.CategoryId == id).Select(obj => new GetTopicsDTO
            {
                TopicId = obj.TopicId,
                TopicName = obj.TopicName,
                CategoryId = obj.CategoryId
            }).ToList();
            return result;
        }

        public GetAccountAdminDTO UpdateAdmin(Guid Id, UpdateAdminDTO data)
        {
            var account = context.Accounts.FirstOrDefault(a => a.AccountId == Id);

            // Fetch admin related to account
            var admin = context.AdminInfos.FirstOrDefault(ad => ad.AccountId == Id);

            if (account == null || admin == null)
            {
                return null; // or throw an exception/log appropriately
            }

            // Update Account table
            account.Password = data.Password;

            // Update Admin table
            admin.AdminName = data.AdminName;
            admin.ContactNo = data.ContactNo;

            // Save all changes
            context.SaveChanges();

            return new GetAccountAdminDTO
            {
                AccountId = account.AccountId,
                AdminId = admin.AdminId,
                AdminName = admin.AdminName,
                Email = account.Email,
                Password = account.Password,
                ContactNo = admin.ContactNo
            };

        }
        public List<GetQuizDTO> GetQuizzesByCategory(string CategoryName)
        {
            List<GetQuizDTO> result = context.Quizs.Where(q => q.CategoryName == CategoryName).Select(obj => new GetQuizDTO
            {
                quizId = obj.QuizId,
                quizTitle = obj.QuizTitle,
                categoryName = obj.CategoryName,
                duration = obj.Duration,
                scheduleTime = obj.ScheduleTime,
                Questions = obj.Questions,
            }).ToList();
            return result;
        }
        //get quiz id
        public QuizDTO GetQuizById(Guid quizId)
        {
            var quiz = context.Quizs.FirstOrDefault(q => q.QuizId == quizId);

            var quizDto = new QuizDTO
            {
                QuizTitle = quiz.QuizTitle,
                CategoryName = quiz.CategoryName,
                Duration = quiz.Duration,
                ScheduleTime = quiz.ScheduleTime
            };

            return quizDto;
        }
        public List<GetQuestionWithOptionsDTO> GetRandomQuestionsByQuiz(Guid id)
        {
            GetQuizDTO quiz = context.Quizs.Where(c => c.QuizId == id).Select(obj => new GetQuizDTO
            {
                quizId = obj.QuizId,
                quizTitle = obj.QuizTitle,
                categoryName = obj.CategoryName,
                duration = obj.Duration,
                scheduleTime = obj.ScheduleTime,
                Questions = obj.Questions,
            }).FirstOrDefault();

            GetCategoryDTO Categories = GetCategoryByName(quiz.categoryName);
            List<GetTopicsDTO> Topics = GetAllTopicsByCategory(Categories.CategoryId);
            List<GetQuestionWithOptionsDTO> allQuestions = new List<GetQuestionWithOptionsDTO>();
            foreach (GetTopicsDTO topic in Topics)
            {
                List<GetQuestionWithOptionsDTO> List = GetQuestionWithOptionByTopics(topic.TopicId);
                allQuestions.AddRange(List);
            }
            var random = new Random();
            var randomizedQuestions = allQuestions.OrderBy(q => random.Next()).Take(3).ToList();
            foreach (var question in randomizedQuestions)
            {
                question.Options = question.Options.OrderBy(o => random.Next()).ToList();
            }
            return randomizedQuestions;

        }
    }
}
