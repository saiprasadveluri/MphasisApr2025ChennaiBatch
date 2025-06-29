using Book.Data.DB;
using Book.Services;
using Microsoft.EntityFrameworkCore;

namespace Book.Services
{
    public class Unity
    {
        private readonly BookMyShowDbContext _db;
        public Unity(BookMyShowDbContext _context)
        {
            _db = _context;
        }
        private UserService _userService;
        public UserService UserService
        {
            get
            {
                if (_userService == null)
                {
                    _userService = new UserService(_db);
                }
                return _userService;
            }
        }





    }
}
