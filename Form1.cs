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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (DataAccessLayer dal = new DataAccessLayer())
            {
                var PostList = dal.GetAllPost();
                gridBlogPost.DataSource = PostList;

            }

        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (DataAccessLayer dal = new DataAccessLayer())
            {
                string title = Titletxt.Text;
                string text = Texttxt.Text;
                string postby = Postbytxt.Text;
                dal.AddPost(title, text, postby);

                var PostList = dal.GetAllPost();
                gridBlogPost.DataSource = null;
                gridBlogPost.DataSource = PostList;
                gridBlogPost.Refresh();


            }
        }

        private void gridBlogPost_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deletePostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridBlogPost.SelectedRows.Count > 0)
            {
                var SelRow = gridBlogPost.SelectedRows[0];
                int selId = int.Parse(SelRow.Cells[0].Value.ToString());
                using (DataAccessLayer dal = new DataAccessLayer())
                {
                    dal.DeletePost(selId);
                    var PostList = dal.GetAllPost();
                    gridBlogPost.DataSource = null;
                    gridBlogPost.DataSource = PostList;
                    gridBlogPost.Refresh();
                }
            }
        }

        private void addCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridBlogPost.SelectedRows.Count > 0)
            {
                var SelRow= gridBlogPost.SelectedRows[0];
                int selId = int.Parse(SelRow.Cells[0].Value.ToString());
                Form2 newComments=new Form2(selId);
                newComments.ShowDialog();
            }




        }

        private void Titletxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
