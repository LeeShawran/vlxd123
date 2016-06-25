namespace QL_VatLieuXayDung
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.bntLammoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSanpham = new System.Windows.Forms.Label();
            this.cbNhaSX = new System.Windows.Forms.ComboBox();
            this.txtDongianhap = new System.Windows.Forms.TextBox();
            this.cbNhaCC = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblDongiaNhap = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.lblDongiaBan = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDes_LoaiSP = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnAsc_LoaiSP = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PHAI";
            this.dataGridViewTextBoxColumn4.HeaderText = "Điện thoại";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MANV";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã KH";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CHUCVU";
            this.dataGridViewTextBoxColumn5.HeaderText = "MS thuế";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcel);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.bntLammoi);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Location = new System.Drawing.Point(1076, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 455);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(19, 362);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(100, 58);
            this.btnExcel.TabIndex = 89;
            this.btnExcel.Text = "Xuất excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(19, 25);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 54);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(19, 93);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 54);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // bntLammoi
            // 
            this.bntLammoi.Image = ((System.Drawing.Image)(resources.GetObject("bntLammoi.Image")));
            this.bntLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntLammoi.Location = new System.Drawing.Point(19, 292);
            this.bntLammoi.Name = "bntLammoi";
            this.bntLammoi.Size = new System.Drawing.Size(80, 54);
            this.bntLammoi.TabIndex = 22;
            this.bntLammoi.Text = "Làm mới";
            this.bntLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntLammoi.UseVisualStyleBackColor = true;
            this.bntLammoi.Click += new System.EventHandler(this.bntLammoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(19, 159);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 54);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(19, 224);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 54);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DIENTHOAI";
            this.dataGridViewTextBoxColumn7.HeaderText = "Ghi chú";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tài khoản";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Nhà sản xuất:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Mã sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7});
            this.dgvSanPham.Location = new System.Drawing.Point(30, 45);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(766, 267);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSanPham_CellMouseClick);
            this.dgvSanPham.Click += new System.EventHandler(this.dgvSanPham_Click);
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
            this.Column2.DataPropertyName = "TENSP";
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MALOAI";
            this.Column3.HeaderText = "Loại sản phẩm";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MANSX";
            this.Column4.HeaderText = "Nhà sản xuất";
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
            // Column7
            // 
            this.Column7.DataPropertyName = "SOLUONG";
            this.Column7.HeaderText = "Số lượng";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HONV";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên khách hàng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // lblSanpham
            // 
            this.lblSanpham.AutoSize = true;
            this.lblSanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanpham.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSanpham.Location = new System.Drawing.Point(564, 9);
            this.lblSanpham.Name = "lblSanpham";
            this.lblSanpham.Size = new System.Drawing.Size(352, 33);
            this.lblSanpham.TabIndex = 87;
            this.lblSanpham.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // cbNhaSX
            // 
            this.cbNhaSX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhaSX.FormattingEnabled = true;
            this.cbNhaSX.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.cbNhaSX.Location = new System.Drawing.Point(418, 50);
            this.cbNhaSX.Name = "cbNhaSX";
            this.cbNhaSX.Size = new System.Drawing.Size(164, 21);
            this.cbNhaSX.TabIndex = 63;
            // 
            // txtDongianhap
            // 
            this.txtDongianhap.Enabled = false;
            this.txtDongianhap.Location = new System.Drawing.Point(690, 23);
            this.txtDongianhap.Name = "txtDongianhap";
            this.txtDongianhap.Size = new System.Drawing.Size(125, 20);
            this.txtDongianhap.TabIndex = 61;
            // 
            // cbNhaCC
            // 
            this.cbNhaCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhaCC.FormattingEnabled = true;
            this.cbNhaCC.Items.AddRange(new object[] {
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.cbNhaCC.Location = new System.Drawing.Point(418, 23);
            this.cbNhaCC.Name = "cbNhaCC";
            this.cbNhaCC.Size = new System.Drawing.Size(164, 21);
            this.cbNhaCC.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Loại sản phẩm:";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Enabled = false;
            this.txtSoluong.Location = new System.Drawing.Point(418, 77);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(163, 20);
            this.txtSoluong.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(334, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Nhà cung cấp:";
            // 
            // cbLoai
            // 
            this.cbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(120, 74);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(181, 21);
            this.cbLoai.TabIndex = 54;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(120, 48);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(181, 20);
            this.txtTenSP.TabIndex = 50;
            // 
            // lblDongiaNhap
            // 
            this.lblDongiaNhap.AutoSize = true;
            this.lblDongiaNhap.Location = new System.Drawing.Point(610, 26);
            this.lblDongiaNhap.Name = "lblDongiaNhap";
            this.lblDongiaNhap.Size = new System.Drawing.Size(74, 13);
            this.lblDongiaNhap.TabIndex = 60;
            this.lblDongiaNhap.Text = "Đơn giá nhập:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(120, 22);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(181, 20);
            this.txtMaSP.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDonGiaBan);
            this.groupBox1.Controls.Add(this.lblDongiaBan);
            this.groupBox1.Controls.Add(this.cbNhaSX);
            this.groupBox1.Controls.Add(this.txtDongianhap);
            this.groupBox1.Controls.Add(this.lblDongiaNhap);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbNhaCC);
            this.groupBox1.Controls.Add(this.cbLoai);
            this.groupBox1.Controls.Add(this.txtSoluong);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(121, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 113);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(821, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "(VNĐ)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(821, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 66;
            this.label3.Text = "(VNĐ)";
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Enabled = false;
            this.txtDonGiaBan.Location = new System.Drawing.Point(690, 48);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.Size = new System.Drawing.Size(125, 20);
            this.txtDonGiaBan.TabIndex = 65;
            // 
            // lblDongiaBan
            // 
            this.lblDongiaBan.AutoSize = true;
            this.lblDongiaBan.Location = new System.Drawing.Point(610, 51);
            this.lblDongiaBan.Name = "lblDongiaBan";
            this.lblDongiaBan.Size = new System.Drawing.Size(68, 13);
            this.lblDongiaBan.TabIndex = 64;
            this.lblDongiaBan.Text = "Đơn giá bán:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnDes_LoaiSP);
            this.groupBox3.Controls.Add(this.txttimkiem);
            this.groupBox3.Controls.Add(this.btnAsc_LoaiSP);
            this.groupBox3.Controls.Add(this.dgvSanPham);
            this.groupBox3.Location = new System.Drawing.Point(121, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(913, 336);
            this.groupBox3.TabIndex = 85;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách các sách";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 89;
            this.label1.Text = "Tìm theo tên sản phẩm";
            // 
            // btnDes_LoaiSP
            // 
            this.btnDes_LoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btnDes_LoaiSP.Image")));
            this.btnDes_LoaiSP.Location = new System.Drawing.Point(824, 180);
            this.btnDes_LoaiSP.Name = "btnDes_LoaiSP";
            this.btnDes_LoaiSP.Size = new System.Drawing.Size(45, 47);
            this.btnDes_LoaiSP.TabIndex = 92;
            this.btnDes_LoaiSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDes_LoaiSP.UseVisualStyleBackColor = true;
            this.btnDes_LoaiSP.Click += new System.EventHandler(this.btnDes_LoaiSP_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txttimkiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txttimkiem.Location = new System.Drawing.Point(172, 19);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(205, 20);
            this.txttimkiem.TabIndex = 90;
            this.txttimkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttimkiem_KeyDown);
            // 
            // btnAsc_LoaiSP
            // 
            this.btnAsc_LoaiSP.Image = ((System.Drawing.Image)(resources.GetObject("btnAsc_LoaiSP.Image")));
            this.btnAsc_LoaiSP.Location = new System.Drawing.Point(824, 105);
            this.btnAsc_LoaiSP.Name = "btnAsc_LoaiSP";
            this.btnAsc_LoaiSP.Size = new System.Drawing.Size(45, 47);
            this.btnAsc_LoaiSP.TabIndex = 91;
            this.btnAsc_LoaiSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsc_LoaiSP.UseVisualStyleBackColor = true;
            this.btnAsc_LoaiSP.Click += new System.EventHandler(this.btnAsc_LoaiSP_Click);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TENNV";
            this.dataGridViewTextBoxColumn3.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblSanpham);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmSanPham";
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.frmSanPham_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button bntLammoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lblSanpham;
        private System.Windows.Forms.ComboBox cbNhaSX;
        private System.Windows.Forms.TextBox txtDongianhap;
        private System.Windows.Forms.ComboBox cbNhaCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label lblDongiaNhap;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.Label lblDongiaBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnAsc_LoaiSP;
        private System.Windows.Forms.Button btnDes_LoaiSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnExcel;

    }
}