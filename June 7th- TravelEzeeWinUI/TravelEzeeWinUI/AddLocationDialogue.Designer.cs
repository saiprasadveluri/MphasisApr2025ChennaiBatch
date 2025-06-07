namespace TravelEzeeWinUI
{
    partial class AddLocationDialogue
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
            locgroupBox = new GroupBox();
            btnAddloc = new Button();
            txtDescription = new TextBox();
            txtLocation = new TextBox();
            label2 = new Label();
            label1 = new Label();
            locgroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // locgroupBox
            // 
            locgroupBox.Controls.Add(btnAddloc);
            locgroupBox.Controls.Add(txtDescription);
            locgroupBox.Controls.Add(txtLocation);
            locgroupBox.Controls.Add(label2);
            locgroupBox.Controls.Add(label1);
            locgroupBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            locgroupBox.Location = new Point(12, 12);
            locgroupBox.Name = "locgroupBox";
            locgroupBox.Size = new Size(935, 472);
            locgroupBox.TabIndex = 0;
            locgroupBox.TabStop = false;
            locgroupBox.Text = "Add Location";
            // 
            // btnAddloc
            // 
            btnAddloc.Location = new Point(307, 291);
            btnAddloc.Name = "btnAddloc";
            btnAddloc.Size = new Size(151, 34);
            btnAddloc.TabIndex = 2;
            btnAddloc.Text = "Add Location";
            btnAddloc.UseVisualStyleBackColor = true;
            btnAddloc.Click += btnAddloc_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(173, 106);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(421, 158);
            txtDescription.TabIndex = 1;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(173, 50);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(421, 25);
            txtLocation.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 109);
            label2.Name = "label2";
            label2.Size = new Size(83, 17);
            label2.TabIndex = 0;
            label2.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 53);
            label1.Name = "label1";
            label1.Size = new Size(109, 17);
            label1.TabIndex = 0;
            label1.Text = "Location Name: ";
            // 
            // AddLocationDialogue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 511);
            Controls.Add(locgroupBox);
            Name = "AddLocationDialogue";
            Text = "AddLocationDialogue";
            locgroupBox.ResumeLayout(false);
            locgroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox locgroupBox;
        private Label label2;
        private Label label1;
        private TextBox txtDescription;
        private TextBox txtLocation;
        private Button btnAddloc;
    }
}