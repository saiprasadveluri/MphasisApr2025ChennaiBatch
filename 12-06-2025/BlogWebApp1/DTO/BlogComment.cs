using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWebApp1.DTO
{
    public class BlogComment
    {
        public long CommentId { get; set; }
        public string Title {  get; set; }
        public string CommentText { get; set; }
        public long PostId { get; set; }
        public string CommentBy {  get; set; }
    }
}