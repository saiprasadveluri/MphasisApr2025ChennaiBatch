namespace FoodApp2
{
    partial class NewRestaurant
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
            this.RestaurantNameLabel = new System.Windows.Forms.Label();
            this.RestLocationLabel = new System.Windows.Forms.Label();
            this.textRestaurantName = new System.Windows.Forms.TextBox();
            this.SaveRestaurantButton = new System.Windows.Forms.Button();
            this.RestLocationBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RestaurantNameLabel
            // 
            this.RestaurantNameLabel.AutoSize = true;
            this.RestaurantNameLabel.Location = new System.Drawing.Point(34, 43);
            this.RestaurantNameLabel.Name = "RestaurantNameLabel";
            this.RestaurantNameLabel.Size = new System.Drawing.Size(87, 13);
            this.RestaurantNameLabel.TabIndex = 0;
            this.RestaurantNameLabel.Text = "RestaurantName";
            // 
            // RestLocationLabel
            // 
            this.RestLocationLabel.AutoSize = true;
            this.RestLocationLabel.Location = new System.Drawing.Point(37, 93);
            this.RestLocationLabel.Name = "RestLocationLabel";
            this.RestLocationLabel.Size = new System.Drawing.Size(70, 13);
            this.RestLocationLabel.TabIndex = 1;
            this.RestLocationLabel.Text = "RestLocation";
            // 
            // textRestaurantName
            // 
            this.textRestaurantName.Location = new System.Drawing.Point(160, 43);
            this.textRestaurantName.Name = "textRestaurantName";
            this.textRestaurantName.Size = new System.Drawing.Size(121, 20);
            this.textRestaurantName.TabIndex = 4;
            // 
            // SaveRestaurantButton
            // 
            this.SaveRestaurantButton.Location = new System.Drawing.Point(37, 163);
            this.SaveRestaurantButton.Name = "SaveRestaurantButton";
            this.SaveRestaurantButton.Size = new System.Drawing.Size(126, 23);
            this.SaveRestaurantButton.TabIndex = 6;
            this.SaveRestaurantButton.Text = "SaveRestaurant";
            this.SaveRestaurantButton.UseVisualStyleBackColor = true;
            this.SaveRestaurantButton.Click += new System.EventHandler(this.SaveRestaurantButton_Click);
            // 
            // RestLocationBox
            // 
            this.RestLocationBox.FormattingEnabled = true;
            this.RestLocationBox.Location = new System.Drawing.Point(160, 93);
            this.RestLocationBox.Name = "RestLocationBox";
            this.RestLocationBox.Size = new System.Drawing.Size(121, 21);
            this.RestLocationBox.TabIndex = 7;
            // 
            // NewRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RestLocationBox);
            this.Controls.Add(this.SaveRestaurantButton);
            this.Controls.Add(this.textRestaurantName);
            this.Controls.Add(this.RestLocationLabel);
            this.Controls.Add(this.RestaurantNameLabel);
            this.Name = "NewRestaurant";
            this.Text = "NewRestaurant";
            this.Load += new System.EventHandler(this.NewRestaurant_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RestaurantNameLabel;
        private System.Windows.Forms.Label RestLocationLabel;
        private System.Windows.Forms.TextBox textRestaurantName;
        private System.Windows.Forms.Button SaveRestaurantButton;
        private System.Windows.Forms.ComboBox RestLocationBox;
    }
}