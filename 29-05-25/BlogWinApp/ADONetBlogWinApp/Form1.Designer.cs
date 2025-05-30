namespace ADONetBlogWinApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gridBlogPosts = new DataGridView();
            contextMenuComment = new ContextMenuStrip(components);
            addCommentToolStripMenuItem = new ToolStripMenuItem();
            deletePostToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            txtPostedBy = new TextBox();
            label3 = new Label();
            txtDescription = new TextBox();
            label2 = new Label();
            txtTitle = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridBlogPosts).BeginInit();
            contextMenuComment.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gridBlogPosts
            // 
            gridBlogPosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridBlogPosts.ContextMenuStrip = contextMenuComment;
            gridBlogPosts.Location = new Point(10, 13);
            gridBlogPosts.MultiSelect = false;
            gridBlogPosts.Name = "gridBlogPosts";
            gridBlogPosts.ReadOnly = true;
            gridBlogPosts.Size = new Size(783, 212);
            gridBlogPosts.TabIndex = 0;
            // 
            // contextMenuComment
            // 
            contextMenuComment.Items.AddRange(new ToolStripItem[] { addCommentToolStripMenuItem, deletePostToolStripMenuItem });
            contextMenuComment.Name = "contextMenuComment";
            contextMenuComment.Size = new Size(154, 48);
            // 
            // addCommentToolStripMenuItem
            // 
            addCommentToolStripMenuItem.Name = "addCommentToolStripMenuItem";
            addCommentToolStripMenuItem.Size = new Size(153, 22);
            addCommentToolStripMenuItem.Text = "Add Comment";
            addCommentToolStripMenuItem.Click += addCommentToolStripMenuItem_Click;
            // 
            // deletePostToolStripMenuItem
            // 
            deletePostToolStripMenuItem.Name = "deletePostToolStripMenuItem";
            deletePostToolStripMenuItem.Size = new Size(153, 22);
            deletePostToolStripMenuItem.Text = "Delete Post";
            deletePostToolStripMenuItem.Click += deletePostToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(txtPostedBy);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(10, 231);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(778, 251);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Post";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(228, 204);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(313, 41);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Post";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtPostedBy
            // 
            txtPostedBy.Location = new Point(90, 169);
            txtPostedBy.Name = "txtPostedBy";
            txtPostedBy.Size = new Size(606, 29);
            txtPostedBy.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 174);
            label3.Name = "label3";
            label3.Size = new Size(66, 21);
            label3.TabIndex = 4;
            label3.Text = "Post By";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(81, 62);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(615, 90);
            txtDescription.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 65);
            label2.Name = "label2";
            label2.Size = new Size(42, 21);
            label2.TabIndex = 2;
            label2.Text = "Text";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(81, 24);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(615, 29);
            txtTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 27);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(groupBox1);
            Controls.Add(gridBlogPosts);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)gridBlogPosts).EndInit();
            contextMenuComment.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridBlogPosts;
        private GroupBox groupBox1;
        private TextBox txtTitle;
        private Label label1;
        private TextBox txtDescription;
        private Label label2;
        private Label label3;
        private TextBox txtPostedBy;
        private Button btnAdd;
        private ContextMenuStrip contextMenuComment;
        private ToolStripMenuItem addCommentToolStripMenuItem;
        private ToolStripMenuItem deletePostToolStripMenuItem;
    }
}
