namespace FoodDelAPP
{
    partial class OwnerDashboardForm
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
            this.cmbRestaurants = new System.Windows.Forms.ComboBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblDishType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblUnitValue = new System.Windows.Forms.Label();
            this.lblUnits = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtValueForUnit = new System.Windows.Forms.TextBox();
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.cmbDishType = new System.Windows.Forms.ComboBox();
            this.lstMenuItems = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbRestaurants
            // 
            this.cmbRestaurants.FormattingEnabled = true;
            this.cmbRestaurants.Location = new System.Drawing.Point(13, 13);
            this.cmbRestaurants.Name = "cmbRestaurants";
            this.cmbRestaurants.Size = new System.Drawing.Size(121, 21);
            this.cmbRestaurants.TabIndex = 0;
            this.cmbRestaurants.SelectedIndexChanged += new System.EventHandler(this.cmbRestaurants_SelectedIndexChanged);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Location = new System.Drawing.Point(13, 51);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(58, 13);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name";
            // 
            // lblDishType
            // 
            this.lblDishType.AutoSize = true;
            this.lblDishType.Location = new System.Drawing.Point(13, 83);
            this.lblDishType.Name = "lblDishType";
            this.lblDishType.Size = new System.Drawing.Size(55, 13);
            this.lblDishType.TabIndex = 2;
            this.lblDishType.Text = "Dish Type";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(13, 110);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "Price";
            // 
            // lblUnitValue
            // 
            this.lblUnitValue.AutoSize = true;
            this.lblUnitValue.Location = new System.Drawing.Point(13, 138);
            this.lblUnitValue.Name = "lblUnitValue";
            this.lblUnitValue.Size = new System.Drawing.Size(71, 13);
            this.lblUnitValue.TabIndex = 4;
            this.lblUnitValue.Text = "Value for Unit";
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(13, 169);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(31, 13);
            this.lblUnits.TabIndex = 5;
            this.lblUnits.Text = "Units";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(90, 200);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Add Menu Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(90, 51);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 20);
            this.txtItemName.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(90, 104);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // txtValueForUnit
            // 
            this.txtValueForUnit.Location = new System.Drawing.Point(90, 133);
            this.txtValueForUnit.Name = "txtValueForUnit";
            this.txtValueForUnit.Size = new System.Drawing.Size(100, 20);
            this.txtValueForUnit.TabIndex = 10;
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(90, 162);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(100, 20);
            this.txtUnits.TabIndex = 11;
            // 
            // cmbDishType
            // 
            this.cmbDishType.FormattingEnabled = true;
            this.cmbDishType.Location = new System.Drawing.Point(90, 77);
            this.cmbDishType.Name = "cmbDishType";
            this.cmbDishType.Size = new System.Drawing.Size(121, 21);
            this.cmbDishType.TabIndex = 12;
            this.cmbDishType.Text = "(Veg/Non-Veg)";
            // 
            // lstMenuItems
            // 
            this.lstMenuItems.FormattingEnabled = true;
            this.lstMenuItems.Location = new System.Drawing.Point(91, 241);
            this.lstMenuItems.Name = "lstMenuItems";
            this.lstMenuItems.Size = new System.Drawing.Size(120, 95);
            this.lstMenuItems.TabIndex = 13;
            // 
            // OwnerDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMenuItems);
            this.Controls.Add(this.cmbDishType);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.txtValueForUnit);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.lblUnitValue);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDishType);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.cmbRestaurants);
            this.Name = "OwnerDashboardForm";
            this.Text = "OwnerDashboardForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbRestaurants;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblDishType;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblUnitValue;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtValueForUnit;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.ComboBox cmbDishType;
        private System.Windows.Forms.ListBox lstMenuItems;
    }
}