using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NetDEMO212june2025.DTO
{
    public class BlogComment
    {
        public long CommentId { get; set; }
        public long PostId { get; set; }
        public string Title { get; set; }
        public string CommentTest { get; set; }
   

    }
}