namespace FoodDeliveryAggregateApp
{
    partial class AddUser
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
            this.Add = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.Label();
            this.UID = new System.Windows.Forms.Label();
            this.Uemail = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.Nametxt = new System.Windows.Forms.TextBox();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(265, 261);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 0;
            this.Add.Text = "ADD USER";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(203, 148);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 1;
            this.Name.Text = "Name";
            // 
            // UID
            // 
            this.UID.AutoSize = true;
            this.UID.Location = new System.Drawing.Point(207, 114);
            this.UID.Name = "UID";
            this.UID.Size = new System.Drawing.Size(18, 13);
            this.UID.TabIndex = 2;
            this.UID.Text = "ID";
            this.UID.Click += new System.EventHandler(this.label2_Click);
            // 
            // Uemail
            // 
            this.Uemail.AutoSize = true;
            this.Uemail.Location = new System.Drawing.Point(203, 189);
            this.Uemail.Name = "Uemail";
            this.Uemail.Size = new System.Drawing.Size(32, 13);
            this.Uemail.TabIndex = 4;
            this.Uemail.Text = "Email";
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(317, 111);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(100, 20);
            this.IDtxt.TabIndex = 5;
            // 
            // Nametxt
            // 
            this.Nametxt.Location = new System.Drawing.Point(317, 148);
            this.Nametxt.Name = "Nametxt";
            this.Nametxt.Size = new System.Drawing.Size(100, 20);
            this.Nametxt.TabIndex = 6;
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(317, 186);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(100, 20);
            this.Emailtxt.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(317, 221);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(100, 20);
            this.Passwordtxt.TabIndex = 10;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Nametxt);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.Uemail);
            this.Controls.Add(this.UID);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Add);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label UID;
        private System.Windows.Forms.Label Uemail;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.TextBox Nametxt;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Passwordtxt;
    }
}