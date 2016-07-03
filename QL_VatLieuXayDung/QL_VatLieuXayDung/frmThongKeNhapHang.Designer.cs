namespace QL_VatLieuXayDung
{
    partial class frmThongKeNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeNhapHang));
            this.btnThongke = new System.Windows.Forms.Button();
            this.bntLammoi = new System.Windows.Forms.Button();
            this.groupBoxNgay = new System.Windows.Forms.GroupBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTongsl = new System.Windows.Forms.Label();
            this.lbTongtien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxThang = new System.Windows.Forms.GroupBox();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvNhapHang = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radNgay = new System.Windows.Forms.RadioButton();
            this.radThoiGian = new System.Windows.Forms.RadioButton();
            this.dtpTG1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpTG2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.radThang = new System.Windows.Forms.RadioButton();
            this.groupBoxThoigian = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSanpham = new System.Windows.Forms.Label();
            this.groupBoxNgay.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxThang.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).BeginInit();
            this.groupBoxThoigian.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThongke
            // 
            this.btnThongke.Image = ((System.Drawing.Image)(resources.GetObject("btnThongke.Image")));
            this.btnThongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.Location = new System.Drawing.Point(43, 19);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(88, 39);
            this.btnThongke.TabIndex = 91;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // bntLammoi
            // 
            this.bntLammoi.Image = ((System.Drawing.Image)(resources.GetObject("bntLammoi.Image")));
            this.bntLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntLammoi.Location = new System.Drawing.Point(180, 19);
            this.bntLammoi.Name = "bntLammoi";
            this.bntLammoi.Size = new System.Drawing.Size(82, 40);
            this.bntLammoi.TabIndex = 96;
            this.bntLammoi.Text = "Làm mới";
            this.bntLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntLammoi.UseVisualStyleBackColor = true;
            this.bntLammoi.Click += new System.EventHandler(this.bntLammoi_Click);
            // 
            // groupBoxNgay
            // 
            this.groupBoxNgay.Controls.Add(this.dtpNgay);
            this.groupBoxNgay.Controls.Add(this.label1);
            this.groupBoxNgay.Location = new System.Drawing.Point(150, 12);
            this.groupBoxNgay.Name = "groupBoxNgay";
            this.groupBoxNgay.Size = new System.Drawing.Size(366, 46);
            this.groupBoxNgay.TabIndex = 103;
            this.groupBoxNgay.TabStop = false;
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(85, 16);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(144, 20);
            this.dtpNgay.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Chọn ngày:";
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(311, 20);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(98, 39);
            this.btnExcel.TabIndex = 95;
            this.btnExcel.Text = "Xuất excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTongsl);
            this.groupBox2.Controls.Add(this.lbTongtien);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(697, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 75);
            this.groupBox2.TabIndex = 102;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả";
            // 
            // lbTongsl
            // 
            this.lbTongsl.AutoSize = true;
            this.lbTongsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongsl.ForeColor = System.Drawing.Color.Red;
            this.lbTongsl.Location = new System.Drawing.Point(137, 31);
            this.lbTongsl.Name = "lbTongsl";
            this.lbTongsl.Size = new System.Drawing.Size(19, 20);
            this.lbTongsl.TabIndex = 50;
            this.lbTongsl.Text = "0";
            // 
            // lbTongtien
            // 
            this.lbTongtien.AutoSize = true;
            this.lbTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongtien.ForeColor = System.Drawing.Color.Red;
            this.lbTongtien.Location = new System.Drawing.Point(282, 31);
            this.lbTongtien.Name = "lbTongtien";
            this.lbTongtien.Size = new System.Drawing.Size(19, 20);
            this.lbTongtien.TabIndex = 49;
            this.lbTongtien.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(193, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Tống tiền :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tống số lượng:";
            // 
            // groupBoxThang
            // 
            this.groupBoxThang.Controls.Add(this.cbNam);
            this.groupBoxThang.Controls.Add(this.label11);
            this.groupBoxThang.Controls.Add(this.cbThang);
            this.groupBoxThang.Controls.Add(this.label4);
            this.groupBoxThang.Location = new System.Drawing.Point(150, 64);
            this.groupBoxThang.Name = "groupBoxThang";
            this.groupBoxThang.Size = new System.Drawing.Size(366, 46);
            this.groupBoxThang.TabIndex = 102;
            this.groupBoxThang.TabStop = false;
            // 
            // cbNam
            // 
            this.cbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Items.AddRange(new object[] {
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
            "2017",
            "2018"});
            this.cbNam.Location = new System.Drawing.Point(225, 16);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(71, 21);
            this.cbNam.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(161, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Chọn năm:";
            // 
            // cbThang
            // 
            this.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(89, 17);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(55, 21);
            this.cbThang.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Chọn tháng:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnThongke);
            this.groupBox3.Controls.Add(this.bntLammoi);
            this.groupBox3.Controls.Add(this.btnExcel);
            this.groupBox3.Location = new System.Drawing.Point(697, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 73);
            this.groupBox3.TabIndex = 103;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác";
            // 
            // dgvNhapHang
            // 
            this.dgvNhapHang.AllowUserToAddRows = false;
            this.dgvNhapHang.AllowUserToDeleteRows = false;
            this.dgvNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.mahd,
            this.ngayxuat,
            this.soluong,
            this.dongia,
            this.thanhtien});
            this.dgvNhapHang.Location = new System.Drawing.Point(79, 261);
            this.dgvNhapHang.Name = "dgvNhapHang";
            this.dgvNhapHang.ReadOnly = true;
            this.dgvNhapHang.Size = new System.Drawing.Size(1175, 271);
            this.dgvNhapHang.TabIndex = 101;
            this.dgvNhapHang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNhapHang_CellFormatting);
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
            // mahd
            // 
            this.mahd.DataPropertyName = "MAPN";
            this.mahd.HeaderText = "Mã phiếu nhập";
            this.mahd.Name = "mahd";
            this.mahd.ReadOnly = true;
            // 
            // ngayxuat
            // 
            this.ngayxuat.DataPropertyName = "NGAYLAP";
            this.ngayxuat.HeaderText = "Ngày nhập";
            this.ngayxuat.Name = "ngayxuat";
            this.ngayxuat.ReadOnly = true;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "SOLUONG";
            this.soluong.HeaderText = "Số lượng nhập";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "DONGIANHAP";
            this.dongia.HeaderText = "Đơn giá nhập";
            this.dongia.Name = "dongia";
            this.dongia.ReadOnly = true;
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            this.thanhtien.ReadOnly = true;
            // 
            // radNgay
            // 
            this.radNgay.AutoSize = true;
            this.radNgay.Checked = true;
            this.radNgay.Location = new System.Drawing.Point(28, 32);
            this.radNgay.Name = "radNgay";
            this.radNgay.Size = new System.Drawing.Size(50, 17);
            this.radNgay.TabIndex = 100;
            this.radNgay.TabStop = true;
            this.radNgay.Text = "Ngày";
            this.radNgay.UseVisualStyleBackColor = true;
            this.radNgay.CheckedChanged += new System.EventHandler(this.radNgay_CheckedChanged);
            // 
            // radThoiGian
            // 
            this.radThoiGian.AutoSize = true;
            this.radThoiGian.Location = new System.Drawing.Point(28, 130);
            this.radThoiGian.Name = "radThoiGian";
            this.radThoiGian.Size = new System.Drawing.Size(102, 17);
            this.radThoiGian.TabIndex = 104;
            this.radThoiGian.Text = "Thời gian cụ thể";
            this.radThoiGian.UseVisualStyleBackColor = true;
            this.radThoiGian.CheckedChanged += new System.EventHandler(this.radThoiGian_CheckedChanged);
            // 
            // dtpTG1
            // 
            this.dtpTG1.CustomFormat = "dd/MM/yyyy";
            this.dtpTG1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTG1.Location = new System.Drawing.Point(50, 16);
            this.dtpTG1.Name = "dtpTG1";
            this.dtpTG1.Size = new System.Drawing.Size(105, 20);
            this.dtpTG1.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Từ:";
            // 
            // dtpTG2
            // 
            this.dtpTG2.CustomFormat = "dd/MM/yyyy";
            this.dtpTG2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTG2.Location = new System.Drawing.Point(196, 16);
            this.dtpTG2.Name = "dtpTG2";
            this.dtpTG2.Size = new System.Drawing.Size(94, 20);
            this.dtpTG2.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "đến:";
            // 
            // radThang
            // 
            this.radThang.AutoSize = true;
            this.radThang.Location = new System.Drawing.Point(28, 80);
            this.radThang.Name = "radThang";
            this.radThang.Size = new System.Drawing.Size(56, 17);
            this.radThang.TabIndex = 105;
            this.radThang.Text = "Tháng";
            this.radThang.UseVisualStyleBackColor = true;
            this.radThang.CheckedChanged += new System.EventHandler(this.radThang_CheckedChanged);
            // 
            // groupBoxThoigian
            // 
            this.groupBoxThoigian.Controls.Add(this.dtpTG1);
            this.groupBoxThoigian.Controls.Add(this.label7);
            this.groupBoxThoigian.Controls.Add(this.dtpTG2);
            this.groupBoxThoigian.Controls.Add(this.label8);
            this.groupBoxThoigian.Location = new System.Drawing.Point(150, 116);
            this.groupBoxThoigian.Name = "groupBoxThoigian";
            this.groupBoxThoigian.Size = new System.Drawing.Size(366, 46);
            this.groupBoxThoigian.TabIndex = 101;
            this.groupBoxThoigian.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxThang);
            this.groupBox1.Controls.Add(this.groupBoxNgay);
            this.groupBox1.Controls.Add(this.radNgay);
            this.groupBox1.Controls.Add(this.radThang);
            this.groupBox1.Controls.Add(this.radThoiGian);
            this.groupBox1.Controls.Add(this.groupBoxThoigian);
            this.groupBox1.Location = new System.Drawing.Point(137, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 175);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểu thời gian thống kê";
            // 
            // lblSanpham
            // 
            this.lblSanpham.AutoSize = true;
            this.lblSanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanpham.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSanpham.Location = new System.Drawing.Point(515, 11);
            this.lblSanpham.Name = "lblSanpham";
            this.lblSanpham.Size = new System.Drawing.Size(365, 33);
            this.lblSanpham.TabIndex = 99;
            this.lblSanpham.Text = "THỐNG KÊ NHẬP HÀNG";
            // 
            // frmThongKeNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 542);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvNhapHang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSanpham);
            this.Name = "frmThongKeNhapHang";
            this.Text = "Thống kê nhập hàng";
            this.Load += new System.EventHandler(this.frmThongKeNhapHang_Load);
            this.groupBoxNgay.ResumeLayout(false);
            this.groupBoxNgay.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxThang.ResumeLayout(false);
            this.groupBoxThang.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhapHang)).EndInit();
            this.groupBoxThoigian.ResumeLayout(false);
            this.groupBoxThoigian.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button bntLammoi;
        private System.Windows.Forms.GroupBox groupBoxNgay;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbTongsl;
        private System.Windows.Forms.Label lbTongtien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxThang;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvNhapHang;
        private System.Windows.Forms.RadioButton radNgay;
        private System.Windows.Forms.RadioButton radThoiGian;
        private System.Windows.Forms.DateTimePicker dtpTG1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpTG2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radThang;
        private System.Windows.Forms.GroupBox groupBoxThoigian;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
    }
}