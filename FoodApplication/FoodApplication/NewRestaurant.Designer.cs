namespace FoodApplication
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
            this.SuspendLayout();
            // 
            // NewRestaurant
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "NewRestaurant";
            this.Load += new System.EventHandler(this.NewRestaurant_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label RestaurantNameLabel;
        private System.Windows.Forms.Label RestLocationLabel;
        private System.Windows.Forms.TextBox textRestaurantName;
        private System.Windows.Forms.Button SaveRestaurantButton;
        private System.Windows.Forms.ComboBox RestLocationBox;
    }
}