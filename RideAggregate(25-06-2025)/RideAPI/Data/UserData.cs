using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RideAPI.Data
{
    public class UserData
    {
        [Key]
        public Guid UserId { get; set; }
        [Required]
        [StringLength(20)]
        public string Email { get; set; }
        [Required]
        [StringLength(10)]
        public string Password { get; set; }
        [Required]
        public string UserRole {  get; set; }
    }
}
