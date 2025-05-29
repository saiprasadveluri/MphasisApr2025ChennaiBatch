namespace ADDNetBlogWinApp
{
    partial class NewComment
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
            this.gridBlogComments = new System.Windows.Forms.DataGridView();
            this.AddComments = new System.Windows.Forms.GroupBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CommentTextLabel = new System.Windows.Forms.Label();
            this.CommentByLabel = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textCommentText = new System.Windows.Forms.TextBox();
            this.textCommentBy = new System.Windows.Forms.TextBox();
            this.AddCommentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridBlogComments)).BeginInit();
            this.AddComments.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridBlogComments
            // 
            this.gridBlogComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBlogComments.Location = new System.Drawing.Point(29, 28);
            this.gridBlogComments.Name = "gridBlogComments";
            this.gridBlogComments.Size = new System.Drawing.Size(608, 150);
            this.gridBlogComments.TabIndex = 0;
            // 
            // AddComments
            // 
            this.AddComments.Controls.Add(this.AddCommentButton);
            this.AddComments.Controls.Add(this.textCommentBy);
            this.AddComments.Controls.Add(this.textCommentText);
            this.AddComments.Controls.Add(this.textTitle);
            this.AddComments.Controls.Add(this.CommentByLabel);
            this.AddComments.Controls.Add(this.CommentTextLabel);
            this.AddComments.Controls.Add(this.TitleLabel);
            this.AddComments.Location = new System.Drawing.Point(29, 196);
            this.AddComments.Name = "AddComments";
            this.AddComments.Size = new System.Drawing.Size(732, 196);
            this.AddComments.TabIndex = 1;
            this.AddComments.TabStop = false;
            this.AddComments.Text = "AddComments";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(21, 45);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            // 
            // CommentTextLabel
            // 
            this.CommentTextLabel.AutoSize = true;
            this.CommentTextLabel.Location = new System.Drawing.Point(21, 76);
            this.CommentTextLabel.Name = "CommentTextLabel";
            this.CommentTextLabel.Size = new System.Drawing.Size(72, 13);
            this.CommentTextLabel.TabIndex = 2;
            this.CommentTextLabel.Text = "CommentText";
            // 
            // CommentByLabel
            // 
            this.CommentByLabel.AutoSize = true;
            this.CommentByLabel.Location = new System.Drawing.Point(21, 109);
            this.CommentByLabel.Name = "CommentByLabel";
            this.CommentByLabel.Size = new System.Drawing.Size(63, 13);
            this.CommentByLabel.TabIndex = 3;
            this.CommentByLabel.Text = "CommentBy";
            // 
            // textTitle
            // 
            this.textTitle.Location = new System.Drawing.Point(228, 45);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(243, 20);
            this.textTitle.TabIndex = 4;
            // 
            // textCommentText
            // 
            this.textCommentText.Location = new System.Drawing.Point(228, 76);
            this.textCommentText.Name = "textCommentText";
            this.textCommentText.Size = new System.Drawing.Size(243, 20);
            this.textCommentText.TabIndex = 5;
            // 
            // textCommentBy
            // 
            this.textCommentBy.Location = new System.Drawing.Point(228, 109);
            this.textCommentBy.Name = "textCommentBy";
            this.textCommentBy.Size = new System.Drawing.Size(243, 20);
            this.textCommentBy.TabIndex = 6;
            // 
            // AddCommentButton
            // 
            this.AddCommentButton.Location = new System.Drawing.Point(228, 160);
            this.AddCommentButton.Name = "AddCommentButton";
            this.AddCommentButton.Size = new System.Drawing.Size(151, 23);
            this.AddCommentButton.TabIndex = 7;
            this.AddCommentButton.Text = "AddComment";
            this.AddCommentButton.UseVisualStyleBackColor = true;
            this.AddCommentButton.Click += new System.EventHandler(this.AddCommentButton_Click);
            // 
            // NewComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddComments);
            this.Controls.Add(this.gridBlogComments);
            this.Name = "NewComment";
            this.Text = "NewComment";
            this.Load += new System.EventHandler(this.NewComment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBlogComments)).EndInit();
            this.AddComments.ResumeLayout(false);
            this.AddComments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBlogComments;
        private System.Windows.Forms.GroupBox AddComments;
        private System.Windows.Forms.Label CommentTextLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label CommentByLabel;
        private System.Windows.Forms.TextBox textCommentBy;
        private System.Windows.Forms.TextBox textCommentText;
        private System.Windows.Forms.TextBox textTitle;
        private System.Windows.Forms.Button AddCommentButton;
    }
}