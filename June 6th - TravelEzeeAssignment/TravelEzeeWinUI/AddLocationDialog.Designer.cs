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
            txtdescription = new TextBox();
            txtlocationName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddLocation);
            groupBox1.Controls.Add(txtdescription);
            groupBox1.Controls.Add(txtlocationName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 396);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Location";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnAddLocation
            // 
            btnAddLocation.Location = new Point(322, 320);
            btnAddLocation.Name = "btnAddLocation";
            btnAddLocation.Size = new Size(193, 34);
            btnAddLocation.TabIndex = 4;
            btnAddLocation.Text = "Add Location";
            btnAddLocation.UseVisualStyleBackColor = true;
            btnAddLocation.Click += btnAddLocation_Click;
            // 
            // txtdescription
            // 
            txtdescription.Location = new Point(181, 103);
            txtdescription.Multiline = true;
            txtdescription.Name = "txtdescription";
            txtdescription.Size = new Size(479, 194);
            txtdescription.TabIndex = 3;
            // 
            // txtlocationName
            // 
            txtlocationName.Location = new Point(181, 50);
            txtlocationName.Name = "txtlocationName";
            txtlocationName.Size = new Size(479, 25);
            txtlocationName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 106);
            label2.Name = "label2";
            label2.Size = new Size(85, 19);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 49);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btnAddLocation;
        private TextBox txtdescription;
        private TextBox txtlocationName;
    }
}