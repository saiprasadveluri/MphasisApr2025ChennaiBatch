namespace Food_Del_Apps
{
    partial class MenuManagementForm
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
            this.lblRestaurantName = new System.Windows.Forms.Label();
            this.dgvMenuItems = new System.Windows.Forms.DataGridView();
            this.colDishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDishType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddMenuItem = new System.Windows.Forms.Button();
            this.btnEditMenuItem = new System.Windows.Forms.Button();
            this.btnUpdateQuantity = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRestaurantName
            // 
            this.lblRestaurantName.AutoSize = true;
            this.lblRestaurantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurantName.Location = new System.Drawing.Point(197, 37);
            this.lblRestaurantName.Name = "lblRestaurantName";
            this.lblRestaurantName.Size = new System.Drawing.Size(127, 20);
            this.lblRestaurantName.TabIndex = 0;
            this.lblRestaurantName.Text = "Managing Menu ";
            // 
            // dgvMenuItems
            // 
            this.dgvMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDishName,
            this.colDishType,
            this.colPrice,
            this.colUnits,
            this.colAvailableQuantity,
            this.colAction});
            this.dgvMenuItems.Location = new System.Drawing.Point(43, 72);
            this.dgvMenuItems.Name = "dgvMenuItems";
            this.dgvMenuItems.Size = new System.Drawing.Size(558, 150);
            this.dgvMenuItems.TabIndex = 1;
            // 
            // colDishName
            // 
            this.colDishName.HeaderText = "Dish";
            this.colDishName.Name = "colDishName";
            // 
            // colDishType
            // 
            this.colDishType.HeaderText = "Type";
            this.colDishType.Name = "colDishType";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            // 
            // colUnits
            // 
            this.colUnits.HeaderText = "Units";
            this.colUnits.Name = "colUnits";
            // 
            // colAvailableQuantity
            // 
            this.colAvailableQuantity.HeaderText = "Available";
            this.colAvailableQuantity.Name = "colAvailableQuantity";
            // 
            // colAction
            // 
            this.colAction.HeaderText = "Edit/Delete";
            this.colAction.Name = "colAction";
            // 
            // btnAddMenuItem
            // 
            this.btnAddMenuItem.Location = new System.Drawing.Point(143, 228);
            this.btnAddMenuItem.Name = "btnAddMenuItem";
            this.btnAddMenuItem.Size = new System.Drawing.Size(143, 23);
            this.btnAddMenuItem.TabIndex = 2;
            this.btnAddMenuItem.Text = "Add New Menu Item";
            this.btnAddMenuItem.UseVisualStyleBackColor = true;
            this.btnAddMenuItem.Click += new System.EventHandler(this.btnAddMenuItem_Click);
            // 
            // btnEditMenuItem
            // 
            this.btnEditMenuItem.Location = new System.Drawing.Point(357, 228);
            this.btnEditMenuItem.Name = "btnEditMenuItem";
            this.btnEditMenuItem.Size = new System.Drawing.Size(171, 23);
            this.btnEditMenuItem.TabIndex = 3;
            this.btnEditMenuItem.Text = "Edit Selected Item";
            this.btnEditMenuItem.UseVisualStyleBackColor = true;
            // 
            // btnUpdateQuantity
            // 
            this.btnUpdateQuantity.Location = new System.Drawing.Point(231, 267);
            this.btnUpdateQuantity.Name = "btnUpdateQuantity";
            this.btnUpdateQuantity.Size = new System.Drawing.Size(183, 23);
            this.btnUpdateQuantity.TabIndex = 4;
            this.btnUpdateQuantity.Text = "Update Selected Item Quantity";
            this.btnUpdateQuantity.UseVisualStyleBackColor = true;
            this.btnUpdateQuantity.Click += new System.EventHandler(this.btnUpdateQuantity_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(250, 316);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 5;
            // 
            // MenuManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnUpdateQuantity);
            this.Controls.Add(this.btnEditMenuItem);
            this.Controls.Add(this.btnAddMenuItem);
            this.Controls.Add(this.dgvMenuItems);
            this.Controls.Add(this.lblRestaurantName);
            this.Name = "MenuManagementForm";
            this.Text = "MenuManagementForm";
            this.Load += new System.EventHandler(this.MenuManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRestaurantName;
        private System.Windows.Forms.DataGridView dgvMenuItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDishType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvailableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAction;
        private System.Windows.Forms.Button btnAddMenuItem;
        private System.Windows.Forms.Button btnEditMenuItem;
        private System.Windows.Forms.Button btnUpdateQuantity;
        private System.Windows.Forms.Label lblMessage;
    }
}