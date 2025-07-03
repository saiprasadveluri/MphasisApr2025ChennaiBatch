using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    public class UserType
    {
        public UserType()
        {
            UserTables = new HashSet<User>();
        }
        [Key]
        public int UserTypeID { get; set; }
        public string UserTypes { get; set; }

        public virtual ICollection<User> UserTables { get; set; }
    }
}

