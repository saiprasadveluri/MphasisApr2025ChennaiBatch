namespace TravelEfForm
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
            dataGridLocation = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridLocation).BeginInit();
            SuspendLayout();
            // 
            // dataGridLocation
            // 
            dataGridLocation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLocation.Location = new Point(78, 54);
            dataGridLocation.Name = "dataGridLocation";
            dataGridLocation.Size = new Size(240, 150);
            dataGridLocation.TabIndex = 0;
            dataGridLocation.CellContentClick += dataGridLocation_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridLocation);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridLocation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridLocation;
    }
}
