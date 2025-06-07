namespace TravelEzeeWinUI
{
    partial class DeleteLocation
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
            DeleteLocgrid = new GroupBox();
            SuspendLayout();
            // 
            // DeleteLocgrid
            // 
            DeleteLocgrid.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteLocgrid.Location = new Point(12, 12);
            DeleteLocgrid.Name = "DeleteLocgrid";
            DeleteLocgrid.Size = new Size(815, 460);
            DeleteLocgrid.TabIndex = 0;
            DeleteLocgrid.TabStop = false;
            DeleteLocgrid.Text = "Delete Location";
            // 
            // DeleteLocation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 484);
            Controls.Add(DeleteLocgrid);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteLocation";
            Text = "DeleteLocation";
            ResumeLayout(false);
        }

        #endregion

        private GroupBox DeleteLocgrid;
    }
}