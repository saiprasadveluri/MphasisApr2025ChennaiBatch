namespace FoodDeliveryAggregateApp
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
            this.Submit = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Emailtxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Role = new System.Windows.Forms.Label();
            this.Rolecomb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(423, 260);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(247, 120);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 1;
            this.Email.Text = "Email";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(247, 158);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // Emailtxt
            // 
            this.Emailtxt.Location = new System.Drawing.Point(404, 120);
            this.Emailtxt.Name = "Emailtxt";
            this.Emailtxt.Size = new System.Drawing.Size(100, 20);
            this.Emailtxt.TabIndex = 3;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Location = new System.Drawing.Point(404, 158);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(100, 20);
            this.Passwordtxt.TabIndex = 4;
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Location = new System.Drawing.Point(247, 197);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(29, 13);
            this.Role.TabIndex = 5;
            this.Role.Text = "Role";
            // 
            // Rolecomb
            // 
            this.Rolecomb.AutoCompleteCustomSource.AddRange(new string[] {
            "Customer,Admin"});
            this.Rolecomb.FormattingEnabled = true;
            this.Rolecomb.Items.AddRange(new object[] {
            "Admin",
            "Customer",
            "Owner"});
            this.Rolecomb.Location = new System.Drawing.Point(404, 197);
            this.Rolecomb.Name = "Rolecomb";
            this.Rolecomb.Size = new System.Drawing.Size(100, 21);
            this.Rolecomb.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rolecomb);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Emailtxt);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Submit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox Emailtxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.ComboBox Rolecomb;
    }
}

