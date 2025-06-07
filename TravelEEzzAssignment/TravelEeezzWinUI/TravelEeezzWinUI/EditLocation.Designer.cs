namespace TravelEeezzWinUI
{
    partial class EditLocation
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtLocationn = new TextBox();
            btnEditLocation = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            editLocationToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(139, 66);
            label1.Name = "label1";
            label1.Size = new Size(101, 17);
            label1.TabIndex = 0;
            label1.Text = "Location Name";
            // 
            // txtLocationn
            // 
            txtLocationn.Location = new Point(284, 60);
            txtLocationn.Name = "txtLocationn";
            txtLocationn.Size = new Size(170, 23);
            txtLocationn.TabIndex = 1;
            // 
            // btnEditLocation
            // 
            btnEditLocation.Location = new Point(309, 134);
            btnEditLocation.Name = "btnEditLocation";
            btnEditLocation.Size = new Size(127, 23);
            btnEditLocation.TabIndex = 2;
            btnEditLocation.Text = "Edit Location";
            btnEditLocation.UseVisualStyleBackColor = true;
            btnEditLocation.Click += btnEditLocation_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { editLocationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(144, 26);
            // 
            // editLocationToolStripMenuItem
            // 
            editLocationToolStripMenuItem.Name = "editLocationToolStripMenuItem";
            editLocationToolStripMenuItem.Size = new Size(143, 22);
            editLocationToolStripMenuItem.Text = "Edit Location";
            // 
            // EditLocation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditLocation);
            Controls.Add(txtLocationn);
            Controls.Add(label1);
            Name = "EditLocation";
            Text = "EditLocation";
            Load += EditLocation_Load;
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLocationn;
        private Button btnEditLocation;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editLocationToolStripMenuItem;
    }
}