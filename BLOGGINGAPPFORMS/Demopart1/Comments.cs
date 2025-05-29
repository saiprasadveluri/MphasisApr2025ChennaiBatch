using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demopart1
{
    public partial class Comments : Form
    {
        public Comments()
        {
            InitializeComponent();
        }

        private void Comments_Load(object sender, EventArgs e)
        {
            using (DataAccess dal = new DataAccess())
            {
                var blogcomments = dal.GetAllComments();
                gridBlogComment.DataSource = blogcomments;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataAccess dal = new DataAccess())
            {
                int postid = txtpostId.Text;
                string title = txtTitle.Text;
                string CommentText = txtcommenttext.Text;
                string CommentLine = txtCommentLine.Text;
                dal.AddComment(postid, title, CommentText, CommentLine);

                var PostList = dal.GetAllPosts();
                gridBlogComment.DataSource = null;
                gridBlogComment.DataSource = PostList;
                gridBlogComment.Refresh();
            }
        }
    }
}
