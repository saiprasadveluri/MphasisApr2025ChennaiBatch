namespace FoodDeliveryAggregateApp
{
    partial class AddLocation
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
            this.Locationid = new System.Windows.Forms.Label();
            this.LocationName = new System.Windows.Forms.Label();
            this.Locationidtxt = new System.Windows.Forms.TextBox();
            this.LocationNmaetxt = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Locationid
            // 
            this.Locationid.AutoSize = true;
            this.Locationid.Location = new System.Drawing.Point(148, 55);
            this.Locationid.Name = "Locationid";
            this.Locationid.Size = new System.Drawing.Size(57, 13);
            this.Locationid.TabIndex = 0;
            this.Locationid.Text = "LocationId";
            // 
            // LocationName
            // 
            this.LocationName.AutoSize = true;
            this.LocationName.Location = new System.Drawing.Point(148, 101);
            this.LocationName.Name = "LocationName";
            this.LocationName.Size = new System.Drawing.Size(76, 13);
            this.LocationName.TabIndex = 1;
            this.LocationName.Text = "LocationName";
            // 
            // Locationidtxt
            // 
            this.Locationidtxt.Location = new System.Drawing.Point(246, 48);
            this.Locationidtxt.Name = "Locationidtxt";
            this.Locationidtxt.Size = new System.Drawing.Size(100, 20);
            this.Locationidtxt.TabIndex = 2;
            this.Locationidtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LocationNmaetxt
            // 
            this.LocationNmaetxt.Location = new System.Drawing.Point(246, 101);
            this.LocationNmaetxt.Name = "LocationNmaetxt";
            this.LocationNmaetxt.Size = new System.Drawing.Size(100, 20);
            this.LocationNmaetxt.TabIndex = 3;
            this.LocationNmaetxt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(231, 199);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AddLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.LocationNmaetxt);
            this.Controls.Add(this.Locationidtxt);
            this.Controls.Add(this.LocationName);
            this.Controls.Add(this.Locationid);
            this.Name = "AddLocation";
            this.Text = "AddLocation";
            this.Load += new System.EventHandler(this.AddLocation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Locationid;
        private System.Windows.Forms.Label LocationName;
        private System.Windows.Forms.TextBox Locationidtxt;
        private System.Windows.Forms.TextBox LocationNmaetxt;
        private System.Windows.Forms.Button Save;
    }
}