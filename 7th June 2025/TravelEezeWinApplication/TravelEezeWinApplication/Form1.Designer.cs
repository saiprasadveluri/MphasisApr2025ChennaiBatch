namespace TravelEezeWinApplication
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
            deleteToolStripMenuItem = new ToolStripMenuItem();
            locationBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            serviceTypeGrid = new DataGridView();
            serviceTypeBindingSource = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            adminActionsToolStripMenuItem = new ToolStripMenuItem();
            addLocationToolStripMenuItem = new ToolStripMenuItem();
            addServiceToolStripMenuItem = new ToolStripMenuItem();
            addNewServiceToolStripMenuItem = new ToolStripMenuItem();
            deleteLocationToolStripMenuItem = new ToolStripMenuItem();
            deleteServiceTypeToolStripMenuItem = new ToolStripMenuItem();
            deleteServiceToolStripMenuItem = new ToolStripMenuItem();
            userActionsToolStripMenuItem = new ToolStripMenuItem();
            serviceListGrid = new DataGridView();
            serviceList = new Label();
            ((System.ComponentModel.ISupportInitialize)locationGrid).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)locationBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serviceTypeGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)serviceTypeBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)serviceListGrid).BeginInit();
            SuspendLayout();
            // 
            // locationGrid
            // 
            locationGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            locationGrid.ContextMenuStrip = contextMenuStrip1;
            locationGrid.Location = new Point(36, 57);
            locationGrid.Name = "locationGrid";
            locationGrid.Size = new Size(348, 113);
            locationGrid.TabIndex = 0;
            locationGrid.CellContentClick += locationGrid_CellContentClick;
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
            // locationBindingSource
            // 
            locationBindingSource.DataSource = typeof(Location);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 33);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 1;
            label1.Text = "Locations";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 210);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 2;
            label2.Text = "Service Types";
            label2.Click += label2_Click;
            // 
            // serviceTypeGrid
            // 
            serviceTypeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            serviceTypeGrid.Location = new Point(36, 234);
            serviceTypeGrid.Name = "serviceTypeGrid";
            serviceTypeGrid.Size = new Size(348, 128);
            serviceTypeGrid.TabIndex = 3;
            // 
            // serviceTypeBindingSource
            // 
            serviceTypeBindingSource.DataSource = typeof(ServiceType);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminActionsToolStripMenuItem, userActionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // adminActionsToolStripMenuItem
            // 
            adminActionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addLocationToolStripMenuItem, addServiceToolStripMenuItem, addNewServiceToolStripMenuItem, deleteLocationToolStripMenuItem, deleteServiceTypeToolStripMenuItem, deleteServiceToolStripMenuItem });
            adminActionsToolStripMenuItem.Name = "adminActionsToolStripMenuItem";
            adminActionsToolStripMenuItem.Size = new Size(98, 20);
            adminActionsToolStripMenuItem.Text = "Admin Actions";
            // 
            // addLocationToolStripMenuItem
            // 
            addLocationToolStripMenuItem.Name = "addLocationToolStripMenuItem";
            addLocationToolStripMenuItem.Size = new Size(174, 22);
            addLocationToolStripMenuItem.Text = "Add Location";
            addLocationToolStripMenuItem.Click += addLocationToolStripMenuItem_Click;
            // 
            // addServiceToolStripMenuItem
            // 
            addServiceToolStripMenuItem.Name = "addServiceToolStripMenuItem";
            addServiceToolStripMenuItem.Size = new Size(174, 22);
            addServiceToolStripMenuItem.Text = "Add Service Type";
            addServiceToolStripMenuItem.Click += addServiceToolStripMenuItem_Click;
            // 
            // addNewServiceToolStripMenuItem
            // 
            addNewServiceToolStripMenuItem.Name = "addNewServiceToolStripMenuItem";
            addNewServiceToolStripMenuItem.Size = new Size(174, 22);
            addNewServiceToolStripMenuItem.Text = "Add New Service";
            addNewServiceToolStripMenuItem.Click += addNewServiceToolStripMenuItem_Click;
            // 
            // deleteLocationToolStripMenuItem
            // 
            deleteLocationToolStripMenuItem.Name = "deleteLocationToolStripMenuItem";
            deleteLocationToolStripMenuItem.Size = new Size(174, 22);
            deleteLocationToolStripMenuItem.Text = "Delete Location";
            deleteLocationToolStripMenuItem.Click += deleteLocationToolStripMenuItem_Click;
            // 
            // deleteServiceTypeToolStripMenuItem
            // 
            deleteServiceTypeToolStripMenuItem.Name = "deleteServiceTypeToolStripMenuItem";
            deleteServiceTypeToolStripMenuItem.Size = new Size(174, 22);
            deleteServiceTypeToolStripMenuItem.Text = "Delete Service Type";
            // 
            // deleteServiceToolStripMenuItem
            // 
            deleteServiceToolStripMenuItem.Name = "deleteServiceToolStripMenuItem";
            deleteServiceToolStripMenuItem.Size = new Size(174, 22);
            deleteServiceToolStripMenuItem.Text = "Delete Service";
            // 
            // userActionsToolStripMenuItem
            // 
            userActionsToolStripMenuItem.Name = "userActionsToolStripMenuItem";
            userActionsToolStripMenuItem.Size = new Size(85, 20);
            userActionsToolStripMenuItem.Text = "User Actions";
            // 
            // serviceListGrid
            // 
            serviceListGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            serviceListGrid.Location = new Point(427, 57);
            serviceListGrid.Name = "serviceListGrid";
            serviceListGrid.ReadOnly = true;
            serviceListGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            serviceListGrid.Size = new Size(353, 249);
            serviceListGrid.TabIndex = 5;
            serviceListGrid.CellContentClick += serviceListGrid_CellContentClick;
            // 
            // serviceList
            // 
            serviceList.AutoSize = true;
            serviceList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            serviceList.Location = new Point(427, 33);
            serviceList.Name = "serviceList";
            serviceList.Size = new Size(96, 21);
            serviceList.TabIndex = 6;
            serviceList.Text = "Service List";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(serviceList);
            Controls.Add(serviceListGrid);
            Controls.Add(serviceTypeGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(locationGrid);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Admin Dashboard";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)locationGrid).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)locationBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)serviceTypeGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)serviceTypeBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)serviceListGrid).EndInit();
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
        private ToolStripMenuItem addLocationToolStripMenuItem;
        private ToolStripMenuItem addServiceToolStripMenuItem;
        private ToolStripMenuItem userActionsToolStripMenuItem;
        private DataGridViewTextBoxColumn locationIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationDescriptionDataGridViewTextBoxColumn;
        private BindingSource locationBindingSource;
        private DataGridView serviceListGrid;
        private DataGridViewTextBoxColumn sTypeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn serviceTypeNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pricePerKmDataGridViewTextBoxColumn;
        private BindingSource serviceTypeBindingSource;
        private Label serviceList;
        private ToolStripMenuItem addNewServiceToolStripMenuItem;
        private ToolStripMenuItem deleteLocationToolStripMenuItem;
        private ToolStripMenuItem deleteServiceTypeToolStripMenuItem;
        private ToolStripMenuItem deleteServiceToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}
