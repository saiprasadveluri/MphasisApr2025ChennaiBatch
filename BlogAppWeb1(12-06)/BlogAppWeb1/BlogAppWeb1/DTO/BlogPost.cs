using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogAppWeb1.DTO
{
    public class BlogPost
    {
        public long PostId { get; set; }
        public string Title { get; set; }
        public string PostText { get; set; }

        public string PostedBy { get; set; }

    }
}