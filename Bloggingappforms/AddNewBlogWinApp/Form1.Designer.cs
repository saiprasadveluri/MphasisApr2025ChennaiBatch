namespace AddNewBlogWinApp
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
            this.AddNewPost = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPostedBy = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GridBlog = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletePostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBlog)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNewPost
            // 
            this.AddNewPost.Controls.Add(this.button1);
            this.AddNewPost.Controls.Add(this.txtPostedBy);
            this.AddNewPost.Controls.Add(this.txtTitle);
            this.AddNewPost.Controls.Add(this.txtDescription);
            this.AddNewPost.Controls.Add(this.label3);
            this.AddNewPost.Controls.Add(this.label2);
            this.AddNewPost.Controls.Add(this.label1);
            this.AddNewPost.Location = new System.Drawing.Point(34, 152);
            this.AddNewPost.Name = "AddNewPost";
            this.AddNewPost.Size = new System.Drawing.Size(569, 168);
            this.AddNewPost.TabIndex = 1;
            this.AddNewPost.TabStop = false;
            this.AddNewPost.Text = "Add New Post";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Post";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPostedBy
            // 
            this.txtPostedBy.Location = new System.Drawing.Point(112, 97);
            this.txtPostedBy.Name = "txtPostedBy";
            this.txtPostedBy.Size = new System.Drawing.Size(292, 20);
            this.txtPostedBy.TabIndex = 5;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(112, 18);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(292, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(112, 44);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(292, 47);
            this.txtDescription.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PostBy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // GridBlog
            // 
            this.GridBlog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridBlog.ContextMenuStrip = this.contextMenuStrip1;
            this.GridBlog.Location = new System.Drawing.Point(70, 27);
            this.GridBlog.Name = "GridBlog";
            this.GridBlog.Size = new System.Drawing.Size(458, 94);
            this.GridBlog.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletePostToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // deletePostToolStripMenuItem
            // 
            this.deletePostToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCommentToolStripMenuItem});
            this.deletePostToolStripMenuItem.Name = "deletePostToolStripMenuItem";
            this.deletePostToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletePostToolStripMenuItem.Text = "Delete Post";
            this.deletePostToolStripMenuItem.Click += new System.EventHandler(this.deletePostToolStripMenuItem_Click_1);
            // 
            // addCommentToolStripMenuItem
            // 
            this.addCommentToolStripMenuItem.Name = "addCommentToolStripMenuItem";
            this.addCommentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addCommentToolStripMenuItem.Text = "AddComment";
            this.addCommentToolStripMenuItem.Click += new System.EventHandler(this.addCommentToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridBlog);
            this.Controls.Add(this.AddNewPost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AddNewPost.ResumeLayout(false);
            this.AddNewPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridBlog)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox AddNewPost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPostedBy;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridBlog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deletePostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCommentToolStripMenuItem;
    }
}

