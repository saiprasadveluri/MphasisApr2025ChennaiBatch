using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using OnlineQuizApplicationAPI.DTO;
using OnlineQuizApplicationAPI.Models;
using System.Linq;

namespace OnlineQuizApplicationAPI.Services
{
    public class ServicesAPI
    {
        QuizDbContext context;
        public ServicesAPI(QuizDbContext ctx)
        {
            context = ctx;
        }
        //Registration Services
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
        //update Account
        public bool UpdateAccountAdmin(Guid id, AccountAdminDTO admin)
        {
            var res = context.Accounts.Where(a => a.AccountId == id).FirstOrDefault();
            if (res != null)
            {
                var Admin = GetAdminById(res.AccountId);
                Admin.AdminName = admin.AdminName;
                Admin.ContactNo = admin.ContactNo;
                Admin.Email = admin.Email;
                Admin.Password = admin.Password;
                AdminInfo adminInfo = new AdminInfo();
                //adminInfo.AdminId = Admin.AdminId;
                adminInfo.AdminName = Admin.AdminName;
                adminInfo.ContactNo = Admin.ContactNo;
                Account account = new Account();
                //account.AccountId = Admin.AccountId;
                account.Email = Admin.Email;
                account.Password = Admin.Password;
                adminInfo.userData = account;
                int Res = context.SaveChanges();
                if (Res > 0) { return true; }
                else { return false; }

            }
            return false;
        }
        //Deletion Services
        public bool DeleteAccount(Guid id)
        {
            var res = context.Accounts.Where(a => a.AccountId == id).FirstOrDefault();
            if (res != null)
            {
                context.Accounts.Remove(res);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool DeleteAdmin(Guid id)
        {
            var res = context.AdminInfos.Where(a => a.AdminId == id).FirstOrDefault();
            if (res != null)
            {
                context.AdminInfos.Remove(res);
                context.SaveChanges();
                return true;
            }
            return false;
        }
        //Data projection services
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
        public GetAccountUserDTO GetUserById(Guid id)//For user action
        {
            GetAccountUserDTO res = context.UserInfos.Where(c => c.AccountId == id).Select(obj => new GetAccountUserDTO{
                                               UserId = obj.UserId,
                                               AccountId = obj.AccountId,
                                               UserName = obj.UserName,
                                               ContactNo = obj.ContactNo,
                                               Email = obj.accountData.Email,
                                               Password = obj.accountData.Password

                                           }).FirstOrDefault();

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
        public List<GetAccountUserDTO> GetAllUserAccounts()//For Admin Action
        {
            List<GetAccountUserDTO> res = ( from obj in context.UserInfos
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
        public GetCategoryDTO GetCategoryByName(string CategoryName)
        {
            GetCategoryDTO result = context.Category.Where(t => t.CategoryName == CategoryName).Select(obj => new GetCategoryDTO
            {
                CategoryId = obj.CategoryId,
                CategoryName = obj.CategoryName,
            }).FirstOrDefault();
            return result;
            
        }
        public GetCategoryDTO2 GetCategoryById(Guid id)
        {
            GetCategoryDTO2 result = context.Category.Where(t => t.CategoryId == id).Select(obj => new GetCategoryDTO2
            {
                CategoryId = obj.CategoryId,
                CategoryName = obj.CategoryName,
            }).FirstOrDefault();
            return result;

        }
        public GetTopicsDTO GetTopicByName(string TopicName)
        {
            GetTopicsDTO Topic = context.Topics.Where(t => t.TopicName == TopicName).Select(obj => new GetTopicsDTO
            {
                TopicId = obj.TopicId,
                TopicName = obj.TopicName,
                CategoryId = obj.CategoryId,

            }).FirstOrDefault();
            return Topic;
        }
        //Get Quizzes by category
        public List<GetQuizDTO> GetQuizzesByCategory(string CategoryName)
        {
            List<GetQuizDTO> result = context.Quizs.Where(q => q.CategoryName == CategoryName).Select(obj => new GetQuizDTO
            {
                QuizId = obj.QuizId,
                QuizTitle = obj.QuizTitle,
                CategoryName = obj.CategoryName,
                Duration = obj.Duration,
                ScheduleTime = obj.ScheduleTime,
                Questions = obj.Questions,
            }).ToList();
            return result;
        }

        public List<AdminInfoDTO> GetAllAdmins()
        {
            List<AdminInfoDTO> res = (from obj in context.AdminInfos
                                      select new AdminInfoDTO
                                      {
                                          AdminId = obj.AdminId,
                                          AccountId= obj.AccountId,
                                          AdminName = obj.AdminName,
                                          ContactNo= obj.ContactNo
                                      }).ToList();
            return res;
        }
        
        public List<AccountDTO> GetAllAcountDetails()
        {
            List<AccountDTO> res = (from obj in context.Accounts
                                    select new AccountDTO
                                    {
                                        AccountId = obj.AccountId,
                                        Email   = obj.Email,
                                        Password = obj.Password,
                                        Role = obj.Role
                                    }).ToList();
            return res;
        }
        public List<GetTopicsDTO> GetAllTopicsByCategory(Guid id)
        {
            List<GetTopicsDTO> result = context.Topics.Where(t => t.CategoryId == id).Select(obj => new GetTopicsDTO
            {
                TopicId = obj.TopicId,
                TopicName = obj.TopicName,
                CategoryId  = obj.CategoryId
            }).ToList();
            return result;
            
        }
        public ICollection<QuestionsDTO> GetQuestionsById(Guid id)
        {
            ICollection<QuestionsDTO> result = context.Questions.Where(q => q.QuestionId == id).Select(obj => new QuestionsDTO
            {
                QuestionId = obj.QuestionId,
                QuestionText = obj.QuestionText,
                TopicId = obj.TopicId,

            }).ToList();
            return result;
        }
        //Select Questions
        public List<GetQuestionWithOptionsDTO> GetAllQuestionsWithOptions()
        {
            List<GetQuestionWithOptionsDTO> result = context.Questions.Include(q =>q.Options).Select(q=>new GetQuestionWithOptionsDTO
            {
                QuestionId = q.QuestionId,
                QuestionText = q.QuestionText,
                TopicId = q.TopicId,
                Options = q.Options.Select(o=>new GetOptionsDTO
                {
                    OptionId = o.OptionId,
                    OptionText = o.OptionText,
                    Answer  = o.Answer
                }).ToList()
            }).ToList();
            return result;
        }
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
        //public List<GetQuestionWithOptionsDTO> GetQuestionsByQuiz(Guid id)
        //{
        //    var rawJoinData = context.Database.SqlQuery<QuestionsQuiz>("SELECT QuestionsQuestionId, QuizzesQuizId FROM QuestionsQuiz").ToList();
        //}
        //Adding Category with Topics Services
        public bool AddCategoryWithTopics(CategoryWithTopicsDTO dto)
        {
            if(string.IsNullOrWhiteSpace(dto.CategoryName)||dto.Topics==null) return false;
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
            catch(Exception ex) 
            {
                return false;
            }
        }
        //Adding Quiz Questions Service
        public bool AddQuizByTopic(Guid topicId)
        {
            var topic = context.Topics
            .Where(t => t.TopicId == topicId)
            .Select(obj => new GetTopicsDTO
            {
                TopicId = obj.TopicId,
                TopicName = obj.TopicName,
                CategoryId = obj.CategoryId
            })
            .FirstOrDefault();
            GetCategoryDTO category = context.Category.Where(c => c.CategoryId == topic.CategoryId).Select(obj => new GetCategoryDTO
            {
                CategoryId = obj.CategoryId,
                CategoryName = obj.CategoryName
            }).FirstOrDefault();
            try
            {
                Quiz quiz = new Quiz();
                quiz.QuizId = Guid.NewGuid();
                quiz.QuizTitle = topic.TopicName;
                quiz.CategoryName = category.CategoryName;
                quiz.Duration = 30;
                quiz.ScheduleTime = DateTime.Now;
                List<GetQuestionWithOptionsDTO> List = GetQuestionWithOptionByTopics(topic.TopicId);
                foreach (var questionDTO in List)
                {

                    Questions questionEntity = context.Questions.FirstOrDefault(q => q.QuestionId == questionDTO.QuestionId);
                    if (questionEntity != null)
                    {
                        quiz.Questions.Add(questionEntity);
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
        public bool AddQuizwithQuestionsByCategory(QuizQuestionsDTO dto)
        {
            if (string.IsNullOrWhiteSpace(dto.QuizTitle) || string.IsNullOrWhiteSpace(dto.CategoryName)){
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
        //get quiz details by quiz id

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

        //Get Randomized questions with options
        public List<GetQuestionWithOptionsDTO> GetRandomQuestionsByTopic(Guid id)
        {
            List<GetQuestionWithOptionsDTO> Res = GetQuestionWithOptionByTopics(id);
            var random = new Random();
            var randomizedQuestions = Res.OrderBy(q => random.Next()).Take(3).ToList();
            foreach (var question in randomizedQuestions)
            {
                question.Options = question.Options.OrderBy(o => random.Next()).ToList();
            }
            return randomizedQuestions;
        }
        public List<GetQuestionWithOptionsDTO> GetRandomQuestionsByQuiz(Guid id)
        {
            GetQuizDTO quiz = context.Quizs.Where(c => c.QuizId == id).Select(obj => new GetQuizDTO
            {
                QuizId = obj.QuizId,
                QuizTitle = obj.QuizTitle,
                CategoryName = obj.CategoryName,
                Duration = obj.Duration,
                ScheduleTime = obj.ScheduleTime,
                Questions = obj.Questions,
            }).FirstOrDefault();
            string catg = quiz.CategoryName;
            GetCategoryDTO Categories = GetCategoryByName(catg);
            List<GetTopicsDTO> Topics = GetAllTopicsByCategory(Categories.CategoryId);
            List<GetQuestionWithOptionsDTO> allQuestions = new List<GetQuestionWithOptionsDTO>();
            foreach (GetTopicsDTO topic in Topics)
            {
                List<GetQuestionWithOptionsDTO> List = GetQuestionWithOptionByTopics(topic.TopicId);
                allQuestions.AddRange(List);
            }
            var random = new Random();
            var randomizedQuestions = allQuestions.OrderBy(q => random.Next()).Take(20).ToList();
            foreach (var question in randomizedQuestions)
            {
                question.Options = question.Options.OrderBy(o => random.Next()).ToList();
            }
            return randomizedQuestions;

        }
        //Evaluation of score
        public int Score (List<GetOptionsDTO> options)
        {
            int score = 0;
            foreach (GetOptionsDTO option in options)
            {
                if(option.Answer == 1)
                {
                    score++;
                }
            }
            return score;
        }

        //Adding Question with options Services
        public bool AddQuestionsWithOptions(QuestionOptionsDTO dto)
        {
            if(string.IsNullOrWhiteSpace(dto.QuestionText)||dto.Options==null|| dto.Options.Count < 4)
            {
                return false;
            }
            if(dto.Options.Count(o => o.Answer ==1)!=1)
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
                    OptionId=Guid.NewGuid(),
                    OptionText = o.OptionText,
                    Answer = o.Answer
                }).ToList();
                context.Questions.Add(question);
                int Res = context.SaveChanges();
                if(Res > 0)
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
                return false ;
            }
        }
        //public List<GetQuestionWithOptionsDTO> GetRandomQuestionsByQuizs(Guid id)
        //{
        //    var quiz = context.Quizs
        //        .Include(q => q.Questions)
        //            .ThenInclude(q => q.Options)
        //        .FirstOrDefault(q => q.QuizId == id);

        //    if (quiz == null)
        //        return new List<GetQuestionWithOptionsDTO>();

        //    var random = new Random();

        //    var questionList = quiz.Questions
        //        .Select(q => new GetQuestionWithOptionsDTO
        //        {
        //            QuestionId = q.QuestionId,
        //            QuestionText = q.QuestionText,
        //            TopicId = q.TopicId,
        //            Options = q.Options
        //                .OrderBy(o => random.Next()) // shuffle options
        //                .Select(o => new GetOptionsDTO
        //                {
        //                    OptionId = o.OptionId,
        //                    OptionText = o.OptionText,
        //                    Answer = o.Answer
        //                }).ToList()
        //        })
        //        .OrderBy(q => random.Next()) // shuffle questions
        //        .Take(3) // or any other number
        //        .ToList();

        //    return questionList;
        //}
        public async Task<bool> SaveQuizAttemptAsync(QuizAttemptDTO attemptDto)
        {
            try
            {
                // Map DTO to Entity
                var attemptEntity = new QuizAttempt
                {
                    AttemptId = Guid.NewGuid(),
                    UserId = attemptDto.UserId,
                    QuizId = attemptDto.QuizId,
                    AttemptTime = attemptDto.AttemptTime,
                    Score = attemptDto.Score,
                    Status = attemptDto.Status
                };

                context.QuizAttempts.Add(attemptEntity);
                await context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
