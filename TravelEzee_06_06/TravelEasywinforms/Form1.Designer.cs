namespace TravelEasywinforms
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            dataGridView3 = new DataGridView();
            menuStrip1 = new MenuStrip();
            adminActionToolStripMenuItem = new ToolStripMenuItem();
            addLocationToolStripMenuItem = new ToolStripMenuItem();
            addServiceTypeToolStripMenuItem = new ToolStripMenuItem();
            userAccessToolStripMenuItem = new ToolStripMenuItem();
            bookingToolStripMenuItem = new ToolStripMenuItem();
            addServiceToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2 = new MenuStrip();
            dataGridView4 = new DataGridView();
            label4 = new Label();
            deleteLocationToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(469, 150);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(114, 22);
            label1.TabIndex = 1;
            label1.Text = "Locations: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 220);
            label2.Name = "label2";
            label2.Size = new Size(143, 22);
            label2.TabIndex = 2;
            label2.Text = "Service Type: ";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 245);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(469, 150);
            dataGridView2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 410);
            label3.Name = "label3";
            label3.Size = new Size(92, 22);
            label3.TabIndex = 4;
            label3.Text = "Service: ";
            label3.Click += label3_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(12, 444);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(469, 150);
            dataGridView3.TabIndex = 5;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminActionToolStripMenuItem, addLocationToolStripMenuItem, addServiceTypeToolStripMenuItem, userAccessToolStripMenuItem, addServiceToolStripMenuItem });
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminActionToolStripMenuItem
            // 
            adminActionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { deleteLocationToolStripMenuItem });
            adminActionToolStripMenuItem.Name = "adminActionToolStripMenuItem";
            adminActionToolStripMenuItem.Size = new Size(93, 20);
            adminActionToolStripMenuItem.Text = "Admin Action";
            // 
            // addLocationToolStripMenuItem
            // 
            addLocationToolStripMenuItem.Name = "addLocationToolStripMenuItem";
            addLocationToolStripMenuItem.Size = new Size(90, 20);
            addLocationToolStripMenuItem.Text = "Add Location";
            addLocationToolStripMenuItem.Click += addLocationToolStripMenuItem_Click_1;
            // 
            // addServiceTypeToolStripMenuItem
            // 
            addServiceTypeToolStripMenuItem.Name = "addServiceTypeToolStripMenuItem";
            addServiceTypeToolStripMenuItem.Size = new Size(108, 20);
            addServiceTypeToolStripMenuItem.Text = "Add Service Type";
            addServiceTypeToolStripMenuItem.Click += addServiceTypeToolStripMenuItem_Click;
            // 
            // userAccessToolStripMenuItem
            // 
            userAccessToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookingToolStripMenuItem });
            userAccessToolStripMenuItem.Name = "userAccessToolStripMenuItem";
            userAccessToolStripMenuItem.Size = new Size(81, 20);
            userAccessToolStripMenuItem.Text = "User Access";
            // 
            // bookingToolStripMenuItem
            // 
            bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            bookingToolStripMenuItem.Size = new Size(180, 22);
            bookingToolStripMenuItem.Text = "Booking";
            bookingToolStripMenuItem.Click += bookingToolStripMenuItem_Click;
            // 
            // addServiceToolStripMenuItem
            // 
            addServiceToolStripMenuItem.Name = "addServiceToolStripMenuItem";
            addServiceToolStripMenuItem.Size = new Size(81, 20);
            addServiceToolStripMenuItem.Text = "Add Service";
            addServiceToolStripMenuItem.Click += addServiceToolStripMenuItem_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(800, 24);
            menuStrip2.TabIndex = 7;
            menuStrip2.Text = "menuStrip2";
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(12, 652);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.Size = new Size(469, 150);
            dataGridView4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 613);
            label4.Name = "label4";
            label4.Size = new Size(100, 22);
            label4.TabIndex = 9;
            label4.Text = "Booking: ";
            // 
            // deleteLocationToolStripMenuItem
            // 
            deleteLocationToolStripMenuItem.Name = "deleteLocationToolStripMenuItem";
            deleteLocationToolStripMenuItem.Size = new Size(180, 22);
            deleteLocationToolStripMenuItem.Text = "Delete Location";
            deleteLocationToolStripMenuItem.Click += deleteLocationToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 814);
            Controls.Add(label4);
            Controls.Add(dataGridView4);
            Controls.Add(dataGridView3);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView2;
        private Label label3;
        private DataGridView dataGridView3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminActionToolStripMenuItem;
        private ToolStripMenuItem addLocationToolStripMenuItem;
        private ToolStripMenuItem addServiceTypeToolStripMenuItem;
        private ToolStripMenuItem userAccessToolStripMenuItem;
        private ToolStripMenuItem bookingToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem addServiceToolStripMenuItem;
        private DataGridView dataGridView4;
        private Label label4;
        private ToolStripMenuItem deleteLocationToolStripMenuItem;
    }
}
