namespace TravelEzzCoreConsole2
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
            txtLocationName = new TextBox();
            LocationEditButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 63);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "LocationName";
            // 
            // txtLocationName
            // 
            txtLocationName.Location = new Point(322, 60);
            txtLocationName.Name = "txtLocationName";
            txtLocationName.Size = new Size(161, 23);
            txtLocationName.TabIndex = 1;
            // 
            // LocationEditButton
            // 
            LocationEditButton.Location = new Point(299, 167);
            LocationEditButton.Name = "LocationEditButton";
            LocationEditButton.Size = new Size(75, 23);
            LocationEditButton.TabIndex = 2;
            LocationEditButton.Text = "Save";
            LocationEditButton.UseVisualStyleBackColor = true;
            LocationEditButton.Click += LocationEditButton_Click;
            // 
            // EditLocation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LocationEditButton);
            Controls.Add(txtLocationName);
            Controls.Add(label1);
            Name = "EditLocation";
            Text = "EditLocation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLocationName;
        private Button LocationEditButton;
    }
}