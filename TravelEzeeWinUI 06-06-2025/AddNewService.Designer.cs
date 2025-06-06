namespace TravelEzeeWinUI2
{
    partial class AddNewService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddNewServiceDialog = new GroupBox();
            btnAddNewService = new Button();
            numDistance = new NumericUpDown();
            cmbDestinationLocation = new ComboBox();
            cmbSourceLocation = new ComboBox();
            cmbServiceType = new ComboBox();
            txtDistance = new Label();
            txtDestination = new Label();
            txtSource = new Label();
            txtService = new Label();
            AddNewServiceDialog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDistance).BeginInit();
            SuspendLayout();
            // 
            // AddNewServiceDialog
            // 
            AddNewServiceDialog.Controls.Add(btnAddNewService);
            AddNewServiceDialog.Controls.Add(numDistance);
            AddNewServiceDialog.Controls.Add(cmbDestinationLocation);
            AddNewServiceDialog.Controls.Add(cmbSourceLocation);
            AddNewServiceDialog.Controls.Add(cmbServiceType);
            AddNewServiceDialog.Controls.Add(txtDistance);
            AddNewServiceDialog.Controls.Add(txtDestination);
            AddNewServiceDialog.Controls.Add(txtSource);
            AddNewServiceDialog.Controls.Add(txtService);
            AddNewServiceDialog.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddNewServiceDialog.Location = new Point(129, 39);
            AddNewServiceDialog.Name = "AddNewServiceDialog";
            AddNewServiceDialog.Size = new Size(593, 276);
            AddNewServiceDialog.TabIndex = 0;
            AddNewServiceDialog.TabStop = false;
            AddNewServiceDialog.Text = "Add New Service";
            // 
            // btnAddNewService
            // 
            btnAddNewService.Location = new Point(268, 208);
            btnAddNewService.Name = "btnAddNewService";
            btnAddNewService.Size = new Size(224, 42);
            btnAddNewService.TabIndex = 8;
            btnAddNewService.Text = "Add New Service";
            btnAddNewService.UseVisualStyleBackColor = true;
            btnAddNewService.Click += btnAddNewService_Click;
            // 
            // numDistance
            // 
            numDistance.Location = new Point(241, 167);
            numDistance.Name = "numDistance";
            numDistance.Size = new Size(312, 29);
            numDistance.TabIndex = 7;
            // 
            // cmbDestinationLocation
            // 
            cmbDestinationLocation.FormattingEnabled = true;
            cmbDestinationLocation.Location = new Point(241, 123);
            cmbDestinationLocation.Name = "cmbDestinationLocation";
            cmbDestinationLocation.Size = new Size(312, 29);
            cmbDestinationLocation.TabIndex = 6;
            // 
            // cmbSourceLocation
            // 
            cmbSourceLocation.FormattingEnabled = true;
            cmbSourceLocation.Location = new Point(241, 80);
            cmbSourceLocation.Name = "cmbSourceLocation";
            cmbSourceLocation.Size = new Size(312, 29);
            cmbSourceLocation.TabIndex = 5;
            // 
            // cmbServiceType
            // 
            cmbServiceType.FormattingEnabled = true;
            cmbServiceType.Location = new Point(241, 36);
            cmbServiceType.Name = "cmbServiceType";
            cmbServiceType.Size = new Size(312, 29);
            cmbServiceType.TabIndex = 4;
            // 
            // txtDistance
            // 
            txtDistance.AutoSize = true;
            txtDistance.Location = new Point(88, 167);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(76, 21);
            txtDistance.TabIndex = 3;
            txtDistance.Text = "Distance";
            // 
            // txtDestination
            // 
            txtDestination.AutoSize = true;
            txtDestination.Location = new Point(88, 123);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(99, 21);
            txtDestination.TabIndex = 2;
            txtDestination.Text = "Destination";
            // 
            // txtSource
            // 
            txtSource.AutoSize = true;
            txtSource.Location = new Point(88, 83);
            txtSource.Name = "txtSource";
            txtSource.Size = new Size(62, 21);
            txtSource.TabIndex = 1;
            txtSource.Text = "Source";
            // 
            // txtService
            // 
            txtService.AutoSize = true;
            txtService.Location = new Point(88, 39);
            txtService.Name = "txtService";
            txtService.Size = new Size(106, 21);
            txtService.TabIndex = 0;
            txtService.Text = "Service Type";
            // 
            // AddNewService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddNewServiceDialog);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddNewService";
            Text = "AddNewService";
            Load += AddNewService_Load;
            AddNewServiceDialog.ResumeLayout(false);
            AddNewServiceDialog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDistance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox AddNewServiceDialog;
        private NumericUpDown numDistance;
        private ComboBox cmbDestinationLocation;
        private ComboBox cmbSourceLocation;
        private ComboBox cmbServiceType;
        private Label txtDistance;
        private Label txtDestination;
        private Label txtSource;
        private Label txtService;
        private Button btnAddNewService;
    }
}