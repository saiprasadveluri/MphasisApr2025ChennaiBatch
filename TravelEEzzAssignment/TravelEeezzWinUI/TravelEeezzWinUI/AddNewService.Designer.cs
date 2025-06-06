namespace TravelEeezzWinUI
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
            btnAddServicee = new Button();
            numDistance = new NumericUpDown();
            comboDestinationLocation = new ComboBox();
            comboSourceLocation = new ComboBox();
            comboSrvType = new ComboBox();
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
            groupBox1.Controls.Add(btnAddServicee);
            groupBox1.Controls.Add(numDistance);
            groupBox1.Controls.Add(comboDestinationLocation);
            groupBox1.Controls.Add(comboSourceLocation);
            groupBox1.Controls.Add(comboSrvType);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(91, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(617, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Service";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnAddServicee
            // 
            btnAddServicee.Location = new Point(309, 221);
            btnAddServicee.Name = "btnAddServicee";
            btnAddServicee.Size = new Size(158, 23);
            btnAddServicee.TabIndex = 8;
            btnAddServicee.Text = "Add  New Service";
            btnAddServicee.UseVisualStyleBackColor = true;
            btnAddServicee.Click += btnAddServicee_Click;
            // 
            // numDistance
            // 
            numDistance.Location = new Point(234, 167);
            numDistance.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDistance.Name = "numDistance";
            numDistance.Size = new Size(283, 25);
            numDistance.TabIndex = 7;
            // 
            // comboDestinationLocation
            // 
            comboDestinationLocation.FormattingEnabled = true;
            comboDestinationLocation.Location = new Point(233, 125);
            comboDestinationLocation.Name = "comboDestinationLocation";
            comboDestinationLocation.Size = new Size(284, 25);
            comboDestinationLocation.TabIndex = 6;
            // 
            // comboSourceLocation
            // 
            comboSourceLocation.FormattingEnabled = true;
            comboSourceLocation.Location = new Point(231, 89);
            comboSourceLocation.Name = "comboSourceLocation";
            comboSourceLocation.Size = new Size(286, 25);
            comboSourceLocation.TabIndex = 5;
            // 
            // comboSrvType
            // 
            comboSrvType.FormattingEnabled = true;
            comboSrvType.Location = new Point(233, 48);
            comboSrvType.Name = "comboSrvType";
            comboSrvType.Size = new Size(284, 25);
            comboSrvType.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 167);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 3;
            label4.Text = "Distance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 125);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 2;
            label3.Text = "Destination";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 89);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 1;
            label2.Text = "Source";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 51);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
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
        private ComboBox comboDestinationLocation;
        private ComboBox comboSourceLocation;
        private ComboBox comboSrvType;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAddServicee;
        private NumericUpDown numDistance;
    }
}