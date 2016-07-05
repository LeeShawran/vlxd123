﻿namespace QL_VatLieuXayDung
{
    partial class frmGiaoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoHang));
            this.dgvCT_HOADON = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluongmua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluonggiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvCT_PhieuGiao = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhieu_Giao = new System.Windows.Forms.DataGridView();
            this.magiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaygiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphieudat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaDonDat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNgayGiao = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhieuGiao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_HOADON)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_PhieuGiao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu_Giao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCT_HOADON
            // 
            this.dgvCT_HOADON.AllowUserToAddRows = false;
            this.dgvCT_HOADON.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_HOADON.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_HOADON.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.soluongmua,
            this.soluonggiao});
            this.dgvCT_HOADON.Location = new System.Drawing.Point(16, 24);
            this.dgvCT_HOADON.MultiSelect = false;
            this.dgvCT_HOADON.Name = "dgvCT_HOADON";
            this.dgvCT_HOADON.Size = new System.Drawing.Size(455, 185);
            this.dgvCT_HOADON.TabIndex = 27;
            this.dgvCT_HOADON.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCT_HOADON_CellFormatting);
            // 
            // masp
            // 
            this.masp.DataPropertyName = "MASP";
            this.masp.HeaderText = "Mã sản phẩm";
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            // 
            // soluongmua
            // 
            this.soluongmua.DataPropertyName = "SOLUONG_CONGIAO";
            this.soluongmua.HeaderText = "Số lượng còn phải giao";
            this.soluongmua.Name = "soluongmua";
            this.soluongmua.ReadOnly = true;
            // 
            // soluonggiao
            // 
            this.soluonggiao.DataPropertyName = "SOLUONG1";
            this.soluonggiao.HeaderText = "Số lượng giao";
            this.soluonggiao.Name = "soluonggiao";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCT_HOADON);
            this.groupBox3.Location = new System.Drawing.Point(327, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 225);
            this.groupBox3.TabIndex = 119;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản phẩm đã thanh toán";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnXuatExcel);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(8, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 92);
            this.groupBox2.TabIndex = 120;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.Image")));
            this.btnXuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatExcel.Location = new System.Drawing.Point(167, 31);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(93, 32);
            this.btnXuatExcel.TabIndex = 17;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(53, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(65, 32);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvCT_PhieuGiao);
            this.groupBox5.Location = new System.Drawing.Point(841, 56);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(484, 475);
            this.groupBox5.TabIndex = 122;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết phiếu giao";
            // 
            // dgvCT_PhieuGiao
            // 
            this.dgvCT_PhieuGiao.AllowUserToAddRows = false;
            this.dgvCT_PhieuGiao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_PhieuGiao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_PhieuGiao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.Column2,
            this.dataGridViewTextBoxColumn6});
            this.dgvCT_PhieuGiao.Location = new System.Drawing.Point(22, 24);
            this.dgvCT_PhieuGiao.MultiSelect = false;
            this.dgvCT_PhieuGiao.Name = "dgvCT_PhieuGiao";
            this.dgvCT_PhieuGiao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCT_PhieuGiao.Size = new System.Drawing.Size(447, 434);
            this.dgvCT_PhieuGiao.TabIndex = 29;
            this.dgvCT_PhieuGiao.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCT_PhieuGiao_CellFormatting);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MASP";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SOLUONG_CONGIAO";
            this.Column2.HeaderText = "Số lượng còn phải giao";
            this.Column2.Name = "Column2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SOLUONGGIAO";
            this.dataGridViewTextBoxColumn6.HeaderText = "Số lượng giao";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dgvPhieu_Giao
            // 
            this.dgvPhieu_Giao.AllowUserToAddRows = false;
            this.dgvPhieu_Giao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieu_Giao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieu_Giao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.magiao,
            this.ngaygiao,
            this.manv,
            this.maphieudat});
            this.dgvPhieu_Giao.Location = new System.Drawing.Point(16, 29);
            this.dgvPhieu_Giao.MultiSelect = false;
            this.dgvPhieu_Giao.Name = "dgvPhieu_Giao";
            this.dgvPhieu_Giao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieu_Giao.Size = new System.Drawing.Size(455, 195);
            this.dgvPhieu_Giao.TabIndex = 28;
            this.dgvPhieu_Giao.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPhieu_Giao_CellFormatting);
            this.dgvPhieu_Giao.Click += new System.EventHandler(this.dgvPhieu_Giao_Click);
            // 
            // magiao
            // 
            this.magiao.DataPropertyName = "MAPHIEUGIAO";
            this.magiao.HeaderText = "Mã phiếu giao";
            this.magiao.Name = "magiao";
            // 
            // ngaygiao
            // 
            this.ngaygiao.DataPropertyName = "NGAYGIAO";
            this.ngaygiao.HeaderText = "Ngày giao";
            this.ngaygiao.Name = "ngaygiao";
            // 
            // manv
            // 
            this.manv.DataPropertyName = "MANV";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.Name = "manv";
            // 
            // maphieudat
            // 
            this.maphieudat.DataPropertyName = "MADDH";
            this.maphieudat.HeaderText = "Mã đơn đặt";
            this.maphieudat.Name = "maphieudat";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Enabled = false;
            this.txtNhanVien.Location = new System.Drawing.Point(100, 99);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(193, 20);
            this.txtNhanVien.TabIndex = 24;
            // 
            // txtMaDonDat
            // 
            this.txtMaDonDat.Enabled = false;
            this.txtMaDonDat.Location = new System.Drawing.Point(99, 47);
            this.txtMaDonDat.Name = "txtMaDonDat";
            this.txtMaDonDat.Size = new System.Drawing.Size(193, 20);
            this.txtMaDonDat.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(498, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 33);
            this.label6.TabIndex = 123;
            this.label6.Text = "Giao hàng";
            // 
            // txtNgayGiao
            // 
            this.txtNgayGiao.CustomFormat = "dd/MM/yyyy";
            this.txtNgayGiao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayGiao.Location = new System.Drawing.Point(99, 73);
            this.txtNgayGiao.Name = "txtNgayGiao";
            this.txtNgayGiao.Size = new System.Drawing.Size(194, 20);
            this.txtNgayGiao.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Mã đơn đặt:";
            // 
            // txtPhieuGiao
            // 
            this.txtPhieuGiao.Enabled = false;
            this.txtPhieuGiao.Location = new System.Drawing.Point(99, 21);
            this.txtPhieuGiao.Name = "txtPhieuGiao";
            this.txtPhieuGiao.Size = new System.Drawing.Size(193, 20);
            this.txtPhieuGiao.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ngày giao:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã phiếu giao:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtKhachHang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNhanVien);
            this.groupBox1.Controls.Add(this.txtMaDonDat);
            this.groupBox1.Controls.Add(this.txtNgayGiao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPhieuGiao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(8, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 183);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(99, 151);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(193, 20);
            this.txtDiaChi.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Địa chỉ:";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Enabled = false;
            this.txtKhachHang.Location = new System.Drawing.Point(99, 125);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(193, 20);
            this.txtKhachHang.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nhân viên:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvPhieu_Giao);
            this.groupBox4.Location = new System.Drawing.Point(327, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(495, 244);
            this.groupBox4.TabIndex = 121;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách phiếu giao";
            // 
            // frmGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmGiaoHang";
            this.Text = "Giao hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGiaoHang_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGiaoHang_FormClosed);
            this.Load += new System.EventHandler(this.frmGiaoHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_HOADON)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_PhieuGiao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu_Giao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCT_HOADON;
        protected System.Windows.Forms.GroupBox groupBox3;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.Button btnXuatExcel;
        protected System.Windows.Forms.Button btnThem;
        protected System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvCT_PhieuGiao;
        private System.Windows.Forms.DataGridView dgvPhieu_Giao;
        protected System.Windows.Forms.TextBox txtNhanVien;
        protected System.Windows.Forms.TextBox txtMaDonDat;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.DateTimePicker txtNgayGiao;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox txtPhieuGiao;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.TextBox txtDiaChi;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.TextBox txtKhachHang;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluongmua;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluonggiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaygiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieudat;
    }
}