namespace QL_VatLieuXayDung
{
    partial class frmDSPhieunhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSPhieunhap));
            this.btnExcelCT_PN = new System.Windows.Forms.Button();
            this.bntLammoi = new System.Windows.Forms.Button();
            this.btnExcelPN = new System.Windows.Forms.Button();
            this.lblDSphieunhap = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvPhieunhap = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylapcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTG1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpTG2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvCT_NhapHang = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieunhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_NhapHang)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcelCT_PN
            // 
            this.btnExcelCT_PN.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelCT_PN.Image")));
            this.btnExcelCT_PN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelCT_PN.Location = new System.Drawing.Point(1045, 96);
            this.btnExcelCT_PN.Name = "btnExcelCT_PN";
            this.btnExcelCT_PN.Size = new System.Drawing.Size(181, 31);
            this.btnExcelCT_PN.TabIndex = 128;
            this.btnExcelCT_PN.Text = "Xuất excel Chi tiết phiếu nhập";
            this.btnExcelCT_PN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcelCT_PN.UseVisualStyleBackColor = true;
            this.btnExcelCT_PN.Click += new System.EventHandler(this.btnExcelCT_PN_Click);
            // 
            // bntLammoi
            // 
            this.bntLammoi.Image = ((System.Drawing.Image)(resources.GetObject("bntLammoi.Image")));
            this.bntLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntLammoi.Location = new System.Drawing.Point(736, 96);
            this.bntLammoi.Name = "bntLammoi";
            this.bntLammoi.Size = new System.Drawing.Size(83, 31);
            this.bntLammoi.TabIndex = 127;
            this.bntLammoi.Text = "Làm mới";
            this.bntLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntLammoi.UseVisualStyleBackColor = true;
            this.bntLammoi.Click += new System.EventHandler(this.bntLammoi_Click);
            // 
            // btnExcelPN
            // 
            this.btnExcelPN.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelPN.Image")));
            this.btnExcelPN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelPN.Location = new System.Drawing.Point(863, 96);
            this.btnExcelPN.Name = "btnExcelPN";
            this.btnExcelPN.Size = new System.Drawing.Size(145, 31);
            this.btnExcelPN.TabIndex = 126;
            this.btnExcelPN.Text = "Xuất excel phiếu nhập";
            this.btnExcelPN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcelPN.UseVisualStyleBackColor = true;
            this.btnExcelPN.Click += new System.EventHandler(this.btnExcelPN_Click);
            // 
            // lblDSphieunhap
            // 
            this.lblDSphieunhap.AutoSize = true;
            this.lblDSphieunhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSphieunhap.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblDSphieunhap.Location = new System.Drawing.Point(487, 21);
            this.lblDSphieunhap.Name = "lblDSphieunhap";
            this.lblDSphieunhap.Size = new System.Drawing.Size(389, 33);
            this.lblDSphieunhap.TabIndex = 125;
            this.lblDSphieunhap.Text = "DANH SÁCH PHIẾU NHẬP";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvPhieunhap);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.btnLoc);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Location = new System.Drawing.Point(80, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(593, 436);
            this.groupBox4.TabIndex = 123;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách hóa đơn";
            // 
            // dgvPhieunhap
            // 
            this.dgvPhieunhap.AllowUserToAddRows = false;
            this.dgvPhieunhap.AllowUserToDeleteRows = false;
            this.dgvPhieunhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieunhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieunhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ngaylapcol,
            this.Column1,
            this.dataGridViewTextBoxColumn3,
            this.Column3});
            this.dgvPhieunhap.Location = new System.Drawing.Point(18, 72);
            this.dgvPhieunhap.MultiSelect = false;
            this.dgvPhieunhap.Name = "dgvPhieunhap";
            this.dgvPhieunhap.ReadOnly = true;
            this.dgvPhieunhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieunhap.Size = new System.Drawing.Size(557, 345);
            this.dgvPhieunhap.TabIndex = 126;
            this.dgvPhieunhap.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPhieunhap_CellFormatting);
            this.dgvPhieunhap.Click += new System.EventHandler(this.dgvPhieunhap_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAPN";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã phiếu nhập";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ngaylapcol
            // 
            this.ngaylapcol.DataPropertyName = "NGAYLAP";
            this.ngaylapcol.HeaderText = "Ngày nhập";
            this.ngaylapcol.Name = "ngaylapcol";
            this.ngaylapcol.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MANV";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MADATNCC";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mã phiếu đặt";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TONGTIEN";
            this.Column3.HeaderText = "Tổng tiền";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
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
            this.btnLoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLoc.Image")));
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(458, 25);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(57, 34);
            this.btnLoc.TabIndex = 124;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvCT_NhapHang);
            this.groupBox5.Location = new System.Drawing.Point(708, 158);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(545, 364);
            this.groupBox5.TabIndex = 124;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết hóa đơn";
            // 
            // dgvCT_NhapHang
            // 
            this.dgvCT_NhapHang.AllowUserToAddRows = false;
            this.dgvCT_NhapHang.AllowUserToDeleteRows = false;
            this.dgvCT_NhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_NhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_NhapHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.Column2,
            this.dataGridViewTextBoxColumn6});
            this.dgvCT_NhapHang.Location = new System.Drawing.Point(28, 31);
            this.dgvCT_NhapHang.MultiSelect = false;
            this.dgvCT_NhapHang.Name = "dgvCT_NhapHang";
            this.dgvCT_NhapHang.ReadOnly = true;
            this.dgvCT_NhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCT_NhapHang.Size = new System.Drawing.Size(490, 314);
            this.dgvCT_NhapHang.TabIndex = 30;
            this.dgvCT_NhapHang.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCT_NhapHang_CellFormatting);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MASP";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DONGIANHAP";
            this.Column2.HeaderText = "Đơn giá nhập";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn6.HeaderText = "Số lượng nhập";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // frmDSPhieunhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 542);
            this.Controls.Add(this.btnExcelCT_PN);
            this.Controls.Add(this.bntLammoi);
            this.Controls.Add(this.btnExcelPN);
            this.Controls.Add(this.lblDSphieunhap);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Name = "frmDSPhieunhap";
            this.Text = "Danh sách phiếu nhập";
            this.Load += new System.EventHandler(this.frmDSPhieunhap_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieunhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_NhapHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcelCT_PN;
        private System.Windows.Forms.Button bntLammoi;
        private System.Windows.Forms.Button btnExcelPN;
        private System.Windows.Forms.Label lblDSphieunhap;
        protected System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTG1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpTG2;
        protected System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvPhieunhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylapcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dgvCT_NhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}