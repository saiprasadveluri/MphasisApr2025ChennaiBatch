namespace TravelEzeeWinUI
{
    partial class AddNewServiceDialogue
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
            btnaddservice = new Button();
            distanceDropdown = new NumericUpDown();
            sourcecombo = new ComboBox();
            destcombo = new ComboBox();
            srvtypecombo = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)distanceDropdown).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnaddservice);
            groupBox1.Controls.Add(distanceDropdown);
            groupBox1.Controls.Add(sourcecombo);
            groupBox1.Controls.Add(destcombo);
            groupBox1.Controls.Add(srvtypecombo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(752, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Service";
            // 
            // btnaddservice
            // 
            btnaddservice.Location = new Point(206, 239);
            btnaddservice.Name = "btnaddservice";
            btnaddservice.Size = new Size(134, 33);
            btnaddservice.TabIndex = 3;
            btnaddservice.Text = "Add Service";
            btnaddservice.UseVisualStyleBackColor = true;
            btnaddservice.Click += btnaddservice_Click;
            // 
            // distanceDropdown
            // 
            distanceDropdown.Location = new Point(139, 184);
            distanceDropdown.Name = "distanceDropdown";
            distanceDropdown.Size = new Size(279, 25);
            distanceDropdown.TabIndex = 2;
            // 
            // sourcecombo
            // 
            sourcecombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sourcecombo.FormattingEnabled = true;
            sourcecombo.Location = new Point(139, 85);
            sourcecombo.Name = "sourcecombo";
            sourcecombo.Size = new Size(279, 25);
            sourcecombo.TabIndex = 1;
            // 
            // destcombo
            // 
            destcombo.DropDownStyle = ComboBoxStyle.DropDownList;
            destcombo.FormattingEnabled = true;
            destcombo.Location = new Point(139, 136);
            destcombo.Name = "destcombo";
            destcombo.Size = new Size(279, 25);
            destcombo.TabIndex = 1;
            // 
            // srvtypecombo
            // 
            srvtypecombo.DropDownStyle = ComboBoxStyle.DropDownList;
            srvtypecombo.FormattingEnabled = true;
            srvtypecombo.Location = new Point(139, 38);
            srvtypecombo.Name = "srvtypecombo";
            srvtypecombo.Size = new Size(279, 25);
            srvtypecombo.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 186);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 0;
            label4.Text = "Distance";
            label4.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 139);
            label3.Name = "label3";
            label3.Size = new Size(80, 17);
            label3.TabIndex = 0;
            label3.Text = "Destination";
            label3.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 88);
            label2.Name = "label2";
            label2.Size = new Size(49, 17);
            label2.TabIndex = 0;
            label2.Text = "Source";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 41);
            label1.Name = "label1";
            label1.Size = new Size(89, 17);
            label1.TabIndex = 0;
            label1.Text = "Service Type ";
            // 
            // AddNewServiceDialogue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddNewServiceDialogue";
            Text = "Add New Service";
            Load += AddNewServiceDialogue_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)distanceDropdown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button btnaddservice;
        private NumericUpDown distanceDropdown;
        private ComboBox sourcecombo;
        private ComboBox destcombo;
        private ComboBox srvtypecombo;
        private Label label4;
    }
}