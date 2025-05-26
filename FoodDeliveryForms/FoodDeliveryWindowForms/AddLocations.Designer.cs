namespace FoodDeliveryWindowForms
{
    partial class AddLocations
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
            this.LocationId = new System.Windows.Forms.Label();
            this.LocId = new System.Windows.Forms.TextBox();
            this.LocationName = new System.Windows.Forms.Label();
            this.btnAddLocations = new System.Windows.Forms.Button();
            this.LocName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LocationId
            // 
            this.LocationId.AutoSize = true;
            this.LocationId.Location = new System.Drawing.Point(103, 63);
            this.LocationId.Name = "LocationId";
            this.LocationId.Size = new System.Drawing.Size(60, 13);
            this.LocationId.TabIndex = 0;
            this.LocationId.Text = "Location Id";
            // 
            // LocId
            // 
            this.LocId.Location = new System.Drawing.Point(202, 55);
            this.LocId.Name = "LocId";
            this.LocId.Size = new System.Drawing.Size(171, 20);
            this.LocId.TabIndex = 1;
        //    this.LocId.TextChanged += new System.EventHandler(this.LocId_TextChanged);
            // 
            // LocationName
            // 
            this.LocationName.AutoSize = true;
            this.LocationName.Location = new System.Drawing.Point(103, 101);
            this.LocationName.Name = "LocationName";
            this.LocationName.Size = new System.Drawing.Size(79, 13);
            this.LocationName.TabIndex = 2;
            this.LocationName.Text = "Location Name";
            // 
            // btnAddLocations
            // 
            this.btnAddLocations.Location = new System.Drawing.Point(238, 144);
            this.btnAddLocations.Name = "btnAddLocations";
            this.btnAddLocations.Size = new System.Drawing.Size(93, 23);
            this.btnAddLocations.TabIndex = 4;
            this.btnAddLocations.Text = "AddLocation";
            this.btnAddLocations.UseVisualStyleBackColor = true;
            // 
            // LocName
            // 
            this.LocName.Location = new System.Drawing.Point(202, 93);
            this.LocName.Name = "LocName";
            this.LocName.Size = new System.Drawing.Size(171, 20);
            this.LocName.TabIndex = 5;
            // 
            // AddLocations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LocName);
            this.Controls.Add(this.btnAddLocations);
            this.Controls.Add(this.LocationName);
            this.Controls.Add(this.LocId);
            this.Controls.Add(this.LocationId);
            this.Name = "AddLocations";
            this.Text = "AddLocations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LocationId;
        private System.Windows.Forms.TextBox LocId;
        private System.Windows.Forms.Label LocationName;
        private System.Windows.Forms.Button btnAddLocations;
        private System.Windows.Forms.TextBox LocName;
    }
}