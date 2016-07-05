namespace QL_VatLieuXayDung
{
    partial class frmGiamGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiamGia));
            this.btnThemCT = new System.Windows.Forms.Button();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGiam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSanPHam = new System.Windows.Forms.DataGridView();
            this.groupBoxsanpham = new System.Windows.Forms.GroupBox();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCT_DonDatHang = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblKetthuc_GG = new System.Windows.Forms.Label();
            this.dtpKetthuc_GG = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvGG = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaybd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnLammoiHD = new System.Windows.Forms.Button();
            this.btnLuu_GG = new System.Windows.Forms.Button();
            this.btnXoa_GG = new System.Windows.Forms.Button();
            this.btnThem_GG = new System.Windows.Forms.Button();
            this.groupBoxThongtinGG = new System.Windows.Forms.GroupBox();
            this.lblBatdau_GG = new System.Windows.Forms.Label();
            this.dtpBatdau_GG = new System.Windows.Forms.DateTimePicker();
            this.txtMaGG_GG = new System.Windows.Forms.TextBox();
            this.lblMaGG_GG = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPHam)).BeginInit();
            this.groupBoxsanpham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_DonDatHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGG)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBoxThongtinGG.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThemCT
            // 
            this.btnThemCT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCT.Image")));
            this.btnThemCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCT.Location = new System.Drawing.Point(212, 13);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(66, 42);
            this.btnThemCT.TabIndex = 3;
            this.btnThemCT.Text = "Thêm";
            this.btnThemCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemCT.UseVisualStyleBackColor = true;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // giaban
            // 
            this.giaban.DataPropertyName = "DONGIABAN";
            this.giaban.HeaderText = "Giá bán";
            this.giaban.Name = "giaban";
            this.giaban.ReadOnly = true;
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "TENSP";
            this.tensp.HeaderText = "Tên sản phẩm";
            this.tensp.Name = "tensp";
            this.tensp.ReadOnly = true;
            // 
            // masp
            // 
            this.masp.DataPropertyName = "MASP";
            this.masp.HeaderText = "Mã sản phẩm";
            this.masp.Name = "masp";
            this.masp.ReadOnly = true;
            // 
            // txtGiam
            // 
            this.txtGiam.Location = new System.Drawing.Point(99, 29);
            this.txtGiam.MaxLength = 2;
            this.txtGiam.Name = "txtGiam";
            this.txtGiam.Size = new System.Drawing.Size(52, 20);
            this.txtGiam.TabIndex = 108;
            this.txtGiam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiam_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "Giảm %";
            // 
            // dgvSanPHam
            // 
            this.dgvSanPHam.AllowUserToAddRows = false;
            this.dgvSanPHam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPHam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPHam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.giaban});
            this.dgvSanPHam.Location = new System.Drawing.Point(18, 72);
            this.dgvSanPHam.Name = "dgvSanPHam";
            this.dgvSanPHam.Size = new System.Drawing.Size(402, 158);
            this.dgvSanPHam.TabIndex = 106;
            this.dgvSanPHam.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSanPHam_CellFormatting);
            // 
            // groupBoxsanpham
            // 
            this.groupBoxsanpham.Controls.Add(this.txtGiam);
            this.groupBoxsanpham.Controls.Add(this.label2);
            this.groupBoxsanpham.Controls.Add(this.dgvSanPHam);
            this.groupBoxsanpham.Controls.Add(this.btnXoaCT);
            this.groupBoxsanpham.Controls.Add(this.btnThemCT);
            this.groupBoxsanpham.Location = new System.Drawing.Point(12, 19);
            this.groupBoxsanpham.Name = "groupBoxsanpham";
            this.groupBoxsanpham.Size = new System.Drawing.Size(442, 242);
            this.groupBoxsanpham.TabIndex = 0;
            this.groupBoxsanpham.TabStop = false;
            this.groupBoxsanpham.Text = "Sản phẩm trong kho";
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCT.Image")));
            this.btnXoaCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCT.Location = new System.Drawing.Point(302, 13);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(66, 42);
            this.btnXoaCT.TabIndex = 4;
            this.btnXoaCT.Text = "Xóa";
            this.btnXoaCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaCT.UseVisualStyleBackColor = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GIAM";
            this.dataGridViewTextBoxColumn2.HeaderText = "Giảm (%)";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MASP";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dgvCT_DonDatHang
            // 
            this.dgvCT_DonDatHang.AllowUserToAddRows = false;
            this.dgvCT_DonDatHang.AllowUserToDeleteRows = false;
            this.dgvCT_DonDatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_DonDatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_DonDatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvCT_DonDatHang.Location = new System.Drawing.Point(21, 267);
            this.dgvCT_DonDatHang.Name = "dgvCT_DonDatHang";
            this.dgvCT_DonDatHang.ReadOnly = true;
            this.dgvCT_DonDatHang.Size = new System.Drawing.Size(411, 178);
            this.dgvCT_DonDatHang.TabIndex = 1;
            this.dgvCT_DonDatHang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCT_DonDatHang_CellFormatting);
            this.dgvCT_DonDatHang.Click += new System.EventHandler(this.dgvCT_DonDatHang_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCT_DonDatHang);
            this.groupBox1.Controls.Add(this.groupBoxsanpham);
            this.groupBox1.Location = new System.Drawing.Point(757, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 460);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết hóa đơn";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(127, 64);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(154, 20);
            this.txtMaNV.TabIndex = 11;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(29, 68);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(75, 13);
            this.lblMaNV.TabIndex = 10;
            this.lblMaNV.Text = "Mã nhân viên:";
            // 
            // lblKetthuc_GG
            // 
            this.lblKetthuc_GG.AutoSize = true;
            this.lblKetthuc_GG.Location = new System.Drawing.Point(29, 120);
            this.lblKetthuc_GG.Name = "lblKetthuc_GG";
            this.lblKetthuc_GG.Size = new System.Drawing.Size(77, 13);
            this.lblKetthuc_GG.TabIndex = 9;
            this.lblKetthuc_GG.Text = "Ngày kết thúc:";
            // 
            // dtpKetthuc_GG
            // 
            this.dtpKetthuc_GG.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKetthuc_GG.Location = new System.Drawing.Point(127, 115);
            this.dtpKetthuc_GG.Name = "dtpKetthuc_GG";
            this.dtpKetthuc_GG.Size = new System.Drawing.Size(154, 20);
            this.dtpKetthuc_GG.TabIndex = 8;
            this.dtpKetthuc_GG.ValueChanged += new System.EventHandler(this.dtpKetthuc_GG_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvGG);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBoxThongtinGG);
            this.groupBox2.Location = new System.Drawing.Point(105, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 460);
            this.groupBox2.TabIndex = 108;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các đợt giảm giá";
            // 
            // dgvGG
            // 
            this.dgvGG.AllowUserToAddRows = false;
            this.dgvGG.AllowUserToDeleteRows = false;
            this.dgvGG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.ngaybd,
            this.ngaykt,
            this.manv});
            this.dgvGG.Location = new System.Drawing.Point(44, 203);
            this.dgvGG.Name = "dgvGG";
            this.dgvGG.ReadOnly = true;
            this.dgvGG.Size = new System.Drawing.Size(549, 242);
            this.dgvGG.TabIndex = 0;
            this.dgvGG.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGG_CellFormatting);
            this.dgvGG.Click += new System.EventHandler(this.dgvGG_Click);
            // 
            // ma
            // 
            this.ma.DataPropertyName = "MAGG";
            this.ma.HeaderText = "Mã giảm giá";
            this.ma.Name = "ma";
            this.ma.ReadOnly = true;
            // 
            // ngaybd
            // 
            this.ngaybd.DataPropertyName = "NGAYBATDAU";
            this.ngaybd.HeaderText = "Ngày bắt đầu";
            this.ngaybd.Name = "ngaybd";
            this.ngaybd.ReadOnly = true;
            // 
            // ngaykt
            // 
            this.ngaykt.DataPropertyName = "NGAYKETTHUC";
            this.ngaykt.HeaderText = "Ngày kết thúc";
            this.ngaykt.Name = "ngaykt";
            this.ngaykt.ReadOnly = true;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "MANV";
            this.manv.HeaderText = "Mã nhân viên";
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnLammoiHD);
            this.groupBox6.Controls.Add(this.btnLuu_GG);
            this.groupBox6.Controls.Add(this.btnXoa_GG);
            this.groupBox6.Controls.Add(this.btnThem_GG);
            this.groupBox6.Location = new System.Drawing.Point(392, 32);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(201, 156);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thao tác";
            // 
            // btnLammoiHD
            // 
            this.btnLammoiHD.Image = ((System.Drawing.Image)(resources.GetObject("btnLammoiHD.Image")));
            this.btnLammoiHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLammoiHD.Location = new System.Drawing.Point(105, 90);
            this.btnLammoiHD.Name = "btnLammoiHD";
            this.btnLammoiHD.Size = new System.Drawing.Size(66, 42);
            this.btnLammoiHD.TabIndex = 7;
            this.btnLammoiHD.Text = "Làm mới";
            this.btnLammoiHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLammoiHD.UseVisualStyleBackColor = true;
            this.btnLammoiHD.Click += new System.EventHandler(this.btnLammoiHD_Click);
            // 
            // btnLuu_GG
            // 
            this.btnLuu_GG.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu_GG.Image")));
            this.btnLuu_GG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu_GG.Location = new System.Drawing.Point(105, 38);
            this.btnLuu_GG.Name = "btnLuu_GG";
            this.btnLuu_GG.Size = new System.Drawing.Size(66, 42);
            this.btnLuu_GG.TabIndex = 6;
            this.btnLuu_GG.Text = "Lưu";
            this.btnLuu_GG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu_GG.UseVisualStyleBackColor = true;
            this.btnLuu_GG.Click += new System.EventHandler(this.btnLuu_GG_Click);
            // 
            // btnXoa_GG
            // 
            this.btnXoa_GG.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa_GG.Image")));
            this.btnXoa_GG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa_GG.Location = new System.Drawing.Point(24, 91);
            this.btnXoa_GG.Name = "btnXoa_GG";
            this.btnXoa_GG.Size = new System.Drawing.Size(66, 42);
            this.btnXoa_GG.TabIndex = 5;
            this.btnXoa_GG.Text = "Xóa";
            this.btnXoa_GG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa_GG.UseVisualStyleBackColor = true;
            this.btnXoa_GG.Click += new System.EventHandler(this.btnXoa_GG_Click);
            // 
            // btnThem_GG
            // 
            this.btnThem_GG.Image = ((System.Drawing.Image)(resources.GetObject("btnThem_GG.Image")));
            this.btnThem_GG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem_GG.Location = new System.Drawing.Point(25, 38);
            this.btnThem_GG.Name = "btnThem_GG";
            this.btnThem_GG.Size = new System.Drawing.Size(65, 42);
            this.btnThem_GG.TabIndex = 0;
            this.btnThem_GG.Text = "Thêm";
            this.btnThem_GG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem_GG.UseVisualStyleBackColor = true;
            this.btnThem_GG.Click += new System.EventHandler(this.btnThem_GG_Click);
            // 
            // groupBoxThongtinGG
            // 
            this.groupBoxThongtinGG.Controls.Add(this.txtMaNV);
            this.groupBoxThongtinGG.Controls.Add(this.lblMaNV);
            this.groupBoxThongtinGG.Controls.Add(this.lblKetthuc_GG);
            this.groupBoxThongtinGG.Controls.Add(this.dtpKetthuc_GG);
            this.groupBoxThongtinGG.Controls.Add(this.lblBatdau_GG);
            this.groupBoxThongtinGG.Controls.Add(this.dtpBatdau_GG);
            this.groupBoxThongtinGG.Controls.Add(this.txtMaGG_GG);
            this.groupBoxThongtinGG.Controls.Add(this.lblMaGG_GG);
            this.groupBoxThongtinGG.Location = new System.Drawing.Point(40, 32);
            this.groupBoxThongtinGG.Name = "groupBoxThongtinGG";
            this.groupBoxThongtinGG.Size = new System.Drawing.Size(319, 156);
            this.groupBoxThongtinGG.TabIndex = 1;
            this.groupBoxThongtinGG.TabStop = false;
            this.groupBoxThongtinGG.Text = "Thông tin đợt giảm giá";
            // 
            // lblBatdau_GG
            // 
            this.lblBatdau_GG.AutoSize = true;
            this.lblBatdau_GG.Location = new System.Drawing.Point(29, 94);
            this.lblBatdau_GG.Name = "lblBatdau_GG";
            this.lblBatdau_GG.Size = new System.Drawing.Size(75, 13);
            this.lblBatdau_GG.TabIndex = 7;
            this.lblBatdau_GG.Text = "Ngày bắt đầu:";
            // 
            // dtpBatdau_GG
            // 
            this.dtpBatdau_GG.Enabled = false;
            this.dtpBatdau_GG.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBatdau_GG.Location = new System.Drawing.Point(127, 89);
            this.dtpBatdau_GG.Name = "dtpBatdau_GG";
            this.dtpBatdau_GG.Size = new System.Drawing.Size(154, 20);
            this.dtpBatdau_GG.TabIndex = 5;
            // 
            // txtMaGG_GG
            // 
            this.txtMaGG_GG.Enabled = false;
            this.txtMaGG_GG.Location = new System.Drawing.Point(127, 38);
            this.txtMaGG_GG.Name = "txtMaGG_GG";
            this.txtMaGG_GG.Size = new System.Drawing.Size(154, 20);
            this.txtMaGG_GG.TabIndex = 1;
            // 
            // lblMaGG_GG
            // 
            this.lblMaGG_GG.AutoSize = true;
            this.lblMaGG_GG.Location = new System.Drawing.Point(29, 38);
            this.lblMaGG_GG.Name = "lblMaGG_GG";
            this.lblMaGG_GG.Size = new System.Drawing.Size(67, 13);
            this.lblMaGG_GG.TabIndex = 0;
            this.lblMaGG_GG.Text = "Mã giảm giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(596, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 33);
            this.label1.TabIndex = 107;
            this.label1.Text = "ĐỢT GIẢM GIÁ";
            // 
            // frmGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 542);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "frmGiamGia";
            this.Text = "Đợt giảm giá";
            this.Load += new System.EventHandler(this.frmGiamGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPHam)).EndInit();
            this.groupBoxsanpham.ResumeLayout(false);
            this.groupBoxsanpham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_DonDatHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGG)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBoxThongtinGG.ResumeLayout(false);
            this.groupBoxThongtinGG.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.TextBox txtGiam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSanPHam;
        private System.Windows.Forms.GroupBox groupBoxsanpham;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgvCT_DonDatHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblKetthuc_GG;
        private System.Windows.Forms.DateTimePicker dtpKetthuc_GG;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvGG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaybd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykt;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnLammoiHD;
        private System.Windows.Forms.Button btnLuu_GG;
        private System.Windows.Forms.Button btnXoa_GG;
        private System.Windows.Forms.Button btnThem_GG;
        private System.Windows.Forms.GroupBox groupBoxThongtinGG;
        private System.Windows.Forms.Label lblBatdau_GG;
        private System.Windows.Forms.DateTimePicker dtpBatdau_GG;
        private System.Windows.Forms.TextBox txtMaGG_GG;
        private System.Windows.Forms.Label lblMaGG_GG;
        private System.Windows.Forms.Label label1;


    }
}