namespace FoodDeliveryApp.Forms
{
    partial class RestaurantSearchForm
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
            this.cmbDishTypeFilter = new System.Windows.Forms.ComboBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDishTypeFilter
            // 
            this.cmbDishTypeFilter.FormattingEnabled = true;
            this.cmbDishTypeFilter.Location = new System.Drawing.Point(196, 89);
            this.cmbDishTypeFilter.Name = "cmbDishTypeFilter";
            this.cmbDishTypeFilter.Size = new System.Drawing.Size(121, 24);
            this.cmbDishTypeFilter.TabIndex = 0;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(196, 149);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 22);
            this.txtLocation.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(196, 215);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "button1";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnViewMenu
            // 
            this.btnViewMenu.Location = new System.Drawing.Point(196, 267);
            this.btnViewMenu.Name = "btnViewMenu";
            this.btnViewMenu.Size = new System.Drawing.Size(75, 23);
            this.btnViewMenu.TabIndex = 3;
            this.btnViewMenu.Text = "button1";
            this.btnViewMenu.UseVisualStyleBackColor = true;
            // 
            // RestaurantSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewMenu);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.cmbDishTypeFilter);
            this.Name = "RestaurantSearchForm";
            this.Text = "RestaurantSearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDishTypeFilter;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewMenu;
    }
}