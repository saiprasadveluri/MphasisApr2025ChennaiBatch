namespace TravelEzeeADOWin
{
    partial class LocationMnager
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
            locationGrid = new DataGridView();
            groupBox1 = new GroupBox();
            AddLocation = new Button();
            LocationName = new TextBox();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteLocationToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)locationGrid).BeginInit();
            groupBox1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // locationGrid
            // 
            locationGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            locationGrid.ContextMenuStrip = contextMenuStrip1;
            locationGrid.Location = new Point(76, 24);
            locationGrid.MultiSelect = false;
            locationGrid.Name = "locationGrid";
            locationGrid.ReadOnly = true;
            locationGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            locationGrid.Size = new Size(647, 150);
            locationGrid.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AddLocation);
            groupBox1.Controls.Add(LocationName);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.Location = new Point(84, 198);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(639, 240);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Location";
            // 
            // AddLocation
            // 
            AddLocation.Location = new Point(266, 122);
            AddLocation.Name = "AddLocation";
            AddLocation.Size = new Size(176, 35);
            AddLocation.TabIndex = 2;
            AddLocation.Text = "Add Location";
            AddLocation.UseVisualStyleBackColor = true;
            AddLocation.Click += AddLocation_Click;
            // 
            // LocationName
            // 
            LocationName.Location = new Point(159, 72);
            LocationName.Name = "LocationName";
            LocationName.Size = new Size(432, 29);
            LocationName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 72);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 0;
            label1.Text = "Location Name";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteLocationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(157, 26);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // deleteLocationToolStripMenuItem
            // 
            deleteLocationToolStripMenuItem.Name = "deleteLocationToolStripMenuItem";
            deleteLocationToolStripMenuItem.Size = new Size(156, 22);
            deleteLocationToolStripMenuItem.Text = "Delete Location";
            deleteLocationToolStripMenuItem.Click += deleteLocationToolStripMenuItem_Click;
            // 
            // LocationMnager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(locationGrid);
            Name = "LocationMnager";
            Text = "LocationMnager";
            Load += LocationMnager_Load;
            ((System.ComponentModel.ISupportInitialize)locationGrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView locationGrid;
        private GroupBox groupBox1;
        private TextBox LocationName;
        private Label label1;
        private Button AddLocation;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteLocationToolStripMenuItem;
    }
}