namespace TravelEasywinforms
{
    partial class AddLocation
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
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.Location = new Point(35, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(667, 352);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Location";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 44);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 0;
            label1.Text = "Location Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 93);
            label2.Name = "label2";
            label2.Size = new Size(135, 21);
            label2.TabIndex = 1;
            label2.Text = "Location Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 134);
            label3.Name = "label3";
            label3.Size = new Size(179, 21);
            label3.TabIndex = 2;
            label3.Text = "Location Description:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 29);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(206, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(307, 29);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(206, 131);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(307, 99);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(206, 262);
            button1.Name = "button1";
            button1.Size = new Size(131, 33);
            button1.TabIndex = 6;
            button1.Text = "Add Location";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddLocation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "AddLocation";
            Text = "AddLocation";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}