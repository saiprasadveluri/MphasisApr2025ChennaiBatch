namespace TravelEezeWinApplication
{
    partial class AddLocationDailog
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
            btnAddLocation = new Button();
            txtDescription = new TextBox();
            txtLocationName = new TextBox();
            label2 = new Label();
            label1 = new Label();
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
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(755, 329);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Location";
            // 
            // btnAddLocation
            // 
            btnAddLocation.Location = new Point(282, 224);
            btnAddLocation.Name = "btnAddLocation";
            btnAddLocation.Size = new Size(220, 37);
            btnAddLocation.TabIndex = 4;
            btnAddLocation.Text = "Add Location";
            btnAddLocation.UseVisualStyleBackColor = true;
            btnAddLocation.Click += btnAddLocation_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(184, 90);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(431, 78);
            txtDescription.TabIndex = 3;
            // 
            // txtLocationName
            // 
            txtLocationName.Location = new Point(184, 44);
            txtLocationName.Name = "txtLocationName";
            txtLocationName.Size = new Size(431, 29);
            txtLocationName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 90);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 47);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 0;
            label1.Text = "Location Name";
            label1.Click += label1_Click;
            // 
            // AddLocationDailog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddLocationDailog";
            Text = "AddLocationDailog";
            Load += this.AddLocationDailog_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtLocationName;
        private Button btnAddLocation;
        private TextBox txtDescription;
    }
}