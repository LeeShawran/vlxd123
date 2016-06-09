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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtLai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGia
            // 
            this.dgvGia.AllowUserToAddRows = false;
            this.dgvGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvGia.Location = new System.Drawing.Point(61, 230);
            this.dgvGia.Name = "dgvGia";
            this.dgvGia.Size = new System.Drawing.Size(261, 211);
            this.dgvGia.TabIndex = 0;
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
            this.lblTenLoai_LoaiSP.Location = new System.Drawing.Point(58, 97);
            this.lblTenLoai_LoaiSP.Name = "lblTenLoai_LoaiSP";
            this.lblTenLoai_LoaiSP.Size = new System.Drawing.Size(50, 13);
            this.lblTenLoai_LoaiSP.TabIndex = 10;
            this.lblTenLoai_LoaiSP.Text = "Giá nhập";
            // 
            // lblMaLoai_LoaiSP
            // 
            this.lblMaLoai_LoaiSP.AutoSize = true;
            this.lblMaLoai_LoaiSP.Location = new System.Drawing.Point(58, 23);
            this.lblMaLoai_LoaiSP.Name = "lblMaLoai_LoaiSP";
            this.lblMaLoai_LoaiSP.Size = new System.Drawing.Size(47, 13);
            this.lblMaLoai_LoaiSP.TabIndex = 11;
            this.lblMaLoai_LoaiSP.Text = "Mã loại :";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(115, 94);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(192, 20);
            this.txtGiaNhap.TabIndex = 13;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(115, 20);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(192, 20);
            this.txtMaSP.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Giá bán";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(115, 190);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(192, 20);
            this.txtGiaBan.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã loại :";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(115, 57);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(192, 20);
            this.txtTenSP.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 74);
            this.button1.TabIndex = 18;
            this.button1.Text = "Lưu giá bán";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLai
            // 
            this.txtLai.Location = new System.Drawing.Point(115, 158);
            this.txtLai.Name = "txtLai";
            this.txtLai.Size = new System.Drawing.Size(143, 20);
            this.txtLai.TabIndex = 19;
            this.txtLai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLai_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Lãi (%)";
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.CustomFormat = "dd/MM/yyyy";
            this.txtNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayLap.Location = new System.Drawing.Point(115, 120);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.Size = new System.Drawing.Size(194, 20);
            this.txtNgayLap.TabIndex = 23;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(272, 158);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(35, 24);
            this.btnOK.TabIndex = 24;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmDinhGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 464);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLai);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.lblTenLoai_LoaiSP);
            this.Controls.Add(this.lblMaLoai_LoaiSP);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.dgvGia);
            this.Name = "frmDinhGia";
            this.Text = "frmDinhGia";
            this.Load += new System.EventHandler(this.frmDinhGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGia)).EndInit();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtLai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        protected System.Windows.Forms.DateTimePicker txtNgayLap;
        private System.Windows.Forms.Button btnOK;
    }
}