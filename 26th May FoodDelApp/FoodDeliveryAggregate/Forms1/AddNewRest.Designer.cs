namespace Forms1
{
    partial class AddNewRest
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
            this.txtrid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtrname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLoc = new System.Windows.Forms.TextBox();
            this.btnAddnr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Restaurant Id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtrid
            // 
            this.txtrid.Location = new System.Drawing.Point(148, 63);
            this.txtrid.Name = "txtrid";
            this.txtrid.Size = new System.Drawing.Size(157, 20);
            this.txtrid.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Restaurant Name";
            // 
            // txtrname
            // 
            this.txtrname.Location = new System.Drawing.Point(148, 100);
            this.txtrname.Name = "txtrname";
            this.txtrname.Size = new System.Drawing.Size(157, 20);
            this.txtrname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Location";
            // 
            // txtLoc
            // 
            this.txtLoc.Location = new System.Drawing.Point(148, 143);
            this.txtLoc.Name = "txtLoc";
            this.txtLoc.Size = new System.Drawing.Size(157, 20);
            this.txtLoc.TabIndex = 1;
            // 
            // btnAddnr
            // 
            this.btnAddnr.Location = new System.Drawing.Point(188, 195);
            this.btnAddnr.Name = "btnAddnr";
            this.btnAddnr.Size = new System.Drawing.Size(75, 23);
            this.btnAddnr.TabIndex = 2;
            this.btnAddnr.Text = "Add";
            this.btnAddnr.UseVisualStyleBackColor = true;
            this.btnAddnr.Click += new System.EventHandler(this.btnAddnr_Click);
            // 
            // AddNewRest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddnr);
            this.Controls.Add(this.txtLoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtrname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtrid);
            this.Controls.Add(this.label1);
            this.Name = "AddNewRest";
            this.Text = "Add New Restaurent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtrname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLoc;
        private System.Windows.Forms.Button btnAddnr;
    }
}