using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogpostcomment
{
    public class BlogPost
    {
        public int BlogPostId { get; set; }
        public required string BlogTitle { get; set; }
        public required string BlogText { get; set; }
        public required string PostedBy { get; set; }
    }
}
