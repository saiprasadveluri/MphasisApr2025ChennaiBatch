using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogAppWeb2.DTO
{
    public class BlogComment
    {
        public long BlogPostId { get; set; }
        public string CommentTitle { get;  set; }
        public string CommentText { get; set; }

    }
}