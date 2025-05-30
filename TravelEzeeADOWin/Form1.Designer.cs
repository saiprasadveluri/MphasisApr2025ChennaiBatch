namespace TravelEzeeADOWin
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
            menuStrip1 = new MenuStrip();
            adminActionsToolStripMenuItem = new ToolStripMenuItem();
            manageLocationsToolStripMenuItem = new ToolStripMenuItem();
            bookingToolStripMenuItem = new ToolStripMenuItem();
            bookTicketToolStripMenuItem = new ToolStripMenuItem();
            showBookingsToolStripMenuItem = new ToolStripMenuItem();
            addServiceTypesToolStripMenuItem = new ToolStripMenuItem();
            addServicesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminActionsToolStripMenuItem, bookingToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminActionsToolStripMenuItem
            // 
            adminActionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageLocationsToolStripMenuItem, addServiceTypesToolStripMenuItem, addServicesToolStripMenuItem });
            adminActionsToolStripMenuItem.Name = "adminActionsToolStripMenuItem";
            adminActionsToolStripMenuItem.Size = new Size(95, 20);
            adminActionsToolStripMenuItem.Text = "AdminActions";
            // 
            // manageLocationsToolStripMenuItem
            // 
            manageLocationsToolStripMenuItem.Name = "manageLocationsToolStripMenuItem";
            manageLocationsToolStripMenuItem.Size = new Size(180, 22);
            manageLocationsToolStripMenuItem.Text = "Manage Locations";
            manageLocationsToolStripMenuItem.Click += manageLocationsToolStripMenuItem_Click;
            // 
            // bookingToolStripMenuItem
            // 
            bookingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookTicketToolStripMenuItem, showBookingsToolStripMenuItem });
            bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            bookingToolStripMenuItem.Size = new Size(63, 20);
            bookingToolStripMenuItem.Text = "Booking";
            // 
            // bookTicketToolStripMenuItem
            // 
            bookTicketToolStripMenuItem.Name = "bookTicketToolStripMenuItem";
            bookTicketToolStripMenuItem.Size = new Size(155, 22);
            bookTicketToolStripMenuItem.Text = "Book Ticket";
            // 
            // showBookingsToolStripMenuItem
            // 
            showBookingsToolStripMenuItem.Name = "showBookingsToolStripMenuItem";
            showBookingsToolStripMenuItem.Size = new Size(155, 22);
            showBookingsToolStripMenuItem.Text = "Show Bookings";
            // 
            // addServiceTypesToolStripMenuItem
            // 
            addServiceTypesToolStripMenuItem.Name = "addServiceTypesToolStripMenuItem";
            addServiceTypesToolStripMenuItem.Size = new Size(189, 22);
            addServiceTypesToolStripMenuItem.Text = "Manage Service Types";
            addServiceTypesToolStripMenuItem.Click += addServiceTypesToolStripMenuItem_Click;
            // 
            // addServicesToolStripMenuItem
            // 
            addServicesToolStripMenuItem.Name = "addServicesToolStripMenuItem";
            addServicesToolStripMenuItem.Size = new Size(189, 22);
            addServicesToolStripMenuItem.Text = "Manage Services";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminActionsToolStripMenuItem;
        private ToolStripMenuItem manageLocationsToolStripMenuItem;
        private ToolStripMenuItem bookingToolStripMenuItem;
        private ToolStripMenuItem bookTicketToolStripMenuItem;
        private ToolStripMenuItem showBookingsToolStripMenuItem;
        private ToolStripMenuItem addServiceTypesToolStripMenuItem;
        private ToolStripMenuItem addServicesToolStripMenuItem;
    }
}
