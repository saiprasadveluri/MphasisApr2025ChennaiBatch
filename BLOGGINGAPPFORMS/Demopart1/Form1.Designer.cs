namespace Demopart1
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletePostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCommentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPostedBy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridBlogPost)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridBlogPost
            // 
            this.gridBlogPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBlogPost.ContextMenuStrip = this.contextMenuStrip1;
            this.gridBlogPost.Location = new System.Drawing.Point(1, 12);
            this.gridBlogPost.Name = "gridBlogPost";
            this.gridBlogPost.ReadOnly = true;
            this.gridBlogPost.Size = new System.Drawing.Size(787, 150);
            this.gridBlogPost.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deletePostToolStripMenuItem,
            this.addCommentToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // deletePostToolStripMenuItem
            // 
            this.deletePostToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCommentToolStripMenuItem1});
            this.deletePostToolStripMenuItem.Name = "deletePostToolStripMenuItem";
            this.deletePostToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deletePostToolStripMenuItem.Text = "DeletePost";
            this.deletePostToolStripMenuItem.Click += new System.EventHandler(this.deletePostToolStripMenuItem_Click_1);
            // 
            // addCommentToolStripMenuItem1
            // 
            this.addCommentToolStripMenuItem1.Name = "addCommentToolStripMenuItem1";
            this.addCommentToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.addCommentToolStripMenuItem1.Text = "AddComment";
            // 
            // addCommentToolStripMenuItem
            // 
            this.addCommentToolStripMenuItem.Name = "addCommentToolStripMenuItem";
            this.addCommentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addCommentToolStripMenuItem.Text = "AddComment";
            this.addCommentToolStripMenuItem.Click += new System.EventHandler(this.addCommentToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtPostedBy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txttitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 168);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Post";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(218, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "AddPost";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtPostedBy
            // 
            this.txtPostedBy.Location = new System.Drawing.Point(101, 105);
            this.txtPostedBy.Name = "txtPostedBy";
            this.txtPostedBy.Size = new System.Drawing.Size(470, 20);
            this.txtPostedBy.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PostedBy";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(101, 52);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(470, 46);
            this.txtDescription.TabIndex = 3;
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(101, 20);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(470, 20);
            this.txttitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridBlogPost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBlogPost)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBlogPost;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPostedBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deletePostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCommentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCommentToolStripMenuItem1;
    }
}

