using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDNetBlogWinApp
{
    public class BlogPost
    {
        public long BlogPostId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogText { get; set; }
        public string PostedDatetime { get; set; }
    }
}
