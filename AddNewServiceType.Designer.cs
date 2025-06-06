namespace TravelEzeeWinUII
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
            label1 = new Label();
            label2 = new Label();
            txtServiceType = new TextBox();
            numericPrice = new NumericUpDown();
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
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(98, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(681, 312);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Service Types";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 66);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 0;
            label1.Text = "Service Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 126);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 1;
            label2.Text = "Price/Km";
            // 
            // txtServiceType
            // 
            txtServiceType.Location = new Point(222, 63);
            txtServiceType.Name = "txtServiceType";
            txtServiceType.Size = new Size(453, 29);
            txtServiceType.TabIndex = 2;
            // 
            // numericPrice
            // 
            numericPrice.Location = new Point(221, 124);
            numericPrice.Name = "numericPrice";
            numericPrice.Size = new Size(454, 29);
            numericPrice.TabIndex = 3;
            // 
            // btnAddServiceType
            // 
            btnAddServiceType.Location = new Point(242, 201);
            btnAddServiceType.Name = "btnAddServiceType";
            btnAddServiceType.Size = new Size(170, 33);
            btnAddServiceType.TabIndex = 4;
            btnAddServiceType.Text = "Add Service";
            btnAddServiceType.UseVisualStyleBackColor = true;
            btnAddServiceType.Click += btnAddServiceType_Click;
            // 
            // AddNewServiceType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private TextBox txtServiceType;
        private Label label2;
        private Label label1;
        private Button btnAddServiceType;
        private NumericUpDown numericPrice;
    }
}