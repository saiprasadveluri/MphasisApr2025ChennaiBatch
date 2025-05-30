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
    public partial class Comment : Form
    {
        long _PostId;
        public Comment(long PostId)
        {
            _PostId = PostId;
            InitializeComponent();
        }

        private void Comment_Load(object sender, EventArgs e)
        {
            using (DataAccess dal = new DataAccess())
            {
                var CommentList = dal.GetAllComments();
                GridBlogComment.DataSource = CommentList;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataAccess dal = new DataAccess())
            {
                string title = txtTitle.Text;
                string description = txtDescription.Text;
                string CommentBy = txtCommentBy.Text;
                dal.AddComment(_PostId,title, description, CommentBy);

                var CommentList = dal.GetAllComments();
                GridBlogComment.DataSource = null;
                GridBlogComment.DataSource = CommentList;
                GridBlogComment.Refresh();
            }
        }

        private void deleteCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (GridBlogComment.SelectedRows.Count > 0)
            {
                var SelRow = GridBlogComment.SelectedRows[0];
                int selId = int.Parse(SelRow.Cells[0].Value.ToString());
                using (DataAccess dal = new DataAccess())
                {
                    dal.DeleteComment(selId);
                    var CommentList = dal.GetAllComments();
                    GridBlogComment.DataSource = CommentList;
                    GridBlogComment.Refresh();
                }

            }
        }
    }
}
    
    
   
