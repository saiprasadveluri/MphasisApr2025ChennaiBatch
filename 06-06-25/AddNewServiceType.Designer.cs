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
            numericPrice = new NumericUpDown();
            txtServiceType = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnAddServiceType = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrice).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddServiceType);
            groupBox1.Controls.Add(numericPrice);
            groupBox1.Controls.Add(txtServiceType);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(27, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(629, 308);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // numericPrice
            // 
            numericPrice.Location = new Point(202, 129);
            numericPrice.Name = "numericPrice";
            numericPrice.Size = new Size(343, 29);
            numericPrice.TabIndex = 3;
            // 
            // txtServiceType
            // 
            txtServiceType.Location = new Point(208, 74);
            txtServiceType.Name = "txtServiceType";
            txtServiceType.Size = new Size(337, 29);
            txtServiceType.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 118);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 1;
            label2.Text = "Price/Km";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 69);
            label1.Name = "label1";
            label1.Size = new Size(96, 21);
            label1.TabIndex = 0;
            label1.Text = "Type Name";
            // 
            // btnAddServiceType
            // 
            btnAddServiceType.Location = new Point(332, 202);
            btnAddServiceType.Name = "btnAddServiceType";
            btnAddServiceType.Size = new Size(75, 23);
            btnAddServiceType.TabIndex = 4;
            btnAddServiceType.Text = "button1";
            btnAddServiceType.UseVisualStyleBackColor = true;
            btnAddServiceType.Click += btnAddNewType_Click;
            // 
            // AddNewServiceType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "AddNewServiceType";
            Text = "AddNewServiceType";
            Load += AddNewServiceType_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
       
        private NumericUpDown numericPrice;
        private TextBox txtServiceType;
        private Label label2;
        private Button btnAddServiceType;
    }
}