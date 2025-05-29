namespace ADONetBlogWinApp
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
            this.gridBlogPost = new System.Windows.Forms.DataGridView();
            this.AddNewPost = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.Button();
            this.Postbytxt = new System.Windows.Forms.TextBox();
            this.Texttxt = new System.Windows.Forms.TextBox();
            this.Titletxt = new System.Windows.Forms.TextBox();
            this.PostBy = new System.Windows.Forms.Label();
            this.Text = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.contextMenuComment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deletePostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.addCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridBlogPost)).BeginInit();
            this.AddNewPost.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridBlogPost
            // 
            this.gridBlogPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBlogPost.Location = new System.Drawing.Point(66, 40);
            this.gridBlogPost.Name = "gridBlogPost";
            this.gridBlogPost.ReadOnly = true;
            this.gridBlogPost.Size = new System.Drawing.Size(588, 150);
            this.gridBlogPost.TabIndex = 0;
            this.gridBlogPost.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBlogPost_CellContentClick);
            // 
            // AddNewPost
            // 
            this.AddNewPost.Controls.Add(this.Add);
            this.AddNewPost.Controls.Add(this.Postbytxt);
            this.AddNewPost.Controls.Add(this.Texttxt);
            this.AddNewPost.Controls.Add(this.Titletxt);
            this.AddNewPost.Controls.Add(this.PostBy);
            this.AddNewPost.Controls.Add(this.Text);
            this.AddNewPost.Controls.Add(this.Title);
            this.AddNewPost.Location = new System.Drawing.Point(86, 219);
            this.AddNewPost.Name = "AddNewPost";
            this.AddNewPost.Size = new System.Drawing.Size(595, 171);
            this.AddNewPost.TabIndex = 1;
            this.AddNewPost.TabStop = false;
            this.AddNewPost.Text = "AddNewPost";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(285, 142);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Postbytxt
            // 
            this.Postbytxt.Location = new System.Drawing.Point(195, 112);
            this.Postbytxt.Name = "Postbytxt";
            this.Postbytxt.Size = new System.Drawing.Size(291, 20);
            this.Postbytxt.TabIndex = 5;
            // 
            // Texttxt
            // 
            this.Texttxt.Location = new System.Drawing.Point(195, 61);
            this.Texttxt.Multiline = true;
            this.Texttxt.Name = "Texttxt";
            this.Texttxt.Size = new System.Drawing.Size(291, 41);
            this.Texttxt.TabIndex = 4;
            // 
            // Titletxt
            // 
            this.Titletxt.Location = new System.Drawing.Point(195, 20);
            this.Titletxt.Name = "Titletxt";
            this.Titletxt.Size = new System.Drawing.Size(291, 20);
            this.Titletxt.TabIndex = 3;
            this.Titletxt.Text = "y";
            this.Titletxt.TextChanged += new System.EventHandler(this.Titletxt_TextChanged);
            // 
            // PostBy
            // 
            this.PostBy.AutoSize = true;
            this.PostBy.Location = new System.Drawing.Point(43, 112);
            this.PostBy.Name = "PostBy";
            this.PostBy.Size = new System.Drawing.Size(40, 13);
            this.PostBy.TabIndex = 2;
            this.PostBy.Text = "PostBy";
            // 
            // Text
            // 
            this.Text.AutoSize = true;
            this.Text.Location = new System.Drawing.Point(43, 64);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(28, 13);
            this.Text.TabIndex = 1;
            this.Text.Text = "Text";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(43, 27);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            // 
            // contextMenuComment
            // 
            this.contextMenuComment.Name = "contextMenuComment";
            this.contextMenuComment.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletePostToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deletePostToolStripMenuItem
            // 
            this.deletePostToolStripMenuItem.Name = "deletePostToolStripMenuItem";
            this.deletePostToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.deletePostToolStripMenuItem.Text = "DeletePost";
            this.deletePostToolStripMenuItem.Click += new System.EventHandler(this.deletePostToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCommentToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // addCommentToolStripMenuItem
            // 
            this.addCommentToolStripMenuItem.Name = "addCommentToolStripMenuItem";
            this.addCommentToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.addCommentToolStripMenuItem.Text = "AddComment";
            this.addCommentToolStripMenuItem.Click += new System.EventHandler(this.addCommentToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.AddNewPost);
            this.Controls.Add(this.gridBlogPost);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBlogPost)).EndInit();
            this.AddNewPost.ResumeLayout(false);
            this.AddNewPost.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBlogPost;
        private System.Windows.Forms.GroupBox AddNewPost;
        private System.Windows.Forms.TextBox Postbytxt;
        private System.Windows.Forms.TextBox Texttxt;
        private System.Windows.Forms.TextBox Titletxt;
        private System.Windows.Forms.Label PostBy;
        private System.Windows.Forms.Label Text;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ContextMenuStrip contextMenuComment;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deletePostToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem addCommentToolStripMenuItem;
    }
}

