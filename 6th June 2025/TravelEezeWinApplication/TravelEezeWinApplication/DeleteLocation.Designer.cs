namespace TravelEezeWinApplication
{
    partial class DeleteLocation
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
            btnDeleteLoc = new Button();
            comboAvlLocation = new ComboBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeleteLoc);
            groupBox1.Controls.Add(comboAvlLocation);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(18, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 350);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Delete Location";
            // 
            // btnDeleteLoc
            // 
            btnDeleteLoc.Location = new Point(239, 131);
            btnDeleteLoc.Name = "btnDeleteLoc";
            btnDeleteLoc.Size = new Size(298, 36);
            btnDeleteLoc.TabIndex = 2;
            btnDeleteLoc.Text = "Delete Location";
            btnDeleteLoc.UseVisualStyleBackColor = true;
            btnDeleteLoc.Click += btnDeleteLoc_Click;
            // 
            // comboAvlLocation
            // 
            comboAvlLocation.FormattingEnabled = true;
            comboAvlLocation.Location = new Point(169, 40);
            comboAvlLocation.Name = "comboAvlLocation";
            comboAvlLocation.Size = new Size(561, 29);
            comboAvlLocation.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 40);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 0;
            label1.Text = "Select Location";
            // 
            // DeleteLocation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteLocation";
            Text = "DeleteLocation";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDeleteLoc;
        private ComboBox comboAvlLocation;
        private Label label1;
    }
}