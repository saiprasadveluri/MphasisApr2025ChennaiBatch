namespace FoodDeliveryWindowForms
{
    partial class AdminDashboard
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridRestaurant = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addRestaurantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LocationsGrid = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.UsersGrid = new System.Windows.Forms.DataGridView();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridRestaurant)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LocationsGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridRestaurant);
            this.groupBox1.Location = new System.Drawing.Point(91, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 116);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restaurant";
            // 
            // gridRestaurant
            // 
            this.gridRestaurant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRestaurant.Location = new System.Drawing.Point(17, 19);
            this.gridRestaurant.Name = "gridRestaurant";
            this.gridRestaurant.Size = new System.Drawing.Size(210, 81);
            this.gridRestaurant.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRestaurantToolStripMenuItem,
            this.addLocationsToolStripMenuItem,
            this.addUserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addRestaurantToolStripMenuItem
            // 
            this.addRestaurantToolStripMenuItem.Name = "addRestaurantToolStripMenuItem";
            this.addRestaurantToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.addRestaurantToolStripMenuItem.Text = "Add Restaurant";
            // 
            // addLocationsToolStripMenuItem
            // 
            this.addLocationsToolStripMenuItem.Name = "addLocationsToolStripMenuItem";
            this.addLocationsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.addLocationsToolStripMenuItem.Text = "Add Locations";
            this.addLocationsToolStripMenuItem.Click += new System.EventHandler(this.addLocationsToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LocationsGrid);
            this.groupBox2.Location = new System.Drawing.Point(31, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 118);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Locations";
            // 
            // LocationsGrid
            // 
            this.LocationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LocationsGrid.Location = new System.Drawing.Point(22, 19);
            this.LocationsGrid.Name = "LocationsGrid";
            this.LocationsGrid.Size = new System.Drawing.Size(302, 82);
            this.LocationsGrid.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.UsersGrid);
            this.groupBox3.Location = new System.Drawing.Point(457, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 175);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Users";
            // 
            // UsersGrid
            // 
            this.UsersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGrid.Location = new System.Drawing.Point(31, 30);
            this.UsersGrid.Name = "UsersGrid";
            this.UsersGrid.Size = new System.Drawing.Size(240, 116);
            this.UsersGrid.TabIndex = 0;
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.addUserToolStripMenuItem.Text = "Add User";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click_1);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridRestaurant)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LocationsGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridRestaurant;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addRestaurantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLocationsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView LocationsGrid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView UsersGrid;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
    }
}