﻿namespace QL_VatLieuXayDung
{
    partial class fmPhieuNhapNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPhieuNhapNCC));
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCT_DatHang = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaDonDat = new System.Windows.Forms.TextBox();
            this.txtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvCT_NhapHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvNhapHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylapcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.bntLammoi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_DatHang)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_NhapHang)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(90, 112);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Size = new System.Drawing.Size(193, 20);
            this.txtNhanVien.TabIndex = 24;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCT_DatHang);
            this.groupBox3.Location = new System.Drawing.Point(325, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 225);
            this.groupBox3.TabIndex = 93;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sản phẩm đã đặt";
            // 
            // dgvCT_DatHang
            // 
            this.dgvCT_DatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_DatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_DatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.soluong,
            this.dongianhap});
            this.dgvCT_DatHang.Location = new System.Drawing.Point(16, 24);
            this.dgvCT_DatHang.Name = "dgvCT_DatHang";
            this.dgvCT_DatHang.Size = new System.Drawing.Size(455, 185);
            this.dgvCT_DatHang.TabIndex = 27;
            // 
            // masp
            // 
            this.masp.DataPropertyName = "MASP";
            this.masp.HeaderText = "Mã sản phẩm";
            this.masp.Name = "masp";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "SOLUONG";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // dongianhap
            // 
            this.dongianhap.DataPropertyName = "DONGIANHAP";
            this.dongianhap.HeaderText = "Đơn giá nhập";
            this.dongianhap.Name = "dongianhap";
            this.dongianhap.ReadOnly = true;
            // 
            // txtMaDonDat
            // 
            this.txtMaDonDat.Enabled = false;
            this.txtMaDonDat.Location = new System.Drawing.Point(90, 151);
            this.txtMaDonDat.Name = "txtMaDonDat";
            this.txtMaDonDat.Size = new System.Drawing.Size(193, 20);
            this.txtMaDonDat.TabIndex = 23;
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.CustomFormat = "dd/MM/yyyy";
            this.txtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayLap.Location = new System.Drawing.Point(90, 77);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(194, 20);
            this.txtNgayLap.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "mã đơn đặt";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Enabled = false;
            this.txtMaPN.Location = new System.Drawing.Point(90, 45);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(193, 20);
            this.txtMaPN.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ngày nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã phiếu nhập";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvCT_NhapHang);
            this.groupBox5.Location = new System.Drawing.Point(839, 56);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(484, 475);
            this.groupBox5.TabIndex = 96;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết phiếu nhập";
            // 
            // dgvCT_NhapHang
            // 
            this.dgvCT_NhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_NhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_NhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.Column2,
            this.dataGridViewTextBoxColumn6});
            this.dgvCT_NhapHang.Location = new System.Drawing.Point(22, 24);
            this.dgvCT_NhapHang.Name = "dgvCT_NhapHang";
            this.dgvCT_NhapHang.Size = new System.Drawing.Size(447, 434);
            this.dgvCT_NhapHang.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MASP";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DONGIANHAP";
            this.Column2.HeaderText = "Đơn giá nhập";
            this.Column2.Name = "Column2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SOLUONGNHAP";
            this.dataGridViewTextBoxColumn6.HeaderText = "Số lượng nhập";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(496, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 33);
            this.label6.TabIndex = 97;
            this.label6.Text = "Phiếp nhập hàng";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvNhapHang);
            this.groupBox4.Location = new System.Drawing.Point(325, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(495, 244);
            this.groupBox4.TabIndex = 95;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách phiếu nhập";
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ngaylapcol,
            this.Column1,
            this.dataGridViewTextBoxColumn3});
            this.dgvNhapHang.Location = new System.Drawing.Point(16, 29);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.Size = new System.Drawing.Size(455, 195);
            this.dgvNhapHang.TabIndex = 28;
            this.dgvNhapHang.Click += new System.EventHandler(this.dgvNhapHang_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAPN";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã phiếu nhập";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ngaylapcol
            // 
            this.ngaylapcol.DataPropertyName = "NGAYLAP";
            this.ngaylapcol.HeaderText = "Ngày nhập";
            this.ngaylapcol.Name = "ngaylapcol";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MANV";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MADATNCC";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã phiếu đặt";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhanVien);
            this.groupBox1.Controls.Add(this.txtMaDonDat);
            this.groupBox1.Controls.Add(this.txtNgayLap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaPN);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 225);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(49, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 55);
            this.button3.TabIndex = 17;
            this.button3.Text = "Xuất Excel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(49, 40);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 55);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "   Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // bntLammoi
            // 
            this.bntLammoi.Location = new System.Drawing.Point(146, 40);
            this.bntLammoi.Name = "bntLammoi";
            this.bntLammoi.Size = new System.Drawing.Size(80, 55);
            this.bntLammoi.TabIndex = 15;
            this.bntLammoi.Text = "Làm mới";
            this.bntLammoi.UseVisualStyleBackColor = true;
            this.bntLammoi.Click += new System.EventHandler(this.bntLammoi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.bntLammoi);
            this.groupBox2.Location = new System.Drawing.Point(6, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 228);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // fmPhieuNhapNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "fmPhieuNhapNCC";
            this.Text = "fmPhieuNhapNCC";
            this.Load += new System.EventHandler(this.fmPhieuNhapNCC_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_DatHang)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_NhapHang)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox txtNhanVien;
        protected System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCT_DatHang;
        protected System.Windows.Forms.TextBox txtMaDonDat;
        protected System.Windows.Forms.DateTimePicker txtNgayLap;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.TextBox txtMaPN;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.GroupBox groupBox5;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.GroupBox groupBox4;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Button button3;
        protected System.Windows.Forms.Button btnThem;
        protected System.Windows.Forms.Button bntLammoi;
        protected System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCT_NhapHang;
        private System.Windows.Forms.DataGridView dgvNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylapcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}