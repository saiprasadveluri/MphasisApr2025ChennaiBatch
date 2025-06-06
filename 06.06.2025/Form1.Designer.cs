namespace TravelEzeeWinUII
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
            locationGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ServiceTypeGrid = new DataGridView();
            mainMenu = new MenuStrip();
            adminAToolStripMenuItem = new ToolStripMenuItem();
            addLocationsToolStripMenuItem = new ToolStripMenuItem();
            addServicesToolStripMenuItem = new ToolStripMenuItem();
            userActionsToolStripMenuItem = new ToolStripMenuItem();
            bookTicketToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            ServicesGrid = new DataGridView();
            addNewServiceToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)locationGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ServiceTypeGrid).BeginInit();
            mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ServicesGrid).BeginInit();
            SuspendLayout();
            // 
            // locationGrid
            // 
            locationGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            locationGrid.Location = new Point(24, 86);
            locationGrid.Name = "locationGrid";
            locationGrid.Size = new Size(276, 150);
            locationGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 1;
            label1.Text = "Locations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 254);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 2;
            label2.Text = "Service Types";
            // 
            // ServiceTypeGrid
            // 
            ServiceTypeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceTypeGrid.Location = new Point(30, 288);
            ServiceTypeGrid.Name = "ServiceTypeGrid";
            ServiceTypeGrid.Size = new Size(270, 150);
            ServiceTypeGrid.TabIndex = 3;
            // 
            // mainMenu
            // 
            mainMenu.Items.AddRange(new ToolStripItem[] { adminAToolStripMenuItem, userActionsToolStripMenuItem });
            mainMenu.Location = new Point(0, 0);
            mainMenu.Name = "mainMenu";
            mainMenu.Size = new Size(800, 24);
            mainMenu.TabIndex = 4;
            mainMenu.Text = "menuStrip1";
            // 
            // adminAToolStripMenuItem
            // 
            adminAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addLocationsToolStripMenuItem, addServicesToolStripMenuItem, addNewServiceToolStripMenuItem });
            adminAToolStripMenuItem.Name = "adminAToolStripMenuItem";
            adminAToolStripMenuItem.Size = new Size(98, 20);
            adminAToolStripMenuItem.Text = "Admin Actions";
            // 
            // addLocationsToolStripMenuItem
            // 
            addLocationsToolStripMenuItem.Name = "addLocationsToolStripMenuItem";
            addLocationsToolStripMenuItem.Size = new Size(180, 22);
            addLocationsToolStripMenuItem.Text = "Add Locations";
            addLocationsToolStripMenuItem.Click += addLocationsToolStripMenuItem_Click;
            // 
            // addServicesToolStripMenuItem
            // 
            addServicesToolStripMenuItem.Name = "addServicesToolStripMenuItem";
            addServicesToolStripMenuItem.Size = new Size(180, 22);
            addServicesToolStripMenuItem.Text = "Add Services";
            addServicesToolStripMenuItem.Click += addServicesToolStripMenuItem_Click;
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
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(341, 24);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 5;
            label3.Text = "Service List";
            // 
            // ServicesGrid
            // 
            ServicesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServicesGrid.Location = new Point(364, 48);
            ServicesGrid.MultiSelect = false;
            ServicesGrid.Name = "ServicesGrid";
            ServicesGrid.ReadOnly = true;
            ServicesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ServicesGrid.Size = new Size(391, 277);
            ServicesGrid.TabIndex = 6;
            // 
            // addNewServiceToolStripMenuItem
            // 
            addNewServiceToolStripMenuItem.Name = "addNewServiceToolStripMenuItem";
            addNewServiceToolStripMenuItem.Size = new Size(180, 22);
            addNewServiceToolStripMenuItem.Text = "Add New Service";
            addNewServiceToolStripMenuItem.Click += addNewServiceToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ServicesGrid);
            Controls.Add(label3);
            Controls.Add(ServiceTypeGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(locationGrid);
            Controls.Add(mainMenu);
            MainMenuStrip = mainMenu;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)locationGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ServiceTypeGrid).EndInit();
            mainMenu.ResumeLayout(false);
            mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ServicesGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView locationGrid;
        private Label label1;
        private Label label2;
        private DataGridView ServiceTypeGrid;
        private MenuStrip mainMenu;
        private ToolStripMenuItem adminAToolStripMenuItem;
        private ToolStripMenuItem addLocationsToolStripMenuItem;
        private ToolStripMenuItem addServicesToolStripMenuItem;
        private ToolStripMenuItem userActionsToolStripMenuItem;
        private ToolStripMenuItem bookTicketToolStripMenuItem;
        private Label label3;
        private DataGridView ServicesGrid;
        private ToolStripMenuItem addNewServiceToolStripMenuItem;
    }
}
