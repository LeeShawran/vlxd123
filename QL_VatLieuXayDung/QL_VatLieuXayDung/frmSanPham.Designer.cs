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
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbNhaSX = new System.Windows.Forms.ComboBox();
            this.txtDongianhap = new System.Windows.Forms.TextBox();
            this.cbNhaCC = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "DONGIANHAP";
            this.Column6.HeaderText = "Đơn giá nhập";
            this.Column6.Name = "Column6";
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
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.bntLammoi);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Location = new System.Drawing.Point(1097, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 490);
            this.groupBox2.TabIndex = 88;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 393);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 54);
            this.button2.TabIndex = 23;
            this.button2.Text = "Xuất excel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(25, 55);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 54);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "   Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(25, 123);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 54);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "    Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // bntLammoi
            // 
            this.bntLammoi.Location = new System.Drawing.Point(25, 322);
            this.bntLammoi.Name = "bntLammoi";
            this.bntLammoi.Size = new System.Drawing.Size(80, 54);
            this.bntLammoi.TabIndex = 22;
            this.bntLammoi.Text = "Làm mới";
            this.bntLammoi.UseVisualStyleBackColor = true;
            this.bntLammoi.Click += new System.EventHandler(this.bntLammoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(25, 189);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 54);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(25, 254);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 54);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "    Sửa";
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
            this.label5.Location = new System.Drawing.Point(488, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Nhà sản xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Mã sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tên sản phẩm";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvSanPham.Location = new System.Drawing.Point(35, 28);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.Size = new System.Drawing.Size(891, 231);
            this.dgvSanPham.TabIndex = 0;
            this.dgvSanPham.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSanPham_CellMouseClick);
            this.dgvSanPham.Click += new System.EventHandler(this.dgvSanPham_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MASP";
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENSP";
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MALOAI";
            this.Column3.HeaderText = "Loại";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MANSX";
            this.Column4.HeaderText = "Nhà sản xuất";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MANCC";
            this.Column5.HeaderText = "Nhà cung cấp";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SOLUONG";
            this.Column7.HeaderText = "Số lượng";
            this.Column7.Name = "Column7";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HONV";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên khách hàng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(545, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 33);
            this.label1.TabIndex = 87;
            this.label1.Text = "SẢN PHẨM";
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
            this.cbNhaSX.Location = new System.Drawing.Point(577, 69);
            this.cbNhaSX.Name = "cbNhaSX";
            this.cbNhaSX.Size = new System.Drawing.Size(215, 21);
            this.cbNhaSX.TabIndex = 63;
            // 
            // txtDongianhap
            // 
            this.txtDongianhap.Enabled = false;
            this.txtDongianhap.Location = new System.Drawing.Point(577, 146);
            this.txtDongianhap.Name = "txtDongianhap";
            this.txtDongianhap.Size = new System.Drawing.Size(215, 20);
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
            this.cbNhaCC.Location = new System.Drawing.Point(577, 34);
            this.cbNhaCC.Name = "cbNhaCC";
            this.cbNhaCC.Size = new System.Drawing.Size(215, 21);
            this.cbNhaCC.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(488, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Loại";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Enabled = false;
            this.txtSoluong.Location = new System.Drawing.Point(577, 108);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(215, 20);
            this.txtSoluong.TabIndex = 53;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(488, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Nhà cung cấp";
            // 
            // cbLoai
            // 
            this.cbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Location = new System.Drawing.Point(165, 115);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(225, 21);
            this.cbLoai.TabIndex = 54;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(164, 76);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(225, 20);
            this.txtTenSP.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(488, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Đơn giá nhập";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Location = new System.Drawing.Point(165, 36);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(225, 20);
            this.txtMaSP.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNhaSX);
            this.groupBox1.Controls.Add(this.txtDongianhap);
            this.groupBox1.Controls.Add(this.label11);
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
            this.groupBox1.Location = new System.Drawing.Point(109, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(961, 186);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvSanPham);
            this.groupBox3.Location = new System.Drawing.Point(103, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(967, 280);
            this.groupBox3.TabIndex = 85;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách các sách";
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
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNhaSX;
        private System.Windows.Forms.TextBox txtDongianhap;
        private System.Windows.Forms.ComboBox cbNhaCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

    }
}