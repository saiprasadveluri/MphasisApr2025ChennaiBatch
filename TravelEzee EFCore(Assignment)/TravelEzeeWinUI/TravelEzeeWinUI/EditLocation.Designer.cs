namespace TravelEzeeWinUI
{
    partial class EditLocation
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
            label1 = new Label();
            txtLocation = new TextBox();
            btnEditLocation = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 90);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Location Name";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(278, 90);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(181, 23);
            txtLocation.TabIndex = 1;
            // 
            // btnEditLocation
            // 
            btnEditLocation.Location = new Point(247, 204);
            btnEditLocation.Name = "btnEditLocation";
            btnEditLocation.Size = new Size(122, 23);
            btnEditLocation.TabIndex = 2;
            btnEditLocation.Text = "EditLocation";
            btnEditLocation.UseVisualStyleBackColor = true;
            btnEditLocation.Click += btnEdit_Click;
            // 
            // EditLocation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditLocation);
            Controls.Add(txtLocation);
            Controls.Add(label1);
            Name = "EditLocation";
            Text = "EditLocation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLocation;
        private Button btnEditLocation;
    }
}