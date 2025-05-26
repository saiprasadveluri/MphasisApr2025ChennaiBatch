namespace FoodDeliveryAggregateApp
{
    partial class NewUser
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textUserId = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textUserPassword = new System.Windows.Forms.TextBox();
            this.textUserEmail = new System.Windows.Forms.TextBox();
            this.textUserRole = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserPassword";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "UserEmail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "UserRole";
            // 
            // textUserId
            // 
            this.textUserId.Location = new System.Drawing.Point(324, 48);
            this.textUserId.Name = "textUserId";
            this.textUserId.Size = new System.Drawing.Size(196, 20);
            this.textUserId.TabIndex = 5;
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(324, 94);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(178, 20);
            this.textUserName.TabIndex = 6;
            // 
            // textUserPassword
            // 
            this.textUserPassword.Location = new System.Drawing.Point(324, 146);
            this.textUserPassword.Name = "textUserPassword";
            this.textUserPassword.Size = new System.Drawing.Size(196, 20);
            this.textUserPassword.TabIndex = 7;
            // 
            // textUserEmail
            // 
            this.textUserEmail.Location = new System.Drawing.Point(324, 195);
            this.textUserEmail.Name = "textUserEmail";
            this.textUserEmail.Size = new System.Drawing.Size(182, 20);
            this.textUserEmail.TabIndex = 8;
            // 
            // textUserRole
            // 
            this.textUserRole.Location = new System.Drawing.Point(324, 240);
            this.textUserRole.Name = "textUserRole";
            this.textUserRole.Size = new System.Drawing.Size(196, 20);
            this.textUserRole.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(313, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textUserRole);
            this.Controls.Add(this.textUserEmail);
            this.Controls.Add(this.textUserPassword);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.textUserId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textUserId;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textUserPassword;
        private System.Windows.Forms.TextBox textUserEmail;
        private System.Windows.Forms.TextBox textUserRole;
        private System.Windows.Forms.Button btnSave;
    }
}