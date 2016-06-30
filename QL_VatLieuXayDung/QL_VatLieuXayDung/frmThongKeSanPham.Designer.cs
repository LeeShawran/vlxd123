namespace QL_VatLieuXayDung
{
    partial class frmThongKeSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeSanPham));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtnhap = new System.Windows.Forms.Label();
            this.txtban = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTimtheoten = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThongke = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxThang = new System.Windows.Forms.GroupBox();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxNgay = new System.Windows.Forms.GroupBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.radThang = new System.Windows.Forms.RadioButton();
            this.groupBoxThoigian = new System.Windows.Forms.GroupBox();
            this.dtpTG1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpTG2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.radThoiGian = new System.Windows.Forms.RadioButton();
            this.radNgay = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bntLammoi = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.groupBoxThang.SuspendLayout();
            this.groupBoxNgay.SuspendLayout();
            this.groupBoxThoigian.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtnhap);
            this.groupBox5.Controls.Add(this.txtban);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(625, 81);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(332, 88);
            this.groupBox5.TabIndex = 93;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kết quả thống kê";
            // 
            // txtnhap
            // 
            this.txtnhap.AutoSize = true;
            this.txtnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnhap.ForeColor = System.Drawing.Color.Red;
            this.txtnhap.Location = new System.Drawing.Point(108, 37);
            this.txtnhap.Name = "txtnhap";
            this.txtnhap.Size = new System.Drawing.Size(19, 20);
            this.txtnhap.TabIndex = 54;
            this.txtnhap.Text = "0";
            // 
            // txtban
            // 
            this.txtban.AutoSize = true;
            this.txtban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtban.ForeColor = System.Drawing.Color.Red;
            this.txtban.Location = new System.Drawing.Point(245, 37);
            this.txtban.Name = "txtban";
            this.txtban.Size = new System.Drawing.Size(19, 20);
            this.txtban.TabIndex = 53;
            this.txtban.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(175, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Bán ra :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 51;
            this.label9.Text = "Nhập vào:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTimtheoten);
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Controls.Add(this.dgvSanPham);
            this.groupBox2.Location = new System.Drawing.Point(67, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 266);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn sản phẩm cần thống kê";
            // 
            // lblTimtheoten
            // 
            this.lblTimtheoten.AutoSize = true;
            this.lblTimtheoten.Location = new System.Drawing.Point(28, 29);
            this.lblTimtheoten.Name = "lblTimtheoten";
            this.lblTimtheoten.Size = new System.Drawing.Size(118, 13);
            this.lblTimtheoten.TabIndex = 106;
            this.lblTimtheoten.Text = "Tìm theo tên sản phẩm:";
            // 
            // txttimkiem
            // 
            this.txttimkiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txttimkiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txttimkiem.Location = new System.Drawing.Point(171, 26);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(272, 20);
            this.txttimkiem.TabIndex = 107;
            this.txttimkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttimkiem_KeyDown);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvSanPham.Location = new System.Drawing.Point(19, 61);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(486, 192);
            this.dgvSanPham.TabIndex = 94;
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
            // btnThongke
            // 
            this.btnThongke.Location = new System.Drawing.Point(31, 26);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(90, 45);
            this.btnThongke.TabIndex = 88;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(377, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(543, 33);
            this.label3.TabIndex = 89;
            this.label3.Text = "THỐNG KÊ SẢN PHẨM NHẬP / XUẤT";
            // 
            // groupBoxThang
            // 
            this.groupBoxThang.Controls.Add(this.cbNam);
            this.groupBoxThang.Controls.Add(this.label11);
            this.groupBoxThang.Controls.Add(this.cbThang);
            this.groupBoxThang.Controls.Add(this.label4);
            this.groupBoxThang.Location = new System.Drawing.Point(139, 63);
            this.groupBoxThang.Name = "groupBoxThang";
            this.groupBoxThang.Size = new System.Drawing.Size(366, 46);
            this.groupBoxThang.TabIndex = 96;
            this.groupBoxThang.TabStop = false;
            // 
            // cbNam
            // 
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
            this.cbNam.Location = new System.Drawing.Point(248, 15);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(71, 21);
            this.cbNam.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(174, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Chọn năm";
            // 
            // cbThang
            // 
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
            this.cbThang.Location = new System.Drawing.Point(103, 16);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(55, 21);
            this.cbThang.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Chọn tháng";
            // 
            // groupBoxNgay
            // 
            this.groupBoxNgay.Controls.Add(this.dtpNgay);
            this.groupBoxNgay.Controls.Add(this.label1);
            this.groupBoxNgay.Location = new System.Drawing.Point(139, 11);
            this.groupBoxNgay.Name = "groupBoxNgay";
            this.groupBoxNgay.Size = new System.Drawing.Size(366, 46);
            this.groupBoxNgay.TabIndex = 97;
            this.groupBoxNgay.TabStop = false;
            // 
            // dtpNgay
            // 
            this.dtpNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgay.Location = new System.Drawing.Point(103, 16);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(144, 20);
            this.dtpNgay.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Chọn ngày";
            // 
            // radThang
            // 
            this.radThang.AutoSize = true;
            this.radThang.Location = new System.Drawing.Point(17, 79);
            this.radThang.Name = "radThang";
            this.radThang.Size = new System.Drawing.Size(56, 17);
            this.radThang.TabIndex = 99;
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
            this.groupBoxThoigian.Location = new System.Drawing.Point(139, 115);
            this.groupBoxThoigian.Name = "groupBoxThoigian";
            this.groupBoxThoigian.Size = new System.Drawing.Size(366, 46);
            this.groupBoxThoigian.TabIndex = 95;
            this.groupBoxThoigian.TabStop = false;
            // 
            // dtpTG1
            // 
            this.dtpTG1.CustomFormat = "dd/MM/yyyy";
            this.dtpTG1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTG1.Location = new System.Drawing.Point(50, 16);
            this.dtpTG1.Name = "dtpTG1";
            this.dtpTG1.Size = new System.Drawing.Size(96, 20);
            this.dtpTG1.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Từ";
            // 
            // dtpTG2
            // 
            this.dtpTG2.CustomFormat = "dd/MM/yyyy";
            this.dtpTG2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTG2.Location = new System.Drawing.Point(210, 16);
            this.dtpTG2.Name = "dtpTG2";
            this.dtpTG2.Size = new System.Drawing.Size(94, 20);
            this.dtpTG2.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "đến";
            // 
            // radThoiGian
            // 
            this.radThoiGian.AutoSize = true;
            this.radThoiGian.Location = new System.Drawing.Point(17, 129);
            this.radThoiGian.Name = "radThoiGian";
            this.radThoiGian.Size = new System.Drawing.Size(102, 17);
            this.radThoiGian.TabIndex = 98;
            this.radThoiGian.Text = "Thời gian cụ thể";
            this.radThoiGian.UseVisualStyleBackColor = true;
            this.radThoiGian.CheckedChanged += new System.EventHandler(this.radThoiGian_CheckedChanged);
            // 
            // radNgay
            // 
            this.radNgay.AutoSize = true;
            this.radNgay.Checked = true;
            this.radNgay.Location = new System.Drawing.Point(17, 31);
            this.radNgay.Name = "radNgay";
            this.radNgay.Size = new System.Drawing.Size(50, 17);
            this.radNgay.TabIndex = 94;
            this.radNgay.TabStop = true;
            this.radNgay.Text = "Ngày";
            this.radNgay.UseVisualStyleBackColor = true;
            this.radNgay.CheckedChanged += new System.EventHandler(this.radNgay_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBoxThang);
            this.groupBox1.Controls.Add(this.radNgay);
            this.groupBox1.Controls.Add(this.groupBoxNgay);
            this.groupBox1.Controls.Add(this.radThoiGian);
            this.groupBox1.Controls.Add(this.radThang);
            this.groupBox1.Controls.Add(this.groupBoxThoigian);
            this.groupBox1.Location = new System.Drawing.Point(67, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 177);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểu thời gian thống kê";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bntLammoi);
            this.groupBox3.Controls.Add(this.btnThongke);
            this.groupBox3.Location = new System.Drawing.Point(983, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 88);
            this.groupBox3.TabIndex = 104;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác";
            // 
            // bntLammoi
            // 
            this.bntLammoi.Image = ((System.Drawing.Image)(resources.GetObject("bntLammoi.Image")));
            this.bntLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntLammoi.Location = new System.Drawing.Point(169, 26);
            this.bntLammoi.Name = "bntLammoi";
            this.bntLammoi.Size = new System.Drawing.Size(82, 44);
            this.bntLammoi.TabIndex = 96;
            this.bntLammoi.Text = "Làm mới";
            this.bntLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntLammoi.UseVisualStyleBackColor = true;
            this.bntLammoi.Click += new System.EventHandler(this.bntLammoi_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(625, 194);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(650, 336);
            this.chart1.TabIndex = 105;
            this.chart1.Text = "chart1";
            // 
            // frmThongKeSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 542);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Name = "frmThongKeSanPham";
            this.Text = "frmThongKeSanPham";
            this.Load += new System.EventHandler(this.frmThongKeSanPham_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.groupBoxThang.ResumeLayout(false);
            this.groupBoxThang.PerformLayout();
            this.groupBoxNgay.ResumeLayout(false);
            this.groupBoxNgay.PerformLayout();
            this.groupBoxThoigian.ResumeLayout(false);
            this.groupBoxThoigian.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.GroupBox groupBoxThang;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxNgay;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radThang;
        private System.Windows.Forms.GroupBox groupBoxThoigian;
        private System.Windows.Forms.DateTimePicker dtpTG1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpTG2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radThoiGian;
        private System.Windows.Forms.RadioButton radNgay;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtnhap;
        private System.Windows.Forms.Label txtban;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bntLammoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblTimtheoten;
        private System.Windows.Forms.TextBox txttimkiem;
    }
}