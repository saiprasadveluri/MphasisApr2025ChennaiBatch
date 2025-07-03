using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    public class User
    {
        public User()
        {
            Company = new HashSet<Company>();
            PostJob = new HashSet<PostJob>();
        }
        [Key]
        public int UserID { get; set; }
        public int UserTypeID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string ContactNo { get; set; }
        public string Image { get; set; }
        public byte[] FileData { get; set; }

        public virtual ICollection<Company> Company { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual ICollection<PostJob> PostJob { get; set; }
    }
}
