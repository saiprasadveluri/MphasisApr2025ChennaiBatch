﻿namespace TravelEasywinforms
{
    partial class Booking
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
            textBox2 = new TextBox();
            numericUpDown2 = new NumericUpDown();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            groupBox1.Location = new Point(33, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(667, 352);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Service";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(140, 165);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(233, 29);
            textBox2.TabIndex = 24;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(140, 128);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(233, 29);
            numericUpDown2.TabIndex = 23;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(140, 93);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 29);
            dateTimePicker1.TabIndex = 22;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 29);
            textBox1.TabIndex = 21;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(140, 57);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(233, 29);
            comboBox2.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 168);
            label7.Name = "label7";
            label7.Size = new Size(95, 21);
            label7.TabIndex = 11;
            label7.Text = "BookedBy:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 131);
            label6.Name = "label6";
            label6.Size = new Size(101, 21);
            label6.TabIndex = 10;
            label6.Text = "Seat Count:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 93);
            label5.Name = "label5";
            label5.Size = new Size(102, 21);
            label5.TabIndex = 9;
            label5.Text = "TravelDate:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 60);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 8;
            label4.Text = "Service Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 25);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 7;
            label1.Text = "Booking Id:";
            // 
            // button1
            // 
            button1.Location = new Point(140, 219);
            button1.Name = "button1";
            button1.Size = new Size(151, 33);
            button1.TabIndex = 6;
            button1.Text = "Add Booking";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 487);
            Controls.Add(groupBox1);
            Name = "Booking";
            Text = "Booking";
            Load += Booking_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private Button button1;
        private NumericUpDown numericUpDown2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
    }
}