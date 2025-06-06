namespace TravelEasywinforms
{
    partial class ServiceTypeAdd
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
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.Location = new Point(67, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(667, 352);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add ServiceType";
            // 
            // button1
            // 
            button1.Location = new Point(182, 182);
            button1.Name = "button1";
            button1.Size = new Size(151, 33);
            button1.TabIndex = 6;
            button1.Text = "Add ServiceType";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(182, 131);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(307, 29);
            textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(307, 29);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 134);
            label3.Name = "label3";
            label3.Size = new Size(117, 21);
            label3.TabIndex = 2;
            label3.Text = "Price Per KM:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 93);
            label2.Name = "label2";
            label2.Size = new Size(160, 21);
            label2.TabIndex = 1;
            label2.Text = "ServiceType Name:";
            // 
            // ServiceTypeAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "ServiceTypeAdd";
            Text = "ServiceTypeAdd";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
    }
}