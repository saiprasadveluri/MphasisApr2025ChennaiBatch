using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web2.DTO
{
    public class BlogPost
    {
        public long PostID {  get; set; }
        public string Title { get; set; }
       public string PostText {  get; set; }
        public long PostedBy { get; set; }

    }
}