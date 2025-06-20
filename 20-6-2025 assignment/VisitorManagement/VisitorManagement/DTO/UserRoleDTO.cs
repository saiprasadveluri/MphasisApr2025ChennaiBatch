using Microsoft.AspNetCore.Mvc.Rendering;

namespace VisitorManagement.DTO
{
    public class UserRoleDTO
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
    public class UserAddRoleDTO
    {

        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public List<SelectListItem> RoleData { get; set; } = new List<SelectListItem>();
        public UserAddRoleDTO()
        {
            RoleData.Add(new SelectListItem("Admin", "Admin"));
            RoleData.Add(new SelectListItem("Host", "Host"));
        }
    }
}
