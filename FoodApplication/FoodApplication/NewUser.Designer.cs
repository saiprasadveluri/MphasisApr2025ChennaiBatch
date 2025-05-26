namespace FoodApplication
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
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.UsersNameLabel = new System.Windows.Forms.Label();
            this.UserPasswordLabel = new System.Windows.Forms.Label();
            this.UsersEmailLabel = new System.Windows.Forms.Label();
            this.UserRoleLabel = new System.Windows.Forms.Label();
            this.textUserId = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textUserPassword = new System.Windows.Forms.TextBox();
            this.textUserEmail = new System.Windows.Forms.TextBox();
            this.SaveUsersButton = new System.Windows.Forms.Button();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Location = new System.Drawing.Point(29, 49);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(38, 13);
            this.UserIdLabel.TabIndex = 0;
            this.UserIdLabel.Text = "UserId";
            // 
            // UsersNameLabel
            // 
            this.UsersNameLabel.AutoSize = true;
            this.UsersNameLabel.Location = new System.Drawing.Point(29, 82);
            this.UsersNameLabel.Name = "UsersNameLabel";
            this.UsersNameLabel.Size = new System.Drawing.Size(62, 13);
            this.UsersNameLabel.TabIndex = 1;
            this.UsersNameLabel.Text = "UsersName";
            // 
            // UserPasswordLabel
            // 
            this.UserPasswordLabel.AutoSize = true;
            this.UserPasswordLabel.Location = new System.Drawing.Point(29, 115);
            this.UserPasswordLabel.Name = "UserPasswordLabel";
            this.UserPasswordLabel.Size = new System.Drawing.Size(75, 13);
            this.UserPasswordLabel.TabIndex = 2;
            this.UserPasswordLabel.Text = "UserPassword";
            // 
            // UsersEmailLabel
            // 
            this.UsersEmailLabel.AutoSize = true;
            this.UsersEmailLabel.Location = new System.Drawing.Point(29, 149);
            this.UsersEmailLabel.Name = "UsersEmailLabel";
            this.UsersEmailLabel.Size = new System.Drawing.Size(59, 13);
            this.UsersEmailLabel.TabIndex = 3;
            this.UsersEmailLabel.Text = "UsersEmail";
            // 
            // UserRoleLabel
            // 
            this.UserRoleLabel.AutoSize = true;
            this.UserRoleLabel.Location = new System.Drawing.Point(29, 182);
            this.UserRoleLabel.Name = "UserRoleLabel";
            this.UserRoleLabel.Size = new System.Drawing.Size(51, 13);
            this.UserRoleLabel.TabIndex = 4;
            this.UserRoleLabel.Text = "UserRole";
            // 
            // textUserId
            // 
            this.textUserId.Location = new System.Drawing.Point(197, 49);
            this.textUserId.Name = "textUserId";
            this.textUserId.Size = new System.Drawing.Size(210, 20);
            this.textUserId.TabIndex = 5;
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(197, 82);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(210, 20);
            this.textUserName.TabIndex = 6;
            // 
            // textUserPassword
            // 
            this.textUserPassword.Location = new System.Drawing.Point(197, 115);
            this.textUserPassword.Name = "textUserPassword";
            this.textUserPassword.Size = new System.Drawing.Size(210, 20);
            this.textUserPassword.TabIndex = 7;
            // 
            // textUserEmail
            // 
            this.textUserEmail.Location = new System.Drawing.Point(197, 149);
            this.textUserEmail.Name = "textUserEmail";
            this.textUserEmail.Size = new System.Drawing.Size(210, 20);
            this.textUserEmail.TabIndex = 8;
            // 
            // SaveUsersButton
            // 
            this.SaveUsersButton.Location = new System.Drawing.Point(32, 235);
            this.SaveUsersButton.Name = "SaveUsersButton";
            this.SaveUsersButton.Size = new System.Drawing.Size(75, 23);
            this.SaveUsersButton.TabIndex = 10;
            this.SaveUsersButton.Text = "SaveUsers";
            this.SaveUsersButton.UseVisualStyleBackColor = true;
            this.SaveUsersButton.Click += new System.EventHandler(this.SaveUsersButton_Click);
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Items.AddRange(new object[] {
            "admin",
            "owner",
            "customer"});
            this.RoleComboBox.Location = new System.Drawing.Point(197, 182);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(210, 21);
            this.RoleComboBox.TabIndex = 11;
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.SaveUsersButton);
            this.Controls.Add(this.textUserEmail);
            this.Controls.Add(this.textUserPassword);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.textUserId);
            this.Controls.Add(this.UserRoleLabel);
            this.Controls.Add(this.UsersEmailLabel);
            this.Controls.Add(this.UserPasswordLabel);
            this.Controls.Add(this.UsersNameLabel);
            this.Controls.Add(this.UserIdLabel);
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.Label UsersNameLabel;
        private System.Windows.Forms.Label UserPasswordLabel;
        private System.Windows.Forms.Label UsersEmailLabel;
        private System.Windows.Forms.Label UserRoleLabel;
        private System.Windows.Forms.TextBox textUserId;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textUserPassword;
        private System.Windows.Forms.TextBox textUserEmail;
        private System.Windows.Forms.Button SaveUsersButton;
        private System.Windows.Forms.ComboBox RoleComboBox;
    }
}