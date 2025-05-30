using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDNetBlogWinApp
{
    public class BlogComment
    {
        public long CommentId {  get; set; }
        public long BlogPostId { get; set; }
        public string CommentTitle { get; set; }
        public string CommentText { get; set; }
        public string CommentBy {  get; set; }
    }
}
