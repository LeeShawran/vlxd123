namespace QL_VatLieuXayDung
{
    partial class frmPhanQuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanQuyen));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvNhomTK = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhanQuyen = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvNhomTK);
            this.groupBox3.Controls.Add(this.dgvPhanQuyen);
            this.groupBox3.Location = new System.Drawing.Point(255, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(952, 301);
            this.groupBox3.TabIndex = 90;
            this.groupBox3.TabStop = false;
            // 
            // dgvNhomTK
            // 
            this.dgvNhomTK.AllowUserToAddRows = false;
            this.dgvNhomTK.AllowUserToDeleteRows = false;
            this.dgvNhomTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhomTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhomTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvNhomTK.Location = new System.Drawing.Point(29, 19);
            this.dgvNhomTK.MultiSelect = false;
            this.dgvNhomTK.Name = "dgvNhomTK";
            this.dgvNhomTK.ReadOnly = true;
            this.dgvNhomTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhomTK.Size = new System.Drawing.Size(312, 266);
            this.dgvNhomTK.TabIndex = 47;
            this.dgvNhomTK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhomTK_CellContentClick);
            this.dgvNhomTK.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNhomTK_CellFormatting);
            this.dgvNhomTK.SelectionChanged += new System.EventHandler(this.dgvNhomTK_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MANHOM";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhóm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENNHOM";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên nhóm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dgvPhanQuyen
            // 
            this.dgvPhanQuyen.AllowUserToAddRows = false;
            this.dgvPhanQuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPhanQuyen.Location = new System.Drawing.Point(368, 19);
            this.dgvPhanQuyen.MultiSelect = false;
            this.dgvPhanQuyen.Name = "dgvPhanQuyen";
            this.dgvPhanQuyen.Size = new System.Drawing.Size(561, 266);
            this.dgvPhanQuyen.TabIndex = 46;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAMH";
            this.Column1.HeaderText = "Mã màn hình";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENMH";
            this.Column2.HeaderText = "Tên màn hình";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "COQUYEN";
            this.Column3.HeaderText = "Có quyền";
            this.Column3.Name = "Column3";
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(1142, 12);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(65, 39);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(555, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(367, 33);
            this.label6.TabIndex = 91;
            this.label6.Text = "PHÂN QUYỀN SỬ DỤNG";
            // 
            // frmPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLuu);
            this.Name = "frmPhanQuyen";
            this.Text = "Phân quyền sử dụng";
            this.Load += new System.EventHandler(this.frmPhanQuyen_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPhanQuyen;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvNhomTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
    }
}