using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddNewBlogWinApp
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
                GridBlog.DataSource = PostList;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataAccess dal = new DataAccess())
            {
                string title = txtTitle.Text;
                string description = txtDescription.Text;
                string postedby = txtPostedBy.Text;
                dal.AddPost(title, description, postedby);

                var PostList = dal.GetAllPosts();
                GridBlog.DataSource = null;
                GridBlog.DataSource = PostList;
                GridBlog.Refresh();
            }
        }


        private void deletePostToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (GridBlog.SelectedRows.Count > 0)
            {
                var SelRow = GridBlog.SelectedRows[0];
                int selId = int.Parse(SelRow.Cells[0].Value.ToString());
                using (DataAccess dal = new DataAccess())
                {
                    dal.DeletePost(selId);
                    var PostList = dal.GetAllPosts();
                    GridBlog.DataSource = PostList;
                    GridBlog.Refresh();
                }

            }
        }

        private void addCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GridBlog.SelectedRows.Count > 0)
            {
                var SelRow = GridBlog.SelectedRows[0];
                int selId = int.Parse(SelRow.Cells[0].Value.ToString());
                using (DataAccess dal = new DataAccess())
                {
                    Comment comment = new Comment(selId);
                    comment.ShowDialog();
                }

            }

         }
            
    }
} 

       