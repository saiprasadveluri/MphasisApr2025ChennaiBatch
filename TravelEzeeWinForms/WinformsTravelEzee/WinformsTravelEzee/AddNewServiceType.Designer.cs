namespace WinformsTravelEzee
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
            groupBox1 = new GroupBox();
            btnAddNewType = new Button();
            numericPrice = new NumericUpDown();
            txtTypeName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrice).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddNewType);
            groupBox1.Controls.Add(numericPrice);
            groupBox1.Controls.Add(txtTypeName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(83, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(642, 289);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Service Type";
            // 
            // btnAddNewType
            // 
            btnAddNewType.Location = new Point(253, 157);
            btnAddNewType.Name = "btnAddNewType";
            btnAddNewType.Size = new Size(184, 34);
            btnAddNewType.TabIndex = 4;
            btnAddNewType.Text = "Add New Type";
            btnAddNewType.UseVisualStyleBackColor = true;
            btnAddNewType.Click += btnAddNewType_Click;
            // 
            // numericPrice
            // 
            numericPrice.Location = new Point(238, 85);
            numericPrice.Name = "numericPrice";
            numericPrice.Size = new Size(325, 29);
            numericPrice.TabIndex = 3;
            // 
            // txtTypeName
            // 
            txtTypeName.Location = new Point(238, 36);
            txtTypeName.Name = "txtTypeName";
            txtTypeName.Size = new Size(325, 29);
            txtTypeName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 87);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 1;
            label2.Text = "Price/Km";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 36);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 0;
            label1.Text = "Type Name";
            // 
            // AddNewServiceType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AddNewServiceType";
            Text = "AddNewServiceType";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAddNewType;
        private NumericUpDown numericPrice;
        private TextBox txtTypeName;
        private Label label2;
        private Label label1;
    }
}