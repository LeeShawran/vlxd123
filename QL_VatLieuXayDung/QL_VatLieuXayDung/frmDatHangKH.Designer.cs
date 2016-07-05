namespace QL_VatLieuXayDung
{
    partial class frmDatHangKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatHangKH));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCT_DonDatHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxsanpham = new System.Windows.Forms.GroupBox();
            this.txtGiam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSanPHam = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.txtSoluongmua = new System.Windows.Forms.TextBox();
            this.lblSoluongmua = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDonDatHang = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaydat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tttt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kieutt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttgiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tonglangiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conlai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGiaoHang = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnLammoiHD = new System.Windows.Forms.Button();
            this.btnLuuDH = new System.Windows.Forms.Button();
            this.btnXoaDH = new System.Windows.Forms.Button();
            this.btnThemDH = new System.Windows.Forms.Button();
            this.groupBoxThongTinDH = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radtrasau = new System.Windows.Forms.RadioButton();
            this.radtratruoc = new System.Windows.Forms.RadioButton();
            this.txtConLai = new System.Windows.Forms.TextBox();
            this.txtTTThanhToan = new System.Windows.Forms.TextBox();
            this.cbKH = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTTGiao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTongLanGiao = new System.Windows.Forms.ComboBox();
            this.dtpNgaydat = new System.Windows.Forms.DateTimePicker();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.lblTongtien = new System.Windows.Forms.Label();
            this.lblTinhtrangthanhtoan = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaDH = new System.Windows.Forms.TextBox();
            this.lblNgaylap = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblMaHDBH = new System.Windows.Forms.Label();
            this.lblBanHangKhachHang = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_DonDatHang)).BeginInit();
            this.groupBoxsanpham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPHam)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBoxThongTinDH.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCT_DonDatHang);
            this.groupBox4.Controls.Add(this.groupBoxsanpham);
            this.groupBox4.Location = new System.Drawing.Point(779, 56);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(541, 460);
            this.groupBox4.TabIndex = 105;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết hóa đơn";
            // 
            // dgvCT_DonDatHang
            // 
            this.dgvCT_DonDatHang.AllowUserToAddRows = false;
            this.dgvCT_DonDatHang.AllowUserToDeleteRows = false;
            this.dgvCT_DonDatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_DonDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_DonDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvCT_DonDatHang.Location = new System.Drawing.Point(30, 262);
            this.dgvCT_DonDatHang.MultiSelect = false;
            this.dgvCT_DonDatHang.Name = "dgvCT_DonDatHang";
            this.dgvCT_DonDatHang.ReadOnly = true;
            this.dgvCT_DonDatHang.Size = new System.Drawing.Size(474, 192);
            this.dgvCT_DonDatHang.TabIndex = 1;
            this.dgvCT_DonDatHang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCT_DonDatHang_CellFormatting);
            this.dgvCT_DonDatHang.Click += new System.EventHandler(this.dgvCT_DonDatHang_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MASP";
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SOLUONG";
            this.Column2.HeaderText = "Số lượng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DONGIABAN";
            this.Column3.HeaderText = "Đơn giá bán";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GIAMGIA";
            this.Column4.HeaderText = "Giảm (%)";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBoxsanpham
            // 
            this.groupBoxsanpham.Controls.Add(this.txtGiam);
            this.groupBoxsanpham.Controls.Add(this.label2);
            this.groupBoxsanpham.Controls.Add(this.dgvSanPHam);
            this.groupBoxsanpham.Controls.Add(this.btnXoaCT);
            this.groupBoxsanpham.Controls.Add(this.btnThemCT);
            this.groupBoxsanpham.Controls.Add(this.txtSoluongmua);
            this.groupBoxsanpham.Controls.Add(this.lblSoluongmua);
            this.groupBoxsanpham.Location = new System.Drawing.Point(12, 19);
            this.groupBoxsanpham.Name = "groupBoxsanpham";
            this.groupBoxsanpham.Size = new System.Drawing.Size(514, 232);
            this.groupBoxsanpham.TabIndex = 0;
            this.groupBoxsanpham.TabStop = false;
            this.groupBoxsanpham.Text = "Sản phẩm trong kho";
            // 
            // txtGiam
            // 
            this.txtGiam.Enabled = false;
            this.txtGiam.Location = new System.Drawing.Point(242, 24);
            this.txtGiam.MaxLength = 2;
            this.txtGiam.Name = "txtGiam";
            this.txtGiam.Size = new System.Drawing.Size(46, 20);
            this.txtGiam.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 109;
            this.label2.Text = "Giảm %";
            // 
            // dgvSanPHam
            // 
            this.dgvSanPHam.AllowUserToAddRows = false;
            this.dgvSanPHam.AllowUserToDeleteRows = false;
            this.dgvSanPHam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPHam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPHam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.soluong,
            this.giaban});
            this.dgvSanPHam.Location = new System.Drawing.Point(18, 61);
            this.dgvSanPHam.MultiSelect = false;
            this.dgvSanPHam.Name = "dgvSanPHam";
            this.dgvSanPHam.ReadOnly = true;
            this.dgvSanPHam.Size = new System.Drawing.Size(474, 150);
            this.dgvSanPHam.TabIndex = 106;
            this.dgvSanPHam.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSanPHam_CellFormatting);
            this.dgvSanPHam.Click += new System.EventHandler(this.dgvSanPHam_Click);
            // 
            // masp
            // 
            this.masp.DataPropertyName = "MASP";
            this.masp.HeaderText = "Mã sản phẩm";
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "TENSP";
            this.tensp.HeaderText = "Tên sản phẩm";
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "SOLUONG";
            this.soluong.HeaderText = "Số lượng trong kho";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // giaban
            // 
            this.giaban.DataPropertyName = "DONGIABAN";
            this.giaban.HeaderText = "Giá bán";
            this.giaban.Name = "giaban";
            this.giaban.ReadOnly = true;
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCT.Image")));
            this.btnXoaCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCT.Location = new System.Drawing.Point(405, 12);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(66, 32);
            this.btnXoaCT.TabIndex = 4;
            this.btnXoaCT.Text = "Xóa";
            this.btnXoaCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCT.Image")));
            this.btnThemCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCT.Location = new System.Drawing.Point(323, 12);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(66, 32);
            this.btnThemCT.TabIndex = 3;
            this.btnThemCT.Text = "Thêm";
            this.btnThemCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemCT.UseVisualStyleBackColor = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // txtSoluongmua
            // 
            this.txtSoluongmua.Location = new System.Drawing.Point(96, 24);
            this.txtSoluongmua.Name = "txtSoluongmua";
            this.txtSoluongmua.Size = new System.Drawing.Size(34, 20);
            this.txtSoluongmua.TabIndex = 1;
            this.txtSoluongmua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoluongmua_KeyPress);
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
            this.groupBox1.Controls.Add(this.dgvDonDatHang);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBoxThongTinDH);
            this.groupBox1.Location = new System.Drawing.Point(3, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 460);
            this.groupBox1.TabIndex = 104;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bán hàng";
            // 
            // dgvDonDatHang
            // 
            this.dgvDonDatHang.AllowUserToAddRows = false;
            this.dgvDonDatHang.AllowUserToDeleteRows = false;
            this.dgvDonDatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.ngaydat,
            this.kh,
            this.nv,
            this.tongtien,
            this.tttt,
            this.kieutt,
            this.ttgiao,
            this.tonglangiao,
            this.conlai});
            this.dgvDonDatHang.Location = new System.Drawing.Point(15, 245);
            this.dgvDonDatHang.MultiSelect = false;
            this.dgvDonDatHang.Name = "dgvDonDatHang";
            this.dgvDonDatHang.ReadOnly = true;
            this.dgvDonDatHang.Size = new System.Drawing.Size(735, 204);
            this.dgvDonDatHang.TabIndex = 2;
            this.dgvDonDatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonDatHang_CellContentClick);
            this.dgvDonDatHang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDonDatHang_CellFormatting);
            this.dgvDonDatHang.Click += new System.EventHandler(this.dgvDonDatHang_Click);
            // 
            // ma
            // 
            this.ma.DataPropertyName = "MADDH";
            this.ma.HeaderText = "Mã đơn đặt";
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            // 
            // ngaydat
            // 
            this.ngaydat.DataPropertyName = "NGAYDDH";
            this.ngaydat.HeaderText = "Ngày đặt";
            this.ngaydat.Name = "ngaydat";
            this.ngaydat.ReadOnly = true;
            // 
            // kh
            // 
            this.kh.DataPropertyName = "MAKH";
            this.kh.HeaderText = "Khách hàng";
            this.kh.Name = "kh";
            this.kh.ReadOnly = true;
            // 
            // nv
            // 
            this.nv.DataPropertyName = "MANV";
            this.nv.HeaderText = "Nhân viên";
            this.nv.Name = "nv";
            this.nv.ReadOnly = true;
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "TONGTIEN";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.Name = "tongtien";
            this.tongtien.ReadOnly = true;
            // 
            // tttt
            // 
            this.tttt.DataPropertyName = "TINHTRANG_THANHTOAN";
            this.tttt.HeaderText = "Tình trạng thanh toán";
            this.tttt.Name = "tttt";
            this.tttt.ReadOnly = true;
            // 
            // kieutt
            // 
            this.kieutt.DataPropertyName = "KIEUTHANHTOAN";
            this.kieutt.HeaderText = "Kiểu thanh toán";
            this.kieutt.Name = "kieutt";
            this.kieutt.ReadOnly = true;
            // 
            // ttgiao
            // 
            this.ttgiao.DataPropertyName = "TINHTRANGGIAO";
            this.ttgiao.HeaderText = "Tình trạng giao";
            this.ttgiao.Name = "ttgiao";
            this.ttgiao.ReadOnly = true;
            // 
            // tonglangiao
            // 
            this.tonglangiao.DataPropertyName = "TONGLANGIAO";
            this.tonglangiao.HeaderText = "Tổng lần giao";
            this.tonglangiao.Name = "tonglangiao";
            this.tonglangiao.ReadOnly = true;
            // 
            // conlai
            // 
            this.conlai.DataPropertyName = "CONLAI";
            this.conlai.HeaderText = "Còn lại";
            this.conlai.Name = "conlai";
            this.conlai.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGiaoHang);
            this.groupBox3.Controls.Add(this.btnThanhToan);
            this.groupBox3.Controls.Add(this.btnLammoiHD);
            this.groupBox3.Controls.Add(this.btnLuuDH);
            this.groupBox3.Controls.Add(this.btnXoaDH);
            this.groupBox3.Controls.Add(this.btnThemDH);
            this.groupBox3.Location = new System.Drawing.Point(520, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 220);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác";
            // 
            // btnGiaoHang
            // 
            this.btnGiaoHang.Location = new System.Drawing.Point(133, 123);
            this.btnGiaoHang.Name = "btnGiaoHang";
            this.btnGiaoHang.Size = new System.Drawing.Size(81, 85);
            this.btnGiaoHang.TabIndex = 106;
            this.btnGiaoHang.Text = "Giao hàng";
            this.btnGiaoHang.UseVisualStyleBackColor = true;
            this.btnGiaoHang.Click += new System.EventHandler(this.btnGiaoHang_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(133, 16);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(81, 98);
            this.btnThanhToan.TabIndex = 104;
            this.btnThanhToan.Text = "Thanh toán đơn đặt hàng";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnLammoiHD
            // 
            this.btnLammoiHD.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoiHD.Image")));
            this.btnLammoiHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoiHD.Location = new System.Drawing.Point(15, 172);
            this.btnLammoiHD.Name = "btnLammoiHD";
            this.btnLammoiHD.Size = new System.Drawing.Size(82, 36);
            this.btnLammoiHD.TabIndex = 4;
            this.btnLammoiHD.Text = "Làm mới";
            this.btnLammoiHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoiHD.UseVisualStyleBackColor = true;
            this.btnLammoiHD.Click += new System.EventHandler(this.btnLammoiHD_Click);
            // 
            // btnLuuDH
            // 
            this.btnLuuDH.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuDH.Image")));
            this.btnLuuDH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuDH.Location = new System.Drawing.Point(15, 121);
            this.btnLuuDH.Name = "btnLuuDH";
            this.btnLuuDH.Size = new System.Drawing.Size(82, 42);
            this.btnLuuDH.TabIndex = 3;
            this.btnLuuDH.Text = "Lưu";
            this.btnLuuDH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuDH.UseVisualStyleBackColor = true;
            this.btnLuuDH.Click += new System.EventHandler(this.btnLuuDH_Click);
            // 
            // btnXoaDH
            // 
            this.btnXoaDH.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDH.Image")));
            this.btnXoaDH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDH.Location = new System.Drawing.Point(15, 72);
            this.btnXoaDH.Name = "btnXoaDH";
            this.btnXoaDH.Size = new System.Drawing.Size(82, 42);
            this.btnXoaDH.TabIndex = 1;
            this.btnXoaDH.Text = "Xóa";
            this.btnXoaDH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDH.UseVisualStyleBackColor = true;
            this.btnXoaDH.Click += new System.EventHandler(this.btnXoaDH_Click);
            // 
            // btnThemDH
            // 
            this.btnThemDH.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDH.Image")));
            this.btnThemDH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDH.Location = new System.Drawing.Point(15, 24);
            this.btnThemDH.Name = "btnThemDH";
            this.btnThemDH.Size = new System.Drawing.Size(82, 42);
            this.btnThemDH.TabIndex = 0;
            this.btnThemDH.Text = "Thêm";
            this.btnThemDH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDH.UseVisualStyleBackColor = true;
            this.btnThemDH.Click += new System.EventHandler(this.btnThemDH_Click);
            // 
            // groupBoxThongTinDH
            // 
            this.groupBoxThongTinDH.Controls.Add(this.label4);
            this.groupBoxThongTinDH.Controls.Add(this.groupBox2);
            this.groupBoxThongTinDH.Controls.Add(this.txtConLai);
            this.groupBoxThongTinDH.Controls.Add(this.txtTTThanhToan);
            this.groupBoxThongTinDH.Controls.Add(this.cbKH);
            this.groupBoxThongTinDH.Controls.Add(this.label1);
            this.groupBoxThongTinDH.Controls.Add(this.label3);
            this.groupBoxThongTinDH.Controls.Add(this.txtTTGiao);
            this.groupBoxThongTinDH.Controls.Add(this.label5);
            this.groupBoxThongTinDH.Controls.Add(this.cbTongLanGiao);
            this.groupBoxThongTinDH.Controls.Add(this.dtpNgaydat);
            this.groupBoxThongTinDH.Controls.Add(this.txtTongtien);
            this.groupBoxThongTinDH.Controls.Add(this.lblTongtien);
            this.groupBoxThongTinDH.Controls.Add(this.lblTinhtrangthanhtoan);
            this.groupBoxThongTinDH.Controls.Add(this.txtMaNV);
            this.groupBoxThongTinDH.Controls.Add(this.txtMaDH);
            this.groupBoxThongTinDH.Controls.Add(this.lblNgaylap);
            this.groupBoxThongTinDH.Controls.Add(this.lblMaNV);
            this.groupBoxThongTinDH.Controls.Add(this.lblMaHDBH);
            this.groupBoxThongTinDH.Location = new System.Drawing.Point(15, 19);
            this.groupBoxThongTinDH.Name = "groupBoxThongTinDH";
            this.groupBoxThongTinDH.Size = new System.Drawing.Size(499, 220);
            this.groupBoxThongTinDH.TabIndex = 0;
            this.groupBoxThongTinDH.TabStop = false;
            this.groupBoxThongTinDH.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 26);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tình trạng \r\ngiao";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radtrasau);
            this.groupBox2.Controls.Add(this.radtratruoc);
            this.groupBox2.Location = new System.Drawing.Point(318, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 84);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiểu thanh toán";
            // 
            // radtrasau
            // 
            this.radtrasau.AutoSize = true;
            this.radtrasau.Location = new System.Drawing.Point(10, 42);
            this.radtrasau.Name = "radtrasau";
            this.radtrasau.Size = new System.Drawing.Size(130, 17);
            this.radtrasau.TabIndex = 1;
            this.radtrasau.Text = "Trả sau (đặt cọc 30%)";
            this.radtrasau.UseVisualStyleBackColor = true;
            this.radtrasau.CheckedChanged += new System.EventHandler(this.radtrasau_CheckedChanged);
            // 
            // radtratruoc
            // 
            this.radtratruoc.AutoSize = true;
            this.radtratruoc.Checked = true;
            this.radtratruoc.Location = new System.Drawing.Point(10, 19);
            this.radtratruoc.Name = "radtratruoc";
            this.radtratruoc.Size = new System.Drawing.Size(97, 17);
            this.radtratruoc.TabIndex = 0;
            this.radtratruoc.TabStop = true;
            this.radtratruoc.Text = "Trả trước 100%";
            this.radtratruoc.UseVisualStyleBackColor = true;
            this.radtratruoc.CheckedChanged += new System.EventHandler(this.radtratruoc_CheckedChanged);
            // 
            // txtConLai
            // 
            this.txtConLai.Enabled = false;
            this.txtConLai.Location = new System.Drawing.Point(393, 152);
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.Size = new System.Drawing.Size(92, 20);
            this.txtConLai.TabIndex = 111;
            // 
            // txtTTThanhToan
            // 
            this.txtTTThanhToan.Enabled = false;
            this.txtTTThanhToan.Location = new System.Drawing.Point(140, 145);
            this.txtTTThanhToan.Name = "txtTTThanhToan";
            this.txtTTThanhToan.Size = new System.Drawing.Size(143, 20);
            this.txtTTThanhToan.TabIndex = 36;
            // 
            // cbKH
            // 
            this.cbKH.FormattingEnabled = true;
            this.cbKH.Location = new System.Drawing.Point(140, 91);
            this.cbKH.Name = "cbKH";
            this.cbKH.Size = new System.Drawing.Size(143, 21);
            this.cbKH.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 110;
            this.label1.Text = "Còn lại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Khách hàng:";
            // 
            // txtTTGiao
            // 
            this.txtTTGiao.Enabled = false;
            this.txtTTGiao.Location = new System.Drawing.Point(141, 174);
            this.txtTTGiao.Name = "txtTTGiao";
            this.txtTTGiao.Size = new System.Drawing.Size(142, 20);
            this.txtTTGiao.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 109;
            this.label5.Text = "Tổng lần giao";
            // 
            // cbTongLanGiao
            // 
            this.cbTongLanGiao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTongLanGiao.FormattingEnabled = true;
            this.cbTongLanGiao.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbTongLanGiao.Location = new System.Drawing.Point(393, 122);
            this.cbTongLanGiao.Name = "cbTongLanGiao";
            this.cbTongLanGiao.Size = new System.Drawing.Size(92, 21);
            this.cbTongLanGiao.TabIndex = 108;
            this.cbTongLanGiao.SelectedValueChanged += new System.EventHandler(this.cbTongLanGiao_SelectedValueChanged);
            // 
            // dtpNgaydat
            // 
            this.dtpNgaydat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaydat.Enabled = false;
            this.dtpNgaydat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaydat.Location = new System.Drawing.Point(140, 65);
            this.dtpNgaydat.Name = "dtpNgaydat";
            this.dtpNgaydat.Size = new System.Drawing.Size(143, 20);
            this.dtpNgaydat.TabIndex = 11;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Enabled = false;
            this.txtTongtien.Location = new System.Drawing.Point(140, 119);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(143, 20);
            this.txtTongtien.TabIndex = 7;
            // 
            // lblTongtien
            // 
            this.lblTongtien.AutoSize = true;
            this.lblTongtien.Location = new System.Drawing.Point(18, 122);
            this.lblTongtien.Name = "lblTongtien";
            this.lblTongtien.Size = new System.Drawing.Size(55, 13);
            this.lblTongtien.TabIndex = 6;
            this.lblTongtien.Text = "Tổng tiền:";
            // 
            // lblTinhtrangthanhtoan
            // 
            this.lblTinhtrangthanhtoan.AutoSize = true;
            this.lblTinhtrangthanhtoan.Location = new System.Drawing.Point(18, 148);
            this.lblTinhtrangthanhtoan.Name = "lblTinhtrangthanhtoan";
            this.lblTinhtrangthanhtoan.Size = new System.Drawing.Size(112, 13);
            this.lblTinhtrangthanhtoan.TabIndex = 9;
            this.lblTinhtrangthanhtoan.Text = "Tình trạng thanh toán:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(140, 42);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(143, 20);
            this.txtMaNV.TabIndex = 4;
            // 
            // txtMaDH
            // 
            this.txtMaDH.Enabled = false;
            this.txtMaDH.Location = new System.Drawing.Point(140, 16);
            this.txtMaDH.Name = "txtMaDH";
            this.txtMaDH.Size = new System.Drawing.Size(143, 20);
            this.txtMaDH.TabIndex = 3;
            // 
            // lblNgaylap
            // 
            this.lblNgaylap.AutoSize = true;
            this.lblNgaylap.Location = new System.Drawing.Point(18, 68);
            this.lblNgaylap.Name = "lblNgaylap";
            this.lblNgaylap.Size = new System.Drawing.Size(51, 13);
            this.lblNgaylap.TabIndex = 2;
            this.lblNgaylap.Text = "Ngày đặt";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(18, 45);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(75, 13);
            this.lblMaNV.TabIndex = 1;
            this.lblMaNV.Text = "Mã nhân viên:";
            // 
            // lblMaHDBH
            // 
            this.lblMaHDBH.AutoSize = true;
            this.lblMaHDBH.Location = new System.Drawing.Point(18, 19);
            this.lblMaHDBH.Name = "lblMaHDBH";
            this.lblMaHDBH.Size = new System.Drawing.Size(93, 13);
            this.lblMaHDBH.TabIndex = 0;
            this.lblMaHDBH.Text = "Mã đơn đặt hàng:";
            // 
            // lblBanHangKhachHang
            // 
            this.lblBanHangKhachHang.AutoSize = true;
            this.lblBanHangKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanHangKhachHang.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblBanHangKhachHang.Location = new System.Drawing.Point(507, 12);
            this.lblBanHangKhachHang.Name = "lblBanHangKhachHang";
            this.lblBanHangKhachHang.Size = new System.Drawing.Size(385, 33);
            this.lblBanHangKhachHang.TabIndex = 103;
            this.lblBanHangKhachHang.Text = "ĐẶT HÀNG KHÁCH HÀNG";
            // 
            // frmDatHangKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 542);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBanHangKhachHang);
            this.Name = "frmDatHangKH";
            this.Text = "Bán hàng khách hàng";
            this.Load += new System.EventHandler(this.frmDatHangKH_Load);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_DonDatHang)).EndInit();
            this.groupBoxsanpham.ResumeLayout(false);
            this.groupBoxsanpham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPHam)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBoxThongTinDH.ResumeLayout(false);
            this.groupBoxThongTinDH.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvCT_DonDatHang;
        private System.Windows.Forms.GroupBox groupBoxsanpham;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.TextBox txtSoluongmua;
        private System.Windows.Forms.Label lblSoluongmua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDonDatHang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLammoiHD;
        private System.Windows.Forms.Button btnLuuDH;
        private System.Windows.Forms.Button btnXoaDH;
        private System.Windows.Forms.Button btnThemDH;
        private System.Windows.Forms.GroupBox groupBoxThongTinDH;
        private System.Windows.Forms.DateTimePicker dtpNgaydat;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label lblTongtien;
        private System.Windows.Forms.Label lblTinhtrangthanhtoan;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaDH;
        private System.Windows.Forms.Label lblNgaylap;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblMaHDBH;
        protected System.Windows.Forms.Label lblBanHangKhachHang;
        private System.Windows.Forms.DataGridView dgvSanPHam;
        private System.Windows.Forms.ComboBox cbKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTTThanhToan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.Button btnGiaoHang;
        private System.Windows.Forms.TextBox txtConLai;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTongLanGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaydat;
        private System.Windows.Forms.DataGridViewTextBoxColumn kh;
        private System.Windows.Forms.DataGridViewTextBoxColumn nv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tttt;
        private System.Windows.Forms.DataGridViewTextBoxColumn kieutt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttgiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn tonglangiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn conlai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radtrasau;
        private System.Windows.Forms.RadioButton radtratruoc;
        private System.Windows.Forms.TextBox txtTTGiao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox txtGiam;
        private System.Windows.Forms.Label label2;


    }
}