using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogAppWeb2.DTO
{
    public class BlogPost
    {
        public long BlogPostId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogText { get; set; }
    }
}