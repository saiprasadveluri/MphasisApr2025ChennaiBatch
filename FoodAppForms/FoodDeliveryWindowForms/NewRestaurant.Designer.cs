namespace FoodDeliveryWindowForms
{
    partial class NewRestaurant
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
            this.RestId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RestName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MinOrderValue = new System.Windows.Forms.TextBox();
            this.bntSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant Id";
            // 
            // RestId
            // 
            this.RestId.Location = new System.Drawing.Point(212, 48);
            this.RestId.Name = "RestId";
            this.RestId.Size = new System.Drawing.Size(142, 20);
            this.RestId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Restaurant Name";
            // 
            // RestName
            // 
            this.RestName.Location = new System.Drawing.Point(212, 86);
            this.RestName.Name = "RestName";
            this.RestName.Size = new System.Drawing.Size(142, 20);
            this.RestName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Restaurant Location";
            // 
            // RLocation
            // 
            this.RLocation.Location = new System.Drawing.Point(212, 126);
            this.RLocation.Name = "RLocation";
            this.RLocation.Size = new System.Drawing.Size(142, 20);
            this.RLocation.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Min Order Value";
            // 
            // MinOrderValue
            // 
            this.MinOrderValue.Location = new System.Drawing.Point(212, 169);
            this.MinOrderValue.Name = "MinOrderValue";
            this.MinOrderValue.Size = new System.Drawing.Size(142, 20);
            this.MinOrderValue.TabIndex = 7;
            // 
            // bntSave
            // 
            this.bntSave.Location = new System.Drawing.Point(254, 223);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(75, 23);
            this.bntSave.TabIndex = 8;
            this.bntSave.Text = "Save";
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // NewRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.MinOrderValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RestName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RestId);
            this.Controls.Add(this.label1);
            this.Name = "NewRestaurant";
            this.Text = "NewRestaurant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RestId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RestName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MinOrderValue;
        private System.Windows.Forms.Button bntSave;
    }
}