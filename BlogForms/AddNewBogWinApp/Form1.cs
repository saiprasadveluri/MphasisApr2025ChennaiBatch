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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (DataAccessLayer dal = new DataAccessLayer())
            {
                var PostList = dal.GetAllPosts();
                gridBlogPosts.DataSource = PostList;
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            using (DataAccessLayer dal = new DataAccessLayer())
            {
                string title = txtTitle.Text;
                string description = txtDescription.Text;
                string postedby = txtPostedBy.Text;
                dal.AddPost(title, description, postedby);

                var PostList = dal.GetAllPosts();
                gridBlogPosts.DataSource = null;
                gridBlogPosts.DataSource = PostList;
                gridBlogPosts.Refresh();
            }
        }

        private void deletePostToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            if(gridBlogPosts.SelectedRows.Count > 0)
            {
                var SelRow = gridBlogPosts.SelectedRows[0];
                int selId = int.Parse(SelRow.Cells[0].Value.ToString());
                using (DataAccessLayer dal = new DataAccessLayer())
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
            Comment comment = new Comment();
            comment.ShowDialog();
        }

        private void gridBlogPosts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
