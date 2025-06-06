namespace TravelEzeeWinUI
{
    partial class AddLocationDialog
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
            btnAddLocation = new Button();
            txtDescription = new TextBox();
            txtlocationName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddLocation);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtlocationName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(34, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(467, 250);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Location";
            // 
            // btnAddLocation
            // 
            btnAddLocation.Location = new Point(237, 189);
            btnAddLocation.Name = "btnAddLocation";
            btnAddLocation.Size = new Size(114, 23);
            btnAddLocation.TabIndex = 4;
            btnAddLocation.Text = "Add Location";
            btnAddLocation.UseVisualStyleBackColor = true;
            btnAddLocation.Click += btnAddLocation_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(164, 76);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(253, 92);
            txtDescription.TabIndex = 3;
            // 
            // txtlocationName
            // 
            txtlocationName.Location = new Point(164, 39);
            txtlocationName.Name = "txtlocationName";
            txtlocationName.Size = new Size(253, 25);
            txtlocationName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 76);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 39);
            label1.Name = "label1";
            label1.Size = new Size(110, 19);
            label1.TabIndex = 0;
            label1.Text = "Location Name";
            // 
            // AddLocationDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddLocationDialog";
            Text = "AddLocationDialog";
            Load += AddLocationDialog_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox txtDescription;
        private TextBox txtlocationName;
        private Button btnAddLocation;
    }
}