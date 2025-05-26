namespace Food_Del_Apps
{
    partial class OrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRestaurantName = new System.Windows.Forms.Label();
            this.lblMinOrderValue = new System.Windows.Forms.Label();
            this.grpFilterMenu = new System.Windows.Forms.GroupBox();
            this.btnFilterMenu = new System.Windows.Forms.Button();
            this.txtMenuItemSearch = new System.Windows.Forms.TextBox();
            this.lblSearchTerm = new System.Windows.Forms.Label();
            this.cmbDishType = new System.Windows.Forms.ComboBox();
            this.lblDishType = new System.Windows.Forms.Label();
            this.dgvMenuItems = new System.Windows.Forms.DataGridView();
            this.colMId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDishType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpAddToCart = new System.Windows.Forms.GroupBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.grpCart = new System.Windows.Forms.GroupBox();
            this.lblOrderMessage = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnApplyCoupon = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtCouponCode = new System.Windows.Forms.TextBox();
            this.lblCouponCode = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.dgvCartItems = new System.Windows.Forms.DataGridView();
            this.colCartDishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCartLineTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFilterMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).BeginInit();
            this.grpAddToCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.grpCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.AutoSize = true;
            this.lblRestaurantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurantName.Location = new System.Drawing.Point(12, 38);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(135, 20);
            this.lblRestaurantName.TabIndex = 0;
            this.lblRestaurantName.Text = "Restaurant Name";
            // 
            // lblMinOrderValue
            // 
            this.lblMinOrderValue.AutoSize = true;
            this.lblMinOrderValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinOrderValue.Location = new System.Drawing.Point(12, 81);
            this.lblMinOrderValue.Name = "lblMinOrderValue";
            this.lblMinOrderValue.Size = new System.Drawing.Size(78, 20);
            this.lblMinOrderValue.TabIndex = 1;
            this.lblMinOrderValue.Text = "Min Order";
            // 
            // grpFilterMenu
            // 
            this.grpFilterMenu.Controls.Add(this.btnFilterMenu);
            this.grpFilterMenu.Controls.Add(this.txtMenuItemSearch);
            this.grpFilterMenu.Controls.Add(this.lblSearchTerm);
            this.grpFilterMenu.Controls.Add(this.cmbDishType);
            this.grpFilterMenu.Controls.Add(this.lblDishType);
            this.grpFilterMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFilterMenu.Location = new System.Drawing.Point(163, 12);
            this.grpFilterMenu.Name = "grpFilterMenu";
            this.grpFilterMenu.Size = new System.Drawing.Size(419, 137);
            this.grpFilterMenu.TabIndex = 2;
            this.grpFilterMenu.TabStop = false;
            this.grpFilterMenu.Text = "Filter Menu";
            // 
            // btnFilterMenu
            // 
            this.btnFilterMenu.Location = new System.Drawing.Point(166, 108);
            this.btnFilterMenu.Name = "btnFilterMenu";
            this.btnFilterMenu.Size = new System.Drawing.Size(75, 23);
            this.btnFilterMenu.TabIndex = 4;
            this.btnFilterMenu.Text = "Filter Menu";
            this.btnFilterMenu.UseVisualStyleBackColor = true;
            this.btnFilterMenu.Click += new System.EventHandler(this.btnFilterMenu_Click);
            // 
            // txtMenuItemSearch
            // 
            this.txtMenuItemSearch.Location = new System.Drawing.Point(166, 69);
            this.txtMenuItemSearch.Name = "txtMenuItemSearch";
            this.txtMenuItemSearch.Size = new System.Drawing.Size(239, 23);
            this.txtMenuItemSearch.TabIndex = 3;
            // 
            // lblSearchTerm
            // 
            this.lblSearchTerm.AutoSize = true;
            this.lblSearchTerm.Location = new System.Drawing.Point(18, 69);
            this.lblSearchTerm.Name = "lblSearchTerm";
            this.lblSearchTerm.Size = new System.Drawing.Size(90, 17);
            this.lblSearchTerm.TabIndex = 2;
            this.lblSearchTerm.Text = "Search Term";
            // 
            // cmbDishType
            // 
            this.cmbDishType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDishType.FormattingEnabled = true;
            this.cmbDishType.Location = new System.Drawing.Point(166, 25);
            this.cmbDishType.Name = "cmbDishType";
            this.cmbDishType.Size = new System.Drawing.Size(239, 24);
            this.cmbDishType.TabIndex = 1;
            // 
            // lblDishType
            // 
            this.lblDishType.AutoSize = true;
            this.lblDishType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDishType.Location = new System.Drawing.Point(18, 25);
            this.lblDishType.Name = "lblDishType";
            this.lblDishType.Size = new System.Drawing.Size(72, 17);
            this.lblDishType.TabIndex = 0;
            this.lblDishType.Text = "Dish Type";
            // 
            // dgvMenuItems
            // 
            this.dgvMenuItems.AllowUserToAddRows = false;
            this.dgvMenuItems.AllowUserToDeleteRows = false;
            this.dgvMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMId,
            this.colDishName,
            this.colDishType,
            this.colPrice,
            this.colUnits,
            this.colAvailableQuantity});
            this.dgvMenuItems.Location = new System.Drawing.Point(16, 168);
            this.dgvMenuItems.Name = "dgvMenuItems";
            this.dgvMenuItems.ReadOnly = true;
            this.dgvMenuItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenuItems.Size = new System.Drawing.Size(527, 150);
            this.dgvMenuItems.TabIndex = 3;
            // 
            // colMId
            // 
            this.colMId.HeaderText = "";
            this.colMId.Name = "colMId";
            this.colMId.ReadOnly = true;
            this.colMId.Visible = false;
            // 
            // colDishName
            // 
            this.colDishName.HeaderText = "Dish";
            this.colDishName.Name = "colDishName";
            this.colDishName.ReadOnly = true;
            // 
            // colDishType
            // 
            this.colDishType.HeaderText = "Type";
            this.colDishType.Name = "colDishType";
            this.colDishType.ReadOnly = true;
            // 
            // colPrice
            // 
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colUnits
            // 
            this.colUnits.HeaderText = "Units";
            this.colUnits.Name = "colUnits";
            this.colUnits.ReadOnly = true;
            // 
            // colAvailableQuantity
            // 
            this.colAvailableQuantity.HeaderText = "Available";
            this.colAvailableQuantity.Name = "colAvailableQuantity";
            this.colAvailableQuantity.ReadOnly = true;
            // 
            // grpAddToCart
            // 
            this.grpAddToCart.Controls.Add(this.btnAddToCart);
            this.grpAddToCart.Controls.Add(this.numQuantity);
            this.grpAddToCart.Controls.Add(this.lblQuantity);
            this.grpAddToCart.Location = new System.Drawing.Point(588, 26);
            this.grpAddToCart.Name = "grpAddToCart";
            this.grpAddToCart.Size = new System.Drawing.Size(200, 100);
            this.grpAddToCart.TabIndex = 4;
            this.grpAddToCart.TabStop = false;
            this.grpAddToCart.Text = "Add To Cart";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(58, 71);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(105, 23);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(80, 26);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 20);
            this.numQuantity.TabIndex = 1;
            this.numQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(19, 28);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(46, 13);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity";
            // 
            // grpCart
            // 
            this.grpCart.Controls.Add(this.lblOrderMessage);
            this.grpCart.Controls.Add(this.btnPlaceOrder);
            this.grpCart.Controls.Add(this.btnApplyCoupon);
            this.grpCart.Controls.Add(this.lblTotalPrice);
            this.grpCart.Controls.Add(this.lblDiscount);
            this.grpCart.Controls.Add(this.lblSubtotal);
            this.grpCart.Controls.Add(this.txtCouponCode);
            this.grpCart.Controls.Add(this.lblCouponCode);
            this.grpCart.Controls.Add(this.btnRemoveItem);
            this.grpCart.Controls.Add(this.dgvCartItems);
            this.grpCart.Location = new System.Drawing.Point(588, 132);
            this.grpCart.Name = "grpCart";
            this.grpCart.Size = new System.Drawing.Size(352, 222);
            this.grpCart.TabIndex = 5;
            this.grpCart.TabStop = false;
            this.grpCart.Text = "Your Cart";
            // 
            // lblOrderMessage
            // 
            this.lblOrderMessage.AutoSize = true;
            this.lblOrderMessage.Location = new System.Drawing.Point(294, 172);
            this.lblOrderMessage.Name = "lblOrderMessage";
            this.lblOrderMessage.Size = new System.Drawing.Size(0, 13);
            this.lblOrderMessage.TabIndex = 9;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(111, 199);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceOrder.TabIndex = 8;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnApplyCoupon
            // 
            this.btnApplyCoupon.Location = new System.Drawing.Point(238, 128);
            this.btnApplyCoupon.Name = "btnApplyCoupon";
            this.btnApplyCoupon.Size = new System.Drawing.Size(88, 23);
            this.btnApplyCoupon.TabIndex = 7;
            this.btnApplyCoupon.Text = "Apply Coupon";
            this.btnApplyCoupon.UseVisualStyleBackColor = true;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Food_Del_Apps.Properties.Settings.Default, "Dynamic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblTotalPrice.Location = new System.Drawing.Point(23, 186);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(55, 13);
            this.lblTotalPrice.TabIndex = 6;
            this.lblTotalPrice.Text = global::Food_Del_Apps.Properties.Settings.Default.Dynamic;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Food_Del_Apps.Properties.Settings.Default, "Dynamic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblDiscount.Location = new System.Drawing.Point(24, 173);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 13);
            this.lblDiscount.TabIndex = 5;
            this.lblDiscount.Text = global::Food_Del_Apps.Properties.Settings.Default.Dynamic;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Food_Del_Apps.Properties.Settings.Default, "Dynamic", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblSubtotal.Location = new System.Drawing.Point(24, 159);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(50, 13);
            this.lblSubtotal.TabIndex = 4;
            this.lblSubtotal.Text = global::Food_Del_Apps.Properties.Settings.Default.Dynamic;
            // 
            // txtCouponCode
            // 
            this.txtCouponCode.Location = new System.Drawing.Point(132, 130);
            this.txtCouponCode.Name = "txtCouponCode";
            this.txtCouponCode.Size = new System.Drawing.Size(100, 20);
            this.txtCouponCode.TabIndex = 3;
            // 
            // lblCouponCode
            // 
            this.lblCouponCode.AutoSize = true;
            this.lblCouponCode.Location = new System.Drawing.Point(37, 136);
            this.lblCouponCode.Name = "lblCouponCode";
            this.lblCouponCode.Size = new System.Drawing.Size(72, 13);
            this.lblCouponCode.TabIndex = 2;
            this.lblCouponCode.Text = "Coupon Code";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(111, 100);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(121, 23);
            this.btnRemoveItem.TabIndex = 1;
            this.btnRemoveItem.Text = "Remove Selected";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // dgvCartItems
            // 
            this.dgvCartItems.AllowUserToAddRows = false;
            this.dgvCartItems.AllowUserToDeleteRows = false;
            this.dgvCartItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCartItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCartDishName,
            this.colCartQuantity,
            this.colCartPrice,
            this.colCartLineTotal});
            this.dgvCartItems.Location = new System.Drawing.Point(26, 19);
            this.dgvCartItems.Name = "dgvCartItems";
            this.dgvCartItems.ReadOnly = true;
            this.dgvCartItems.Size = new System.Drawing.Size(326, 75);
            this.dgvCartItems.TabIndex = 0;
            // 
            // colCartDishName
            // 
            this.colCartDishName.HeaderText = "Item";
            this.colCartDishName.Name = "colCartDishName";
            this.colCartDishName.ReadOnly = true;
            // 
            // colCartQuantity
            // 
            this.colCartQuantity.HeaderText = "Qty";
            this.colCartQuantity.Name = "colCartQuantity";
            this.colCartQuantity.ReadOnly = true;
            // 
            // colCartPrice
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.colCartPrice.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCartPrice.HeaderText = "UnitPrice";
            this.colCartPrice.Name = "colCartPrice";
            this.colCartPrice.ReadOnly = true;
            // 
            // colCartLineTotal
            // 
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.colCartLineTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCartLineTotal.HeaderText = "Line Total";
            this.colCartLineTotal.Name = "colCartLineTotal";
            this.colCartLineTotal.ReadOnly = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.grpCart);
            this.Controls.Add(this.grpAddToCart);
            this.Controls.Add(this.dgvMenuItems);
            this.Controls.Add(this.grpFilterMenu);
            this.Controls.Add(this.lblMinOrderValue);
            this.Controls.Add(this.lblRestaurantName);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.grpFilterMenu.ResumeLayout(false);
            this.grpFilterMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).EndInit();
            this.grpAddToCart.ResumeLayout(false);
            this.grpAddToCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.grpCart.ResumeLayout(false);
            this.grpCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCartItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.Label lblMinOrderValue;
        private System.Windows.Forms.GroupBox grpFilterMenu;
        private System.Windows.Forms.ComboBox cmbDishType;
        private System.Windows.Forms.Label lblDishType;
        private System.Windows.Forms.Button btnFilterMenu;
        private System.Windows.Forms.TextBox txtMenuItemSearch;
        private System.Windows.Forms.Label lblSearchTerm;
        private System.Windows.Forms.DataGridView dgvMenuItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDishType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailableQuantity;
        private System.Windows.Forms.GroupBox grpAddToCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.GroupBox grpCart;
        private System.Windows.Forms.Label lblCouponCode;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.DataGridView dgvCartItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartDishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCartLineTotal;
        private System.Windows.Forms.Label lblOrderMessage;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnApplyCoupon;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtCouponCode;
    }
}