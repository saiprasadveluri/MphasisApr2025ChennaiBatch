namespace Food_App
{
    partial class OwnerDashboard
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
            this.dgvRestaurants = new System.Windows.Forms.DataGridView();
            this.dgvMenuItems = new System.Windows.Forms.DataGridView();
            this.btnAddMenuItems = new System.Windows.Forms.Button();
            this.btnEditMenuItem = new System.Windows.Forms.Button();
            this.btnDeleteMenuItem = new System.Windows.Forms.Button();
            this.lblOwnerName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRestaurants
            // 
            this.dgvRestaurants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRestaurants.Location = new System.Drawing.Point(113, 83);
            this.dgvRestaurants.Name = "dgvRestaurants";
            this.dgvRestaurants.Size = new System.Drawing.Size(240, 150);
            this.dgvRestaurants.TabIndex = 0;
            // 
            // dgvMenuItems
            // 
            this.dgvMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuItems.Location = new System.Drawing.Point(439, 83);
            this.dgvMenuItems.Name = "dgvMenuItems";
            this.dgvMenuItems.Size = new System.Drawing.Size(240, 150);
            this.dgvMenuItems.TabIndex = 1;
            // 
            // btnAddMenuItems
            // 
            this.btnAddMenuItems.Location = new System.Drawing.Point(219, 269);
            this.btnAddMenuItems.Name = "btnAddMenuItems";
            this.btnAddMenuItems.Size = new System.Drawing.Size(75, 23);
            this.btnAddMenuItems.TabIndex = 2;
            this.btnAddMenuItems.Text = "Add Menu Items";
            this.btnAddMenuItems.UseVisualStyleBackColor = true;
            this.btnAddMenuItems.Click += new System.EventHandler(this.btnAddMenuItems_Click);
            // 
            // btnEditMenuItem
            // 
            this.btnEditMenuItem.Location = new System.Drawing.Point(362, 269);
            this.btnEditMenuItem.Name = "btnEditMenuItem";
            this.btnEditMenuItem.Size = new System.Drawing.Size(75, 23);
            this.btnEditMenuItem.TabIndex = 3;
            this.btnEditMenuItem.Text = "Edit Item";
            this.btnEditMenuItem.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMenuItem
            // 
            this.btnDeleteMenuItem.Location = new System.Drawing.Point(502, 269);
            this.btnDeleteMenuItem.Name = "btnDeleteMenuItem";
            this.btnDeleteMenuItem.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMenuItem.TabIndex = 4;
            this.btnDeleteMenuItem.Text = "Delete Menu Item";
            this.btnDeleteMenuItem.UseVisualStyleBackColor = true;
            // 
            // lblOwnerName
            // 
            this.lblOwnerName.AutoSize = true;
            this.lblOwnerName.Location = new System.Drawing.Point(362, 34);
            this.lblOwnerName.Name = "lblOwnerName";
            this.lblOwnerName.Size = new System.Drawing.Size(93, 13);
            this.lblOwnerName.TabIndex = 5;
            this.lblOwnerName.Text = "Owner Dashboard";
            // 
            // OwnerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOwnerName);
            this.Controls.Add(this.btnDeleteMenuItem);
            this.Controls.Add(this.btnEditMenuItem);
            this.Controls.Add(this.btnAddMenuItems);
            this.Controls.Add(this.dgvMenuItems);
            this.Controls.Add(this.dgvRestaurants);
            this.Name = "OwnerDashboard";
            this.Text = "OwnerDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRestaurants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRestaurants;
        private System.Windows.Forms.DataGridView dgvMenuItems;
        private System.Windows.Forms.Button btnAddMenuItems;
        private System.Windows.Forms.Button btnEditMenuItem;
        private System.Windows.Forms.Button btnDeleteMenuItem;
        private System.Windows.Forms.Label lblOwnerName;
    }
}