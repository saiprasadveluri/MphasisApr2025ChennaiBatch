namespace FoodDelForms
{
    partial class NewLocation
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
            this.LocationId = new System.Windows.Forms.TextBox();
            this.LocationName = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LocationId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "LocationName";
            // 
            // LocationId
            // 
            this.LocationId.Location = new System.Drawing.Point(158, 50);
            this.LocationId.Name = "LocationId";
            this.LocationId.Size = new System.Drawing.Size(100, 20);
            this.LocationId.TabIndex = 2;
            // 
            // LocationName
            // 
            this.LocationName.Location = new System.Drawing.Point(158, 140);
            this.LocationName.Name = "LocationName";
            this.LocationName.Size = new System.Drawing.Size(100, 20);
            this.LocationName.TabIndex = 3;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(181, 215);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // NewLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.LocationName);
            this.Controls.Add(this.LocationId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewLocation";
            this.Text = "Location";
            
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LocationId;
        private System.Windows.Forms.TextBox LocationName;
        private System.Windows.Forms.Button Save;
    }
}