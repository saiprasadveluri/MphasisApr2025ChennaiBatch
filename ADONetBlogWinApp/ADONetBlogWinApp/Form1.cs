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
            using (DataAccess dal = new DataAccess())
            {
                var PostList = dal.GetAllPosts();
                gridBlogPosts.DataSource = PostList;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (DataAccess dal = new DataAccess())
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

        private void addCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deletePostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridBlogPosts.SelectedRows.Count > 0)
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
    }
}
