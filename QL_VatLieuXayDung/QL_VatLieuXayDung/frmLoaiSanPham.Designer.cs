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
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTimten = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
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
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSua_LoaiSP = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaLoai_LoaiSP = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.lblTenLoai_LoaiSP = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.AutoSize = true;
            this.lblLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiSP.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblLoaiSP.Location = new System.Drawing.Point(538, 11);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(440, 33);
            this.lblLoaiSP.TabIndex = 81;
            this.lblLoaiSP.Text = "DANH SÁCH LOẠI SẢN PHẨM";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTimten);
            this.groupBox3.Controls.Add(this.txttimkiem);
            this.groupBox3.Controls.Add(this.btnDes_LoaiSP);
            this.groupBox3.Controls.Add(this.btnAsc_LoaiSP);
            this.groupBox3.Controls.Add(this.dgvLoaiSP);
            this.groupBox3.Location = new System.Drawing.Point(450, 161);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 369);
            this.groupBox3.TabIndex = 80;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách loại sản phẩm";
            // 
            // lblTimten
            // 
            this.lblTimten.AutoSize = true;
            this.lblTimten.Location = new System.Drawing.Point(28, 22);
            this.lblTimten.Name = "lblTimten";
            this.lblTimten.Size = new System.Drawing.Size(137, 13);
            this.lblTimten.TabIndex = 93;
            this.lblTimten.Text = "Tìm theo tên loại sản phẩm:";
            // 
            // txttimkiem
            // 
            this.txttimkiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txttimkiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txttimkiem.Location = new System.Drawing.Point(171, 19);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(186, 20);
            this.txttimkiem.TabIndex = 94;
            this.txttimkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttimkiem_KeyDown);
            // 
            // btnDes_LoaiSP
            // 
            this.btnDes_LoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btnDes_LoaiSP.Image")));
            this.btnDes_LoaiSP.Location = new System.Drawing.Point(421, 255);
            this.btnDes_LoaiSP.Name = "btnDes_LoaiSP";
            this.btnDes_LoaiSP.Size = new System.Drawing.Size(52, 47);
            this.btnDes_LoaiSP.TabIndex = 39;
            this.btnDes_LoaiSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDes_LoaiSP.UseVisualStyleBackColor = true;
            this.btnDes_LoaiSP.Click += new System.EventHandler(this.btnDes_LoaiSP_Click);
            // 
            // btnAsc_LoaiSP
            // 
            this.btnAsc_LoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btnAsc_LoaiSP.Image")));
            this.btnAsc_LoaiSP.Location = new System.Drawing.Point(421, 102);
            this.btnAsc_LoaiSP.Name = "btnAsc_LoaiSP";
            this.btnAsc_LoaiSP.Size = new System.Drawing.Size(52, 47);
            this.btnAsc_LoaiSP.TabIndex = 38;
            this.btnAsc_LoaiSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsc_LoaiSP.UseVisualStyleBackColor = true;
            this.btnAsc_LoaiSP.Click += new System.EventHandler(this.btnAsc_LoaiSP_Click);
            // 
            // dgvLoaiSP
            // 
            this.dgvLoaiSP.AllowUserToAddRows = false;
            this.dgvLoaiSP.AllowUserToDeleteRows = false;
            this.dgvLoaiSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaLoai_LoaiSP,
            this.ColumnTenLoai_LoaiSP});
            this.dgvLoaiSP.Location = new System.Drawing.Point(21, 45);
            this.dgvLoaiSP.Name = "dgvLoaiSP";
            this.dgvLoaiSP.ReadOnly = true;
            this.dgvLoaiSP.Size = new System.Drawing.Size(369, 308);
            this.dgvLoaiSP.TabIndex = 37;
            this.dgvLoaiSP.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLoaiSP_CellFormatting);
            this.dgvLoaiSP.Click += new System.EventHandler(this.dgvLoaiSP_Click);
            // 
            // ColumnMaLoai_LoaiSP
            // 
            this.ColumnMaLoai_LoaiSP.DataPropertyName = "MALOAI";
            this.ColumnMaLoai_LoaiSP.HeaderText = "Mã Loại";
            this.ColumnMaLoai_LoaiSP.Name = "ColumnMaLoai_LoaiSP";
            this.ColumnMaLoai_LoaiSP.ReadOnly = true;
            // 
            // ColumnTenLoai_LoaiSP
            // 
            this.ColumnTenLoai_LoaiSP.DataPropertyName = "TENLOAI";
            this.ColumnTenLoai_LoaiSP.HeaderText = "Tên loại";
            this.ColumnTenLoai_LoaiSP.Name = "ColumnTenLoai_LoaiSP";
            this.ColumnTenLoai_LoaiSP.ReadOnly = true;
            // 
            // btnThem_LoaiSP
            // 
            this.btnThem_LoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btnThem_LoaiSP.Image")));
            this.btnThem_LoaiSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem_LoaiSP.Location = new System.Drawing.Point(18, 16);
            this.btnThem_LoaiSP.Name = "btnThem_LoaiSP";
            this.btnThem_LoaiSP.Size = new System.Drawing.Size(66, 30);
            this.btnThem_LoaiSP.TabIndex = 12;
            this.btnThem_LoaiSP.Text = "Thêm";
            this.btnThem_LoaiSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem_LoaiSP.UseVisualStyleBackColor = true;
            this.btnThem_LoaiSP.Click += new System.EventHandler(this.btnThem_LoaiSP_Click);
            // 
            // btnLuu_LoaiSP
            // 
            this.btnLuu_LoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu_LoaiSP.Image")));
            this.btnLuu_LoaiSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu_LoaiSP.Location = new System.Drawing.Point(90, 55);
            this.btnLuu_LoaiSP.Name = "btnLuu_LoaiSP";
            this.btnLuu_LoaiSP.Size = new System.Drawing.Size(58, 30);
            this.btnLuu_LoaiSP.TabIndex = 16;
            this.btnLuu_LoaiSP.Text = "Lưu";
            this.btnLuu_LoaiSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnXoa_LoaiSP.Location = new System.Drawing.Point(18, 55);
            this.btnXoa_LoaiSP.Name = "btnXoa_LoaiSP";
            this.btnXoa_LoaiSP.Size = new System.Drawing.Size(66, 30);
            this.btnXoa_LoaiSP.TabIndex = 13;
            this.btnXoa_LoaiSP.Text = "Xóa";
            this.btnXoa_LoaiSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa_LoaiSP.UseVisualStyleBackColor = true;
            this.btnXoa_LoaiSP.Click += new System.EventHandler(this.btnXoa_LoaiSP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXuatExcel);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnThem_LoaiSP);
            this.groupBox2.Controls.Add(this.btnLuu_LoaiSP);
            this.groupBox2.Controls.Add(this.btnXoa_LoaiSP);
            this.groupBox2.Controls.Add(this.btnSua_LoaiSP);
            this.groupBox2.Location = new System.Drawing.Point(692, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 98);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.Image")));
            this.btnXuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatExcel.Location = new System.Drawing.Point(154, 55);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(94, 30);
            this.btnXuatExcel.TabIndex = 25;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(154, 16);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(94, 31);
            this.btnLamMoi.TabIndex = 24;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua_LoaiSP
            // 
            this.btnSua_LoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btnSua_LoaiSP.Image")));
            this.btnSua_LoaiSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua_LoaiSP.Location = new System.Drawing.Point(90, 16);
            this.btnSua_LoaiSP.Name = "btnSua_LoaiSP";
            this.btnSua_LoaiSP.Size = new System.Drawing.Size(58, 30);
            this.btnSua_LoaiSP.TabIndex = 14;
            this.btnSua_LoaiSP.Text = "Sửa";
            this.btnSua_LoaiSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.lblMaLoai_LoaiSP.Location = new System.Drawing.Point(22, 29);
            this.lblMaLoai_LoaiSP.Name = "lblMaLoai_LoaiSP";
            this.lblMaLoai_LoaiSP.Size = new System.Drawing.Size(47, 13);
            this.lblMaLoai_LoaiSP.TabIndex = 6;
            this.lblMaLoai_LoaiSP.Text = "Mã loại :";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(75, 52);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(144, 20);
            this.txtTenLoai.TabIndex = 9;
            // 
            // lblTenLoai_LoaiSP
            // 
            this.lblTenLoai_LoaiSP.AutoSize = true;
            this.lblTenLoai_LoaiSP.Location = new System.Drawing.Point(18, 55);
            this.lblTenLoai_LoaiSP.Name = "lblTenLoai_LoaiSP";
            this.lblTenLoai_LoaiSP.Size = new System.Drawing.Size(51, 13);
            this.lblTenLoai_LoaiSP.TabIndex = 0;
            this.lblTenLoai_LoaiSP.Text = "Tên loại :";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Enabled = false;
            this.txtMaLoai.Location = new System.Drawing.Point(75, 26);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(144, 20);
            this.txtMaLoai.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTenLoai_LoaiSP);
            this.groupBox1.Controls.Add(this.lblMaLoai_LoaiSP);
            this.groupBox1.Controls.Add(this.txtTenLoai);
            this.groupBox1.Controls.Add(this.txtMaLoai);
            this.groupBox1.Location = new System.Drawing.Point(450, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 98);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại sản phẩm";
            // 
            // frmLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 542);
            this.Controls.Add(this.lblLoaiSP);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLoaiSanPham";
            this.Text = "Loại sản phẩm";
            this.Load += new System.EventHandler(this.frmLoaiSanPham_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoaiSP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem_LoaiSP;
        private System.Windows.Forms.Button btnLuu_LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnXoa_LoaiSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSua_LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label lblMaLoai_LoaiSP;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label lblTenLoai_LoaiSP;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLoaiSP;
        private System.Windows.Forms.Button btnDes_LoaiSP;
        private System.Windows.Forms.Button btnAsc_LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaLoai_LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenLoai_LoaiSP;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblTimten;
        private System.Windows.Forms.TextBox txttimkiem;
    }
}