using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demopart1
{
    public class BlogComment
    {
        public long CommentId { get; set; }
        public long PostId { get; set; }
        public string Title {  get; set; }
        public string CommentText { get; set; }
        public string CommentLine {  get; set; }
    }
}
