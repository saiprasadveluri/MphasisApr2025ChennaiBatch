namespace TravelEzeeWinFormUI
{
    partial class AddNewSrviceType
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
            txtPrice = new NumericUpDown();
            txtTypeName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtPrice).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddService);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(txtTypeName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(53, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(705, 373);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Service Type";
            // 
            // btnAddService
            // 
            btnAddService.Location = new Point(257, 198);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(109, 23);
            btnAddService.TabIndex = 4;
            btnAddService.Text = "Add Service";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(144, 114);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(521, 23);
            txtPrice.TabIndex = 3;
            // 
            // txtTypeName
            // 
            txtTypeName.Location = new Point(143, 58);
            txtTypeName.Name = "txtTypeName";
            txtTypeName.Size = new Size(522, 23);
            txtTypeName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 110);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Price/km";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 66);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Type Name";
            // 
            // AddNewSrviceType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "AddNewSrviceType";
            Text = "AddNewSrviceType";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtPrice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtTypeName;
        private Label label2;
        private Label label1;
        private Button btnAddService;
        private NumericUpDown txtPrice;
    }
}