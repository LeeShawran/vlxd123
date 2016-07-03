namespace QL_VatLieuXayDung
{
    partial class frmDinhGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDinhGia));
            this.dgvGia = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTenLoai_LoaiSP = new System.Windows.Forms.Label();
            this.lblMaLoai_LoaiSP = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDinhgia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGia
            // 
            this.dgvGia.AllowUserToAddRows = false;
            this.dgvGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvGia.Location = new System.Drawing.Point(16, 176);
            this.dgvGia.Name = "dgvGia";
            this.dgvGia.Size = new System.Drawing.Size(284, 294);
            this.dgvGia.TabIndex = 0;
            this.dgvGia.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGia_CellFormatting);
            this.dgvGia.Click += new System.EventHandler(this.dgvGia_Click);
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
            // lblTenLoai_LoaiSP
            // 
            this.lblTenLoai_LoaiSP.AutoSize = true;
            this.lblTenLoai_LoaiSP.Location = new System.Drawing.Point(28, 74);
            this.lblTenLoai_LoaiSP.Name = "lblTenLoai_LoaiSP";
            this.lblTenLoai_LoaiSP.Size = new System.Drawing.Size(53, 13);
            this.lblTenLoai_LoaiSP.TabIndex = 10;
            this.lblTenLoai_LoaiSP.Text = "Giá nhập:";
            // 
            // lblMaLoai_LoaiSP
            // 
            this.lblMaLoai_LoaiSP.AutoSize = true;
            this.lblMaLoai_LoaiSP.Location = new System.Drawing.Point(28, 22);
            this.lblMaLoai_LoaiSP.Name = "lblMaLoai_LoaiSP";
            this.lblMaLoai_LoaiSP.Size = new System.Drawing.Size(47, 13);
            this.lblMaLoai_LoaiSP.TabIndex = 11;
            this.lblMaLoai_LoaiSP.Text = "Mã loại :";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(87, 71);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(171, 20);
            this.txtGiaNhap.TabIndex = 13;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(87, 19);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(129, 20);
            this.txtMaSP.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giá bán:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(87, 150);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(158, 20);
            this.txtGiaBan.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên loại :";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(87, 45);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(129, 20);
            this.txtTenSP.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(222, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "Lưu giá bán";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLai
            // 
            this.txtLai.Location = new System.Drawing.Point(87, 124);
            this.txtLai.Name = "txtLai";
            this.txtLai.Size = new System.Drawing.Size(144, 20);
            this.txtLai.TabIndex = 19;
            this.txtLai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLai_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Lãi suất:";
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.CustomFormat = "dd/MM/yyyy";
            this.txtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayLap.Location = new System.Drawing.Point(87, 97);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(131, 20);
            this.txtNgayLap.TabIndex = 23;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(265, 120);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(35, 24);
            this.btnOK.TabIndex = 24;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvGia);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblMaLoai_LoaiSP);
            this.groupBox1.Controls.Add(this.txtLai);
            this.groupBox1.Controls.Add(this.txtNgayLap);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtGiaNhap);
            this.groupBox1.Controls.Add(this.lblTenLoai_LoaiSP);
            this.groupBox1.Location = new System.Drawing.Point(538, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 485);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều chỉnh giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "(VNĐ)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "(VNĐ)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ngày nhập:";
            // 
            // lblDinhgia
            // 
            this.lblDinhgia.AutoSize = true;
            this.lblDinhgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDinhgia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDinhgia.Location = new System.Drawing.Point(532, 9);
            this.lblDinhgia.Name = "lblDinhgia";
            this.lblDinhgia.Size = new System.Drawing.Size(327, 33);
            this.lblDinhgia.TabIndex = 26;
            this.lblDinhgia.Text = "ĐIỂU CHỈNH GIÁ BÁN";
            // 
            // frmDinhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 542);
            this.Controls.Add(this.lblDinhgia);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDinhGia";
            this.Text = "Định giá sản phẩm";
            this.Load += new System.EventHandler(this.frmDinhGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGia;
        private System.Windows.Forms.Label lblTenLoai_LoaiSP;
        private System.Windows.Forms.Label lblMaLoai_LoaiSP;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        protected System.Windows.Forms.DateTimePicker txtNgayLap;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDinhgia;
    }
}