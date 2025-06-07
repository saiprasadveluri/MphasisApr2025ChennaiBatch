namespace TravelEzzCoreConsole2
{
    partial class from1
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
            deleteToolStripMenuItem = new ToolStripMenuItem();
            updateLocationToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            ServiceTypeGrid = new DataGridView();
            deleteServiceType = new ContextMenuStrip(components);
            deleteServiceTpes = new ToolStripMenuItem();
            mainMenu = new MenuStrip();
            adminActionsToolStripMenuItem = new ToolStripMenuItem();
            addLocationsToolStripMenuItem = new ToolStripMenuItem();
            addServiceTypeToolStripMenuItem = new ToolStripMenuItem();
            addNewServiceToolStripMenuItem = new ToolStripMenuItem();
            userActionsToolStripMenuItem = new ToolStripMenuItem();
            bookTicketToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            ServicesGrid = new DataGridView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            deleteServiceToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)LocationGrid).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ServiceTypeGrid).BeginInit();
            deleteServiceType.SuspendLayout();
            mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ServicesGrid).BeginInit();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // LocationGrid
            // 
            LocationGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LocationGrid.ContextMenuStrip = contextMenuStrip1;
            LocationGrid.Location = new Point(36, 104);
            LocationGrid.Name = "LocationGrid";
            LocationGrid.Size = new Size(260, 94);
            LocationGrid.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem, updateLocationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(159, 48);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(158, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // updateLocationToolStripMenuItem
            // 
            updateLocationToolStripMenuItem.Name = "updateLocationToolStripMenuItem";
            updateLocationToolStripMenuItem.Size = new Size(158, 22);
            updateLocationToolStripMenuItem.Text = "UpdateLocation";
            updateLocationToolStripMenuItem.Click += updateLocationToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Locations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 233);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 2;
            label2.Text = "ServiceTpes";
            // 
            // ServiceTypeGrid
            // 
            ServiceTypeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceTypeGrid.ContextMenuStrip = deleteServiceType;
            ServiceTypeGrid.Location = new Point(36, 265);
            ServiceTypeGrid.Name = "ServiceTypeGrid";
            ServiceTypeGrid.Size = new Size(250, 106);
            ServiceTypeGrid.TabIndex = 3;
            // 
            // deleteServiceType
            // 
            deleteServiceType.Items.AddRange(new ToolStripItem[] { deleteServiceTpes });
            deleteServiceType.Name = "contextMenuStrip3";
            deleteServiceType.Size = new Size(181, 48);
            // 
            // deleteServiceTpes
            // 
            deleteServiceTpes.Name = "deleteServiceTpes";
            deleteServiceTpes.Size = new Size(180, 22);
            deleteServiceTpes.Text = "delete servicetype";
            deleteServiceTpes.Click += deleteToolStripMenuItem1_Click;
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new ToolStripItem[] { adminActionsToolStripMenuItem, userActionsToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(800, 24);
            mainMenu.TabIndex = 4;
            mainMenu.Text = "menuStrip1";
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
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(390, 25);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 5;
            label3.Text = "ServiceList";
            // 
            // ServicesGrid
            // 
            ServicesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServicesGrid.ContextMenuStrip = contextMenuStrip2;
            ServicesGrid.Location = new Point(464, 43);
            ServicesGrid.MultiSelect = false;
            ServicesGrid.Name = "ServicesGrid";
            ServicesGrid.ReadOnly = true;
            ServicesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ServicesGrid.Size = new Size(324, 155);
            ServicesGrid.TabIndex = 6;
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
            // from1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ServicesGrid);
            Controls.Add(label3);
            Controls.Add(ServiceTypeGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LocationGrid);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Name = "from1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)LocationGrid).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ServiceTypeGrid).EndInit();
            deleteServiceType.ResumeLayout(false);
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ServicesGrid).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView LocationGrid;
        private Label label1;
        private Label label2;
        private DataGridView ServiceTypeGrid;
        private MenuStrip mainMenu;
        private ToolStripMenuItem adminActionsToolStripMenuItem;
        private ToolStripMenuItem addLocationsToolStripMenuItem;
        private ToolStripMenuItem addServiceTypeToolStripMenuItem;
        private ToolStripMenuItem userActionsToolStripMenuItem;
        private ToolStripMenuItem bookTicketToolStripMenuItem;
        private Label label3;
        private DataGridView ServicesGrid;
        private ToolStripMenuItem addNewServiceToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem deleteServiceToolStripMenuItem;
        private ContextMenuStrip deleteServiceType;
        private ToolStripMenuItem deleteServiceTpes;
        private ToolStripMenuItem updateLocationToolStripMenuItem;
    }
}
