using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogpostcomment
{
    public class BComment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required string Author { get; set; }
    }
}
