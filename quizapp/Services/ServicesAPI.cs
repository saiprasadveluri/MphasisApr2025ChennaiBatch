using Microsoft.EntityFrameworkCore;
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
                QuestionText = q.QuestionText,

                TopicId = q.TopicId,

                Options = q.Options.Select(o => new GetOptionsDTO

                {

                    OptionText = o.OptionText,

                    Answer = o.Answer

                }).ToList()

            }).ToList();

            return result;

        }

    }
}
