namespace ADDNetBlogWinApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridBlogPosts = new System.Windows.Forms.DataGridView();
            this.AddNewPost = new System.Windows.Forms.GroupBox();
            this.AddPostButton = new System.Windows.Forms.Button();
            this.textPostBy = new System.Windows.Forms.TextBox();
            this.PostByLabel = new System.Windows.Forms.Label();
            this.textPostText = new System.Windows.Forms.TextBox();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletePostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridBlogPosts)).BeginInit();
            this.AddNewPost.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridBlogPosts
            // 
            this.gridBlogPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBlogPosts.ContextMenuStrip = this.contextMenuStrip1;
            this.gridBlogPosts.Location = new System.Drawing.Point(28, 22);
            this.gridBlogPosts.Name = "gridBlogPosts";
            this.gridBlogPosts.ReadOnly = true;
            this.gridBlogPosts.Size = new System.Drawing.Size(516, 150);
            this.gridBlogPosts.TabIndex = 0;
            // 
            // AddNewPost
            // 
            this.AddNewPost.Controls.Add(this.AddPostButton);
            this.AddNewPost.Controls.Add(this.textPostBy);
            this.AddNewPost.Controls.Add(this.PostByLabel);
            this.AddNewPost.Controls.Add(this.textPostText);
            this.AddNewPost.Controls.Add(this.textTitle);
            this.AddNewPost.Controls.Add(this.TextLabel);
            this.AddNewPost.Controls.Add(this.TitleLabel);
            this.AddNewPost.Location = new System.Drawing.Point(28, 192);
            this.AddNewPost.Name = "AddNewPost";
            this.AddNewPost.Size = new System.Drawing.Size(711, 215);
            this.AddNewPost.TabIndex = 1;
            this.AddNewPost.TabStop = false;
            this.AddNewPost.Text = "AddNewPost";
            // 
            // AddPostButton
            // 
            this.AddPostButton.Location = new System.Drawing.Point(229, 171);
            this.AddPostButton.Name = "AddPostButton";
            this.AddPostButton.Size = new System.Drawing.Size(75, 23);
            this.AddPostButton.TabIndex = 6;
            this.AddPostButton.Text = "AddPost";
            this.AddPostButton.UseVisualStyleBackColor = true;
            this.AddPostButton.Click += new System.EventHandler(this.AddPostButton_Click);
            // 
            // textPostBy
            // 
            this.textPostBy.Location = new System.Drawing.Point(230, 133);
            this.textPostBy.Name = "textPostBy";
            this.textPostBy.Size = new System.Drawing.Size(286, 20);
            this.textPostBy.TabIndex = 5;
            // 
            // PostByLabel
            // 
            this.PostByLabel.AutoSize = true;
            this.PostByLabel.Location = new System.Drawing.Point(23, 133);
            this.PostByLabel.Name = "PostByLabel";
            this.PostByLabel.Size = new System.Drawing.Size(43, 13);
            this.PostByLabel.TabIndex = 4;
            this.PostByLabel.Text = "Post By";
            // 
            // textPostText
            // 
            this.textPostText.Location = new System.Drawing.Point(230, 62);
            this.textPostText.Multiline = true;
            this.textPostText.Name = "textPostText";
            this.textPostText.Size = new System.Drawing.Size(287, 49);
            this.textPostText.TabIndex = 3;
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(229, 30);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(287, 20);
            this.textTitle.TabIndex = 2;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(23, 62);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(28, 13);
            this.TextLabel.TabIndex = 1;
            this.TextLabel.Text = "Text";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(23, 30);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCommentToolStripMenuItem,
            this.deletePostToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // addCommentToolStripMenuItem
            // 
            this.addCommentToolStripMenuItem.Name = "addCommentToolStripMenuItem";
            this.addCommentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addCommentToolStripMenuItem.Text = "AddComment";
            this.addCommentToolStripMenuItem.Click += new System.EventHandler(this.addCommentToolStripMenuItem_Click);
            // 
            // deletePostToolStripMenuItem
            // 
            this.deletePostToolStripMenuItem.Name = "deletePostToolStripMenuItem";
            this.deletePostToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletePostToolStripMenuItem.Text = "DeletePost";
            this.deletePostToolStripMenuItem.Click += new System.EventHandler(this.deletePostToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.AddNewPost);
            this.Controls.Add(this.gridBlogPosts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBlogPosts)).EndInit();
            this.AddNewPost.ResumeLayout(false);
            this.AddNewPost.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBlogPosts;
        private System.Windows.Forms.GroupBox AddNewPost;
        private System.Windows.Forms.TextBox textPostText;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button AddPostButton;
        private System.Windows.Forms.TextBox textPostBy;
        private System.Windows.Forms.Label PostByLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addCommentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletePostToolStripMenuItem;
    }
}

