namespace QL_VatLieuXayDung
{
    partial class frmDonDatHangNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonDatHangNCC));
            this.lblMaDDHNCC = new System.Windows.Forms.Label();
            this.lblNgaylap_DDHNCC = new System.Windows.Forms.Label();
            this.lblNCC_DDHNCC = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.cbNCC = new System.Windows.Forms.ComboBox();
            this.dgvDonDatHang = new System.Windows.Forms.DataGridView();
            this.madondat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbDSDDH = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnPhieuNhap = new System.Windows.Forms.Button();
            this.groupBoxThongTinDH = new System.Windows.Forms.GroupBox();
            this.txtTinhTrangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV_DDHNCC = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btnXoaDDH = new System.Windows.Forms.Button();
            this.btnLuuDDH = new System.Windows.Forms.Button();
            this.btnThemDDH = new System.Windows.Forms.Button();
            this.lblDDH_NCC = new System.Windows.Forms.Label();
            this.groupBoxSanPham = new System.Windows.Forms.GroupBox();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.dgvSanPHam = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSLDat = new System.Windows.Forms.TextBox();
            this.lblSoluongdat = new System.Windows.Forms.Label();
            this.groupBoxCT_DDH = new System.Windows.Forms.GroupBox();
            this.dgvCTDonDatHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).BeginInit();
            this.grbDSDDH.SuspendLayout();
            this.groupBoxThongTinDH.SuspendLayout();
            this.groupBoxSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPHam)).BeginInit();
            this.groupBoxCT_DDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDonDatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaDDHNCC
            // 
            this.lblMaDDHNCC.AutoSize = true;
            this.lblMaDDHNCC.Location = new System.Drawing.Point(21, 27);
            this.lblMaDDHNCC.Name = "lblMaDDHNCC";
            this.lblMaDDHNCC.Size = new System.Drawing.Size(100, 13);
            this.lblMaDDHNCC.TabIndex = 0;
            this.lblMaDDHNCC.Text = "Mã phiếu đặt hàng:";
            // 
            // lblNgaylap_DDHNCC
            // 
            this.lblNgaylap_DDHNCC.AutoSize = true;
            this.lblNgaylap_DDHNCC.Location = new System.Drawing.Point(21, 80);
            this.lblNgaylap_DDHNCC.Name = "lblNgaylap_DDHNCC";
            this.lblNgaylap_DDHNCC.Size = new System.Drawing.Size(52, 13);
            this.lblNgaylap_DDHNCC.TabIndex = 1;
            this.lblNgaylap_DDHNCC.Text = "Ngày lập:";
            // 
            // lblNCC_DDHNCC
            // 
            this.lblNCC_DDHNCC.AutoSize = true;
            this.lblNCC_DDHNCC.Location = new System.Drawing.Point(21, 105);
            this.lblNCC_DDHNCC.Name = "lblNCC_DDHNCC";
            this.lblNCC_DDHNCC.Size = new System.Drawing.Size(78, 13);
            this.lblNCC_DDHNCC.TabIndex = 2;
            this.lblNCC_DDHNCC.Text = "Nhà cung cấp:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Enabled = false;
            this.txtMaPhieu.Location = new System.Drawing.Point(127, 24);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(174, 20);
            this.txtMaPhieu.TabIndex = 5;
            // 
            // cbNCC
            // 
            this.cbNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNCC.FormattingEnabled = true;
            this.cbNCC.Location = new System.Drawing.Point(127, 102);
            this.cbNCC.Name = "cbNCC";
            this.cbNCC.Size = new System.Drawing.Size(174, 21);
            this.cbNCC.TabIndex = 7;
            this.cbNCC.SelectedIndexChanged += new System.EventHandler(this.cbNCC_SelectedIndexChanged);
            // 
            // dgvDonDatHang
            // 
            this.dgvDonDatHang.AllowUserToAddRows = false;
            this.dgvDonDatHang.AllowUserToDeleteRows = false;
            this.dgvDonDatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madondat,
            this.Column4,
            this.Column5,
            this.Column9,
            this.ttnhap});
            this.dgvDonDatHang.Location = new System.Drawing.Point(23, 206);
            this.dgvDonDatHang.Name = "dgvDonDatHang";
            this.dgvDonDatHang.ReadOnly = true;
            this.dgvDonDatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonDatHang.Size = new System.Drawing.Size(507, 262);
            this.dgvDonDatHang.TabIndex = 12;
            this.dgvDonDatHang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDonDatHang_CellFormatting);
            this.dgvDonDatHang.Click += new System.EventHandler(this.dgvDonDatHang_Click);
            // 
            // madondat
            // 
            this.madondat.DataPropertyName = "MADATNCC";
            this.madondat.HeaderText = "Mã đơn đặt ";
            this.madondat.Name = "madondat";
            this.madondat.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NGAYDATNCC";
            this.Column4.HeaderText = "Ngày lập";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MANCC";
            this.Column5.HeaderText = "Nhà cung cấp";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MANV";
            this.Column9.HeaderText = "Nhân viên";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // ttnhap
            // 
            this.ttnhap.DataPropertyName = "TINHTRANGNHAP";
            this.ttnhap.HeaderText = "Tình trạng";
            this.ttnhap.Name = "ttnhap";
            this.ttnhap.ReadOnly = true;
            // 
            // grbDSDDH
            // 
            this.grbDSDDH.Controls.Add(this.btnLamMoi);
            this.grbDSDDH.Controls.Add(this.btnPhieuNhap);
            this.grbDSDDH.Controls.Add(this.groupBoxThongTinDH);
            this.grbDSDDH.Controls.Add(this.btnXoaDDH);
            this.grbDSDDH.Controls.Add(this.btnLuuDDH);
            this.grbDSDDH.Controls.Add(this.btnThemDDH);
            this.grbDSDDH.Controls.Add(this.dgvDonDatHang);
            this.grbDSDDH.Location = new System.Drawing.Point(103, 45);
            this.grbDSDDH.Name = "grbDSDDH";
            this.grbDSDDH.Size = new System.Drawing.Size(558, 485);
            this.grbDSDDH.TabIndex = 15;
            this.grbDSDDH.TabStop = false;
            this.grbDSDDH.Text = "Danh sách đơn đặt hàng";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLamMoi.Location = new System.Drawing.Point(449, 149);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(81, 36);
            this.btnLamMoi.TabIndex = 102;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnPhieuNhap
            // 
            this.btnPhieuNhap.Location = new System.Drawing.Point(449, 23);
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.Size = new System.Drawing.Size(81, 114);
            this.btnPhieuNhap.TabIndex = 101;
            this.btnPhieuNhap.Text = "Tạo phiếu nhập";
            this.btnPhieuNhap.UseVisualStyleBackColor = true;
            this.btnPhieuNhap.Click += new System.EventHandler(this.btnPhieuNhap_Click);
            // 
            // groupBoxThongTinDH
            // 
            this.groupBoxThongTinDH.Controls.Add(this.txtTinhTrangNhap);
            this.groupBoxThongTinDH.Controls.Add(this.label1);
            this.groupBoxThongTinDH.Controls.Add(this.lblMaDDHNCC);
            this.groupBoxThongTinDH.Controls.Add(this.lblNgaylap_DDHNCC);
            this.groupBoxThongTinDH.Controls.Add(this.lblNCC_DDHNCC);
            this.groupBoxThongTinDH.Controls.Add(this.txtMaNV);
            this.groupBoxThongTinDH.Controls.Add(this.txtMaPhieu);
            this.groupBoxThongTinDH.Controls.Add(this.lblMaNV_DDHNCC);
            this.groupBoxThongTinDH.Controls.Add(this.cbNCC);
            this.groupBoxThongTinDH.Controls.Add(this.dtpNgayLap);
            this.groupBoxThongTinDH.Location = new System.Drawing.Point(23, 20);
            this.groupBoxThongTinDH.Name = "groupBoxThongTinDH";
            this.groupBoxThongTinDH.Size = new System.Drawing.Size(316, 166);
            this.groupBoxThongTinDH.TabIndex = 100;
            this.groupBoxThongTinDH.TabStop = false;
            // 
            // txtTinhTrangNhap
            // 
            this.txtTinhTrangNhap.Enabled = false;
            this.txtTinhTrangNhap.Location = new System.Drawing.Point(127, 129);
            this.txtTinhTrangNhap.Name = "txtTinhTrangNhap";
            this.txtTinhTrangNhap.Size = new System.Drawing.Size(174, 20);
            this.txtTinhTrangNhap.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Tình trạng nhập:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(127, 50);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(174, 20);
            this.txtMaNV.TabIndex = 25;
            // 
            // lblMaNV_DDHNCC
            // 
            this.lblMaNV_DDHNCC.AutoSize = true;
            this.lblMaNV_DDHNCC.Location = new System.Drawing.Point(21, 54);
            this.lblMaNV_DDHNCC.Name = "lblMaNV_DDHNCC";
            this.lblMaNV_DDHNCC.Size = new System.Drawing.Size(75, 13);
            this.lblMaNV_DDHNCC.TabIndex = 24;
            this.lblMaNV_DDHNCC.Text = "Mã nhân viên:";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Enabled = false;
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayLap.Location = new System.Drawing.Point(127, 76);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(174, 20);
            this.dtpNgayLap.TabIndex = 22;
            // 
            // btnXoaDDH
            // 
            this.btnXoaDDH.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDDH.Image")));
            this.btnXoaDDH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaDDH.Location = new System.Drawing.Point(362, 88);
            this.btnXoaDDH.Name = "btnXoaDDH";
            this.btnXoaDDH.Size = new System.Drawing.Size(70, 36);
            this.btnXoaDDH.TabIndex = 19;
            this.btnXoaDDH.Text = "Xóa";
            this.btnXoaDDH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDDH.UseVisualStyleBackColor = true;
            this.btnXoaDDH.Click += new System.EventHandler(this.btnXoaDDH_Click);
            // 
            // btnLuuDDH
            // 
            this.btnLuuDDH.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuDDH.Image")));
            this.btnLuuDDH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuuDDH.Location = new System.Drawing.Point(362, 149);
            this.btnLuuDDH.Name = "btnLuuDDH";
            this.btnLuuDDH.Size = new System.Drawing.Size(70, 36);
            this.btnLuuDDH.TabIndex = 20;
            this.btnLuuDDH.Text = "Lưu";
            this.btnLuuDDH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuDDH.UseVisualStyleBackColor = true;
            this.btnLuuDDH.Click += new System.EventHandler(this.btnLuuDDH_Click);
            // 
            // btnThemDDH
            // 
            this.btnThemDDH.Enabled = false;
            this.btnThemDDH.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDDH.Image")));
            this.btnThemDDH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemDDH.Location = new System.Drawing.Point(362, 28);
            this.btnThemDDH.Name = "btnThemDDH";
            this.btnThemDDH.Size = new System.Drawing.Size(70, 36);
            this.btnThemDDH.TabIndex = 18;
            this.btnThemDDH.Text = "Thêm";
            this.btnThemDDH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemDDH.UseVisualStyleBackColor = true;
            this.btnThemDDH.Click += new System.EventHandler(this.btnThemDDH_Click);
            // 
            // lblDDH_NCC
            // 
            this.lblDDH_NCC.AutoSize = true;
            this.lblDDH_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDDH_NCC.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDDH_NCC.Location = new System.Drawing.Point(461, 9);
            this.lblDDH_NCC.Name = "lblDDH_NCC";
            this.lblDDH_NCC.Size = new System.Drawing.Size(416, 33);
            this.lblDDH_NCC.TabIndex = 16;
            this.lblDDH_NCC.Text = "ĐẶT HÀNG NHÀ CUNG CẤP";
            // 
            // groupBoxSanPham
            // 
            this.groupBoxSanPham.Controls.Add(this.btnXoaCT);
            this.groupBoxSanPham.Controls.Add(this.btnThemCT);
            this.groupBoxSanPham.Controls.Add(this.dgvSanPHam);
            this.groupBoxSanPham.Controls.Add(this.txtSLDat);
            this.groupBoxSanPham.Controls.Add(this.lblSoluongdat);
            this.groupBoxSanPham.Location = new System.Drawing.Point(19, 19);
            this.groupBoxSanPham.Name = "groupBoxSanPham";
            this.groupBoxSanPham.Size = new System.Drawing.Size(492, 225);
            this.groupBoxSanPham.TabIndex = 94;
            this.groupBoxSanPham.TabStop = false;
            this.groupBoxSanPham.Text = "Sản phẩm trong kho";
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCT.Image")));
            this.btnXoaCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCT.Location = new System.Drawing.Point(399, 103);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(76, 43);
            this.btnXoaCT.TabIndex = 105;
            this.btnXoaCT.Text = "Xóa";
            this.btnXoaCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click_1);
            // 
            // btnThemCT
            // 
            this.btnThemCT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCT.Image")));
            this.btnThemCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCT.Location = new System.Drawing.Point(399, 51);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(76, 43);
            this.btnThemCT.TabIndex = 104;
            this.btnThemCT.Text = "Thêm";
            this.btnThemCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemCT.UseVisualStyleBackColor = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click_1);
            // 
            // dgvSanPHam
            // 
            this.dgvSanPHam.AllowUserToAddRows = false;
            this.dgvSanPHam.AllowUserToDeleteRows = false;
            this.dgvSanPHam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPHam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPHam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp});
            this.dgvSanPHam.Location = new System.Drawing.Point(18, 51);
            this.dgvSanPHam.Name = "dgvSanPHam";
            this.dgvSanPHam.ReadOnly = true;
            this.dgvSanPHam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPHam.Size = new System.Drawing.Size(356, 150);
            this.dgvSanPHam.TabIndex = 27;
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
            // txtSLDat
            // 
            this.txtSLDat.Location = new System.Drawing.Point(131, 25);
            this.txtSLDat.Name = "txtSLDat";
            this.txtSLDat.Size = new System.Drawing.Size(45, 20);
            this.txtSLDat.TabIndex = 26;
            this.txtSLDat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLDat_KeyPress);
            // 
            // lblSoluongdat
            // 
            this.lblSoluongdat.AutoSize = true;
            this.lblSoluongdat.Location = new System.Drawing.Point(15, 28);
            this.lblSoluongdat.Name = "lblSoluongdat";
            this.lblSoluongdat.Size = new System.Drawing.Size(97, 13);
            this.lblSoluongdat.TabIndex = 25;
            this.lblSoluongdat.Text = "Chọn số lượng đặt:";
            this.lblSoluongdat.Click += new System.EventHandler(this.label7_Click);
            // 
            // groupBoxCT_DDH
            // 
            this.groupBoxCT_DDH.Controls.Add(this.dgvCTDonDatHang);
            this.groupBoxCT_DDH.Controls.Add(this.groupBoxSanPham);
            this.groupBoxCT_DDH.Location = new System.Drawing.Point(689, 45);
            this.groupBoxCT_DDH.Name = "groupBoxCT_DDH";
            this.groupBoxCT_DDH.Size = new System.Drawing.Size(526, 485);
            this.groupBoxCT_DDH.TabIndex = 95;
            this.groupBoxCT_DDH.TabStop = false;
            this.groupBoxCT_DDH.Text = "Chi tiết đơn đặt hàng";
            // 
            // dgvCTDonDatHang
            // 
            this.dgvCTDonDatHang.AllowUserToAddRows = false;
            this.dgvCTDonDatHang.AllowUserToDeleteRows = false;
            this.dgvCTDonDatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTDonDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDonDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvCTDonDatHang.Location = new System.Drawing.Point(19, 250);
            this.dgvCTDonDatHang.Name = "dgvCTDonDatHang";
            this.dgvCTDonDatHang.ReadOnly = true;
            this.dgvCTDonDatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTDonDatHang.Size = new System.Drawing.Size(492, 218);
            this.dgvCTDonDatHang.TabIndex = 104;
            this.dgvCTDonDatHang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCTDonDatHang_CellFormatting);
            this.dgvCTDonDatHang.Click += new System.EventHandler(this.dgvCTDonDatHang_Click);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MASP";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn5.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // frmDonDatHangNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 542);
            this.Controls.Add(this.groupBoxCT_DDH);
            this.Controls.Add(this.lblDDH_NCC);
            this.Controls.Add(this.grbDSDDH);
            this.Name = "frmDonDatHangNCC";
            this.Text = "Đặt hàng nhà cung cấp";
            this.Load += new System.EventHandler(this.frmDatHangNCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonDatHang)).EndInit();
            this.grbDSDDH.ResumeLayout(false);
            this.groupBoxThongTinDH.ResumeLayout(false);
            this.groupBoxThongTinDH.PerformLayout();
            this.groupBoxSanPham.ResumeLayout(false);
            this.groupBoxSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPHam)).EndInit();
            this.groupBoxCT_DDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDonDatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaDDHNCC;
        private System.Windows.Forms.Label lblNgaylap_DDHNCC;
        private System.Windows.Forms.Label lblNCC_DDHNCC;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.ComboBox cbNCC;
        private System.Windows.Forms.DataGridView dgvDonDatHang;
        private System.Windows.Forms.GroupBox grbDSDDH;
        private System.Windows.Forms.Button btnLuuDDH;
        private System.Windows.Forms.Button btnXoaDDH;
        private System.Windows.Forms.Button btnThemDDH;
        private System.Windows.Forms.Label lblDDH_NCC;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV_DDHNCC;
        protected System.Windows.Forms.GroupBox groupBoxSanPham;
        private System.Windows.Forms.DataGridView dgvSanPHam;
        protected System.Windows.Forms.TextBox txtSLDat;
        protected System.Windows.Forms.Label lblSoluongdat;
        private System.Windows.Forms.GroupBox groupBoxCT_DDH;
        private System.Windows.Forms.DataGridView dgvCTDonDatHang;
        private System.Windows.Forms.GroupBox groupBoxThongTinDH;
        private System.Windows.Forms.Button btnPhieuNhap;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTinhTrangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn madondat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttnhap;
    }
}