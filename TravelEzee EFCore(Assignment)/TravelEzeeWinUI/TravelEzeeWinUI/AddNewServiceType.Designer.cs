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
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(41, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(524, 237);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Service Type";
            // 
            // btnAddNewType
            // 
            btnAddNewType.Location = new Point(221, 150);
            btnAddNewType.Name = "btnAddNewType";
            btnAddNewType.Size = new Size(138, 28);
            btnAddNewType.TabIndex = 5;
            btnAddNewType.Text = "Add New Type";
            btnAddNewType.UseVisualStyleBackColor = true;
            btnAddNewType.Click += btnAddNewType_Click;
            // 
            // numericPrice
            // 
            numericPrice.Location = new Point(174, 80);
            numericPrice.Name = "numericPrice";
            numericPrice.Size = new Size(309, 25);
            numericPrice.TabIndex = 4;
            // 
            // txtTypeName
            // 
            txtTypeName.Location = new Point(168, 33);
            txtTypeName.Name = "txtTypeName";
            txtTypeName.Size = new Size(315, 25);
            txtTypeName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 80);
            label2.Name = "label2";
            label2.Size = new Size(71, 19);
            label2.TabIndex = 2;
            label2.Text = "Price/Km";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 33);
            label1.Name = "label1";
            label1.Size = new Size(85, 19);
            label1.TabIndex = 1;
            label1.Text = "Type Name";
            // 
            // AddNewServiceType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
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