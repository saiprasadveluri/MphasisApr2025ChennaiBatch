using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNewBogWinApp
{
    public class BlogComment
    {
        public long PostId {  get; set; }
        public long CommentId { get; set; }
        public string Title { get; set; }
        public string CommentText { get; set; }
        public string CommentedBy { get; set; }
    }
}
