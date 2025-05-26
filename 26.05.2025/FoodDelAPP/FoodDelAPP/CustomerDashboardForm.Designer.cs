namespace FoodDelAPP
{
    partial class CustomerDashboardForm
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
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstRestaurants = new System.Windows.Forms.ListBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.lstMenuItems = new System.Windows.Forms.ListBox();
            this.cmbDishType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(33, 29);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(99, 13);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Search by Location";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(147, 29);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 1;
            this.txtLocation.Text = "Type location";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(253, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstRestaurants
            // 
            this.lstRestaurants.FormattingEnabled = true;
            this.lstRestaurants.Location = new System.Drawing.Point(147, 58);
            this.lstRestaurants.Name = "lstRestaurants";
            this.lstRestaurants.Size = new System.Drawing.Size(181, 95);
            this.lstRestaurants.TabIndex = 3;
            this.lstRestaurants.SelectedIndexChanged += new System.EventHandler(this.lstRestaurants_SelectedIndexChanged);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(36, 173);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(55, 13);
            this.lblFilter.TabIndex = 4;
            this.lblFilter.Text = "Dish Type";
            // 
            // lstMenuItems
            // 
            this.lstMenuItems.FormattingEnabled = true;
            this.lstMenuItems.Location = new System.Drawing.Point(148, 211);
            this.lstMenuItems.Name = "lstMenuItems";
            this.lstMenuItems.Size = new System.Drawing.Size(180, 95);
            this.lstMenuItems.TabIndex = 5;
            // 
            // cmbDishType
            // 
            this.cmbDishType.FormattingEnabled = true;
            this.cmbDishType.Location = new System.Drawing.Point(147, 170);
            this.cmbDishType.Name = "cmbDishType";
            this.cmbDishType.Size = new System.Drawing.Size(121, 21);
            this.cmbDishType.TabIndex = 6;
            this.cmbDishType.SelectedIndexChanged += new System.EventHandler(this.cmbDishType_SelectedIndexChanged);
            // 
            // CustomerDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbDishType);
            this.Controls.Add(this.lstMenuItems);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.lstRestaurants);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Name = "CustomerDashboardForm";
            this.Text = "CustomerDashboardForm";
            this.Load += new System.EventHandler(this.CustomerDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstRestaurants;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ListBox lstMenuItems;
        private System.Windows.Forms.ComboBox cmbDishType;
    }
}