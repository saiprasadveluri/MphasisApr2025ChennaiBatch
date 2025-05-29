namespace Demopart1
{
    partial class Comments
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtcommenttext = new System.Windows.Forms.TextBox();
            this.txtCommentLine = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpostId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridBlogComment)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridBlogComment
            // 
            this.gridBlogComment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBlogComment.Location = new System.Drawing.Point(12, 12);
            this.gridBlogComment.Name = "gridBlogComment";
            this.gridBlogComment.Size = new System.Drawing.Size(727, 150);
            this.gridBlogComment.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpostId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtCommentLine);
            this.groupBox1.Controls.Add(this.txtcommenttext);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 240);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AddNewComment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CommentText";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CommentLine";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(163, 88);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(272, 20);
            this.txtTitle.TabIndex = 7;
            // 
            // txtcommenttext
            // 
            this.txtcommenttext.Location = new System.Drawing.Point(163, 122);
            this.txtcommenttext.Name = "txtcommenttext";
            this.txtcommenttext.Size = new System.Drawing.Size(272, 20);
            this.txtcommenttext.TabIndex = 8;
            // 
            // txtCommentLine
            // 
            this.txtCommentLine.Location = new System.Drawing.Point(163, 157);
            this.txtCommentLine.Name = "txtCommentLine";
            this.txtCommentLine.Size = new System.Drawing.Size(272, 20);
            this.txtCommentLine.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "AddComment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "PostId";
            // 
            // txtpostId
            // 
            this.txtpostId.Location = new System.Drawing.Point(163, 54);
            this.txtpostId.Name = "txtpostId";
            this.txtpostId.Size = new System.Drawing.Size(272, 20);
            this.txtpostId.TabIndex = 12;
            // 
            // Comments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridBlogComment);
            this.Name = "Comments";
            this.Text = "Comments";
            this.Load += new System.EventHandler(this.Comments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBlogComment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBlogComment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCommentLine;
        private System.Windows.Forms.TextBox txtcommenttext;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpostId;
        private System.Windows.Forms.Label label1;
    }
}