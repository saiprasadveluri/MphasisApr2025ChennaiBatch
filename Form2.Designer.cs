namespace ADONetBlogWinApp
{
    partial class Form2
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
            this.gridBlogComment = new System.Windows.Forms.DataGridView();
            this.AddNewComment = new System.Windows.Forms.GroupBox();
            this.Titletxt = new System.Windows.Forms.TextBox();
            this.PostIdtxt = new System.Windows.Forms.TextBox();
            this.CommentedBy = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Commentedbytxt = new System.Windows.Forms.TextBox();
            this.Commenttxt = new System.Windows.Forms.TextBox();
            this.CommentText = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.PostId = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.deleteCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridBlogComment)).BeginInit();
            this.AddNewComment.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridBlogComment
            // 
            this.gridBlogComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBlogComment.Location = new System.Drawing.Point(41, 40);
            this.gridBlogComment.Name = "gridBlogComment";
            this.gridBlogComment.ReadOnly = true;
            this.gridBlogComment.Size = new System.Drawing.Size(588, 150);
            this.gridBlogComment.TabIndex = 2;
            // 
            // AddNewComment
            // 
            this.AddNewComment.Controls.Add(this.Titletxt);
            this.AddNewComment.Controls.Add(this.PostIdtxt);
            this.AddNewComment.Controls.Add(this.CommentedBy);
            this.AddNewComment.Controls.Add(this.Add);
            this.AddNewComment.Controls.Add(this.Commentedbytxt);
            this.AddNewComment.Controls.Add(this.Commenttxt);
            this.AddNewComment.Controls.Add(this.CommentText);
            this.AddNewComment.Controls.Add(this.Title);
            this.AddNewComment.Controls.Add(this.PostId);
            this.AddNewComment.Location = new System.Drawing.Point(50, 209);
            this.AddNewComment.Name = "AddNewComment";
            this.AddNewComment.Size = new System.Drawing.Size(595, 171);
            this.AddNewComment.TabIndex = 3;
            this.AddNewComment.TabStop = false;
            this.AddNewComment.Text = "AddNewComment";
            // 
            // Titletxt
            // 
            this.Titletxt.Location = new System.Drawing.Point(181, 42);
            this.Titletxt.Name = "Titletxt";
            this.Titletxt.Size = new System.Drawing.Size(291, 20);
            this.Titletxt.TabIndex = 9;
            // 
            // PostIdtxt
            // 
            this.PostIdtxt.Location = new System.Drawing.Point(181, 16);
            this.PostIdtxt.Name = "PostIdtxt";
            this.PostIdtxt.Size = new System.Drawing.Size(291, 20);
            this.PostIdtxt.TabIndex = 8;
            // 
            // CommentedBy
            // 
            this.CommentedBy.AutoSize = true;
            this.CommentedBy.Location = new System.Drawing.Point(44, 115);
            this.CommentedBy.Name = "CommentedBy";
            this.CommentedBy.Size = new System.Drawing.Size(75, 13);
            this.CommentedBy.TabIndex = 7;
            this.CommentedBy.Text = "CommentedBy";
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
            // Commentedbytxt
            // 
            this.Commentedbytxt.Location = new System.Drawing.Point(181, 115);
            this.Commentedbytxt.Name = "Commentedbytxt";
            this.Commentedbytxt.Size = new System.Drawing.Size(291, 20);
            this.Commentedbytxt.TabIndex = 5;
            // 
            // Commenttxt
            // 
            this.Commenttxt.Location = new System.Drawing.Point(181, 68);
            this.Commenttxt.Multiline = true;
            this.Commenttxt.Name = "Commenttxt";
            this.Commenttxt.Size = new System.Drawing.Size(291, 41);
            this.Commenttxt.TabIndex = 4;
            // 
            // CommentText
            // 
            this.CommentText.AutoSize = true;
            this.CommentText.Location = new System.Drawing.Point(44, 81);
            this.CommentText.Name = "CommentText";
            this.CommentText.Size = new System.Drawing.Size(72, 13);
            this.CommentText.TabIndex = 2;
            this.CommentText.Text = "CommentText";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(44, 52);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 1;
            this.Title.Text = "Title";
            // 
            // PostId
            // 
            this.PostId.AutoSize = true;
            this.PostId.Location = new System.Drawing.Point(42, 23);
            this.PostId.Name = "PostId";
            this.PostId.Size = new System.Drawing.Size(37, 13);
            this.PostId.TabIndex = 0;
            this.PostId.Text = "PostId";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteCommentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // deleteCommentToolStripMenuItem
            // 
            this.deleteCommentToolStripMenuItem.Name = "deleteCommentToolStripMenuItem";
            this.deleteCommentToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.deleteCommentToolStripMenuItem.Text = "DeleteComment";
            this.deleteCommentToolStripMenuItem.Click += new System.EventHandler(this.deleteCommentToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddNewComment);
            this.Controls.Add(this.gridBlogComment);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBlogComment)).EndInit();
            this.AddNewComment.ResumeLayout(false);
            this.AddNewComment.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBlogComment;
        private System.Windows.Forms.GroupBox AddNewComment;
        private System.Windows.Forms.TextBox Titletxt;
        private System.Windows.Forms.TextBox PostIdtxt;
        private System.Windows.Forms.Label CommentedBy;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Commentedbytxt;
        private System.Windows.Forms.TextBox Commenttxt;
        private System.Windows.Forms.Label CommentText;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label PostId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteCommentToolStripMenuItem;
    }
}