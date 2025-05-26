namespace FoodDeliveryAggregateApp
{
    partial class CustomerDashboard
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
            this.CustomerOrderGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerOrderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerOrderGrid
            // 
            this.CustomerOrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerOrderGrid.Location = new System.Drawing.Point(42, 63);
            this.CustomerOrderGrid.Name = "CustomerOrderGrid";
            this.CustomerOrderGrid.Size = new System.Drawing.Size(242, 124);
            this.CustomerOrderGrid.TabIndex = 1;
            // 
            // CustomerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerOrderGrid);
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.CustomerOrderGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerOrderGrid;
    }
}