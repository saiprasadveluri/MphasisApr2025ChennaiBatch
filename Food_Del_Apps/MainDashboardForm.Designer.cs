namespace Food_Del_Apps
{
    partial class MainDashboardForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlAppUser = new System.Windows.Forms.Panel();
            this.btnViewMyOrders = new System.Windows.Forms.Button();
            this.btnAppSearchRestaurants = new System.Windows.Forms.Button();
            this.pnlOwner = new System.Windows.Forms.Panel();
            this.btnOwnerViewOrders = new System.Windows.Forms.Button();
            this.btnOwnerViewRestaurant = new System.Windows.Forms.Button();
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.btnAdminManageCoupons = new System.Windows.Forms.Button();
            this.btnAdminManageUsers = new System.Windows.Forms.Button();
            this.btnAdminAddRestaurant = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlAppUser.SuspendLayout();
            this.pnlOwner.SuspendLayout();
            this.pnlAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(367, 31);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(75, 20);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // pnlAppUser
            // 
            this.pnlAppUser.Controls.Add(this.btnViewMyOrders);
            this.pnlAppUser.Controls.Add(this.btnAppSearchRestaurants);
            this.pnlAppUser.Location = new System.Drawing.Point(30, 120);
            this.pnlAppUser.Name = "pnlAppUser";
            this.pnlAppUser.Size = new System.Drawing.Size(200, 107);
            this.pnlAppUser.TabIndex = 1;
            // 
            // btnViewMyOrders
            // 
            this.btnViewMyOrders.Location = new System.Drawing.Point(26, 58);
            this.btnViewMyOrders.Name = "btnViewMyOrders";
            this.btnViewMyOrders.Size = new System.Drawing.Size(146, 23);
            this.btnViewMyOrders.TabIndex = 1;
            this.btnViewMyOrders.Text = "View My Orders";
            this.btnViewMyOrders.UseVisualStyleBackColor = true;
            this.btnViewMyOrders.Click += new System.EventHandler(this.btnViewMyOrders_Click);
            // 
            // btnAppSearchRestaurants
            // 
            this.btnAppSearchRestaurants.Location = new System.Drawing.Point(26, 13);
            this.btnAppSearchRestaurants.Name = "btnAppSearchRestaurants";
            this.btnAppSearchRestaurants.Size = new System.Drawing.Size(146, 23);
            this.btnAppSearchRestaurants.TabIndex = 0;
            this.btnAppSearchRestaurants.Text = "Search Restaurants";
            this.btnAppSearchRestaurants.UseVisualStyleBackColor = true;
            this.btnAppSearchRestaurants.Click += new System.EventHandler(this.btnAppSearchRestaurants_Click);
            // 
            // pnlOwner
            // 
            this.pnlOwner.Controls.Add(this.btnOwnerViewOrders);
            this.pnlOwner.Controls.Add(this.btnOwnerViewRestaurant);
            this.pnlOwner.Location = new System.Drawing.Point(301, 120);
            this.pnlOwner.Name = "pnlOwner";
            this.pnlOwner.Size = new System.Drawing.Size(207, 107);
            this.pnlOwner.TabIndex = 2;
            // 
            // btnOwnerViewOrders
            // 
            this.btnOwnerViewOrders.Location = new System.Drawing.Point(26, 62);
            this.btnOwnerViewOrders.Name = "btnOwnerViewOrders";
            this.btnOwnerViewOrders.Size = new System.Drawing.Size(140, 23);
            this.btnOwnerViewOrders.TabIndex = 1;
            this.btnOwnerViewOrders.Text = "View Restaurant Orders";
            this.btnOwnerViewOrders.UseVisualStyleBackColor = true;
            this.btnOwnerViewOrders.Click += new System.EventHandler(this.btnOwnerViewOrders_Click);
            // 
            // btnOwnerViewRestaurant
            // 
            this.btnOwnerViewRestaurant.Location = new System.Drawing.Point(26, 12);
            this.btnOwnerViewRestaurant.Name = "btnOwnerViewRestaurant";
            this.btnOwnerViewRestaurant.Size = new System.Drawing.Size(140, 23);
            this.btnOwnerViewRestaurant.TabIndex = 0;
            this.btnOwnerViewRestaurant.Text = "Manage My Restaurant";
            this.btnOwnerViewRestaurant.UseVisualStyleBackColor = true;
            this.btnOwnerViewRestaurant.Click += new System.EventHandler(this.btnOwnerViewRestaurant_Click);
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Controls.Add(this.btnAdminManageCoupons);
            this.pnlAdmin.Controls.Add(this.btnAdminManageUsers);
            this.pnlAdmin.Controls.Add(this.btnAdminAddRestaurant);
            this.pnlAdmin.Location = new System.Drawing.Point(568, 120);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(207, 107);
            this.pnlAdmin.TabIndex = 3;
            // 
            // btnAdminManageCoupons
            // 
            this.btnAdminManageCoupons.Location = new System.Drawing.Point(35, 71);
            this.btnAdminManageCoupons.Name = "btnAdminManageCoupons";
            this.btnAdminManageCoupons.Size = new System.Drawing.Size(141, 23);
            this.btnAdminManageCoupons.TabIndex = 2;
            this.btnAdminManageCoupons.Text = "Manage Coupons";
            this.btnAdminManageCoupons.UseVisualStyleBackColor = true;
            // 
            // btnAdminManageUsers
            // 
            this.btnAdminManageUsers.Location = new System.Drawing.Point(35, 42);
            this.btnAdminManageUsers.Name = "btnAdminManageUsers";
            this.btnAdminManageUsers.Size = new System.Drawing.Size(141, 23);
            this.btnAdminManageUsers.TabIndex = 1;
            this.btnAdminManageUsers.Text = "Manage Users";
            this.btnAdminManageUsers.UseVisualStyleBackColor = true;
            // 
            // btnAdminAddRestaurant
            // 
            this.btnAdminAddRestaurant.Location = new System.Drawing.Point(35, 13);
            this.btnAdminAddRestaurant.Name = "btnAdminAddRestaurant";
            this.btnAdminAddRestaurant.Size = new System.Drawing.Size(141, 23);
            this.btnAdminAddRestaurant.TabIndex = 0;
            this.btnAdminAddRestaurant.Text = "Add New Restaurant";
            this.btnAdminAddRestaurant.UseVisualStyleBackColor = true;
            this.btnAdminAddRestaurant.Click += new System.EventHandler(this.btnAdminAddRestaurant_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(350, 283);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnlAdmin);
            this.Controls.Add(this.pnlOwner);
            this.Controls.Add(this.pnlAppUser);
            this.Controls.Add(this.lblWelcome);
            this.Name = "MainDashboardForm";
            this.Text = "MainDashboardForm";
            this.Load += new System.EventHandler(this.MainDashboardForm_Load);
            this.pnlAppUser.ResumeLayout(false);
            this.pnlOwner.ResumeLayout(false);
            this.pnlAdmin.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlAppUser;
        private System.Windows.Forms.Button btnViewMyOrders;
        private System.Windows.Forms.Button btnAppSearchRestaurants;
        private System.Windows.Forms.Panel pnlOwner;
        private System.Windows.Forms.Button btnOwnerViewOrders;
        private System.Windows.Forms.Button btnOwnerViewRestaurant;
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Button btnAdminManageCoupons;
        private System.Windows.Forms.Button btnAdminManageUsers;
        private System.Windows.Forms.Button btnAdminAddRestaurant;
        private System.Windows.Forms.Button btnLogout;
    }
}