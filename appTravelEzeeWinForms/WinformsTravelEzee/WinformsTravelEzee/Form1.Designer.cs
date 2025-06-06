namespace WinformsTravelEzee
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            locationGrid = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteLocationToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            serviceTypeGrid = new DataGridView();
            menuStrip1 = new MenuStrip();
            adminActionsToolStripMenuItem = new ToolStripMenuItem();
            addLocationsToolStripMenuItem = new ToolStripMenuItem();
            addServiceTypeToolStripMenuItem = new ToolStripMenuItem();
            addNewServiceToolStripMenuItem = new ToolStripMenuItem();
            userActionsToolStripMenuItem = new ToolStripMenuItem();
            bookTicketToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            serviceGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)locationGrid).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)serviceTypeGrid).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)serviceGrid).BeginInit();
            SuspendLayout();
            // 
            // locationGrid
            // 
            locationGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            locationGrid.ContextMenuStrip = contextMenuStrip1;
            locationGrid.Location = new Point(42, 60);
            locationGrid.Name = "locationGrid";
            locationGrid.Size = new Size(287, 95);
            locationGrid.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteLocationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(157, 26);
            // 
            // deleteLocationToolStripMenuItem
            // 
            deleteLocationToolStripMenuItem.Name = "deleteLocationToolStripMenuItem";
            deleteLocationToolStripMenuItem.Size = new Size(156, 22);
            deleteLocationToolStripMenuItem.Text = "Delete Location";
            deleteLocationToolStripMenuItem.Click += deleteLocationToolStripMenuItem_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 42);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Locations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 158);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Service Types";
            // 
            // serviceTypeGrid
            // 
            serviceTypeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            serviceTypeGrid.Location = new Point(42, 176);
            serviceTypeGrid.Name = "serviceTypeGrid";
            serviceTypeGrid.Size = new Size(271, 114);
            serviceTypeGrid.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminActionsToolStripMenuItem, userActionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminActionsToolStripMenuItem
            // 
            adminActionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addLocationsToolStripMenuItem, addServiceTypeToolStripMenuItem, addNewServiceToolStripMenuItem });
            adminActionsToolStripMenuItem.Name = "adminActionsToolStripMenuItem";
            adminActionsToolStripMenuItem.Size = new Size(98, 20);
            adminActionsToolStripMenuItem.Text = "Admin Actions";
            // 
            // addLocationsToolStripMenuItem
            // 
            addLocationsToolStripMenuItem.Name = "addLocationsToolStripMenuItem";
            addLocationsToolStripMenuItem.Size = new Size(163, 22);
            addLocationsToolStripMenuItem.Text = "Add Location";
            addLocationsToolStripMenuItem.Click += addLocationsToolStripMenuItem_Click;
            // 
            // addServiceTypeToolStripMenuItem
            // 
            addServiceTypeToolStripMenuItem.Name = "addServiceTypeToolStripMenuItem";
            addServiceTypeToolStripMenuItem.Size = new Size(163, 22);
            addServiceTypeToolStripMenuItem.Text = "Add Service Type";
            addServiceTypeToolStripMenuItem.Click += addServiceTypeToolStripMenuItem_Click;
            // 
            // addNewServiceToolStripMenuItem
            // 
            addNewServiceToolStripMenuItem.Name = "addNewServiceToolStripMenuItem";
            addNewServiceToolStripMenuItem.Size = new Size(163, 22);
            addNewServiceToolStripMenuItem.Text = "Add New Service";
            addNewServiceToolStripMenuItem.Click += addNewServiceToolStripMenuItem_Click;
            // 
            // userActionsToolStripMenuItem
            // 
            userActionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookTicketToolStripMenuItem });
            userActionsToolStripMenuItem.Name = "userActionsToolStripMenuItem";
            userActionsToolStripMenuItem.Size = new Size(85, 20);
            userActionsToolStripMenuItem.Text = "User Actions";
            // 
            // bookTicketToolStripMenuItem
            // 
            bookTicketToolStripMenuItem.Name = "bookTicketToolStripMenuItem";
            bookTicketToolStripMenuItem.Size = new Size(135, 22);
            bookTicketToolStripMenuItem.Text = "Book Ticket";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(342, 31);
            label3.Name = "label3";
            label3.Size = new Size(85, 19);
            label3.TabIndex = 5;
            label3.Text = "Service List";
            // 
            // serviceGrid
            // 
            serviceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            serviceGrid.Location = new Point(374, 63);
            serviceGrid.MultiSelect = false;
            serviceGrid.Name = "serviceGrid";
            serviceGrid.ReadOnly = true;
            serviceGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            serviceGrid.Size = new Size(326, 227);
            serviceGrid.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 412);
            Controls.Add(serviceGrid);
            Controls.Add(label3);
            Controls.Add(serviceTypeGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(locationGrid);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)locationGrid).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)serviceTypeGrid).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)serviceGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView locationGrid;
        private Label label1;
        private Label label2;
        private DataGridView serviceTypeGrid;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminActionsToolStripMenuItem;
        private ToolStripMenuItem addLocationsToolStripMenuItem;
        private ToolStripMenuItem addServiceTypeToolStripMenuItem;
        private ToolStripMenuItem userActionsToolStripMenuItem;
        private ToolStripMenuItem bookTicketToolStripMenuItem;
        private Label label3;
        private DataGridView serviceGrid;
        private ToolStripMenuItem addNewServiceToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteLocationToolStripMenuItem;
    }
}
