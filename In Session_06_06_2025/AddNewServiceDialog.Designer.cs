namespace TravelEzeeWinUI
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
            numDistance = new NumericUpDown();
            cmbDestinationLocations = new ComboBox();
            cmbSourceLocations = new ComboBox();
            cmbSrvTypes = new ComboBox();
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
            groupBox1.Controls.Add(cmbDestinationLocations);
            groupBox1.Controls.Add(cmbSourceLocations);
            groupBox1.Controls.Add(cmbSrvTypes);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(13, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(613, 347);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Service";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(252, 264);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(237, 38);
            btnAddService.TabIndex = 8;
            btnAddService.Text = "Add Service";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // numDistance
            // 
            numDistance.Location = new Point(178, 216);
            numDistance.Name = "numDistance";
            numDistance.Size = new Size(388, 29);
            numDistance.TabIndex = 7;
            // 
            // cmbDestinationLocations
            // 
            cmbDestinationLocations.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestinationLocations.FormattingEnabled = true;
            cmbDestinationLocations.Location = new Point(176, 156);
            cmbDestinationLocations.Name = "cmbDestinationLocations";
            cmbDestinationLocations.Size = new Size(390, 29);
            cmbDestinationLocations.TabIndex = 6;
            // 
            // cmbSourceLocations
            // 
            cmbSourceLocations.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSourceLocations.FormattingEnabled = true;
            cmbSourceLocations.Location = new Point(176, 103);
            cmbSourceLocations.Name = "cmbSourceLocations";
            cmbSourceLocations.Size = new Size(390, 29);
            cmbSourceLocations.TabIndex = 5;
            // 
            // cmbSrvTypes
            // 
            cmbSrvTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSrvTypes.FormattingEnabled = true;
            cmbSrvTypes.Location = new Point(176, 43);
            cmbSrvTypes.Name = "cmbSrvTypes";
            cmbSrvTypes.Size = new Size(390, 29);
            cmbSrvTypes.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 218);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 3;
            label4.Text = "Distance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 156);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 2;
            label3.Text = "Destination";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 99);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 1;
            label2.Text = "Source";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 41);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 0;
            label1.Text = "Service Type";
            // 
            // AddNewServiceDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 373);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddNewServiceDialog";
            Text = "Add New Service";
            Load += AddNewServiceDialog_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDistance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbSrvTypes;
        private NumericUpDown numDistance;
        private ComboBox cmbDestinationLocations;
        private ComboBox cmbSourceLocations;
        private Button btnAddService;
    }
}