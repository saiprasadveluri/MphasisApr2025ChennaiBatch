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
            locationGrid = new DataGridView();
            label1 = new Label();
            servicetypeGrid = new DataGridView();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            adminActionsToolStripMenuItem = new ToolStripMenuItem();
            addLoactionToolStripMenuItem = new ToolStripMenuItem();
            addServicesToolStripMenuItem = new ToolStripMenuItem();
            addNewServiceToolStripMenuItem = new ToolStripMenuItem();
            userActionsToolStripMenuItem = new ToolStripMenuItem();
            servicesGrid = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)locationGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)servicetypeGrid).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)servicesGrid).BeginInit();
            SuspendLayout();
            // 
            // locationGrid
            // 
            locationGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            locationGrid.Location = new Point(42, 41);
            locationGrid.Name = "locationGrid";
            locationGrid.Size = new Size(465, 192);
            locationGrid.TabIndex = 0;
            locationGrid.CellContentClick += locationGrid_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(42, 21);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 1;
            label1.Text = "Locations";
            // 
            // servicetypeGrid
            // 
            servicetypeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            servicetypeGrid.Location = new Point(42, 292);
            servicetypeGrid.Name = "servicetypeGrid";
            servicetypeGrid.Size = new Size(465, 186);
            servicetypeGrid.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 272);
            label2.Name = "label2";
            label2.Size = new Size(91, 17);
            label2.TabIndex = 3;
            label2.Text = "Service Types";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminActionsToolStripMenuItem, userActionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1142, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminActionsToolStripMenuItem
            // 
            adminActionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addLoactionToolStripMenuItem, addServicesToolStripMenuItem, addNewServiceToolStripMenuItem });
            adminActionsToolStripMenuItem.Name = "adminActionsToolStripMenuItem";
            adminActionsToolStripMenuItem.Size = new Size(98, 20);
            adminActionsToolStripMenuItem.Text = "Admin Actions";
            adminActionsToolStripMenuItem.Click += adminActionsToolStripMenuItem_Click;
            // 
            // addLoactionToolStripMenuItem
            // 
            addLoactionToolStripMenuItem.Name = "addLoactionToolStripMenuItem";
            addLoactionToolStripMenuItem.Size = new Size(180, 22);
            addLoactionToolStripMenuItem.Text = "Add Loaction";
            addLoactionToolStripMenuItem.Click += addLoactionToolStripMenuItem_Click;
            // 
            // addServicesToolStripMenuItem
            // 
            addServicesToolStripMenuItem.Name = "addServicesToolStripMenuItem";
            addServicesToolStripMenuItem.Size = new Size(180, 22);
            addServicesToolStripMenuItem.Text = "Add Services";
            addServicesToolStripMenuItem.Click += addServicesToolStripMenuItem_Click;
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
            userActionsToolStripMenuItem.Name = "userActionsToolStripMenuItem";
            userActionsToolStripMenuItem.Size = new Size(85, 20);
            userActionsToolStripMenuItem.Text = "User Actions";
            // 
            // servicesGrid
            // 
            servicesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            servicesGrid.Location = new Point(592, 61);
            servicesGrid.Name = "servicesGrid";
            servicesGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            servicesGrid.Size = new Size(465, 386);
            servicesGrid.TabIndex = 0;
            servicesGrid.CellContentClick += servicesGrid_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(592, 41);
            label3.Name = "label3";
            label3.Size = new Size(82, 17);
            label3.TabIndex = 1;
            label3.Text = "Service List ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 653);
            Controls.Add(label2);
            Controls.Add(servicetypeGrid);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(servicesGrid);
            Controls.Add(locationGrid);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)locationGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)servicetypeGrid).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)servicesGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView locationGrid;
        private Label label1;
        private DataGridView servicetypeGrid;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminActionsToolStripMenuItem;
        private ToolStripMenuItem addLoactionToolStripMenuItem;
        private ToolStripMenuItem addServicesToolStripMenuItem;
        private ToolStripMenuItem userActionsToolStripMenuItem;
        private DataGridView servicesGrid;
        private Label label3;
        private ToolStripMenuItem addNewServiceToolStripMenuItem;
    }
}
