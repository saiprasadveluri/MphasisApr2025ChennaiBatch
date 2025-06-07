namespace TravelEzeeWinUI
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
            ServiceTypeGrid = new DataGridView();
            contextMenuStrip3 = new ContextMenuStrip(components);
            deleteServiceTypesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            adminActionsToolStripMenuItem = new ToolStripMenuItem();
            addLocationToolStripMenuItem = new ToolStripMenuItem();
            addServiceTypeToolStripMenuItem = new ToolStripMenuItem();
            addNewServiceToolStripMenuItem = new ToolStripMenuItem();
            userActionsToolStripMenuItem = new ToolStripMenuItem();
            bookTicketToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            ServiceGrid = new DataGridView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            deleteServiceToolStripMenuItem = new ToolStripMenuItem();
            editLocationToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)LocationGrid).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ServiceTypeGrid).BeginInit();
            contextMenuStrip3.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ServiceGrid).BeginInit();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // LocationGrid
            // 
            LocationGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LocationGrid.ContextMenuStrip = contextMenuStrip1;
            LocationGrid.Location = new Point(37, 61);
            LocationGrid.Name = "LocationGrid";
            LocationGrid.Size = new Size(291, 105);
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
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 34);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 1;
            label1.Text = "Locations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 175);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Service Types";
            // 
            // ServiceTypeGrid
            // 
            ServiceTypeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceTypeGrid.ContextMenuStrip = contextMenuStrip3;
            ServiceTypeGrid.Location = new Point(37, 204);
            ServiceTypeGrid.Name = "ServiceTypeGrid";
            ServiceTypeGrid.Size = new Size(269, 105);
            ServiceTypeGrid.TabIndex = 3;
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { deleteServiceTypesToolStripMenuItem });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(180, 26);
            // 
            // deleteServiceTypesToolStripMenuItem
            // 
            deleteServiceTypesToolStripMenuItem.Name = "deleteServiceTypesToolStripMenuItem";
            deleteServiceTypesToolStripMenuItem.Size = new Size(179, 22);
            deleteServiceTypesToolStripMenuItem.Text = "Delete Service Types";
            deleteServiceTypesToolStripMenuItem.Click += deleteServiceTypesToolStripMenuItem_Click;
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
            adminActionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addLocationToolStripMenuItem, addServiceTypeToolStripMenuItem, addNewServiceToolStripMenuItem });
            adminActionsToolStripMenuItem.Name = "adminActionsToolStripMenuItem";
            adminActionsToolStripMenuItem.Size = new Size(98, 20);
            adminActionsToolStripMenuItem.Text = "Admin Actions";
            // 
            // addLocationToolStripMenuItem
            // 
            addLocationToolStripMenuItem.Name = "addLocationToolStripMenuItem";
            addLocationToolStripMenuItem.Size = new Size(163, 22);
            addLocationToolStripMenuItem.Text = "Add Location";
            addLocationToolStripMenuItem.Click += addLocationToolStripMenuItem_Click;
            // 
            // addServiceTypeToolStripMenuItem
            // 
            addServiceTypeToolStripMenuItem.Name = "addServiceTypeToolStripMenuItem";
            addServiceTypeToolStripMenuItem.Size = new Size(163, 22);
            addServiceTypeToolStripMenuItem.Text = "Add ServiceType";
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
            label3.Location = new Point(423, 30);
            label3.Name = "label3";
            label3.Size = new Size(85, 19);
            label3.TabIndex = 5;
            label3.Text = "Service List";
            // 
            // ServiceGrid
            // 
            ServiceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceGrid.ContextMenuStrip = contextMenuStrip2;
            ServiceGrid.Location = new Point(456, 61);
            ServiceGrid.MultiSelect = false;
            ServiceGrid.Name = "ServiceGrid";
            ServiceGrid.ReadOnly = true;
            ServiceGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ServiceGrid.Size = new Size(277, 105);
            ServiceGrid.TabIndex = 6;
            ServiceGrid.CellContentClick += ServiceGrid_CellContentClick;
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
            deleteServiceToolStripMenuItem.Click += deleteServiceToolStripMenuItem_Click_1;
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
            Controls.Add(ServiceGrid);
            Controls.Add(label3);
            Controls.Add(ServiceTypeGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LocationGrid);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)LocationGrid).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ServiceTypeGrid).EndInit();
            contextMenuStrip3.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ServiceGrid).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView LocationGrid;
        private Label label1;
        private Label label2;
        private DataGridView ServiceTypeGrid;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminActionsToolStripMenuItem;
        private ToolStripMenuItem addLocationToolStripMenuItem;
        private ToolStripMenuItem addServiceTypeToolStripMenuItem;
        private ToolStripMenuItem userActionsToolStripMenuItem;
        private ToolStripMenuItem bookTicketToolStripMenuItem;
        private Label label3;
        private DataGridView ServiceGrid;
        private ToolStripMenuItem addNewServiceToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteLocationToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem deleteServiceToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem deleteServiceTypesToolStripMenuItem;
        private ToolStripMenuItem editLocationToolStripMenuItem;
    }
}
