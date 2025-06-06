namespace TravelEzzCoreConsole2
{
    partial class Add_New_Service
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
            btnaddservice = new Button();
            numDistance = new NumericUpDown();
            cmbDestinationLoaction = new ComboBox();
            cmbSourceLocation = new ComboBox();
            cmbSrvType = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDistance).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnaddservice);
            groupBox1.Controls.Add(numDistance);
            groupBox1.Controls.Add(cmbDestinationLoaction);
            groupBox1.Controls.Add(cmbSourceLocation);
            groupBox1.Controls.Add(cmbSrvType);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(44, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(646, 309);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Service";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnaddservice
            // 
            btnaddservice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnaddservice.Location = new Point(292, 244);
            btnaddservice.Name = "btnaddservice";
            btnaddservice.Size = new Size(129, 23);
            btnaddservice.TabIndex = 8;
            btnaddservice.Text = "Add Service";
            btnaddservice.UseVisualStyleBackColor = true;
            btnaddservice.Click += btnaddservice_Click;
            // 
            // numDistance
            // 
            numDistance.Location = new Point(200, 181);
            numDistance.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDistance.Name = "numDistance";
            numDistance.Size = new Size(181, 25);
            numDistance.TabIndex = 7;
            // 
            // cmbDestinationLoaction
            // 
            cmbDestinationLoaction.FormattingEnabled = true;
            cmbDestinationLoaction.Location = new Point(198, 141);
            cmbDestinationLoaction.Name = "cmbDestinationLoaction";
            cmbDestinationLoaction.Size = new Size(183, 25);
            cmbDestinationLoaction.TabIndex = 6;
            // 
            // cmbSourceLocation
            // 
            cmbSourceLocation.FormattingEnabled = true;
            cmbSourceLocation.Location = new Point(200, 89);
            cmbSourceLocation.Name = "cmbSourceLocation";
            cmbSourceLocation.Size = new Size(183, 25);
            cmbSourceLocation.TabIndex = 5;
            // 
            // cmbSrvType
            // 
            cmbSrvType.FormattingEnabled = true;
            cmbSrvType.Location = new Point(198, 46);
            cmbSrvType.Name = "cmbSrvType";
            cmbSrvType.Size = new Size(183, 25);
            cmbSrvType.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(40, 186);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 3;
            label4.Text = "Distance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(40, 145);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 2;
            label3.Text = "Destination";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(49, 94);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Source";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(27, 51);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Service Type";
            // 
            // Add_New_Service
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Add_New_Service";
            Text = "Add_New_Service";
            Load += Add_New_Service_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDistance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbSrvType;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbDestinationLoaction;
        private ComboBox cmbSourceLocation;
        private NumericUpDown numDistance;
        private Button btnaddservice;
    }
}