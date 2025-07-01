using OnlinePharmacyAppAPI.DTO;
using OnlinePharmacyAppAPI.Model;

namespace OnlinePharmacyAppAPI.Services
{
    public class UserService
    {
        private OPADBContext _context;
        public UserService(OPADBContext context)
        {
            _context = context;
        }
        public List<UserDTO> GetAllUsers()
        {
            List<UserDTO> users = (from obj in _context.Users
                                   select new UserDTO
                                   {
                                       UserId = obj.UserId,
                                       UserName = obj.UserName,
                                       Email = obj.Email,
                                       Password = obj.Password,
                                       PhoneNumber = obj.PhoneNumber,
                                       Address = obj.Address,
                                       IsAdmin = obj.IsAdmin

                                   }).ToList();
            return users;
        }
        public UserDTO GetUserById(int id)
        {
            var user = (from obj in _context.Users
                        where obj.UserId == id
                        select new UserDTO
                        {
                            UserId = obj.UserId,
                            UserName = obj.UserName,
                            Email = obj.Email,
                            Password = obj.Password,
                            PhoneNumber = obj.PhoneNumber,
                            Address = obj.Address,
                            IsAdmin = obj.IsAdmin
                        }).FirstOrDefault();

            return user;
        }

        public bool AddNewUser(UserDTO user)
        {
            User userInfo = new User();
            userInfo.UserName = user.UserName;
            userInfo.Email = user.Email;
            userInfo.Password = user.Password;
            userInfo.PhoneNumber = user.PhoneNumber;
            userInfo.Address = user.Address;
            userInfo.IsAdmin = user.IsAdmin;
            _context.Users.Add(userInfo);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateUser(UserDTO user)
        {
            var existingUser = _context.Users.Find(user.UserId);
            if (existingUser == null) return false;

            existingUser.UserName = user.UserName;
            existingUser.Email = user.Email;
            existingUser.Password = user.Password;
            existingUser.PhoneNumber = user.PhoneNumber;
            existingUser.Address = user.Address;
            existingUser.IsAdmin = user.IsAdmin;
            
            _context.SaveChanges();
            return true;
        }
        public bool DeleteUser(int userId)
        {
            var user = _context.Users.Find(userId);
            if (user == null) return false;

            _context.Users.Remove(user);
            _context.SaveChanges();
            return true;
        }
        public UserDTO? AuthenticateUser(string email, string password)

        {
            return (from obj in _context.Users
                    where obj.Email == email && obj.Password == password
                    select new UserDTO
                    {
                        UserId = obj.UserId,
                        UserName = obj.UserName,
                        Email = obj.Email,
                        Password = obj.Password,
                        PhoneNumber = obj.PhoneNumber,
                        Address = obj.Address,
                        IsAdmin = obj.IsAdmin
                    }).FirstOrDefault();
        }

    }
}
