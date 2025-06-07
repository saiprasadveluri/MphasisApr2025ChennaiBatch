namespace TravelEzeeWinUI
{
    partial class AddNewServiceType
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
            locgroupBox = new GroupBox();
            numericUpDown = new NumericUpDown();
            btnAddSrvType = new Button();
            txtSrvType = new TextBox();
            srvTypeId = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            locgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // locgroupBox
            // 
            locgroupBox.Controls.Add(numericUpDown);
            locgroupBox.Controls.Add(btnAddSrvType);
            locgroupBox.Controls.Add(txtSrvType);
            locgroupBox.Controls.Add(srvTypeId);
            locgroupBox.Controls.Add(label3);
            locgroupBox.Controls.Add(label2);
            locgroupBox.Controls.Add(label1);
            locgroupBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            locgroupBox.Location = new Point(12, 12);
            locgroupBox.Name = "locgroupBox";
            locgroupBox.Size = new Size(935, 472);
            locgroupBox.TabIndex = 1;
            locgroupBox.TabStop = false;
            locgroupBox.Text = "Add New Service Type";
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(174, 158);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(566, 25);
            numericUpDown.TabIndex = 3;
            // 
            // btnAddSrvType
            // 
            btnAddSrvType.Location = new Point(361, 217);
            btnAddSrvType.Name = "btnAddSrvType";
            btnAddSrvType.Size = new Size(188, 34);
            btnAddSrvType.TabIndex = 2;
            btnAddSrvType.Text = "Add New Service Type";
            btnAddSrvType.UseVisualStyleBackColor = true;
            btnAddSrvType.Click += btnAddSrvType_Click_1;
            // 
            // txtSrvType
            // 
            txtSrvType.Location = new Point(174, 112);
            txtSrvType.Name = "txtSrvType";
            txtSrvType.Size = new Size(566, 25);
            txtSrvType.TabIndex = 1;
            // 
            // srvTypeId
            // 
            srvTypeId.Location = new Point(174, 68);
            srvTypeId.Name = "srvTypeId";
            srvTypeId.Size = new Size(566, 25);
            srvTypeId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 115);
            label3.Name = "label3";
            label3.Size = new Size(89, 17);
            label3.TabIndex = 0;
            label3.Text = "Type Name : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 160);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 0;
            label2.Text = "Price/Km :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 71);
            label1.Name = "label1";
            label1.Size = new Size(63, 17);
            label1.TabIndex = 0;
            label1.Text = "Type ID :";
            label1.Click += label1_Click;
            // 
            // AddNewServiceType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 693);
            Controls.Add(locgroupBox);
            Name = "AddNewServiceType";
            Text = "AddNewServiceType";
            locgroupBox.ResumeLayout(false);
            locgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
        }
        #endregion
        private GroupBox locgroupBox;
        private NumericUpDown numericUpDown;
        private Button btnAddSrvType;
        private TextBox srvTypeId;
        private Label label2;
        private Label label1;
        private TextBox txtSrvType;
        private Label label3;
    }
}