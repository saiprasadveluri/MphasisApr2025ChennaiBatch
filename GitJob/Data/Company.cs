using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data
{
    public class Company
    {
        public Company()
        {
            PostJobTables = new HashSet<PostJob>();
        }

        public int CompanyID { get; set; }
        public int UserID { get; set; }
        public string CompanyName { get; set; }
        public string ContactNo { get; set; }
        public string PhoneNo { get; set; }
        public string EmailAddress { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }

        public virtual User UserTable { get; set; }
        public virtual ICollection<PostJob> PostJobTables { get; set; }
    }
}
