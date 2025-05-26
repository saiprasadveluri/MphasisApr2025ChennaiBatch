namespace Food_Del_Apps
{
    partial class AddRestaurantForm
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
            this.lblRName = new System.Windows.Forms.Label();
            this.txtRName = new System.Windows.Forms.TextBox();
            this.txtRLocation = new System.Windows.Forms.TextBox();
            this.lblRLocation = new System.Windows.Forms.Label();
            this.lblMinOrderValue = new System.Windows.Forms.Label();
            this.numMinOrderValue = new System.Windows.Forms.NumericUpDown();
            this.lblOwner = new System.Windows.Forms.Label();
            this.cmbOwner = new System.Windows.Forms.ComboBox();
            this.btnAddRestaurant = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMinOrderValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRName
            // 
            this.lblRName.AutoSize = true;
            this.lblRName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRName.Location = new System.Drawing.Point(92, 44);
            this.lblRName.Name = "lblRName";
            this.lblRName.Size = new System.Drawing.Size(135, 20);
            this.lblRName.TabIndex = 0;
            this.lblRName.Text = "Restaurant Name";
            // 
            // txtRName
            // 
            this.txtRName.Location = new System.Drawing.Point(233, 44);
            this.txtRName.Name = "txtRName";
            this.txtRName.Size = new System.Drawing.Size(170, 20);
            this.txtRName.TabIndex = 1;
            // 
            // txtRLocation
            // 
            this.txtRLocation.Location = new System.Drawing.Point(233, 100);
            this.txtRLocation.Name = "txtRLocation";
            this.txtRLocation.Size = new System.Drawing.Size(170, 20);
            this.txtRLocation.TabIndex = 2;
            // 
            // lblRLocation
            // 
            this.lblRLocation.AutoSize = true;
            this.lblRLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRLocation.Location = new System.Drawing.Point(157, 100);
            this.lblRLocation.Name = "lblRLocation";
            this.lblRLocation.Size = new System.Drawing.Size(70, 20);
            this.lblRLocation.TabIndex = 3;
            this.lblRLocation.Text = "Location";
            // 
            // lblMinOrderValue
            // 
            this.lblMinOrderValue.AutoSize = true;
            this.lblMinOrderValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinOrderValue.Location = new System.Drawing.Point(66, 154);
            this.lblMinOrderValue.Name = "lblMinOrderValue";
            this.lblMinOrderValue.Size = new System.Drawing.Size(161, 20);
            this.lblMinOrderValue.TabIndex = 4;
            this.lblMinOrderValue.Text = "Minimum Order Value";
            // 
            // numMinOrderValue
            // 
            this.numMinOrderValue.DecimalPlaces = 2;
            this.numMinOrderValue.Location = new System.Drawing.Point(233, 154);
            this.numMinOrderValue.Name = "numMinOrderValue";
            this.numMinOrderValue.Size = new System.Drawing.Size(170, 20);
            this.numMinOrderValue.TabIndex = 5;
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwner.Location = new System.Drawing.Point(172, 202);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(55, 20);
            this.lblOwner.TabIndex = 6;
            this.lblOwner.Text = "Owner";
            // 
            // cmbOwner
            // 
            this.cmbOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.Location = new System.Drawing.Point(234, 200);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(169, 21);
            this.cmbOwner.TabIndex = 7;
            // 
            // btnAddRestaurant
            // 
            this.btnAddRestaurant.Location = new System.Drawing.Point(217, 257);
            this.btnAddRestaurant.Name = "btnAddRestaurant";
            this.btnAddRestaurant.Size = new System.Drawing.Size(117, 23);
            this.btnAddRestaurant.TabIndex = 8;
            this.btnAddRestaurant.Text = "Add Restaurant";
            this.btnAddRestaurant.UseVisualStyleBackColor = true;
            this.btnAddRestaurant.Click += new System.EventHandler(this.btnAddRestaurant_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(357, 266);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 9;
            // 
            // AddRestaurantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnAddRestaurant);
            this.Controls.Add(this.cmbOwner);
            this.Controls.Add(this.lblOwner);
            this.Controls.Add(this.numMinOrderValue);
            this.Controls.Add(this.lblMinOrderValue);
            this.Controls.Add(this.lblRLocation);
            this.Controls.Add(this.txtRLocation);
            this.Controls.Add(this.txtRName);
            this.Controls.Add(this.lblRName);
            this.Name = "AddRestaurantForm";
            this.Text = "AddRestaurantForm";
            this.Load += new System.EventHandler(this.AddRestaurantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMinOrderValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRName;
        private System.Windows.Forms.TextBox txtRName;
        private System.Windows.Forms.TextBox txtRLocation;
        private System.Windows.Forms.Label lblRLocation;
        private System.Windows.Forms.Label lblMinOrderValue;
        private System.Windows.Forms.NumericUpDown numMinOrderValue;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.ComboBox cmbOwner;
        private System.Windows.Forms.Button btnAddRestaurant;
        private System.Windows.Forms.Label lblMessage;
    }
}