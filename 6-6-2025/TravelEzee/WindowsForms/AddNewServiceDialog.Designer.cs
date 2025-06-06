namespace TravelEzeeWinFormUI
{
    partial class AddNewServiceDialog
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
            txtDistance = new NumericUpDown();
            cmbDestinationLocations = new ComboBox();
            cmbSourceLocation = new ComboBox();
            cmbServicetype = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtDistance).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddService);
            groupBox1.Controls.Add(txtDistance);
            groupBox1.Controls.Add(cmbDestinationLocations);
            groupBox1.Controls.Add(cmbSourceLocation);
            groupBox1.Controls.Add(cmbServicetype);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(751, 371);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Service";
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(238, 235);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(228, 23);
            btnAddService.TabIndex = 8;
            btnAddService.Text = "Add";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(140, 157);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(357, 23);
            txtDistance.TabIndex = 7;
            // 
            // cmbDestinationLocations
            // 
            cmbDestinationLocations.FormattingEnabled = true;
            cmbDestinationLocations.Location = new Point(139, 127);
            cmbDestinationLocations.Name = "cmbDestinationLocations";
            cmbDestinationLocations.Size = new Size(358, 23);
            cmbDestinationLocations.TabIndex = 6;
            // 
            // cmbSourceLocation
            // 
            cmbSourceLocation.FormattingEnabled = true;
            cmbSourceLocation.Location = new Point(138, 95);
            cmbSourceLocation.Name = "cmbSourceLocation";
            cmbSourceLocation.Size = new Size(355, 23);
            cmbSourceLocation.TabIndex = 5;
            // 
            // cmbServicetype
            // 
            cmbServicetype.FormattingEnabled = true;
            cmbServicetype.Location = new Point(139, 55);
            cmbServicetype.Name = "cmbServicetype";
            cmbServicetype.Size = new Size(354, 23);
            cmbServicetype.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 165);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 3;
            label4.Text = "Distance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 135);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Destination";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 103);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Source";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 63);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Service Type";
            // 
            // AddNewServiceDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddNewServiceDialog";
            Text = "AddNewServiceDialog";
            Load += AddNewServiceDialog_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtDistance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private NumericUpDown txtDistance;
        private ComboBox cmbDestinationLocations;
        private ComboBox cmbSourceLocation;
        private ComboBox cmbServicetype;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAddService;
    }
}