namespace FoodDeliveryAggregateApp
{
    partial class AddRestaurant
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResId = new System.Windows.Forms.TextBox();
            this.ResName = new System.Windows.Forms.TextBox();
            this.Loc = new System.Windows.Forms.TextBox();
            this.Minorder = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RestName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "MinimumOrderValue";
            // 
            // ResId
            // 
            this.ResId.Location = new System.Drawing.Point(318, 44);
            this.ResId.Name = "ResId";
            this.ResId.Size = new System.Drawing.Size(143, 20);
            this.ResId.TabIndex = 4;
            // 
            // ResName
            // 
            this.ResName.Location = new System.Drawing.Point(318, 74);
            this.ResName.Name = "ResName";
            this.ResName.Size = new System.Drawing.Size(143, 20);
            this.ResName.TabIndex = 5;
            // 
            // Loc
            // 
            this.Loc.Location = new System.Drawing.Point(318, 113);
            this.Loc.Name = "Loc";
            this.Loc.Size = new System.Drawing.Size(143, 20);
            this.Loc.TabIndex = 6;
            // 
            // Minorder
            // 
            this.Minorder.Location = new System.Drawing.Point(318, 156);
            this.Minorder.Name = "Minorder";
            this.Minorder.Size = new System.Drawing.Size(143, 20);
            this.Minorder.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Minorder);
            this.Controls.Add(this.Loc);
            this.Controls.Add(this.ResName);
            this.Controls.Add(this.ResId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddRestaurant";
            this.Text = "AddRestaurant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ResId;
        private System.Windows.Forms.TextBox ResName;
        private System.Windows.Forms.TextBox Loc;
        private System.Windows.Forms.TextBox Minorder;
        private System.Windows.Forms.Button button1;
    }
}