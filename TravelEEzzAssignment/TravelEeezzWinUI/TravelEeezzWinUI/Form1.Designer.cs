namespace TravelEeezzWinUI
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
            LocationGrid = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteLocationToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            serviceTypeGrid = new DataGridView();
            contextMenuStrip3 = new ContextMenuStrip(components);
            deleteServiceTypeToolStripMenuItem = new ToolStripMenuItem();
            NameMenu = new MenuStrip();
            adminActionsToolStripMenuItem = new ToolStripMenuItem();
            addLocationsToolStripMenuItem = new ToolStripMenuItem();
            addServiceTypeToolStripMenuItem = new ToolStripMenuItem();
            addNewServiceToolStripMenuItem = new ToolStripMenuItem();
            userActionsToolStripMenuItem = new ToolStripMenuItem();
            bookTicketToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            SevicesGrid = new DataGridView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            deleteServiceToolStripMenuItem = new ToolStripMenuItem();
            editLocationToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)LocationGrid).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)serviceTypeGrid).BeginInit();
            contextMenuStrip3.SuspendLayout();
            NameMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SevicesGrid).BeginInit();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // LocationGrid
            // 
            LocationGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LocationGrid.ContextMenuStrip = contextMenuStrip1;
            LocationGrid.Location = new Point(12, 50);
            LocationGrid.Name = "LocationGrid";
            LocationGrid.Size = new Size(340, 106);
            LocationGrid.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteLocationToolStripMenuItem, editLocationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 70);
            // 
            // deleteLocationToolStripMenuItem
            // 
            deleteLocationToolStripMenuItem.Name = "deleteLocationToolStripMenuItem";
            deleteLocationToolStripMenuItem.Size = new Size(180, 22);
            deleteLocationToolStripMenuItem.Text = "Delete Location";
            deleteLocationToolStripMenuItem.Click += deleteLocationToolStripMenuItem_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 1;
            label1.Text = "Locations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 172);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 2;
            label2.Text = "Service Types";
            // 
            // serviceTypeGrid
            // 
            serviceTypeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            serviceTypeGrid.ContextMenuStrip = contextMenuStrip3;
            serviceTypeGrid.Location = new Point(12, 203);
            serviceTypeGrid.Name = "serviceTypeGrid";
            serviceTypeGrid.Size = new Size(340, 103);
            serviceTypeGrid.TabIndex = 3;
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { deleteServiceTypeToolStripMenuItem });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(172, 26);
            // 
            // deleteServiceTypeToolStripMenuItem
            // 
            deleteServiceTypeToolStripMenuItem.Name = "deleteServiceTypeToolStripMenuItem";
            deleteServiceTypeToolStripMenuItem.Size = new Size(171, 22);
            deleteServiceTypeToolStripMenuItem.Text = "Delete ServiceType";
            deleteServiceTypeToolStripMenuItem.Click += deleteServiceTypeToolStripMenuItem_Click;
            // 
            // NameMenu
            // 
            NameMenu.Items.AddRange(new ToolStripItem[] { adminActionsToolStripMenuItem, userActionsToolStripMenuItem });
            NameMenu.Location = new Point(0, 0);
            NameMenu.Name = "NameMenu";
            NameMenu.Size = new Size(800, 24);
            NameMenu.TabIndex = 4;
            NameMenu.Text = "menuStrip1";
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
            addLocationsToolStripMenuItem.Text = "Add Locations";
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
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(372, 30);
            label3.Name = "label3";
            label3.Size = new Size(78, 17);
            label3.TabIndex = 5;
            label3.Text = "Service List";
            // 
            // SevicesGrid
            // 
            SevicesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SevicesGrid.ContextMenuStrip = contextMenuStrip2;
            SevicesGrid.Location = new Point(372, 50);
            SevicesGrid.MultiSelect = false;
            SevicesGrid.Name = "SevicesGrid";
            SevicesGrid.ReadOnly = true;
            SevicesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SevicesGrid.Size = new Size(398, 106);
            SevicesGrid.TabIndex = 6;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { deleteServiceToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(148, 26);
            // 
            // deleteServiceToolStripMenuItem
            // 
            deleteServiceToolStripMenuItem.Name = "deleteServiceToolStripMenuItem";
            deleteServiceToolStripMenuItem.Size = new Size(147, 22);
            deleteServiceToolStripMenuItem.Text = "Delete Service";
            deleteServiceToolStripMenuItem.Click += deleteServiceToolStripMenuItem_Click;
            // 
            // editLocationToolStripMenuItem
            // 
            editLocationToolStripMenuItem.Name = "editLocationToolStripMenuItem";
            editLocationToolStripMenuItem.Size = new Size(180, 22);
            editLocationToolStripMenuItem.Text = "Edit Location";
            editLocationToolStripMenuItem.Click += editLocationToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SevicesGrid);
            Controls.Add(label3);
            Controls.Add(serviceTypeGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LocationGrid);
            Controls.Add(NameMenu);
            MainMenuStrip = NameMenu;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)LocationGrid).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)serviceTypeGrid).EndInit();
            contextMenuStrip3.ResumeLayout(false);
            NameMenu.ResumeLayout(false);
            NameMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SevicesGrid).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView LocationGrid;
        private Label label1;
        private Label label2;
        private DataGridView serviceTypeGrid;
        private MenuStrip NameMenu;
        private ToolStripMenuItem adminActionsToolStripMenuItem;
        private ToolStripMenuItem addLocationsToolStripMenuItem;
        private ToolStripMenuItem addServiceTypeToolStripMenuItem;
        private ToolStripMenuItem userActionsToolStripMenuItem;
        private ToolStripMenuItem bookTicketToolStripMenuItem;
        private Label label3;
        private DataGridView SevicesGrid;
        private ToolStripMenuItem addNewServiceToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteLocationToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem deleteServiceToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem deleteServiceTypeToolStripMenuItem;
        private ToolStripMenuItem editLocationToolStripMenuItem;
    }
}
