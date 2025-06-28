using OnlinePharmacyAppAPI.DTO;
using OnlinePharmacyAppAPI.Model;

namespace OnlinePharmacyAppAPI.Services
{
    public class ProfileService
    {
        private OPADBContext _context;
        public ProfileService(OPADBContext context)
        {
            _context = context;
        }
        public List<ProfileDTO> GetAll()
        {
            List<ProfileDTO> profile = (from obj in _context.profiles
                                    select new ProfileDTO
                                    {
                                        UserId = obj.UserId,
                                        PhoneNumber=obj.PhoneNumber,
                                        Address=obj.Address

                                    }).ToList();
            return profile;
        }
        public bool AddNewProfile(ProfileDTO p)
        {
            Profile profile = new Profile();
            profile.UserId = p.UserId;
            profile.PhoneNumber = p.PhoneNumber;
            profile.Address = p.Address;
            _context.profiles.Add(profile);
            _context.SaveChanges();
            return true;
        }
        public bool UpdateProfile(ProfileDTO p)
        {
            var existingprofile = _context.profiles.Find(p.UserId);
            if (existingprofile == null)
                return false;
            existingprofile.PhoneNumber = p.PhoneNumber;
            existingprofile.Address = p.Address;

            _context.SaveChanges();
            return true;
        }
        public bool DeleteUser(int userid)
        {
            var profile = _context.profiles.Find(userid);
            if (profile == null) return false;

            _context.profiles.Remove(profile);
            _context.SaveChanges();
            return true;
        }
    }
}
