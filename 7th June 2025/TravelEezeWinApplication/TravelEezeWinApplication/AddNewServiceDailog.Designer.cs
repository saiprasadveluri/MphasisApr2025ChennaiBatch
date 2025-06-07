namespace TravelEezeWinApplication
{
    partial class AddNewServiceDailog
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
            numericDistance = new NumericUpDown();
            comboDestinationLoc = new ComboBox();
            comboSourceLoc = new ComboBox();
            comboServiceType = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericDistance).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddService);
            groupBox1.Controls.Add(numericDistance);
            groupBox1.Controls.Add(comboDestinationLoc);
            groupBox1.Controls.Add(comboSourceLoc);
            groupBox1.Controls.Add(comboServiceType);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(16, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(772, 420);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Service";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(289, 249);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(164, 34);
            btnAddService.TabIndex = 8;
            btnAddService.Text = "Add Service";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // numericDistance
            // 
            numericDistance.Location = new Point(157, 186);
            numericDistance.Name = "numericDistance";
            numericDistance.Size = new Size(561, 29);
            numericDistance.TabIndex = 7;
            // 
            // comboDestinationLoc
            // 
            comboDestinationLoc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDestinationLoc.FormattingEnabled = true;
            comboDestinationLoc.Location = new Point(157, 140);
            comboDestinationLoc.Name = "comboDestinationLoc";
            comboDestinationLoc.Size = new Size(561, 29);
            comboDestinationLoc.TabIndex = 6;
            // 
            // comboSourceLoc
            // 
            comboSourceLoc.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSourceLoc.FormattingEnabled = true;
            comboSourceLoc.Location = new Point(157, 91);
            comboSourceLoc.Name = "comboSourceLoc";
            comboSourceLoc.Size = new Size(561, 29);
            comboSourceLoc.TabIndex = 5;
            // 
            // comboServiceType
            // 
            comboServiceType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboServiceType.FormattingEnabled = true;
            comboServiceType.Location = new Point(157, 48);
            comboServiceType.Name = "comboServiceType";
            comboServiceType.Size = new Size(561, 29);
            comboServiceType.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 186);
            label4.Name = "label4";
            label4.Size = new Size(76, 21);
            label4.TabIndex = 3;
            label4.Text = "Distance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 140);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 2;
            label3.Text = "Destination";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 91);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 1;
            label2.Text = "Source";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 48);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 0;
            label1.Text = "Service Type";
            // 
            // AddNewServiceDailog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddNewServiceDailog";
            Text = "AddNewServiceDailog";
            Load += AddNewServiceDailog_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericDistance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAddService;
        private NumericUpDown numericDistance;
        private ComboBox comboDestinationLoc;
        private ComboBox comboSourceLoc;
        private ComboBox comboServiceType;
    }
}