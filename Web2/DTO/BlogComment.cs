using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web2.DTO
{
    public class BlogComment
    {
        public long CommentId {  get; set; }
        public string CommentText { get; set; }
        public string CommentTitle {  get; set; }
        public long PostId {  get; set; }
        public long CommentBy{ get; set; }

    }
}