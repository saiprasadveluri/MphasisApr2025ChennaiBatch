namespace FoodDeliveryAggregateApp
{
    partial class AddLocation
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
            this.Location = new System.Windows.Forms.Label();
            this.LocId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.LocName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Location = new System.Drawing.Point(140, 56);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(60, 13);
            this.Location.TabIndex = 0;
            this.Location.Text = "Location Id";
            // 
            // LocId
            // 
            this.LocId.Location = new System.Drawing.Point(279, 56);
            this.LocId.Name = "LocId";
            this.LocId.Size = new System.Drawing.Size(163, 20);
            this.LocId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Location";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(292, 195);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // LocName
            // 
            this.LocName.Location = new System.Drawing.Point(279, 111);
            this.LocName.Name = "LocName";
            this.LocName.Size = new System.Drawing.Size(163, 20);
            this.LocName.TabIndex = 5;
            // 
            // AddLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LocName);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LocId);
            this.Controls.Add(this.Location);
            this.Name = "AddLocation";
           // this.Load += new System.EventHandler(this.AddLocation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.TextBox LocId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox LocName;
    }
}