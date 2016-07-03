namespace QL_VatLieuXayDung
{
    partial class frmDSPhieugiao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSPhieugiao));
            this.btnExcelCT_PG = new System.Windows.Forms.Button();
            this.bntLammoi = new System.Windows.Forms.Button();
            this.btnExcelPG = new System.Windows.Forms.Button();
            this.lblSanpham = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvPhieu_Giao = new System.Windows.Forms.DataGridView();
            this.magiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaygiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphieudat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTG1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpTG2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvCT_PhieuGiao = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu_Giao)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_PhieuGiao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcelCT_PG
            // 
            this.btnExcelCT_PG.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelCT_PG.Image")));
            this.btnExcelCT_PG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelCT_PG.Location = new System.Drawing.Point(1054, 96);
            this.btnExcelCT_PG.Name = "btnExcelCT_PG";
            this.btnExcelCT_PG.Size = new System.Drawing.Size(180, 31);
            this.btnExcelCT_PG.TabIndex = 128;
            this.btnExcelCT_PG.Text = "Xuất excel Chi tiết phiếu giao";
            this.btnExcelCT_PG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcelCT_PG.UseVisualStyleBackColor = true;
            this.btnExcelCT_PG.Click += new System.EventHandler(this.btnExcelCT_PG_Click);
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
            // btnExcelPG
            // 
            this.btnExcelPG.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelPG.Image")));
            this.btnExcelPG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelPG.Location = new System.Drawing.Point(863, 96);
            this.btnExcelPG.Name = "btnExcelPG";
            this.btnExcelPG.Size = new System.Drawing.Size(146, 31);
            this.btnExcelPG.TabIndex = 126;
            this.btnExcelPG.Text = "Xuất excel phiếu giao";
            this.btnExcelPG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcelPG.UseVisualStyleBackColor = true;
            this.btnExcelPG.Click += new System.EventHandler(this.btnExcelPG_Click);
            // 
            // lblSanpham
            // 
            this.lblSanpham.AutoSize = true;
            this.lblSanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanpham.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSanpham.Location = new System.Drawing.Point(487, 21);
            this.lblSanpham.Name = "lblSanpham";
            this.lblSanpham.Size = new System.Drawing.Size(382, 33);
            this.lblSanpham.TabIndex = 125;
            this.lblSanpham.Text = "DANH SÁCH PHIẾU GIAO";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvPhieu_Giao);
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
            // dgvPhieu_Giao
            // 
            this.dgvPhieu_Giao.AllowUserToAddRows = false;
            this.dgvPhieu_Giao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieu_Giao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieu_Giao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.magiao,
            this.ngaygiao,
            this.manv,
            this.maphieudat});
            this.dgvPhieu_Giao.Location = new System.Drawing.Point(18, 65);
            this.dgvPhieu_Giao.Name = "dgvPhieu_Giao";
            this.dgvPhieu_Giao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieu_Giao.Size = new System.Drawing.Size(557, 352);
            this.dgvPhieu_Giao.TabIndex = 126;
            this.dgvPhieu_Giao.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPhieu_Giao_CellFormatting);
            this.dgvPhieu_Giao.Click += new System.EventHandler(this.dgvPhieu_Giao_Click);
            // 
            // magiao
            // 
            this.magiao.DataPropertyName = "MAPHIEUGIAO";
            this.magiao.HeaderText = "Mã phiếu giao";
            this.magiao.Name = "magiao";
            // 
            // ngaygiao
            // 
            this.ngaygiao.DataPropertyName = "NGAYGIAO";
            this.ngaygiao.HeaderText = "Ngày giao";
            this.ngaygiao.Name = "ngaygiao";
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
            this.maphieudat.HeaderText = "Mã đơn đặt";
            this.maphieudat.Name = "maphieudat";
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
            this.groupBox5.Controls.Add(this.dgvCT_PhieuGiao);
            this.groupBox5.Location = new System.Drawing.Point(708, 158);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(545, 364);
            this.groupBox5.TabIndex = 124;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết hóa đơn";
            // 
            // dgvCT_PhieuGiao
            // 
            this.dgvCT_PhieuGiao.AllowUserToAddRows = false;
            this.dgvCT_PhieuGiao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT_PhieuGiao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT_PhieuGiao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.Column2,
            this.dataGridViewTextBoxColumn6});
            this.dgvCT_PhieuGiao.Location = new System.Drawing.Point(16, 19);
            this.dgvCT_PhieuGiao.Name = "dgvCT_PhieuGiao";
            this.dgvCT_PhieuGiao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCT_PhieuGiao.Size = new System.Drawing.Size(510, 326);
            this.dgvCT_PhieuGiao.TabIndex = 30;
            this.dgvCT_PhieuGiao.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCT_PhieuGiao_CellFormatting);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MASP";
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SOLUONG_CONGIAO";
            this.Column2.HeaderText = "Số lượng còn phải giao";
            this.Column2.Name = "Column2";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SOLUONGGIAO";
            this.dataGridViewTextBoxColumn6.HeaderText = "Số lượng giao";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // frmDSPhieugiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 542);
            this.Controls.Add(this.btnExcelCT_PG);
            this.Controls.Add(this.bntLammoi);
            this.Controls.Add(this.btnExcelPG);
            this.Controls.Add(this.lblSanpham);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Name = "frmDSPhieugiao";
            this.Text = "Danh sách phiếu giao";
            this.Load += new System.EventHandler(this.fmDSPhieugiao_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu_Giao)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_PhieuGiao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcelCT_PG;
        private System.Windows.Forms.Button bntLammoi;
        private System.Windows.Forms.Button btnExcelPG;
        private System.Windows.Forms.Label lblSanpham;
        protected System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTG1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpTG2;
        protected System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvPhieu_Giao;
        private System.Windows.Forms.DataGridViewTextBoxColumn magiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaygiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphieudat;
        private System.Windows.Forms.DataGridView dgvCT_PhieuGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}