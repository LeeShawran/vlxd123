namespace QL_VatLieuXayDung
{
    partial class frmLoaiSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDes_LoaiSP = new System.Windows.Forms.Button();
            this.btnAsc_LoaiSP = new System.Windows.Forms.Button();
            this.dgvLoaiSP = new System.Windows.Forms.DataGridView();
            this.ColumnMaLoai_LoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenLoai_LoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem_LoaiSP = new System.Windows.Forms.Button();
            this.btnLuu_LoaiSP = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa_LoaiSP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSua_LoaiSP = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaLoai_LoaiSP = new System.Windows.Forms.Label();
            this.txtTenLoai_LoaiSP = new System.Windows.Forms.TextBox();
            this.lblTenLoai_LoaiSP = new System.Windows.Forms.Label();
            this.txtMaLoai_LoaiSP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus_LoaiSP = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(538, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 33);
            this.label1.TabIndex = 81;
            this.label1.Text = "LOẠI SẢN PHẨM";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDes_LoaiSP);
            this.groupBox3.Controls.Add(this.btnAsc_LoaiSP);
            this.groupBox3.Controls.Add(this.dgvLoaiSP);
            this.groupBox3.Location = new System.Drawing.Point(379, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(608, 310);
            this.groupBox3.TabIndex = 80;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách loại sản phẩm";
            // 
            // btnDes_LoaiSP
            // 
            this.btnDes_LoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btnDes_LoaiSP.Image")));
            this.btnDes_LoaiSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDes_LoaiSP.Location = new System.Drawing.Point(501, 193);
            this.btnDes_LoaiSP.Name = "btnDes_LoaiSP";
            this.btnDes_LoaiSP.Size = new System.Drawing.Size(101, 47);
            this.btnDes_LoaiSP.TabIndex = 39;
            this.btnDes_LoaiSP.Text = "Dưới lên";
            this.btnDes_LoaiSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDes_LoaiSP.UseVisualStyleBackColor = true;
            this.btnDes_LoaiSP.Click += new System.EventHandler(this.btnDes_LoaiSP_Click);
            // 
            // btnAsc_LoaiSP
            // 
            this.btnAsc_LoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btnAsc_LoaiSP.Image")));
            this.btnAsc_LoaiSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsc_LoaiSP.Location = new System.Drawing.Point(501, 75);
            this.btnAsc_LoaiSP.Name = "btnAsc_LoaiSP";
            this.btnAsc_LoaiSP.Size = new System.Drawing.Size(101, 47);
            this.btnAsc_LoaiSP.TabIndex = 38;
            this.btnAsc_LoaiSP.Text = "Trên xuống";
            this.btnAsc_LoaiSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsc_LoaiSP.UseVisualStyleBackColor = true;
            this.btnAsc_LoaiSP.Click += new System.EventHandler(this.btnAsc_LoaiSP_Click);
            // 
            // dgvLoaiSP
            // 
            this.dgvLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaLoai_LoaiSP,
            this.ColumnTenLoai_LoaiSP});
            this.dgvLoaiSP.Location = new System.Drawing.Point(29, 33);
            this.dgvLoaiSP.Name = "dgvLoaiSP";
            this.dgvLoaiSP.Size = new System.Drawing.Size(456, 259);
            this.dgvLoaiSP.TabIndex = 37;
            this.dgvLoaiSP.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLoaiSP_CellMouseClick);
            // 
            // ColumnMaLoai_LoaiSP
            // 
            this.ColumnMaLoai_LoaiSP.DataPropertyName = "MALOAI";
            this.ColumnMaLoai_LoaiSP.HeaderText = "Mã Loại";
            this.ColumnMaLoai_LoaiSP.Name = "ColumnMaLoai_LoaiSP";
            // 
            // ColumnTenLoai_LoaiSP
            // 
            this.ColumnTenLoai_LoaiSP.DataPropertyName = "TENLOAI";
            this.ColumnTenLoai_LoaiSP.HeaderText = "Tên loại";
            this.ColumnTenLoai_LoaiSP.Name = "ColumnTenLoai_LoaiSP";
            // 
            // btnThem_LoaiSP
            // 
            this.btnThem_LoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btnThem_LoaiSP.Image")));
            this.btnThem_LoaiSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem_LoaiSP.Location = new System.Drawing.Point(18, 21);
            this.btnThem_LoaiSP.Name = "btnThem_LoaiSP";
            this.btnThem_LoaiSP.Size = new System.Drawing.Size(80, 30);
            this.btnThem_LoaiSP.TabIndex = 12;
            this.btnThem_LoaiSP.Text = "   Thêm";
            this.btnThem_LoaiSP.UseVisualStyleBackColor = true;
            this.btnThem_LoaiSP.Click += new System.EventHandler(this.btnThem_LoaiSP_Click);
            // 
            // btnLuu_LoaiSP
            // 
            this.btnLuu_LoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu_LoaiSP.Image")));
            this.btnLuu_LoaiSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu_LoaiSP.Location = new System.Drawing.Point(121, 60);
            this.btnLuu_LoaiSP.Name = "btnLuu_LoaiSP";
            this.btnLuu_LoaiSP.Size = new System.Drawing.Size(80, 30);
            this.btnLuu_LoaiSP.TabIndex = 16;
            this.btnLuu_LoaiSP.Text = "    Lưu";
            this.btnLuu_LoaiSP.UseVisualStyleBackColor = true;
            this.btnLuu_LoaiSP.Click += new System.EventHandler(this.btnLuu_LoaiSP_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENLOAISACH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên loại sách";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // btnXoa_LoaiSP
            // 
            this.btnXoa_LoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa_LoaiSP.Image")));
            this.btnXoa_LoaiSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa_LoaiSP.Location = new System.Drawing.Point(18, 60);
            this.btnXoa_LoaiSP.Name = "btnXoa_LoaiSP";
            this.btnXoa_LoaiSP.Size = new System.Drawing.Size(80, 30);
            this.btnXoa_LoaiSP.TabIndex = 13;
            this.btnXoa_LoaiSP.Text = "Xóa";
            this.btnXoa_LoaiSP.UseVisualStyleBackColor = true;
            this.btnXoa_LoaiSP.Click += new System.EventHandler(this.btnXoa_LoaiSP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThem_LoaiSP);
            this.groupBox2.Controls.Add(this.btnLuu_LoaiSP);
            this.groupBox2.Controls.Add(this.btnXoa_LoaiSP);
            this.groupBox2.Controls.Add(this.btnSua_LoaiSP);
            this.groupBox2.Location = new System.Drawing.Point(766, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 117);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // btnSua_LoaiSP
            // 
            this.btnSua_LoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btnSua_LoaiSP.Image")));
            this.btnSua_LoaiSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua_LoaiSP.Location = new System.Drawing.Point(121, 21);
            this.btnSua_LoaiSP.Name = "btnSua_LoaiSP";
            this.btnSua_LoaiSP.Size = new System.Drawing.Size(80, 30);
            this.btnSua_LoaiSP.TabIndex = 14;
            this.btnSua_LoaiSP.Text = "    Sửa";
            this.btnSua_LoaiSP.UseVisualStyleBackColor = true;
            this.btnSua_LoaiSP.Click += new System.EventHandler(this.btnSua_LoaiSP_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MALOAISACH";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã loại sách";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // lblMaLoai_LoaiSP
            // 
            this.lblMaLoai_LoaiSP.AutoSize = true;
            this.lblMaLoai_LoaiSP.Location = new System.Drawing.Point(55, 35);
            this.lblMaLoai_LoaiSP.Name = "lblMaLoai_LoaiSP";
            this.lblMaLoai_LoaiSP.Size = new System.Drawing.Size(47, 13);
            this.lblMaLoai_LoaiSP.TabIndex = 6;
            this.lblMaLoai_LoaiSP.Text = "Mã loại :";
            // 
            // txtTenLoai_LoaiSP
            // 
            this.txtTenLoai_LoaiSP.Location = new System.Drawing.Point(112, 57);
            this.txtTenLoai_LoaiSP.Name = "txtTenLoai_LoaiSP";
            this.txtTenLoai_LoaiSP.Size = new System.Drawing.Size(192, 20);
            this.txtTenLoai_LoaiSP.TabIndex = 9;
            // 
            // lblTenLoai_LoaiSP
            // 
            this.lblTenLoai_LoaiSP.AutoSize = true;
            this.lblTenLoai_LoaiSP.Location = new System.Drawing.Point(55, 60);
            this.lblTenLoai_LoaiSP.Name = "lblTenLoai_LoaiSP";
            this.lblTenLoai_LoaiSP.Size = new System.Drawing.Size(51, 13);
            this.lblTenLoai_LoaiSP.TabIndex = 0;
            this.lblTenLoai_LoaiSP.Text = "Tên loại :";
            // 
            // txtMaLoai_LoaiSP
            // 
            this.txtMaLoai_LoaiSP.Location = new System.Drawing.Point(112, 31);
            this.txtMaLoai_LoaiSP.Name = "txtMaLoai_LoaiSP";
            this.txtMaLoai_LoaiSP.Size = new System.Drawing.Size(192, 20);
            this.txtMaLoai_LoaiSP.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus_LoaiSP);
            this.groupBox1.Controls.Add(this.lblMaLoai_LoaiSP);
            this.groupBox1.Controls.Add(this.txtTenLoai_LoaiSP);
            this.groupBox1.Controls.Add(this.lblTenLoai_LoaiSP);
            this.groupBox1.Controls.Add(this.txtMaLoai_LoaiSP);
            this.groupBox1.Location = new System.Drawing.Point(379, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 117);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại sản phẩm";
            // 
            // lblStatus_LoaiSP
            // 
            this.lblStatus_LoaiSP.AutoSize = true;
            this.lblStatus_LoaiSP.Location = new System.Drawing.Point(55, 86);
            this.lblStatus_LoaiSP.Name = "lblStatus_LoaiSP";
            this.lblStatus_LoaiSP.Size = new System.Drawing.Size(10, 13);
            this.lblStatus_LoaiSP.TabIndex = 10;
            this.lblStatus_LoaiSP.Text = ".";
            // 
            // frmLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLoaiSanPham";
            this.Text = "Loại sản phẩm";
            this.Load += new System.EventHandler(this.frmLoaiSanPham_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem_LoaiSP;
        private System.Windows.Forms.Button btnLuu_LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnXoa_LoaiSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSua_LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblMaLoai_LoaiSP;
        private System.Windows.Forms.TextBox txtTenLoai_LoaiSP;
        private System.Windows.Forms.Label lblTenLoai_LoaiSP;
        private System.Windows.Forms.TextBox txtMaLoai_LoaiSP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLoaiSP;
        private System.Windows.Forms.Button btnDes_LoaiSP;
        private System.Windows.Forms.Button btnAsc_LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaLoai_LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenLoai_LoaiSP;
        private System.Windows.Forms.Label lblStatus_LoaiSP;
    }
}