﻿namespace QL_VatLieuXayDung
{
    partial class frmBanHangKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHangKH));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvSanPHam = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuaSP = new System.Windows.Forms.Button();
            this.btnXoaSP = new System.Windows.Forms.Button();
            this.txtGiaban = new System.Windows.Forms.TextBox();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.lblGiaban = new System.Windows.Forms.Label();
            this.txtSoluongmua = new System.Windows.Forms.TextBox();
            this.lblSoluongmua = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLammoiHD = new System.Windows.Forms.Button();
            this.btnLuuHD = new System.Windows.Forms.Button();
            this.btnSuaHD = new System.Windows.Forms.Button();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTinhtrangThanhtoan = new System.Windows.Forms.TextBox();
            this.dtpNgaylap = new System.Windows.Forms.DateTimePicker();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.lblTinhtrangthanhtoan = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaHDBH = new System.Windows.Forms.TextBox();
            this.lblNgaylap = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblMaHDBH = new System.Windows.Forms.Label();
            this.lblBanHangKhachHang = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPHam)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCTHD);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(729, 56);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(541, 475);
            this.groupBox4.TabIndex = 105;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết hóa đơn";
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Location = new System.Drawing.Point(6, 277);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.Size = new System.Drawing.Size(438, 192);
            this.dgvCTHD.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvSanPHam);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.btnSuaSP);
            this.groupBox5.Controls.Add(this.btnXoaSP);
            this.groupBox5.Controls.Add(this.txtGiaban);
            this.groupBox5.Controls.Add(this.btnThemSP);
            this.groupBox5.Controls.Add(this.lblGiaban);
            this.groupBox5.Controls.Add(this.txtSoluongmua);
            this.groupBox5.Controls.Add(this.lblSoluongmua);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(517, 243);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sản phẩm trong kho";
            // 
            // dgvSanPHam
            // 
            this.dgvSanPHam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPHam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPHam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.soluong});
            this.dgvSanPHam.Location = new System.Drawing.Point(6, 65);
            this.dgvSanPHam.Name = "dgvSanPHam";
            this.dgvSanPHam.Size = new System.Drawing.Size(356, 150);
            this.dgvSanPHam.TabIndex = 106;
            // 
            // masp
            // 
            this.masp.DataPropertyName = "MASP";
            this.masp.HeaderText = "Mã sản phẩm";
            this.masp.Name = "masp";
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "TENSP";
            this.tensp.HeaderText = "Tên sản phẩm";
            this.tensp.Name = "tensp";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "SOLUONG";
            this.soluong.HeaderText = "Số lượng trong kho";
            this.soluong.Name = "soluong";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(378, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(45, 21);
            this.comboBox1.TabIndex = 106;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Khuyến mãi:";
            // 
            // btnSuaSP
            // 
            this.btnSuaSP.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaSP.Image")));
            this.btnSuaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaSP.Location = new System.Drawing.Point(419, 169);
            this.btnSuaSP.Name = "btnSuaSP";
            this.btnSuaSP.Size = new System.Drawing.Size(66, 42);
            this.btnSuaSP.TabIndex = 5;
            this.btnSuaSP.Text = "Sửa";
            this.btnSuaSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaSP.UseVisualStyleBackColor = true;
            // 
            // btnXoaSP
            // 
            this.btnXoaSP.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaSP.Image")));
            this.btnXoaSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaSP.Location = new System.Drawing.Point(419, 115);
            this.btnXoaSP.Name = "btnXoaSP";
            this.btnXoaSP.Size = new System.Drawing.Size(66, 42);
            this.btnXoaSP.TabIndex = 4;
            this.btnXoaSP.Text = "Xóa";
            this.btnXoaSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaSP.UseVisualStyleBackColor = true;
            // 
            // txtGiaban
            // 
            this.txtGiaban.Location = new System.Drawing.Point(189, 24);
            this.txtGiaban.Name = "txtGiaban";
            this.txtGiaban.Size = new System.Drawing.Size(94, 20);
            this.txtGiaban.TabIndex = 3;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSP.Image")));
            this.btnThemSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemSP.Location = new System.Drawing.Point(419, 53);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(66, 42);
            this.btnThemSP.TabIndex = 3;
            this.btnThemSP.Text = "Thêm";
            this.btnThemSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSP.UseVisualStyleBackColor = true;
            // 
            // lblGiaban
            // 
            this.lblGiaban.AutoSize = true;
            this.lblGiaban.Location = new System.Drawing.Point(136, 27);
            this.lblGiaban.Name = "lblGiaban";
            this.lblGiaban.Size = new System.Drawing.Size(47, 13);
            this.lblGiaban.TabIndex = 2;
            this.lblGiaban.Text = "Giá bán:";
            // 
            // txtSoluongmua
            // 
            this.txtSoluongmua.Location = new System.Drawing.Point(96, 24);
            this.txtSoluongmua.Name = "txtSoluongmua";
            this.txtSoluongmua.Size = new System.Drawing.Size(34, 20);
            this.txtSoluongmua.TabIndex = 1;
            // 
            // lblSoluongmua
            // 
            this.lblSoluongmua.AutoSize = true;
            this.lblSoluongmua.Location = new System.Drawing.Point(15, 27);
            this.lblSoluongmua.Name = "lblSoluongmua";
            this.lblSoluongmua.Size = new System.Drawing.Size(75, 13);
            this.lblSoluongmua.TabIndex = 0;
            this.lblSoluongmua.Text = "Số lượng mua:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHD);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(141, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 475);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bán hàng";
            // 
            // dgvHD
            // 
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Location = new System.Drawing.Point(15, 277);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.Size = new System.Drawing.Size(553, 192);
            this.dgvHD.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLammoiHD);
            this.groupBox3.Controls.Add(this.btnLuuHD);
            this.groupBox3.Controls.Add(this.btnSuaHD);
            this.groupBox3.Controls.Add(this.btnXoaHD);
            this.groupBox3.Controls.Add(this.btnThemHD);
            this.groupBox3.Location = new System.Drawing.Point(345, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 187);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác";
            // 
            // btnLammoiHD
            // 
            this.btnLammoiHD.Location = new System.Drawing.Point(27, 130);
            this.btnLammoiHD.Name = "btnLammoiHD";
            this.btnLammoiHD.Size = new System.Drawing.Size(168, 51);
            this.btnLammoiHD.TabIndex = 4;
            this.btnLammoiHD.Text = "Làm mới";
            this.btnLammoiHD.UseVisualStyleBackColor = true;
            // 
            // btnLuuHD
            // 
            this.btnLuuHD.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuHD.Image")));
            this.btnLuuHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuHD.Location = new System.Drawing.Point(132, 79);
            this.btnLuuHD.Name = "btnLuuHD";
            this.btnLuuHD.Size = new System.Drawing.Size(63, 42);
            this.btnLuuHD.TabIndex = 3;
            this.btnLuuHD.Text = "Lưu";
            this.btnLuuHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuHD.UseVisualStyleBackColor = true;
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaHD.Image")));
            this.btnSuaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaHD.Location = new System.Drawing.Point(27, 79);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(66, 42);
            this.btnSuaHD.TabIndex = 2;
            this.btnSuaHD.Text = "Sửa";
            this.btnSuaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaHD.UseVisualStyleBackColor = true;
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHD.Image")));
            this.btnXoaHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaHD.Location = new System.Drawing.Point(132, 24);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(63, 42);
            this.btnXoaHD.TabIndex = 1;
            this.btnXoaHD.Text = "Xóa";
            this.btnXoaHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaHD.UseVisualStyleBackColor = true;
            // 
            // btnThemHD
            // 
            this.btnThemHD.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHD.Image")));
            this.btnThemHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHD.Location = new System.Drawing.Point(27, 24);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(66, 42);
            this.btnThemHD.TabIndex = 0;
            this.btnThemHD.Text = "Thêm";
            this.btnThemHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemHD.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTinhtrangThanhtoan);
            this.groupBox2.Controls.Add(this.dtpNgaylap);
            this.groupBox2.Controls.Add(this.txtTongtien);
            this.groupBox2.Controls.Add(this.lblTongtien);
            this.groupBox2.Controls.Add(this.lblTinhtrangthanhtoan);
            this.groupBox2.Controls.Add(this.txtMaNV);
            this.groupBox2.Controls.Add(this.txtMaHDBH);
            this.groupBox2.Controls.Add(this.lblNgaylap);
            this.groupBox2.Controls.Add(this.lblMaNV);
            this.groupBox2.Controls.Add(this.lblMaHDBH);
            this.groupBox2.Location = new System.Drawing.Point(15, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 243);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(140, 218);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 20);
            this.textBox3.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tình trạng giao";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(140, 193);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(166, 20);
            this.textBox4.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Số lần giao";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 167);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 20);
            this.textBox2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tình trạng thanh toán:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tổng số lượng";
            // 
            // txtTinhtrangThanhtoan
            // 
            this.txtTinhtrangThanhtoan.Location = new System.Drawing.Point(140, 113);
            this.txtTinhtrangThanhtoan.Name = "txtTinhtrangThanhtoan";
            this.txtTinhtrangThanhtoan.Size = new System.Drawing.Size(166, 20);
            this.txtTinhtrangThanhtoan.TabIndex = 12;
            // 
            // dtpNgaylap
            // 
            this.dtpNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaylap.Location = new System.Drawing.Point(140, 61);
            this.dtpNgaylap.Name = "dtpNgaylap";
            this.dtpNgaylap.Size = new System.Drawing.Size(166, 20);
            this.dtpNgaylap.TabIndex = 11;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(140, 87);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(166, 20);
            this.txtTongtien.TabIndex = 7;
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Location = new System.Drawing.Point(18, 93);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(55, 13);
            this.lblTongtien.TabIndex = 6;
            this.lblTongtien.Text = "Tổng tiền:";
            // 
            // lblTinhtrangthanhtoan
            // 
            this.lblTinhtrangthanhtoan.AutoSize = true;
            this.lblTinhtrangthanhtoan.Location = new System.Drawing.Point(18, 119);
            this.lblTinhtrangthanhtoan.Name = "lblTinhtrangthanhtoan";
            this.lblTinhtrangthanhtoan.Size = new System.Drawing.Size(112, 13);
            this.lblTinhtrangthanhtoan.TabIndex = 9;
            this.lblTinhtrangthanhtoan.Text = "Tình trạng thanh toán:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(140, 36);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(166, 20);
            this.txtMaNV.TabIndex = 4;
            // 
            // txtMaHDBH
            // 
            this.txtMaHDBH.Location = new System.Drawing.Point(140, 10);
            this.txtMaHDBH.Name = "txtMaHDBH";
            this.txtMaHDBH.Size = new System.Drawing.Size(166, 20);
            this.txtMaHDBH.TabIndex = 3;
            // 
            // lblNgaylap
            // 
            this.lblNgaylap.AutoSize = true;
            this.lblNgaylap.Location = new System.Drawing.Point(18, 68);
            this.lblNgaylap.Name = "lblNgaylap";
            this.lblNgaylap.Size = new System.Drawing.Size(52, 13);
            this.lblNgaylap.TabIndex = 2;
            this.lblNgaylap.Text = "Ngày lập:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(18, 42);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(75, 13);
            this.lblMaNV.TabIndex = 1;
            this.lblMaNV.Text = "Mã nhân viên:";
            // 
            // lblMaHDBH
            // 
            this.lblMaHDBH.AutoSize = true;
            this.lblMaHDBH.Location = new System.Drawing.Point(18, 16);
            this.lblMaHDBH.Name = "lblMaHDBH";
            this.lblMaHDBH.Size = new System.Drawing.Size(116, 13);
            this.lblMaHDBH.TabIndex = 0;
            this.lblMaHDBH.Text = "Mã hóa đơn bán hàng:";
            // 
            // lblBanHangKhachHang
            // 
            this.lblBanHangKhachHang.AutoSize = true;
            this.lblBanHangKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanHangKhachHang.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBanHangKhachHang.Location = new System.Drawing.Point(507, 12);
            this.lblBanHangKhachHang.Name = "lblBanHangKhachHang";
            this.lblBanHangKhachHang.Size = new System.Drawing.Size(386, 33);
            this.lblBanHangKhachHang.TabIndex = 103;
            this.lblBanHangKhachHang.Text = "BÁN HÀNG KHÁCH HÀNG";
            // 
            // frmBanHangKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 542);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBanHangKhachHang);
            this.Name = "frmBanHangKH";
            this.Text = "Bán hàng khách hàng";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPHam)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSuaSP;
        private System.Windows.Forms.Button btnXoaSP;
        private System.Windows.Forms.TextBox txtGiaban;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.Label lblGiaban;
        private System.Windows.Forms.TextBox txtSoluongmua;
        private System.Windows.Forms.Label lblSoluongmua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLammoiHD;
        private System.Windows.Forms.Button btnLuuHD;
        private System.Windows.Forms.Button btnSuaHD;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTinhtrangThanhtoan;
        private System.Windows.Forms.DateTimePicker dtpNgaylap;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.Label lblTinhtrangthanhtoan;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaHDBH;
        private System.Windows.Forms.Label lblNgaylap;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblMaHDBH;
        protected System.Windows.Forms.Label lblBanHangKhachHang;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSanPHam;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;


    }
}