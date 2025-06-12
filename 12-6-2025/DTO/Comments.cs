using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWinApp.DTO
{
    public class Comments
    {

        public long CommentId{ get; set; }
        public long PostId { get; set; }
        public string Title { get; set; }
        public string cmtText { get; set; }
     
    }
}