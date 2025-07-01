using OnlineQuizWebAPI.DTO;
using OnlineQuizWepAPI.Data;
using OnlineQuizWepAPI.DTO;

namespace OnlineQuizWebAPI.ServiceAPI
{
    public class ServiceApi
    {
        public QuizDbContext context;
        public ServiceApi(QuizDbContext ctx)
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
                                         userId = obj.UserId,
                                         accountId = obj.AccountId,
                                         userName = obj.UserName,
                                         contactNo = obj.ContactNo
                                     }).ToList();
            return res;
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

        internal bool AddCategoryWithTopics(CategoryWithTopicsDTO categoryWithTopicsDTO)
        {
            throw new NotImplementedException();
        }

        internal object GetAllQuestionsWithOptions()
        {
            throw new NotImplementedException();
        }
    }
}
