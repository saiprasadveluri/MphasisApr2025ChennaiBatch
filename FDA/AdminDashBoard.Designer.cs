namespace FDA
{
    partial class AdminDashBoard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxLocations = new System.Windows.Forms.GroupBox();
            this.grpBoxUsers = new System.Windows.Forms.GroupBox();
            this.GridLocations = new System.Windows.Forms.DataGridView();
            this.GridUsers = new System.Windows.Forms.DataGridView();
            this.addRestaurantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxRestaurant = new System.Windows.Forms.GroupBox();
            this.GridRestaurant = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.grpBoxLocations.SuspendLayout();
            this.grpBoxUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLocations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRestaurant)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLocationToolStripMenuItem,
            this.addUserToolStripMenuItem,
            this.addRestaurantToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addLocationToolStripMenuItem
            // 
            this.addLocationToolStripMenuItem.Name = "addLocationToolStripMenuItem";
            this.addLocationToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.addLocationToolStripMenuItem.Text = "Add Location";
            this.addLocationToolStripMenuItem.Click += new System.EventHandler(this.addLocationToolStripMenuItem_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // grpBoxLocations
            // 
            this.grpBoxLocations.Controls.Add(this.GridLocations);
            this.grpBoxLocations.Location = new System.Drawing.Point(44, 43);
            this.grpBoxLocations.Name = "grpBoxLocations";
            this.grpBoxLocations.Size = new System.Drawing.Size(303, 120);
            this.grpBoxLocations.TabIndex = 1;
            this.grpBoxLocations.TabStop = false;
            this.grpBoxLocations.Text = "Locations";
            // 
            // grpBoxUsers
            // 
            this.grpBoxUsers.Controls.Add(this.GridUsers);
            this.grpBoxUsers.Location = new System.Drawing.Point(486, 43);
            this.grpBoxUsers.Name = "grpBoxUsers";
            this.grpBoxUsers.Size = new System.Drawing.Size(302, 132);
            this.grpBoxUsers.TabIndex = 2;
            this.grpBoxUsers.TabStop = false;
            this.grpBoxUsers.Text = "Users";
            // 
            // GridLocations
            // 
            this.GridLocations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLocations.Location = new System.Drawing.Point(15, 19);
            this.GridLocations.Name = "GridLocations";
            this.GridLocations.Size = new System.Drawing.Size(240, 70);
            this.GridLocations.TabIndex = 0;
            // 
            // GridUsers
            // 
            this.GridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUsers.Location = new System.Drawing.Point(6, 19);
            this.GridUsers.Name = "GridUsers";
            this.GridUsers.Size = new System.Drawing.Size(267, 86);
            this.GridUsers.TabIndex = 0;
            // 
            // addRestaurantToolStripMenuItem
            // 
            this.addRestaurantToolStripMenuItem.Name = "addRestaurantToolStripMenuItem";
            this.addRestaurantToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.addRestaurantToolStripMenuItem.Text = "Add Restaurant";
            this.addRestaurantToolStripMenuItem.Click += new System.EventHandler(this.addRestaurantToolStripMenuItem_Click);
            // 
            // grpBoxRestaurant
            // 
            this.grpBoxRestaurant.Location = new System.Drawing.Point(74, 199);
            this.grpBoxRestaurant.Name = "grpBoxRestaurant";
            this.grpBoxRestaurant.Size = new System.Drawing.Size(286, 100);
            this.grpBoxRestaurant.TabIndex = 3;
            this.grpBoxRestaurant.TabStop = false;
            this.grpBoxRestaurant.Text = "Restaurants";
            // 
            // GridRestaurant
            // 
            this.GridRestaurant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridRestaurant.Location = new System.Drawing.Point(101, 218);
            this.GridRestaurant.Name = "GridRestaurant";
            this.GridRestaurant.Size = new System.Drawing.Size(240, 75);
            this.GridRestaurant.TabIndex = 0;
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GridRestaurant);
            this.Controls.Add(this.grpBoxRestaurant);
            this.Controls.Add(this.grpBoxUsers);
            this.Controls.Add(this.grpBoxLocations);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminDashBoard";
            this.Text = "AdminDashBoard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashBoard_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBoxLocations.ResumeLayout(false);
            this.grpBoxUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridLocations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridRestaurant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBoxLocations;
        private System.Windows.Forms.DataGridView GridLocations;
        private System.Windows.Forms.GroupBox grpBoxUsers;
        private System.Windows.Forms.DataGridView GridUsers;
        private System.Windows.Forms.ToolStripMenuItem addRestaurantToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBoxRestaurant;
        private System.Windows.Forms.DataGridView GridRestaurant;
    }
}