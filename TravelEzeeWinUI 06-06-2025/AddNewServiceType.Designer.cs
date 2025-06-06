namespace TravelEzeeWinUI2
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
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(113, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(583, 280);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Service Type";
            // 
            // btnAddNewType
            // 
            btnAddNewType.Location = new Point(295, 154);
            btnAddNewType.Name = "btnAddNewType";
            btnAddNewType.Size = new Size(191, 41);
            btnAddNewType.TabIndex = 4;
            btnAddNewType.Text = "Add New Type";
            btnAddNewType.UseVisualStyleBackColor = true;
            btnAddNewType.Click += btnAddNewType_Click;
            // 
            // numericPrice
            // 
            numericPrice.Location = new Point(232, 96);
            numericPrice.Name = "numericPrice";
            numericPrice.Size = new Size(326, 29);
            numericPrice.TabIndex = 3;
            // 
            // txtTypeName
            // 
            txtTypeName.Location = new Point(232, 37);
            txtTypeName.Name = "txtTypeName";
            txtTypeName.Size = new Size(326, 29);
            txtTypeName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 98);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 1;
            label2.Text = "Price/Km";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 40);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 0;
            label1.Text = "Type Name";
            // 
            // AddNewServiceType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddNewServiceType";
            Text = "AddNewServiceType";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Button btnAddNewType;
        private NumericUpDown numericPrice;
        private TextBox txtTypeName;
        private Label label2;
    }
}