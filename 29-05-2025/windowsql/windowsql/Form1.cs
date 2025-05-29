namespace windowsql
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
                var PostList = dal.GetAllPosts();
                GridBlogPost.DataSource = PostList;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            using (DataAccessLayer dal = new DataAccessLayer())
            {
                string title=txttitle.Text;
                string description=txtDescription.Text;
                string postedby=txtPostedBy.Text;
                dal.AddPost(title, description, postedby);
                var PostList=dal.GetAllPosts();
                GridBlogPost.DataSource = null;
                GridBlogPost.DataSource = PostList;
                GridBlogPost.Refresh();
            }
        }
    }
}
