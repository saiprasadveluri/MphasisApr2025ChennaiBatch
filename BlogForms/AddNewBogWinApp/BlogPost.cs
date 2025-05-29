using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNewBogWinApp
{
    public class BlogPost
    {
        public long PostId { get; set; }
        public string Title { get; set; }
        public string PostText { get; set; }
        public string PostedBy { get; set; }
    }
}

