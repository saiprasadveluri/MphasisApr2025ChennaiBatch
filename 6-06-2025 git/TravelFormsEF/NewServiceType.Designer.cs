namespace TravelFormsEF
{
    partial class btnSerType
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
            AddServiceType = new Button();
            PricePerKm = new NumericUpDown();
            txtSerTypeName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PricePerKm).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddServiceType);
            groupBox1.Controls.Add(PricePerKm);
            groupBox1.Controls.Add(txtSerTypeName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(55, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(563, 238);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "New Service Type";
            // 
            // AddServiceType
            // 
            AddServiceType.Location = new Point(127, 180);
            AddServiceType.Name = "AddServiceType";
            AddServiceType.Size = new Size(185, 29);
            AddServiceType.TabIndex = 4;
            AddServiceType.Text = "Add Service Type";
            AddServiceType.UseVisualStyleBackColor = true;
            AddServiceType.Click += AddServiceType_Click;
            // 
            // PricePerKm
            // 
            PricePerKm.Location = new Point(214, 112);
            PricePerKm.Name = "PricePerKm";
            PricePerKm.Size = new Size(237, 29);
            PricePerKm.TabIndex = 3;
            // 
            // txtSerTypeName
            // 
            txtSerTypeName.Location = new Point(214, 45);
            txtSerTypeName.Name = "txtSerTypeName";
            txtSerTypeName.Size = new Size(237, 29);
            txtSerTypeName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 115);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 1;
            label2.Text = "PricePerKm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 45);
            label1.Name = "label1";
            label1.Size = new Size(150, 21);
            label1.TabIndex = 0;
            label1.Text = "Service Type Name";
            // 
            // btnSerType
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "btnSerType";
            Text = "NewServiceType";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PricePerKm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtSerTypeName;
        private Label label2;
        private Button AddServiceType;
        private NumericUpDown PricePerKm;
    }
}