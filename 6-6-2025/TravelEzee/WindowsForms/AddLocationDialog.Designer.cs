namespace TravelEzeeWinFormUI
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
            AddLocation = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            txtLocationName = new TextBox();
            txtDescription = new TextBox();
            btnAddLocation = new Button();
            AddLocation.SuspendLayout();
            SuspendLayout();
            // 
            // AddLocation
            // 
            AddLocation.Controls.Add(btnAddLocation);
            AddLocation.Controls.Add(txtDescription);
            AddLocation.Controls.Add(txtLocationName);
            AddLocation.Controls.Add(label2);
            AddLocation.Controls.Add(label1);
            AddLocation.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddLocation.Location = new Point(27, 29);
            AddLocation.Name = "AddLocation";
            AddLocation.Size = new Size(723, 311);
            AddLocation.TabIndex = 0;
            AddLocation.TabStop = false;
            AddLocation.Text = "Add Location";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 65);
            label1.Name = "label1";
            label1.Size = new Size(101, 17);
            label1.TabIndex = 0;
            label1.Text = "Location Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 119);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 1;
            label2.Text = "Description";
            // 
            // txtLocationName
            // 
            txtLocationName.Location = new Point(181, 57);
            txtLocationName.Name = "txtLocationName";
            txtLocationName.Size = new Size(481, 25);
            txtLocationName.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(181, 119);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(481, 97);
            txtDescription.TabIndex = 3;
            // 
            // btnAddLocation
            // 
            btnAddLocation.Location = new Point(344, 244);
            btnAddLocation.Name = "btnAddLocation";
            btnAddLocation.Size = new Size(125, 23);
            btnAddLocation.TabIndex = 4;
            btnAddLocation.Text = "Add Location";
            btnAddLocation.UseVisualStyleBackColor = true;
            btnAddLocation.Click += btnAddLocation_Click;
            // 
            // AddLocationDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddLocation);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddLocationDialog";
            Text = "AddLocationDialog";
            AddLocation.ResumeLayout(false);
            AddLocation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox AddLocation;
        private Label label2;
        private Label label1;
        private Button btnAddLocation;
        private TextBox txtDescription;
        private TextBox txtLocationName;
    }
}