using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.DTO
{
    public class Comments
    {
        public long CommentId { get; set; }
        public long PostId { get; set; }
        public string Title { get; set; }
        public string CommentText { get; set; }
        
    }
}