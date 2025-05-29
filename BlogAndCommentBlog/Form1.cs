using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADDNetBlogWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (DataAccess dal = new DataAccess())
            {
                var PostList = dal.GetAllPosts();
                gridBlogPosts.DataSource = PostList;
            }
        }

        private void AddPostButton_Click(object sender, EventArgs e)
        {
            using (DataAccess dal = new DataAccess())
            {
                string title = textTitle.Text;
                string postText = textPostText.Text;
                string postBy = textPostBy.Text;
                dal.AddPost(title, postText, postBy);

                var PostList = dal.GetAllPosts();
                gridBlogPosts.DataSource = null;
                gridBlogPosts.DataSource = PostList;
                gridBlogPosts.Refresh();
            }

        }

        private void deletePostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(gridBlogPosts.SelectedRows.Count > 0)
            {
                var SelRow = gridBlogPosts.SelectedRows[0];
                int selId = int.Parse(SelRow.Cells[0].Value.ToString());
                using (DataAccess dal = new DataAccess())
                {
                    dal.DeletePost(selId);
                    var PostList = dal.GetAllPosts();
                    gridBlogPosts.DataSource = null;
                    gridBlogPosts.DataSource = PostList;
                    gridBlogPosts.Refresh();
                }
            }
        }

        private void addCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridBlogPosts.SelectedRows.Count > 0)
            {
                var SelRow = gridBlogPosts.SelectedRows[0];
                int selId = int.Parse(SelRow.Cells[0].Value.ToString());
                NewComment newComment = new NewComment(selId);
                newComment.ShowDialog();
            }
        }
    }
}
