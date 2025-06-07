namespace EzeeTravelWinUI
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
           //     components.Dispose();
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
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteLocationToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            serviceTypeGrid = new DataGridView();
            menuStrip1 = new MenuStrip();
            adminActionsToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            addServiceTypeToolStripMenuItem = new ToolStripMenuItem();
            addNewServiceToolStripMenuItem = new ToolStripMenuItem();
            userActionsToolStripMenuItem = new ToolStripMenuItem();
            bookTicketToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            servicesGrid = new DataGridView();
            contextMenuStrip2 = new ContextMenuStrip(components);
            deleteServiceToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip3 = new ContextMenuStrip(components);
            deleteServiceTypeToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)locationGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)serviceTypeGrid).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)servicesGrid).BeginInit();
            contextMenuStrip2.SuspendLayout();
            contextMenuStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // locationGrid
            // 
            locationGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            locationGrid.Location = new Point(154, 58);
            locationGrid.Name = "locationGrid";
            locationGrid.Size = new Size(240, 150);
            locationGrid.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(12, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(288, 150);
            dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteLocationToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(154, 26);
            // 
            // deleteLocationToolStripMenuItem
            // 
            deleteLocationToolStripMenuItem.Name = "deleteLocationToolStripMenuItem";
            deleteLocationToolStripMenuItem.Size = new Size(153, 22);
            deleteLocationToolStripMenuItem.Text = "DeleteLocation";
            deleteLocationToolStripMenuItem.Click += deleteLocationToolStripMenuItem_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 34);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Locations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 216);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 2;
            label2.Text = "ServiceTypes";
            // 
            // serviceTypeGrid
            // 
            serviceTypeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            serviceTypeGrid.ContextMenuStrip = contextMenuStrip2;
            serviceTypeGrid.Location = new Point(35, 246);
            serviceTypeGrid.Name = "serviceTypeGrid";
            serviceTypeGrid.Size = new Size(244, 150);
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
            adminActionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addToolStripMenuItem, addServiceTypeToolStripMenuItem, addNewServiceToolStripMenuItem });
            adminActionsToolStripMenuItem.Name = "adminActionsToolStripMenuItem";
            adminActionsToolStripMenuItem.Size = new Size(98, 20);
            adminActionsToolStripMenuItem.Text = "Admin Actions";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(180, 22);
            addToolStripMenuItem.Text = "Add  Locations";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // addServiceTypeToolStripMenuItem
            // 
            addServiceTypeToolStripMenuItem.Name = "addServiceTypeToolStripMenuItem";
            addServiceTypeToolStripMenuItem.Size = new Size(180, 22);
            addServiceTypeToolStripMenuItem.Text = "Add ServiceType";
            addServiceTypeToolStripMenuItem.Click += addServiceTypeToolStripMenuItem_Click;
            // 
            // addNewServiceToolStripMenuItem
            // 
            addNewServiceToolStripMenuItem.Name = "addNewServiceToolStripMenuItem";
            addNewServiceToolStripMenuItem.Size = new Size(180, 22);
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
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(405, 34);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 5;
            label3.Text = "ServiceList";
            // 
            // servicesGrid
            // 
            servicesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            servicesGrid.ContextMenuStrip = contextMenuStrip2;
            servicesGrid.Location = new Point(417, 67);
            servicesGrid.MultiSelect = false;
            servicesGrid.Name = "servicesGrid";
            servicesGrid.ReadOnly = true;
            servicesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            servicesGrid.Size = new Size(240, 150);
            servicesGrid.TabIndex = 6;
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
            deleteServiceToolStripMenuItem.Size = new Size(180, 22);
            deleteServiceToolStripMenuItem.Text = "Delete Service";
            deleteServiceToolStripMenuItem.Click += deleteServiceToolStripMenuItem_Click;
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { deleteServiceTypeToolStripMenuItem });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(181, 48);
            // 
            // deleteServiceTypeToolStripMenuItem
            // 
            deleteServiceTypeToolStripMenuItem.Name = "deleteServiceTypeToolStripMenuItem";
            deleteServiceTypeToolStripMenuItem.Size = new Size(180, 22);
            deleteServiceTypeToolStripMenuItem.Text = "Delete ServiceType";
            deleteServiceTypeToolStripMenuItem.Click += deleteServiceTypeToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(servicesGrid);
            Controls.Add(label3);
            Controls.Add(serviceTypeGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)locationGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)serviceTypeGrid).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)servicesGrid).EndInit();
            contextMenuStrip2.ResumeLayout(false);
            contextMenuStrip3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView locationGrid;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private DataGridView serviceTypeGrid;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminActionsToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem addServiceTypeToolStripMenuItem;
        private ToolStripMenuItem userActionsToolStripMenuItem;
        private ToolStripMenuItem bookTicketToolStripMenuItem;
        private Label label3;
        private DataGridView servicesGrid;
        private ToolStripMenuItem addNewServiceToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteLocationToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem deleteServiceToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem deleteServiceTypeToolStripMenuItem;
    }
}
