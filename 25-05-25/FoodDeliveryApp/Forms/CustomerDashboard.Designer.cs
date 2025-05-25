namespace FoodDeliveryApp.Forms
{
    partial class CustomerDashboard
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
            this.btnSearchRestaurants = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearchRestaurants
            // 
            this.btnSearchRestaurants.Location = new System.Drawing.Point(268, 112);
            this.btnSearchRestaurants.Name = "btnSearchRestaurants";
            this.btnSearchRestaurants.Size = new System.Drawing.Size(75, 23);
            this.btnSearchRestaurants.TabIndex = 0;
            this.btnSearchRestaurants.Text = "button1";
            this.btnSearchRestaurants.UseVisualStyleBackColor = true;
            this.btnSearchRestaurants.Click += new System.EventHandler(this.btnSearchRestaurants_Click);
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchRestaurants);
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchRestaurants;
    }
}