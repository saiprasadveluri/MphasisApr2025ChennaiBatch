using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogpostcomment
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int BlogPostId { get; set; }
        public required string CommentTitle { get; set; }
        public required string CommentText { get; set; }
        public required string CommentBy { get; set; }
    }
}
