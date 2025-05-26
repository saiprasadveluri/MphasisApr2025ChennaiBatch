namespace Food_App
{
    partial class Card_Summary
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
            this.dgvCartItems = new System.Windows.Forms.DataGridView();
            this.lblCoupon = new System.Windows.Forms.Label();
            this.txtCoupon = new System.Windows.Forms.TextBox();
            this.btnApplyCoupon = new System.Windows.Forms.Button();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCartItems
            // 
            this.dgvCartItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartItems.Location = new System.Drawing.Point(234, 125);
            this.dgvCartItems.Name = "dgvCartItems";
            this.dgvCartItems.Size = new System.Drawing.Size(240, 150);
            this.dgvCartItems.TabIndex = 0;
            // 
            // lblCoupon
            // 
            this.lblCoupon.AutoSize = true;
            this.lblCoupon.Location = new System.Drawing.Point(261, 71);
            this.lblCoupon.Name = "lblCoupon";
            this.lblCoupon.Size = new System.Drawing.Size(44, 13);
            this.lblCoupon.TabIndex = 1;
            this.lblCoupon.Text = "Coupon";
            // 
            // txtCoupon
            // 
            this.txtCoupon.Location = new System.Drawing.Point(341, 68);
            this.txtCoupon.Name = "txtCoupon";
            this.txtCoupon.Size = new System.Drawing.Size(100, 20);
            this.txtCoupon.TabIndex = 2;
            // 
            // btnApplyCoupon
            // 
            this.btnApplyCoupon.Location = new System.Drawing.Point(234, 293);
            this.btnApplyCoupon.Name = "btnApplyCoupon";
            this.btnApplyCoupon.Size = new System.Drawing.Size(75, 23);
            this.btnApplyCoupon.TabIndex = 3;
            this.btnApplyCoupon.Text = "Apply Coupon";
            this.btnApplyCoupon.UseVisualStyleBackColor = true;
            this.btnApplyCoupon.Click += new System.EventHandler(this.btnApplyCoupon_Click);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.Location = new System.Drawing.Point(391, 292);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmOrder.TabIndex = 4;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = true;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(319, 339);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(63, 13);
            this.lblGrandTotal.TabIndex = 5;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // Card_Summary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.btnApplyCoupon);
            this.Controls.Add(this.txtCoupon);
            this.Controls.Add(this.lblCoupon);
            this.Controls.Add(this.dgvCartItems);
            this.Name = "Card_Summary";
            this.Text = "Card_Summary";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCartItems;
        private System.Windows.Forms.Label lblCoupon;
        private System.Windows.Forms.TextBox txtCoupon;
        private System.Windows.Forms.Button btnApplyCoupon;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Label lblGrandTotal;
    }
}