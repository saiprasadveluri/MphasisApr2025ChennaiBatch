namespace TravelFormsEF
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
            groupBox1 = new GroupBox();
            btnLocation = new Button();
            label1 = new Label();
            txtLocName = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLocName);
            groupBox1.Controls.Add(btnLocation);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(53, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(652, 216);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Edit Location";
            // 
            // btnLocation
            // 
            btnLocation.Location = new Point(243, 151);
            btnLocation.Name = "btnLocation";
            btnLocation.Size = new Size(79, 34);
            btnLocation.TabIndex = 3;
            btnLocation.Text = "Edit";
            btnLocation.UseVisualStyleBackColor = true;
            btnLocation.Click += btnLocation_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 47);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 2;
            label1.Text = "Location Name";
            // 
            // txtLocName
            // 
            txtLocName.Location = new Point(319, 47);
            txtLocName.Name = "txtLocName";
            txtLocName.Size = new Size(209, 29);
            txtLocName.TabIndex = 4;
            // 
            // EditLocation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "EditLocation";
            Text = "EditLocation";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLocation;
        private Label label1;
        private TextBox txtLocName;
    }
}