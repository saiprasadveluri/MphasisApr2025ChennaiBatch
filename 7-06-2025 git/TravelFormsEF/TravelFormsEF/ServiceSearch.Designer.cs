namespace TravelFormsEF
{
    partial class ServiceSearch
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
            groupBox1 = new GroupBox();
            btnSearch = new Button();
            label2 = new Label();
            label1 = new Label();
            cmbDesS = new ComboBox();
            cmbSrcS = new ComboBox();
            GridSearch = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridSearch).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cmbDesS);
            groupBox1.Controls.Add(cmbSrcS);
            groupBox1.Location = new Point(44, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(668, 118);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "SearchEngine";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(314, 77);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 38);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 3;
            label2.Text = "Dest Location";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 46);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 2;
            label1.Text = "Source Location";
            // 
            // cmbDesS
            // 
            cmbDesS.FormattingEnabled = true;
            cmbDesS.Location = new Point(498, 38);
            cmbDesS.Name = "cmbDesS";
            cmbDesS.Size = new Size(121, 23);
            cmbDesS.TabIndex = 1;
            // 
            // cmbSrcS
            // 
            cmbSrcS.FormattingEnabled = true;
            cmbSrcS.Location = new Point(163, 38);
            cmbSrcS.Name = "cmbSrcS";
            cmbSrcS.Size = new Size(121, 23);
            cmbSrcS.TabIndex = 0;
            // 
            // GridSearch
            // 
            GridSearch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridSearch.Location = new Point(120, 189);
            GridSearch.Name = "GridSearch";
            GridSearch.Size = new Size(543, 150);
            GridSearch.TabIndex = 1;
            GridSearch.CellContentClick += GridSearch_CellContentClick;
            // 
            // ServiceSearch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GridSearch);
            Controls.Add(groupBox1);
            Name = "ServiceSearch";
            Text = "ServiceSearch";
            Load += ServiceSearch_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridSearch).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnSearch;
        private Label label2;
        private Label label1;
        private ComboBox cmbDesS;
        private ComboBox cmbSrcS;
        private DataGridView GridSearch;
    }
}