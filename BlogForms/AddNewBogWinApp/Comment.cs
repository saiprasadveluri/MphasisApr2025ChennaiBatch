using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddNewBogWinApp
{
    public partial class Comment : Form
    {
        public Comment()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Comment_Load(object sender, EventArgs e)
        {
            using (DataAccessLayer dal = new DataAccessLayer())
            {
                var CommentList = dal.GetAllPosts();
                gridBlogComment.DataSource = CommentList;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataAccessLayer dal = new DataAccessLayer())
            {
                string title = txtTitle.Text;
                string text= txtDescription.Text;
                string Commentedby = txtCommentedBy.Text;
                dal.AddPost(title, text, Commentedby);

                var CommentList = dal.GetAllComments();
                gridBlogComment.DataSource = null;
                gridBlogComment.DataSource = CommentList;
                gridBlogComment.Refresh();
            }
        }
    }
}
