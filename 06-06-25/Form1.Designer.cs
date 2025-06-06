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
            ServiceTypeGrid = new DataGridView();
            label2 = new Label();
            menuStrip1 = new MenuStrip();
            adminActionsToolStripMenuItem = new ToolStripMenuItem();
            addLocationsToolStripMenuItem = new ToolStripMenuItem();
            addServicesToolStripMenuItem = new ToolStripMenuItem();
            addNewServiceToolStripMenuItem = new ToolStripMenuItem();
            userActionsToolStripMenuItem = new ToolStripMenuItem();
            bookToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            ServicesGrid = new DataGridView();
            label4 = new Label();
            bookingGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)locationGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ServiceTypeGrid).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ServicesGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bookingGrid).BeginInit();
            SuspendLayout();
            // 
            // locationGrid
            // 
            locationGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            locationGrid.Location = new Point(59, 55);
            locationGrid.Name = "locationGrid";
            locationGrid.Size = new Size(211, 123);
            locationGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 21);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Locations";
            // 
            // ServiceTypeGrid
            // 
            ServiceTypeGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServiceTypeGrid.Location = new Point(59, 248);
            ServiceTypeGrid.Name = "ServiceTypeGrid";
            ServiceTypeGrid.Size = new Size(132, 97);
            ServiceTypeGrid.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 210);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 3;
            label2.Text = "Sevice Types";
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
            adminActionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addLocationsToolStripMenuItem, addServicesToolStripMenuItem, addNewServiceToolStripMenuItem });
            adminActionsToolStripMenuItem.Name = "adminActionsToolStripMenuItem";
            adminActionsToolStripMenuItem.Size = new Size(96, 20);
            adminActionsToolStripMenuItem.Text = "Admin actions";
            // 
            // addLocationsToolStripMenuItem
            // 
            addLocationsToolStripMenuItem.Name = "addLocationsToolStripMenuItem";
            addLocationsToolStripMenuItem.Size = new Size(160, 22);
            addLocationsToolStripMenuItem.Text = "Add Locations";
            // 
            // addServicesToolStripMenuItem
            // 
            addServicesToolStripMenuItem.Name = "addServicesToolStripMenuItem";
            addServicesToolStripMenuItem.Size = new Size(160, 22);
            addServicesToolStripMenuItem.Text = "Add Services";
            // 
            // addNewServiceToolStripMenuItem
            // 
            addNewServiceToolStripMenuItem.Name = "addNewServiceToolStripMenuItem";
            addNewServiceToolStripMenuItem.Size = new Size(160, 22);
            addNewServiceToolStripMenuItem.Text = "Add NewService";
            addNewServiceToolStripMenuItem.Click += addNewServiceToolStripMenuItem_Click;
            // 
            // userActionsToolStripMenuItem
            // 
            userActionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookToolStripMenuItem });
            userActionsToolStripMenuItem.Name = "userActionsToolStripMenuItem";
            userActionsToolStripMenuItem.Size = new Size(83, 20);
            userActionsToolStripMenuItem.Text = "User actions";
            // 
            // bookToolStripMenuItem
            // 
            bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            bookToolStripMenuItem.Size = new Size(101, 22);
            bookToolStripMenuItem.Text = "Book";
            bookToolStripMenuItem.Click += bookToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(419, 64);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // ServicesGrid
            // 
            ServicesGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ServicesGrid.Location = new Point(515, 21);
            ServicesGrid.Name = "ServicesGrid";
            ServicesGrid.Size = new Size(240, 150);
            ServicesGrid.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(419, 210);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // bookingGrid
            // 
            bookingGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookingGrid.Location = new Point(515, 186);
            bookingGrid.Name = "bookingGrid";
            bookingGrid.Size = new Size(240, 150);
            bookingGrid.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bookingGrid);
            Controls.Add(label4);
            Controls.Add(ServicesGrid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ServiceTypeGrid);
            Controls.Add(label1);
            Controls.Add(locationGrid);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)locationGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)ServiceTypeGrid).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ServicesGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)bookingGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView locationGrid;
        private Label label1;
        private DataGridView ServiceTypeGrid;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminActionsToolStripMenuItem;
        private ToolStripMenuItem addLocationsToolStripMenuItem;
        private ToolStripMenuItem addServicesToolStripMenuItem;
        private ToolStripMenuItem userActionsToolStripMenuItem;
        private ToolStripMenuItem addNewServiceToolStripMenuItem;
        private Label label3;
        private DataGridView ServicesGrid;
        private Label label4;
        private DataGridView bookingGrid;
        private ToolStripMenuItem bookToolStripMenuItem;
    }
}
