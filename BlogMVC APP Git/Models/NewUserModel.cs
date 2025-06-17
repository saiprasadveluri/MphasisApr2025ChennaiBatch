using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogWebMVCApp.Models
{
    public class NewUserModel
    {
        public long UserId { get; set; }
        [Required]
        public string Email {  get; set; }
        [Required]
        public string Password { get; set; }
        public string UserRole { get; set; }
        public List<SelectListItem> AvailableUserRoles { get; set; }
    }
}