using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONetBlogWinApp
{
    public partial class Form2 : Form
    {
        public Form2(int id)
        {
            postid = id;
            InitializeComponent();
            access = new DataAccessLayer();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (DataAccessLayer dal = new DataAccessLayer())
            {
                var PostList = dal.GetAllComments();
                gridBlogComment.DataSource = PostList;

            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (DataAccessLayer dal = new DataAccessLayer())
            {
                long postId = this.PostId;
                string title = Titletxt.Text;
                string commentText= Commenttxt.Text;
                string commentedby = Commentedbytxt.Text;
                dal.AddComment(postId, title, commentText, commentedby);

                var CommentsList = dal.GetAllComments();
                gridBlogComment.DataSource = null;
                gridBlogComment.DataSource = CommentsList;
                gridBlogComment.Refresh();


            }

        }

        private void deleteCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridBlogComment.SelectedRows.Count > 0)
            {
                var SelRow = gridBlogComment.SelectedRows[0];
                int selId = int.Parse(SelRow.Cells[0].Value.ToString());
                using (DataAccessLayer dal = new DataAccessLayer())
                {
                    dal.DeletePost(selId);
                    var PostList = dal.GetAllPost();
                    gridBlogComment.DataSource = null;
                    gridBlogComment.DataSource = PostList;
                    gridBlogComment.Refresh();
                }
            }
        }
    }
}
