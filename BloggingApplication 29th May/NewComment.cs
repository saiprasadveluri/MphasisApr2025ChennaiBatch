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
    public partial class NewComment : Form
    {
        public int postid;
        public DataAccess access;
        public NewComment(int id)
        {
            postid = id;
            InitializeComponent();
            access = new DataAccess();
        }

        private void AddCommentButton_Click(object sender, EventArgs e)
        {
            using (DataAccess dal = new DataAccess())
            {
                string Title = textTitle.Text;
                string CommentText = textCommentText.Text;
                string CommentBy = textCommentBy.Text;
                int PostId=this.postid;
                access.AddComment(Title, CommentText, CommentBy, PostId);
                var CommentList = dal.GetAllComments();
                gridComments.DataSource = null;
                gridComments.DataSource = CommentList;
                gridComments.Refresh();
            }
        }

        private void NewComment_Load(object sender, EventArgs e)
        {
            using (DataAccess dal = new DataAccess())
            {
                var CommentList = dal.GetAllComments();
                gridComments.DataSource = CommentList;
            }
        }
    }
}
