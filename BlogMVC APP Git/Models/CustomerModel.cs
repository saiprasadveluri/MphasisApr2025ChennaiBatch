using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace BlogWebMVCApp.Models
{
    public class CustomerModel
    {           
        [Required]
        public int CustId {  get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        
        public string City { get; set; }
        public string Department {  get; set; }
        public List<SelectListItem> DepartmentList { get; set; } = new List<SelectListItem>
        {
           new SelectListItem(){Text="DEV",Value="DEV"},
           new SelectListItem(){Text="QA",Value="QA"}
        };
    }
}