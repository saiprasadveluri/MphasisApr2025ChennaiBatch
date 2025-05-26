namespace FoodApp2
{
    partial class NewLocation
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
            this.LocationIdLabel = new System.Windows.Forms.Label();
            this.LocationNameLabel = new System.Windows.Forms.Label();
            this.textLocationId = new System.Windows.Forms.TextBox();
            this.textLocationName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LocationIdLabel
            // 
            this.LocationIdLabel.AutoSize = true;
            this.LocationIdLabel.Location = new System.Drawing.Point(44, 75);
            this.LocationIdLabel.Name = "LocationIdLabel";
            this.LocationIdLabel.Size = new System.Drawing.Size(57, 13);
            this.LocationIdLabel.TabIndex = 0;
            this.LocationIdLabel.Text = "LocationId";
            // 
            // LocationNameLabel
            // 
            this.LocationNameLabel.AutoSize = true;
            this.LocationNameLabel.Location = new System.Drawing.Point(44, 121);
            this.LocationNameLabel.Name = "LocationNameLabel";
            this.LocationNameLabel.Size = new System.Drawing.Size(76, 13);
            this.LocationNameLabel.TabIndex = 1;
            this.LocationNameLabel.Text = "LocationName";
            // 
            // textLocationId
            // 
            this.textLocationId.Location = new System.Drawing.Point(155, 75);
            this.textLocationId.Name = "textLocationId";
            this.textLocationId.Size = new System.Drawing.Size(100, 20);
            this.textLocationId.TabIndex = 2;
            // 
            // textLocationName
            // 
            this.textLocationName.Location = new System.Drawing.Point(155, 121);
            this.textLocationName.Name = "textLocationName";
            this.textLocationName.Size = new System.Drawing.Size(100, 20);
            this.textLocationName.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "SaveLocation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textLocationName);
            this.Controls.Add(this.textLocationId);
            this.Controls.Add(this.LocationNameLabel);
            this.Controls.Add(this.LocationIdLabel);
            this.Name = "NewLocation";
            this.Text = "NewLocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LocationIdLabel;
        private System.Windows.Forms.Label LocationNameLabel;
        private System.Windows.Forms.TextBox textLocationId;
        private System.Windows.Forms.TextBox textLocationName;
        private System.Windows.Forms.Button button1;
    }
}