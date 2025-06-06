namespace TravelEzeeWinUI
{
    partial class AddNewService
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
            btnAddService = new Button();
            numDistance = new NumericUpDown();
            comDestinationLocation = new ComboBox();
            comSourceLocation = new ComboBox();
            comSrvType = new ComboBox();
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
            groupBox1.Controls.Add(btnAddService);
            groupBox1.Controls.Add(numDistance);
            groupBox1.Controls.Add(comDestinationLocation);
            groupBox1.Controls.Add(comSourceLocation);
            groupBox1.Controls.Add(comSrvType);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(56, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(492, 256);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Service";
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(211, 208);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(123, 27);
            btnAddService.TabIndex = 8;
            btnAddService.Text = "Add Service";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // numDistance
            // 
            numDistance.Location = new Point(161, 168);
            numDistance.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numDistance.Name = "numDistance";
            numDistance.Size = new Size(209, 25);
            numDistance.TabIndex = 7;
            // 
            // comDestinationLocation
            // 
            comDestinationLocation.FormattingEnabled = true;
            comDestinationLocation.Location = new Point(161, 128);
            comDestinationLocation.Name = "comDestinationLocation";
            comDestinationLocation.Size = new Size(214, 25);
            comDestinationLocation.TabIndex = 6;
            // 
            // comSourceLocation
            // 
            comSourceLocation.FormattingEnabled = true;
            comSourceLocation.Location = new Point(161, 81);
            comSourceLocation.Name = "comSourceLocation";
            comSourceLocation.Size = new Size(214, 25);
            comSourceLocation.TabIndex = 5;
            // 
            // comSrvType
            // 
            comSrvType.FormattingEnabled = true;
            comSrvType.Location = new Point(161, 35);
            comSrvType.Name = "comSrvType";
            comSrvType.Size = new Size(214, 25);
            comSrvType.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 159);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 3;
            label4.Text = "Distance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 117);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 2;
            label3.Text = "Destination";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 79);
            label2.Name = "label2";
            label2.Size = new Size(55, 19);
            label2.TabIndex = 1;
            label2.Text = "Source";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 37);
            label1.Name = "label1";
            label1.Size = new Size(95, 19);
            label1.TabIndex = 0;
            label1.Text = "Service Type";
            // 
            // AddNewService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddNewService";
            Text = "AddNewService";
            Load += AddNewService_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDistance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnAddService;
        private NumericUpDown numDistance;
        private ComboBox comDestinationLocation;
        private ComboBox comSourceLocation;
        private ComboBox comSrvType;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}