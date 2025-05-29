namespace windowsql
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
            GridBlogPost = new DataGridView();
            groupBox1 = new GroupBox();
            btnadd = new Button();
            label3 = new Label();
            txtPostedBy = new TextBox();
            label2 = new Label();
            txtDescription = new TextBox();
            txttitle = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)GridBlogPost).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // GridBlogPost
            // 
            GridBlogPost.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridBlogPost.Location = new Point(12, 12);
            GridBlogPost.Name = "GridBlogPost";
            GridBlogPost.ReadOnly = true;
            GridBlogPost.Size = new Size(637, 150);
            GridBlogPost.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnadd);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPostedBy);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txttitle);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(37, 209);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(544, 229);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Post";
            // 
            // btnadd
            // 
            btnadd.Location = new Point(164, 184);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 6;
            btnadd.Text = "AddPost";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 137);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "PostBy";
            // 
            // txtPostedBy
            // 
            txtPostedBy.Location = new Point(97, 137);
            txtPostedBy.Name = "txtPostedBy";
            txtPostedBy.Size = new Size(405, 23);
            txtPostedBy.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 73);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 3;
            label2.Text = "Text";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(97, 65);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(405, 52);
            txtDescription.TabIndex = 2;
            // 
            // txttitle
            // 
            txttitle.Location = new Point(97, 23);
            txttitle.Name = "txttitle";
            txttitle.Size = new Size(405, 23);
            txttitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(GridBlogPost);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)GridBlogPost).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView GridBlogPost;
        private GroupBox groupBox1;
        private Button btnadd;
        private Label label3;
        private TextBox txtPostedBy;
        private Label label2;
        private TextBox txtDescription;
        private TextBox txttitle;
        private Label label1;
    }
}
