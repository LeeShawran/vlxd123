namespace QL_VatLieuXayDung
{
    partial class frmDSHoadon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSHoadon));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTG1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpTG2 = new System.Windows.Forms.DateTimePicker();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphieudat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvCT_HD = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblSanpham = new System.Windows.Forms.Label();
            this.bntLammoi = new System.Windows.Forms.Button();
            this.btnExcelHD = new System.Windows.Forms.Button();
            this.btnExcelCT_HD = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_HD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.btnLoc);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.dgvHoaDon);
            this.groupBox4.Location = new System.Drawing.Point(74, 94);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(593, 436);
            this.groupBox4.TabIndex = 117;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách hóa đơn";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(49, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(44, 17);
            this.checkBox1.TabIndex = 125;
            this.checkBox1.Text = "Lọc";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnLoc
            // 
            this.btnLoc.Enabled = false;
            this.btnLoc.Location = new System.Drawing.Point(458, 25);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(72, 34);
            this.btnLoc.TabIndex = 124;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTG1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtpTG2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(108, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 40);
            this.groupBox1.TabIndex = 123;
            this.groupBox1.TabStop = false;
            // 
            // dtpTG1
            // 
            this.dtpTG1.CustomFormat = "dd/MM/yyyy";
            this.dtpTG1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTG1.Location = new System.Drawing.Point(53, 12);
            this.dtpTG1.Name = "dtpTG1";
            this.dtpTG1.Size = new System.Drawing.Size(96, 20);
            this.dtpTG1.TabIndex = 120;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 121;
            this.label7.Text = "Từ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 122;
            this.label8.Text = "đến";
            // 
            // dtpTG2
            // 
            this.dtpTG2.CustomFormat = "dd/MM/yyyy";
            this.dtpTG2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTG2.Location = new System.Drawing.Point(213, 12);
            this.dtpTG2.Name = "dtpTG2";
            this.dtpTG2.Size = new System.Drawing.Size(94, 20);
            this.dtpTG2.TabIndex = 119;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahd,
            this.ngaylap,
            this.manv,
            this.maphieudat,
            this.tongtien});
            this.dgvHoaDon.Location = new System.Drawing.Point(18, 83);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(553, 330);
            this.dgvHoaDon.TabIndex = 28;
            this.dgvHoaDon.Click += new System.EventHandler(this.dgvHoaDon_Click);
            // 
            // mahd
            // 
            this.mahd.DataPropertyName = "MAHD";
            this.mahd.HeaderText = "Mã hóa đơn";
            this.mahd.Name = "mahd";
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "NGAYHD";
            this.ngaylap.HeaderText = "Ngày hóa đơn";
            this.ngaylap.Name = "ngaylap";
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
            this.maphieudat.HeaderText = "Mã phiếu đặt";
            this.maphieudat.Name = "maphieudat";
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "TONGTIEN";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.Name = "tongtien";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvCT_HD);
            this.groupBox5.Location = new System.Drawing.Point(702, 166);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(545, 364);
            this.groupBox5.TabIndex = 118;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết hóa đơn";
            // 
            // dgvCT_HD
            // 
            this.dgvCT_HD.AllowUserToAddRows = false;
            this.dgvCT_HD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_HD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.Column2});
            this.dgvCT_HD.Location = new System.Drawing.Point(28, 30);
            this.dgvCT_HD.MultiSelect = false;
            this.dgvCT_HD.Name = "dgvCT_HD";
            this.dgvCT_HD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCT_HD.Size = new System.Drawing.Size(500, 308);
            this.dgvCT_HD.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MASP";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn6.HeaderText = "Số lượng bán";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DONGIABAN";
            this.Column2.HeaderText = "Đơn giá bán";
            this.Column2.Name = "Column2";
            // 
            // lblSanpham
            // 
            this.lblSanpham.AutoSize = true;
            this.lblSanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanpham.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSanpham.Location = new System.Drawing.Point(481, 29);
            this.lblSanpham.Name = "lblSanpham";
            this.lblSanpham.Size = new System.Drawing.Size(346, 33);
            this.lblSanpham.TabIndex = 119;
            this.lblSanpham.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // bntLammoi
            // 
            this.bntLammoi.Image = ((System.Drawing.Image)(resources.GetObject("bntLammoi.Image")));
            this.bntLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntLammoi.Location = new System.Drawing.Point(729, 96);
            this.bntLammoi.Name = "bntLammoi";
            this.bntLammoi.Size = new System.Drawing.Size(98, 44);
            this.bntLammoi.TabIndex = 121;
            this.bntLammoi.Text = "Làm mới";
            this.bntLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntLammoi.UseVisualStyleBackColor = true;
            this.bntLammoi.Click += new System.EventHandler(this.bntLammoi_Click);
            // 
            // btnExcelHD
            // 
            this.btnExcelHD.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelHD.Image")));
            this.btnExcelHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelHD.Location = new System.Drawing.Point(870, 96);
            this.btnExcelHD.Name = "btnExcelHD";
            this.btnExcelHD.Size = new System.Drawing.Size(150, 46);
            this.btnExcelHD.TabIndex = 120;
            this.btnExcelHD.Text = "Xuất excel hóa đơn";
            this.btnExcelHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcelHD.UseVisualStyleBackColor = true;
            this.btnExcelHD.Click += new System.EventHandler(this.btnExcelHD_Click);
            // 
            // btnExcelCT_HD
            // 
            this.btnExcelCT_HD.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelCT_HD.Image")));
            this.btnExcelCT_HD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelCT_HD.Location = new System.Drawing.Point(1058, 94);
            this.btnExcelCT_HD.Name = "btnExcelCT_HD";
            this.btnExcelCT_HD.Size = new System.Drawing.Size(172, 46);
            this.btnExcelCT_HD.TabIndex = 122;
            this.btnExcelCT_HD.Text = "Xuất excel Chi tiết hóa đơn";
            this.btnExcelCT_HD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcelCT_HD.UseVisualStyleBackColor = true;
            this.btnExcelCT_HD.Click += new System.EventHandler(this.btnExcelCT_HD_Click);
            // 
            // frmDSHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 542);
            this.Controls.Add(this.btnExcelCT_HD);
            this.Controls.Add(this.bntLammoi);
            this.Controls.Add(this.btnExcelHD);
            this.Controls.Add(this.lblSanpham);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Name = "frmDSHoadon";
            this.Text = "frmDSHoadon";
            this.Load += new System.EventHandler(this.frmDSHoadon_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_HD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieudat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien;
        protected System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvCT_HD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTG1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpTG2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblSanpham;
        private System.Windows.Forms.Button bntLammoi;
        private System.Windows.Forms.Button btnExcelHD;
        private System.Windows.Forms.Button btnExcelCT_HD;
    }
}