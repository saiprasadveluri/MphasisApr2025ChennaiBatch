using Microsoft.AspNetCore.Mvc.Rendering;

namespace RoomManagerMVCApp.DTO
{
    public class UserInfoDTO
    {
        public Guid UserId { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string UserRole { get; set; }
    }

    public class UserAddInfoDTO
    {
        public Guid UserId { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
        public List<SelectListItem> RoleData { get; set; } = new List<SelectListItem>();
        public UserAddInfoDTO() 
        {
            RoleData.Add(new SelectListItem("Admin", "Admin"));
            RoleData.Add(new SelectListItem("User", "User"));
        }
    }
}
