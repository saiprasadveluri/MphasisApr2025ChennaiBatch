namespace FoodDeliveryAggregateApp
{
    partial class AddRestaurant
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
            this.RestSubmit = new System.Windows.Forms.Button();
            this.RestId = new System.Windows.Forms.Label();
            this.RestName = new System.Windows.Forms.Label();
            this.RestLocation = new System.Windows.Forms.Label();
            this.RestIdtxt = new System.Windows.Forms.TextBox();
            this.RestNmaetxt = new System.Windows.Forms.TextBox();
            this.Restlocationtxt = new System.Windows.Forms.TextBox();
            this.MinimumOrderValue = new System.Windows.Forms.Label();
            this.OwnerId = new System.Windows.Forms.Label();
            this.RestMinimumValuetxt = new System.Windows.Forms.TextBox();
            this.RestOwnerIdtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RestSubmit
            // 
            this.RestSubmit.Location = new System.Drawing.Point(303, 268);
            this.RestSubmit.Name = "RestSubmit";
            this.RestSubmit.Size = new System.Drawing.Size(123, 23);
            this.RestSubmit.TabIndex = 0;
            this.RestSubmit.Text = "Add Restaurant";
            this.RestSubmit.UseVisualStyleBackColor = true;
            this.RestSubmit.Click += new System.EventHandler(this.RestSubmit_Click);
            // 
            // RestId
            // 
            this.RestId.AutoSize = true;
            this.RestId.Location = new System.Drawing.Point(244, 57);
            this.RestId.Name = "RestId";
            this.RestId.Size = new System.Drawing.Size(68, 13);
            this.RestId.TabIndex = 1;
            this.RestId.Text = "RestaurantId";
            this.RestId.Click += new System.EventHandler(this.RestId_Click);
            // 
            // RestName
            // 
            this.RestName.AutoSize = true;
            this.RestName.Location = new System.Drawing.Point(244, 100);
            this.RestName.Name = "RestName";
            this.RestName.Size = new System.Drawing.Size(87, 13);
            this.RestName.TabIndex = 2;
            this.RestName.Text = "RestaurantName";
            // 
            // RestLocation
            // 
            this.RestLocation.AutoSize = true;
            this.RestLocation.Location = new System.Drawing.Point(244, 144);
            this.RestLocation.Name = "RestLocation";
            this.RestLocation.Size = new System.Drawing.Size(48, 13);
            this.RestLocation.TabIndex = 3;
            this.RestLocation.Text = "Location";
            // 
            // RestIdtxt
            // 
            this.RestIdtxt.Location = new System.Drawing.Point(361, 57);
            this.RestIdtxt.Name = "RestIdtxt";
            this.RestIdtxt.Size = new System.Drawing.Size(100, 20);
            this.RestIdtxt.TabIndex = 4;
            this.RestIdtxt.TextChanged += new System.EventHandler(this.RestIdtxt_TextChanged);
            // 
            // RestNmaetxt
            // 
            this.RestNmaetxt.Location = new System.Drawing.Point(361, 100);
            this.RestNmaetxt.Name = "RestNmaetxt";
            this.RestNmaetxt.Size = new System.Drawing.Size(100, 20);
            this.RestNmaetxt.TabIndex = 5;
            // 
            // Restlocationtxt
            // 
            this.Restlocationtxt.Location = new System.Drawing.Point(361, 141);
            this.Restlocationtxt.Name = "Restlocationtxt";
            this.Restlocationtxt.Size = new System.Drawing.Size(100, 20);
            this.Restlocationtxt.TabIndex = 6;
            // 
            // MinimumOrderValue
            // 
            this.MinimumOrderValue.AutoSize = true;
            this.MinimumOrderValue.Location = new System.Drawing.Point(244, 184);
            this.MinimumOrderValue.Name = "MinimumOrderValue";
            this.MinimumOrderValue.Size = new System.Drawing.Size(101, 13);
            this.MinimumOrderValue.TabIndex = 7;
            this.MinimumOrderValue.Text = "MinimumOrderValue";
            // 
            // OwnerId
            // 
            this.OwnerId.AutoSize = true;
            this.OwnerId.Location = new System.Drawing.Point(245, 223);
            this.OwnerId.Name = "OwnerId";
            this.OwnerId.Size = new System.Drawing.Size(47, 13);
            this.OwnerId.TabIndex = 8;
            this.OwnerId.Text = "OwnerId";
            this.OwnerId.Click += new System.EventHandler(this.label2_Click);
            // 
            // RestMinimumValuetxt
            // 
            this.RestMinimumValuetxt.Location = new System.Drawing.Point(361, 184);
            this.RestMinimumValuetxt.Name = "RestMinimumValuetxt";
            this.RestMinimumValuetxt.Size = new System.Drawing.Size(100, 20);
            this.RestMinimumValuetxt.TabIndex = 9;
            // 
            // RestOwnerIdtxt
            // 
            this.RestOwnerIdtxt.Location = new System.Drawing.Point(361, 220);
            this.RestOwnerIdtxt.Name = "RestOwnerIdtxt";
            this.RestOwnerIdtxt.Size = new System.Drawing.Size(100, 20);
            this.RestOwnerIdtxt.TabIndex = 10;
            // 
            // AddRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RestOwnerIdtxt);
            this.Controls.Add(this.RestMinimumValuetxt);
            this.Controls.Add(this.OwnerId);
            this.Controls.Add(this.MinimumOrderValue);
            this.Controls.Add(this.Restlocationtxt);
            this.Controls.Add(this.RestNmaetxt);
            this.Controls.Add(this.RestIdtxt);
            this.Controls.Add(this.RestLocation);
            this.Controls.Add(this.RestName);
            this.Controls.Add(this.RestId);
            this.Controls.Add(this.RestSubmit);
            this.Name = "AddRestaurant";
            this.Text = "AddRestaurant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RestSubmit;
        private System.Windows.Forms.Label RestId;
        private System.Windows.Forms.Label RestName;
        private System.Windows.Forms.Label RestLocation;
        private System.Windows.Forms.TextBox RestIdtxt;
        private System.Windows.Forms.TextBox RestNmaetxt;
        private System.Windows.Forms.TextBox Restlocationtxt;
        private System.Windows.Forms.Label MinimumOrderValue;
        private System.Windows.Forms.Label OwnerId;
        private System.Windows.Forms.TextBox RestMinimumValuetxt;
        private System.Windows.Forms.TextBox RestOwnerIdtxt;
    }
}