using OnlinePharmacyApp.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlinePharmacyApp.DTO
{
    
        public class GetUsers
        {
            public List<UserDTO> data { get; set; }

        }
        public class UserDTO
     {

        public int userId { get; set; }
        
        public string userName { get; set; }
       
        public string email { get; set; }
   
        public string password { get; set; }
  
        public string phoneNumber { get; set; }
      
        public string address { get; set; }
        public bool isAdmin { get; set; } = false;

       
    }
}
