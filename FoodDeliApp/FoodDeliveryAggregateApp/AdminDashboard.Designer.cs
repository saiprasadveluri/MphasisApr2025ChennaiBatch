namespace FoodDeliveryAggregateApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addRestaurantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridrestaurant = new System.Windows.Forms.DataGridView();
            this.Locatongrp = new System.Windows.Forms.GroupBox();
            this.gridLocation = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.usersGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridrestaurant)).BeginInit();
            this.Locatongrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridLocation)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRestaurantToolStripMenuItem,
            this.addLocationToolStripMenuItem,
            this.addUserToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addRestaurantToolStripMenuItem
            // 
            this.addRestaurantToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrderToolStripMenuItem});
            this.addRestaurantToolStripMenuItem.Name = "addRestaurantToolStripMenuItem";
            this.addRestaurantToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.addRestaurantToolStripMenuItem.Text = "AddRestaurant";
            // 
            // addOrderToolStripMenuItem
            // 
            this.addOrderToolStripMenuItem.Name = "addOrderToolStripMenuItem";
            this.addOrderToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.addOrderToolStripMenuItem.Text = "Add Order";
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
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.addUserToolStripMenuItem.Text = "AddUser";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridrestaurant);
            this.groupBox1.Location = new System.Drawing.Point(102, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Restuarant";
            // 
            // gridrestaurant
            // 
            this.gridrestaurant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridrestaurant.Location = new System.Drawing.Point(25, 19);
            this.gridrestaurant.Name = "gridrestaurant";
            this.gridrestaurant.Size = new System.Drawing.Size(322, 81);
            this.gridrestaurant.TabIndex = 0;
            // 
            // Locatongrp
            // 
            this.Locatongrp.Controls.Add(this.gridLocation);
            this.Locatongrp.Location = new System.Drawing.Point(102, 167);
            this.Locatongrp.Name = "Locatongrp";
            this.Locatongrp.Size = new System.Drawing.Size(443, 100);
            this.Locatongrp.TabIndex = 2;
            this.Locatongrp.TabStop = false;
            this.Locatongrp.Text = "Location";
            // 
            // gridLocation
            // 
            this.gridLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLocation.Location = new System.Drawing.Point(25, 13);
            this.gridLocation.Name = "gridLocation";
            this.gridLocation.Size = new System.Drawing.Size(322, 81);
            this.gridLocation.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.usersGrid);
            this.groupBox2.Location = new System.Drawing.Point(102, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Users";
            // 
            // usersGrid
            // 
            this.usersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGrid.Location = new System.Drawing.Point(25, 19);
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.Size = new System.Drawing.Size(322, 150);
            this.usersGrid.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Locatongrp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashboard_FormClosed);
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridrestaurant)).EndInit();
            this.Locatongrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridLocation)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addRestaurantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOrderToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem addLocationToolStripMenuItem;
        private System.Windows.Forms.DataGridView gridrestaurant;
        private System.Windows.Forms.GroupBox Locatongrp;
        private System.Windows.Forms.DataGridView gridLocation;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView usersGrid;
    }
}