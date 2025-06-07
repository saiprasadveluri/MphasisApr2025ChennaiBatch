namespace EzeeTravelWinUI
{
    partial class AddLocationDialog
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
            label1 = new Label();
            label2 = new Label();
            txtLocationName = new TextBox();
            txtDescription = new TextBox();
            btnAddLocation = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddLocation);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtLocationName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(45, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(717, 278);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "AddLocation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 46);
            label1.Name = "label1";
            label1.Size = new Size(122, 21);
            label1.TabIndex = 0;
            label1.Text = "LocationName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 89);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // txtLocationName
            // 
            txtLocationName.Location = new Point(207, 43);
            txtLocationName.Name = "txtLocationName";
            txtLocationName.Size = new Size(272, 29);
            txtLocationName.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(205, 89);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(274, 75);
            txtDescription.TabIndex = 3;
            // 
            // btnAddLocation
            // 
            btnAddLocation.Location = new Point(245, 186);
            btnAddLocation.Name = "btnAddLocation";
            btnAddLocation.Size = new Size(143, 27);
            btnAddLocation.TabIndex = 4;
            btnAddLocation.Text = "AddLocation";
            btnAddLocation.UseVisualStyleBackColor = true;
            btnAddLocation.Click += btnAddLocation_Click;
            // 
            // AddLocationDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddLocationDialog";
            Text = "AddLocationDialog";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btnAddLocation;
        private TextBox txtDescription;
        private TextBox txtLocationName;
    }
}