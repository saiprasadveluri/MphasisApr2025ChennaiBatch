using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodDelAPP.Models;

namespace Forms1
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.restgrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminactions = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewRestaurentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locgrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.restgrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 47);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(120, 18);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome Admin!";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // restgrid
            // 
            this.restgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.restgrid.Location = new System.Drawing.Point(15, 80);
            this.restgrid.Name = "restgrid";
            this.restgrid.Size = new System.Drawing.Size(487, 176);
            this.restgrid.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminactions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminactions
            // 
            this.adminactions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewRestaurentToolStripMenuItem,
            this.addLocationToolStripMenuItem});
            this.adminactions.Name = "adminactions";
            this.adminactions.Size = new System.Drawing.Size(98, 20);
            this.adminactions.Text = "Admin Actions";
            // 
            // addNewRestaurentToolStripMenuItem
            // 
            this.addNewRestaurentToolStripMenuItem.Name = "addNewRestaurentToolStripMenuItem";
            this.addNewRestaurentToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.addNewRestaurentToolStripMenuItem.Text = "Add New Restaurent";
            this.addNewRestaurentToolStripMenuItem.Click += new System.EventHandler(this.addNewRestaurentToolStripMenuItem_Click_1);
            // 
            // addLocationToolStripMenuItem
            // 
            this.addLocationToolStripMenuItem.Name = "addLocationToolStripMenuItem";
            this.addLocationToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.addLocationToolStripMenuItem.Text = "Add Location";
            // 
            // locgrid
            // 
            this.locgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locgrid.Location = new System.Drawing.Point(15, 262);
            this.locgrid.Name = "locgrid";
            this.locgrid.Size = new System.Drawing.Size(487, 176);
            this.locgrid.TabIndex = 2;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.locgrid);
            this.Controls.Add(this.restgrid);
            this.Controls.Add(this.lblWelcome);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.restgrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView restgrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminactions;
        private System.Windows.Forms.ToolStripMenuItem addNewRestaurentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLocationToolStripMenuItem;
        private System.Windows.Forms.DataGridView locgrid;
    }
}