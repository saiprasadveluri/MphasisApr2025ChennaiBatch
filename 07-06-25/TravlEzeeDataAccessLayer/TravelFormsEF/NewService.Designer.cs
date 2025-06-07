namespace TravelFormsEF
{
    partial class NewService
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
            Distance = new NumericUpDown();
            cmbDest = new ComboBox();
            cmbSource = new ComboBox();
            cmbServType = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Distance).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddService);
            groupBox1.Controls.Add(Distance);
            groupBox1.Controls.Add(cmbDest);
            groupBox1.Controls.Add(cmbSource);
            groupBox1.Controls.Add(cmbServType);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(44, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 320);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Service";
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(94, 266);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(187, 28);
            btnAddService.TabIndex = 8;
            btnAddService.Text = "Add Service";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // Distance
            // 
            Distance.Location = new Point(186, 199);
            Distance.Name = "Distance";
            Distance.Size = new Size(192, 29);
            Distance.TabIndex = 7;
            // 
            // cmbDest
            // 
            cmbDest.FormattingEnabled = true;
            cmbDest.Location = new Point(185, 142);
            cmbDest.Name = "cmbDest";
            cmbDest.Size = new Size(193, 29);
            cmbDest.TabIndex = 6;
            // 
            // cmbSource
            // 
            cmbSource.FormattingEnabled = true;
            cmbSource.Location = new Point(185, 90);
            cmbSource.Name = "cmbSource";
            cmbSource.Size = new Size(193, 29);
            cmbSource.TabIndex = 5;
            // 
            // cmbServType
            // 
            cmbServType.FormattingEnabled = true;
            cmbServType.Location = new Point(185, 38);
            cmbServType.Name = "cmbServType";
            cmbServType.Size = new Size(193, 29);
            cmbServType.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 197);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 3;
            label4.Text = "Distance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 142);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 2;
            label3.Text = "Destination";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 98);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 1;
            label2.Text = "Source";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 41);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 0;
            label1.Text = "ServiceType";
            // 
            // NewService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "NewService";
            Text = "NewService";
            Load += NewService_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Distance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAddService;
        private NumericUpDown Distance;
        private ComboBox cmbDest;
        private ComboBox cmbSource;
        private ComboBox cmbServType;
        private Label label4;
    }
}