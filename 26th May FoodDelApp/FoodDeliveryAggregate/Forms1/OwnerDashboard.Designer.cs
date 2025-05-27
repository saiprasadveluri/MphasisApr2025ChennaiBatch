namespace Forms1
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
            this.lblOwner = new System.Windows.Forms.Label();
            this.cmbRestaurants = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMenuItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.availableqty = new System.Windows.Forms.Label();
            this.txtaqty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDishType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddMenuItem = new System.Windows.Forms.Button();
            this.valforunit = new System.Windows.Forms.Label();
            this.txtValueForUnit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(12, 9);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(71, 16);
            this.lblOwner.TabIndex = 0;
            this.lblOwner.Text = "Welcome!!";
            // 
            // cmbRestaurants
            // 
            this.cmbRestaurants.FormattingEnabled = true;
            this.cmbRestaurants.Items.AddRange(new object[] {
            "A2B",
            "Palmshore",
            "Cream Story",
            "BBQ Nation"});
            this.cmbRestaurants.Location = new System.Drawing.Point(134, 46);
            this.cmbRestaurants.Name = "cmbRestaurants";
            this.cmbRestaurants.Size = new System.Drawing.Size(185, 21);
            this.cmbRestaurants.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu Item Name";
            // 
            // txtMenuItemName
            // 
            this.txtMenuItemName.Location = new System.Drawing.Point(134, 73);
            this.txtMenuItemName.Name = "txtMenuItemName";
            this.txtMenuItemName.Size = new System.Drawing.Size(147, 20);
            this.txtMenuItemName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DishType";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(134, 126);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(147, 20);
            this.txtPrice.TabIndex = 3;
            // 
            // availableqty
            // 
            this.availableqty.AutoSize = true;
            this.availableqty.Location = new System.Drawing.Point(23, 181);
            this.availableqty.Name = "availableqty";
            this.availableqty.Size = new System.Drawing.Size(92, 13);
            this.availableqty.TabIndex = 2;
            this.availableqty.Text = "Available Quantity";
            //this.availableqty.Click += new System.EventHandler(this.availableqty_Click);
            // 
            // txtaqty
            // 
            this.txtaqty.Location = new System.Drawing.Point(134, 178);
            this.txtaqty.Name = "txtaqty";
            this.txtaqty.Size = new System.Drawing.Size(147, 20);
            this.txtaqty.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price";
            // 
            // cmbDishType
            // 
            this.cmbDishType.FormattingEnabled = true;
            this.cmbDishType.Location = new System.Drawing.Point(134, 99);
            this.cmbDishType.Name = "cmbDishType";
            this.cmbDishType.Size = new System.Drawing.Size(147, 21);
            this.cmbDishType.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Restaurent";
            // 
            // btnAddMenuItem
            // 
            this.btnAddMenuItem.Location = new System.Drawing.Point(134, 216);
            this.btnAddMenuItem.Name = "btnAddMenuItem";
            this.btnAddMenuItem.Size = new System.Drawing.Size(120, 23);
            this.btnAddMenuItem.TabIndex = 5;
            this.btnAddMenuItem.Text = "Add Menu Item";
            this.btnAddMenuItem.UseVisualStyleBackColor = true;
            this.btnAddMenuItem.Click += new System.EventHandler(this.btnAddMenuItem_Click);
            // 
            // valforunit
            // 
            this.valforunit.AutoSize = true;
            this.valforunit.Location = new System.Drawing.Point(39, 155);
            this.valforunit.Name = "valforunit";
            this.valforunit.Size = new System.Drawing.Size(76, 13);
            this.valforunit.TabIndex = 2;
            this.valforunit.Text = "Value for Units";
            // 
            // txtValueForUnit
            // 
            this.txtValueForUnit.Location = new System.Drawing.Point(134, 152);
            this.txtValueForUnit.Name = "txtValueForUnit";
            this.txtValueForUnit.Size = new System.Drawing.Size(147, 20);
            this.txtValueForUnit.TabIndex = 3;
            // 
            // OwnerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddMenuItem);
            this.Controls.Add(this.cmbDishType);
            this.Controls.Add(this.txtValueForUnit);
            this.Controls.Add(this.txtaqty);
            this.Controls.Add(this.valforunit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.availableqty);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMenuItemName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbRestaurants);
            this.Controls.Add(this.lblOwner);
            this.Name = "OwnerDashboard";
            this.Text = "OwnerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.ComboBox cmbRestaurants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMenuItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label availableqty;
        private System.Windows.Forms.TextBox txtaqty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDishType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddMenuItem;
        private System.Windows.Forms.Label valforunit;
        private System.Windows.Forms.TextBox txtValueForUnit;
    }
}