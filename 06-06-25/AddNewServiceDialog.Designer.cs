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
            numDistance = new NumericUpDown();
            btnAddService = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbSrvType = new ComboBox();
            cmbSourceLocations = new ComboBox();
            cmbDestinationLocations = new ComboBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDistance).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbDestinationLocations);
            groupBox1.Controls.Add(cmbSourceLocations);
            groupBox1.Controls.Add(cmbSrvType);
            groupBox1.Controls.Add(numDistance);
            groupBox1.Controls.Add(btnAddService);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(73, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(623, 292);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // numDistance
            // 
            numDistance.Location = new Point(241, 214);
            numDistance.Name = "numDistance";
            numDistance.Size = new Size(120, 23);
            numDistance.TabIndex = 8;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(252, 251);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(75, 23);
            btnAddService.TabIndex = 4;
            btnAddService.Text = "button1";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(93, 209);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 157);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 96);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(81, 46);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // cmbSrvType
            // 
            cmbSrvType.FormattingEnabled = true;
            cmbSrvType.Location = new Point(260, 56);
            cmbSrvType.Name = "cmbSrvType";
            cmbSrvType.Size = new Size(121, 23);
            cmbSrvType.TabIndex = 9;
            // 
            // cmbSourceLocations
            // 
            cmbSourceLocations.FormattingEnabled = true;
            cmbSourceLocations.Location = new Point(260, 109);
            cmbSourceLocations.Name = "cmbSourceLocations";
            cmbSourceLocations.Size = new Size(121, 23);
            cmbSourceLocations.TabIndex = 10;
            // 
            // cmbDestinationLocations
            // 
            cmbDestinationLocations.FormattingEnabled = true;
            cmbDestinationLocations.Location = new Point(267, 171);
            cmbDestinationLocations.Name = "cmbDestinationLocations";
            cmbDestinationLocations.Size = new Size(121, 23);
            cmbDestinationLocations.TabIndex = 11;
            // 
            // AddNewServiceDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "AddNewServiceDialog";
            Text = "AddNewServiceDialog";
            Load += AddNewServiceDialog_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDistance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAddService;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numDistance;
        private ComboBox cmbDestinationLocations;
        private ComboBox cmbSourceLocations;
        private ComboBox cmbSrvType;
    }
}