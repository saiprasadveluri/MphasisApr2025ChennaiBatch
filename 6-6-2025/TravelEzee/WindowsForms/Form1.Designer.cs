namespace TravelEzeeWinFormUI
{
    partial class AdminDashboard
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
            LocationsGrid = new DataGridView();
            label1 = new Label();
            ServiceTypesGrid = new DataGridView();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            adminActionsToolStripMenuItem = new ToolStripMenuItem();
            addLocationToolStripMenuItem = new ToolStripMenuItem();
            addServiceTypeToolStripMenuItem = new ToolStripMenuItem();
            addNewServiceToolStripMenuItem = new ToolStripMenuItem();
            userActionsToolStripMenuItem = new ToolStripMenuItem();
            bookTicketToolStripMenuItem = new ToolStripMenuItem();
            serviceListGrid = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)LocationsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ServiceTypesGrid).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)serviceListGrid).BeginInit();
            SuspendLayout();
            // 
            // LocationsGrid
            // 
            LocationsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LocationsGrid.Location = new Point(22, 84);
            LocationsGrid.Name = "LocationsGrid";
            LocationsGrid.Size = new Size(325, 143);
            LocationsGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 66);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Locations";
            label1.Click += label1_Click;
            // 
            // ServiceTypesGrid
            // 
            ServiceTypesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceTypesGrid.Location = new Point(22, 262);
            ServiceTypesGrid.Name = "ServiceTypesGrid";
            ServiceTypesGrid.Size = new Size(325, 140);
            ServiceTypesGrid.TabIndex = 2;
            ServiceTypesGrid.CellContentClick += ServiceTypesGrid_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 244);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 3;
            label2.Text = "Service Types";
            label2.Click += label2_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminActionsToolStripMenuItem, userActionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(905, 24);
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
            bookTicketToolStripMenuItem.Size = new Size(180, 22);
            bookTicketToolStripMenuItem.Text = "Book Ticket";
            bookTicketToolStripMenuItem.Click += bookTicketToolStripMenuItem_Click;
            // 
            // serviceListGrid
            // 
            serviceListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            serviceListGrid.Location = new Point(554, 103);
            serviceListGrid.MultiSelect = false;
            serviceListGrid.Name = "serviceListGrid";
            serviceListGrid.ReadOnly = true;
            serviceListGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            serviceListGrid.Size = new Size(298, 296);
            serviceListGrid.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(556, 73);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 6;
            label3.Text = "Serice List";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 450);
            Controls.Add(label3);
            Controls.Add(serviceListGrid);
            Controls.Add(label2);
            Controls.Add(ServiceTypesGrid);
            Controls.Add(label1);
            Controls.Add(LocationsGrid);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)LocationsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ServiceTypesGrid).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)serviceListGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView LocationsGrid;
        private Label label1;
        private DataGridView ServiceTypesGrid;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminActionsToolStripMenuItem;
        private ToolStripMenuItem addLocationToolStripMenuItem;
        private ToolStripMenuItem addServiceTypeToolStripMenuItem;
        private ToolStripMenuItem userActionsToolStripMenuItem;
        private ToolStripMenuItem bookTicketToolStripMenuItem;
        private DataGridView serviceListGrid;
        private Label label3;
        private ToolStripMenuItem addNewServiceToolStripMenuItem;
    }
}
