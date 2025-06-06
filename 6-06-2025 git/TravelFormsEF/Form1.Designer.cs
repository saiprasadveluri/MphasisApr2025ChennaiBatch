namespace TravelFormsEF
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
            GridLocations = new DataGridView();
            menuStrip1 = new MenuStrip();
            adminActionsToolStripMenuItem = new ToolStripMenuItem();
            addLocationToolStripMenuItem = new ToolStripMenuItem();
            addServiceTypeToolStripMenuItem = new ToolStripMenuItem();
            addServiceToolStripMenuItem = new ToolStripMenuItem();
            userActionsToolStripMenuItem = new ToolStripMenuItem();
            bookTicketToolStripMenuItem = new ToolStripMenuItem();
            GridServiceType = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            GridServices = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)GridLocations).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridServiceType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridServices).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // GridLocations
            // 
            GridLocations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridLocations.ContextMenuStrip = contextMenuStrip1;
            GridLocations.Location = new Point(20, 76);
            GridLocations.Name = "GridLocations";
            GridLocations.Size = new Size(359, 150);
            GridLocations.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminActionsToolStripMenuItem, userActionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminActionsToolStripMenuItem
            // 
            adminActionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addLocationToolStripMenuItem, addServiceTypeToolStripMenuItem, addServiceToolStripMenuItem });
            adminActionsToolStripMenuItem.Name = "adminActionsToolStripMenuItem";
            adminActionsToolStripMenuItem.Size = new Size(98, 20);
            adminActionsToolStripMenuItem.Text = "Admin Actions";
            // 
            // addLocationToolStripMenuItem
            // 
            addLocationToolStripMenuItem.Name = "addLocationToolStripMenuItem";
            addLocationToolStripMenuItem.Size = new Size(160, 22);
            addLocationToolStripMenuItem.Text = "Add Location";
            addLocationToolStripMenuItem.Click += addLocationToolStripMenuItem_Click;
            // 
            // addServiceTypeToolStripMenuItem
            // 
            addServiceTypeToolStripMenuItem.Name = "addServiceTypeToolStripMenuItem";
            addServiceTypeToolStripMenuItem.Size = new Size(160, 22);
            addServiceTypeToolStripMenuItem.Text = "AddService Type";
            addServiceTypeToolStripMenuItem.Click += addServiceTypeToolStripMenuItem_Click;
            // 
            // addServiceToolStripMenuItem
            // 
            addServiceToolStripMenuItem.Name = "addServiceToolStripMenuItem";
            addServiceToolStripMenuItem.Size = new Size(160, 22);
            addServiceToolStripMenuItem.Text = "Add Service";
            addServiceToolStripMenuItem.Click += addServiceToolStripMenuItem_Click;
            // 
            // userActionsToolStripMenuItem
            // 
            userActionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookTicketToolStripMenuItem });
            userActionsToolStripMenuItem.Name = "userActionsToolStripMenuItem";
            userActionsToolStripMenuItem.Size = new Size(82, 20);
            userActionsToolStripMenuItem.Text = "UserActions";
            // 
            // bookTicketToolStripMenuItem
            // 
            bookTicketToolStripMenuItem.Name = "bookTicketToolStripMenuItem";
            bookTicketToolStripMenuItem.Size = new Size(135, 22);
            bookTicketToolStripMenuItem.Text = "Book Ticket";
            // 
            // GridServiceType
            // 
            GridServiceType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridServiceType.Location = new Point(20, 278);
            GridServiceType.Name = "GridServiceType";
            GridServiceType.Size = new Size(359, 150);
            GridServiceType.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 246);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
            label1.TabIndex = 3;
            label1.Text = "ServiceTypes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 47);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "Locations";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(420, 47);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 5;
            label3.Text = "Services";
            // 
            // GridServices
            // 
            GridServices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridServices.Location = new Point(420, 76);
            GridServices.MultiSelect = false;
            GridServices.Name = "GridServices";
            GridServices.ReadOnly = true;
            GridServices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridServices.Size = new Size(343, 166);
            GridServices.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GridServices);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(GridServiceType);
            Controls.Add(GridLocations);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)GridLocations).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridServiceType).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridServices).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GridLocations;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminActionsToolStripMenuItem;
        private ToolStripMenuItem addLocationToolStripMenuItem;
        private ToolStripMenuItem addServiceTypeToolStripMenuItem;
        private ToolStripMenuItem userActionsToolStripMenuItem;
        private ToolStripMenuItem bookTicketToolStripMenuItem;
        private DataGridView GridServiceType;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView GridServices;
        private ToolStripMenuItem addServiceToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
