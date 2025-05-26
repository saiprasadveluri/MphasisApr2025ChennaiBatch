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
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LocationId = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.Label();
            this.textLocationId = new System.Windows.Forms.TextBox();
            this.textLocationName = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LocationId
            // 
            this.LocationId.AutoSize = true;
            this.LocationId.Location = new System.Drawing.Point(114, 47);
            this.LocationId.Name = "LocationId";
            this.LocationId.Size = new System.Drawing.Size(60, 13);
            this.LocationId.TabIndex = 0;
            this.LocationId.Text = "Location Id";
            // 
            // Location
            // 
            this.Location.AutoSize = true;
            this.Location.Location = new System.Drawing.Point(114, 87);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(48, 13);
            this.Location.TabIndex = 1;
            this.Location.Text = "Location";
            // 
            // textLocationId
            // 
            this.textLocationId.Location = new System.Drawing.Point(230, 47);
            this.textLocationId.Name = "textLocationId";
            this.textLocationId.Size = new System.Drawing.Size(152, 20);
            this.textLocationId.TabIndex = 2;
            // 
            // textLocationName
            // 
            this.textLocationName.FormattingEnabled = true;
            this.textLocationName.Items.AddRange(new object[] {
            "Hyd",
            "Mlg",
            "Srpt"});
            this.textLocationName.Location = new System.Drawing.Point(230, 87);
            this.textLocationName.Name = "textLocationName";
            this.textLocationName.Size = new System.Drawing.Size(137, 21);
            this.textLocationName.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(251, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(253, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(243, 20);
            this.textBox2.TabIndex = 3;
            // 
            // AddLocation
            // 
            this.ClientSize = new System.Drawing.Size(777, 242);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddLocation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LocationId;
        private System.Windows.Forms.Label Location;
        private System.Windows.Forms.TextBox textLocationId;
        private System.Windows.Forms.ComboBox textLocationName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}