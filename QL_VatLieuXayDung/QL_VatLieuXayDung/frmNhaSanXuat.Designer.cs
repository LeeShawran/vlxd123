﻿namespace QL_VatLieuXayDung
{
    partial class frmNhaSanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaSanXuat));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThem_NSX = new System.Windows.Forms.Button();
            this.btnLuu_NSX = new System.Windows.Forms.Button();
            this.btnXoa_NSX = new System.Windows.Forms.Button();
            this.btnSua_NSX = new System.Windows.Forms.Button();
            this.lblFrmNSX = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail_NSX = new System.Windows.Forms.TextBox();
            this.lblEmail_NSX = new System.Windows.Forms.Label();
            this.txtMaNSX_NSX = new System.Windows.Forms.TextBox();
            this.lblMaNSX_NSX = new System.Windows.Forms.Label();
            this.txtDienthoai_NSX = new System.Windows.Forms.TextBox();
            this.txtDiachi_NSX = new System.Windows.Forms.TextBox();
            this.txtTenNSX_NSX = new System.Windows.Forms.TextBox();
            this.lblDienthoai_NSX = new System.Windows.Forms.Label();
            this.lblDiachi_NSX = new System.Windows.Forms.Label();
            this.lblTenNSX_NSX = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblStatus_NSX = new System.Windows.Forms.Label();
            this.dgvNSX = new System.Windows.Forms.DataGridView();
            this.ColumnMaNSX_NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenNSX_NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDthoai_NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail_NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDchi_NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAsc_NSX = new System.Windows.Forms.Button();
            this.btnDes_NSX = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNSX)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAsc_NSX);
            this.groupBox3.Controls.Add(this.btnDes_NSX);
            this.groupBox3.Controls.Add(this.dgvNSX);
            this.groupBox3.Location = new System.Drawing.Point(216, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(715, 281);
            this.groupBox3.TabIndex = 82;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách nhà xuất bản";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MASOTHUE";
            this.dataGridViewTextBoxColumn5.HeaderText = "Mã số thuế";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MANCC";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhà CC";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENNCC";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên nhà CC";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn3.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnThem_NSX);
            this.groupBox2.Controls.Add(this.btnLuu_NSX);
            this.groupBox2.Controls.Add(this.btnXoa_NSX);
            this.groupBox2.Controls.Add(this.btnSua_NSX);
            this.groupBox2.Location = new System.Drawing.Point(937, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(131, 449);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 54);
            this.button1.TabIndex = 23;
            this.button1.Text = "Xuất excel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnThem_NSX
            // 
            this.btnThem_NSX.Image = ((System.Drawing.Image)(resources.GetObject("btnThem_NSX.Image")));
            this.btnThem_NSX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem_NSX.Location = new System.Drawing.Point(25, 34);
            this.btnThem_NSX.Name = "btnThem_NSX";
            this.btnThem_NSX.Size = new System.Drawing.Size(67, 54);
            this.btnThem_NSX.TabIndex = 18;
            this.btnThem_NSX.Text = "Thêm";
            this.btnThem_NSX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem_NSX.UseVisualStyleBackColor = true;
            this.btnThem_NSX.Click += new System.EventHandler(this.btnThem_NSX_Click);
            // 
            // btnLuu_NSX
            // 
            this.btnLuu_NSX.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu_NSX.Image")));
            this.btnLuu_NSX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu_NSX.Location = new System.Drawing.Point(25, 281);
            this.btnLuu_NSX.Name = "btnLuu_NSX";
            this.btnLuu_NSX.Size = new System.Drawing.Size(67, 54);
            this.btnLuu_NSX.TabIndex = 21;
            this.btnLuu_NSX.Text = "Lưu";
            this.btnLuu_NSX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu_NSX.UseVisualStyleBackColor = true;
            this.btnLuu_NSX.Click += new System.EventHandler(this.btnLuu_NSX_Click);
            // 
            // btnXoa_NSX
            // 
            this.btnXoa_NSX.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa_NSX.Image")));
            this.btnXoa_NSX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa_NSX.Location = new System.Drawing.Point(25, 113);
            this.btnXoa_NSX.Name = "btnXoa_NSX";
            this.btnXoa_NSX.Size = new System.Drawing.Size(67, 54);
            this.btnXoa_NSX.TabIndex = 19;
            this.btnXoa_NSX.Text = "Xóa";
            this.btnXoa_NSX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa_NSX.UseVisualStyleBackColor = true;
            this.btnXoa_NSX.Click += new System.EventHandler(this.btnXoa_NSX_Click);
            // 
            // btnSua_NSX
            // 
            this.btnSua_NSX.Image = ((System.Drawing.Image)(resources.GetObject("btnSua_NSX.Image")));
            this.btnSua_NSX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua_NSX.Location = new System.Drawing.Point(25, 193);
            this.btnSua_NSX.Name = "btnSua_NSX";
            this.btnSua_NSX.Size = new System.Drawing.Size(67, 54);
            this.btnSua_NSX.TabIndex = 20;
            this.btnSua_NSX.Text = "Sửa";
            this.btnSua_NSX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua_NSX.UseVisualStyleBackColor = true;
            this.btnSua_NSX.Click += new System.EventHandler(this.btnSua_NSX_Click);
            // 
            // lblFrmNSX
            // 
            this.lblFrmNSX.AutoSize = true;
            this.lblFrmNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmNSX.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblFrmNSX.Location = new System.Drawing.Point(550, 18);
            this.lblFrmNSX.Name = "lblFrmNSX";
            this.lblFrmNSX.Size = new System.Drawing.Size(240, 33);
            this.lblFrmNSX.TabIndex = 84;
            this.lblFrmNSX.Text = "NHÀ SẢN XUẤT";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DIENTHOAI";
            this.dataGridViewTextBoxColumn4.HeaderText = "Điện thoại";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus_NSX);
            this.groupBox1.Controls.Add(this.txtEmail_NSX);
            this.groupBox1.Controls.Add(this.lblEmail_NSX);
            this.groupBox1.Controls.Add(this.txtMaNSX_NSX);
            this.groupBox1.Controls.Add(this.lblMaNSX_NSX);
            this.groupBox1.Controls.Add(this.txtDienthoai_NSX);
            this.groupBox1.Controls.Add(this.txtDiachi_NSX);
            this.groupBox1.Controls.Add(this.txtTenNSX_NSX);
            this.groupBox1.Controls.Add(this.lblDienthoai_NSX);
            this.groupBox1.Controls.Add(this.lblDiachi_NSX);
            this.groupBox1.Controls.Add(this.lblTenNSX_NSX);
            this.groupBox1.Location = new System.Drawing.Point(216, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 156);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtEmail_NSX
            // 
            this.txtEmail_NSX.Location = new System.Drawing.Point(490, 57);
            this.txtEmail_NSX.Name = "txtEmail_NSX";
            this.txtEmail_NSX.Size = new System.Drawing.Size(190, 20);
            this.txtEmail_NSX.TabIndex = 29;
            // 
            // lblEmail_NSX
            // 
            this.lblEmail_NSX.AutoSize = true;
            this.lblEmail_NSX.Location = new System.Drawing.Point(426, 60);
            this.lblEmail_NSX.Name = "lblEmail_NSX";
            this.lblEmail_NSX.Size = new System.Drawing.Size(35, 13);
            this.lblEmail_NSX.TabIndex = 28;
            this.lblEmail_NSX.Text = "Email:";
            // 
            // txtMaNSX_NSX
            // 
            this.txtMaNSX_NSX.Location = new System.Drawing.Point(136, 31);
            this.txtMaNSX_NSX.Name = "txtMaNSX_NSX";
            this.txtMaNSX_NSX.Size = new System.Drawing.Size(190, 20);
            this.txtMaNSX_NSX.TabIndex = 27;
            // 
            // lblMaNSX_NSX
            // 
            this.lblMaNSX_NSX.AutoSize = true;
            this.lblMaNSX_NSX.Location = new System.Drawing.Point(37, 34);
            this.lblMaNSX_NSX.Name = "lblMaNSX_NSX";
            this.lblMaNSX_NSX.Size = new System.Drawing.Size(89, 13);
            this.lblMaNSX_NSX.TabIndex = 26;
            this.lblMaNSX_NSX.Text = "Mã nhà sản xuất:";
            // 
            // txtDienthoai_NSX
            // 
            this.txtDienthoai_NSX.Location = new System.Drawing.Point(490, 31);
            this.txtDienthoai_NSX.Name = "txtDienthoai_NSX";
            this.txtDienthoai_NSX.Size = new System.Drawing.Size(190, 20);
            this.txtDienthoai_NSX.TabIndex = 25;
            // 
            // txtDiachi_NSX
            // 
            this.txtDiachi_NSX.Location = new System.Drawing.Point(490, 83);
            this.txtDiachi_NSX.Multiline = true;
            this.txtDiachi_NSX.Name = "txtDiachi_NSX";
            this.txtDiachi_NSX.Size = new System.Drawing.Size(190, 54);
            this.txtDiachi_NSX.TabIndex = 24;
            // 
            // txtTenNSX_NSX
            // 
            this.txtTenNSX_NSX.Location = new System.Drawing.Point(136, 57);
            this.txtTenNSX_NSX.Name = "txtTenNSX_NSX";
            this.txtTenNSX_NSX.Size = new System.Drawing.Size(190, 20);
            this.txtTenNSX_NSX.TabIndex = 23;
            // 
            // lblDienthoai_NSX
            // 
            this.lblDienthoai_NSX.AutoSize = true;
            this.lblDienthoai_NSX.Location = new System.Drawing.Point(426, 34);
            this.lblDienthoai_NSX.Name = "lblDienthoai_NSX";
            this.lblDienthoai_NSX.Size = new System.Drawing.Size(58, 13);
            this.lblDienthoai_NSX.TabIndex = 22;
            this.lblDienthoai_NSX.Text = "Điện thoại:";
            // 
            // lblDiachi_NSX
            // 
            this.lblDiachi_NSX.AutoSize = true;
            this.lblDiachi_NSX.Location = new System.Drawing.Point(426, 86);
            this.lblDiachi_NSX.Name = "lblDiachi_NSX";
            this.lblDiachi_NSX.Size = new System.Drawing.Size(43, 13);
            this.lblDiachi_NSX.TabIndex = 21;
            this.lblDiachi_NSX.Text = "Địa chỉ:";
            // 
            // lblTenNSX_NSX
            // 
            this.lblTenNSX_NSX.AutoSize = true;
            this.lblTenNSX_NSX.Location = new System.Drawing.Point(37, 60);
            this.lblTenNSX_NSX.Name = "lblTenNSX_NSX";
            this.lblTenNSX_NSX.Size = new System.Drawing.Size(93, 13);
            this.lblTenNSX_NSX.TabIndex = 20;
            this.lblTenNSX_NSX.Text = "Tên nhà sản xuất:";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GHICHU";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ghi chú";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // lblStatus_NSX
            // 
            this.lblStatus_NSX.AutoSize = true;
            this.lblStatus_NSX.Location = new System.Drawing.Point(37, 86);
            this.lblStatus_NSX.Name = "lblStatus_NSX";
            this.lblStatus_NSX.Size = new System.Drawing.Size(10, 13);
            this.lblStatus_NSX.TabIndex = 30;
            this.lblStatus_NSX.Text = ".";
            // 
            // dgvNSX
            // 
            this.dgvNSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaNSX_NSX,
            this.ColumnTenNSX_NSX,
            this.ColumnDthoai_NSX,
            this.ColumnEmail_NSX,
            this.ColumnDchi_NSX});
            this.dgvNSX.Location = new System.Drawing.Point(18, 25);
            this.dgvNSX.Name = "dgvNSX";
            this.dgvNSX.Size = new System.Drawing.Size(544, 233);
            this.dgvNSX.TabIndex = 0;
            this.dgvNSX.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNSX_CellMouseClick);
            // 
            // ColumnMaNSX_NSX
            // 
            this.ColumnMaNSX_NSX.DataPropertyName = "MANSX";
            this.ColumnMaNSX_NSX.HeaderText = "Mã sản xuất";
            this.ColumnMaNSX_NSX.Name = "ColumnMaNSX_NSX";
            // 
            // ColumnTenNSX_NSX
            // 
            this.ColumnTenNSX_NSX.DataPropertyName = "TENNSX";
            this.ColumnTenNSX_NSX.HeaderText = "Tên nhà sản xuất";
            this.ColumnTenNSX_NSX.Name = "ColumnTenNSX_NSX";
            // 
            // ColumnDthoai_NSX
            // 
            this.ColumnDthoai_NSX.DataPropertyName = "DTHOAINSX";
            this.ColumnDthoai_NSX.HeaderText = "Điện thoại";
            this.ColumnDthoai_NSX.Name = "ColumnDthoai_NSX";
            // 
            // ColumnEmail_NSX
            // 
            this.ColumnEmail_NSX.DataPropertyName = "EMAILNSX";
            this.ColumnEmail_NSX.HeaderText = "Email";
            this.ColumnEmail_NSX.Name = "ColumnEmail_NSX";
            // 
            // ColumnDchi_NSX
            // 
            this.ColumnDchi_NSX.DataPropertyName = "DCHINSX";
            this.ColumnDchi_NSX.HeaderText = "Địa chỉ";
            this.ColumnDchi_NSX.Name = "ColumnDchi_NSX";
            // 
            // btnAsc_NSX
            // 
            this.btnAsc_NSX.Image = ((System.Drawing.Image)(resources.GetObject("btnAsc_NSX.Image")));
            this.btnAsc_NSX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsc_NSX.Location = new System.Drawing.Point(592, 73);
            this.btnAsc_NSX.Name = "btnAsc_NSX";
            this.btnAsc_NSX.Size = new System.Drawing.Size(99, 44);
            this.btnAsc_NSX.TabIndex = 21;
            this.btnAsc_NSX.Text = "Trên xuống";
            this.btnAsc_NSX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsc_NSX.UseVisualStyleBackColor = true;
            this.btnAsc_NSX.Click += new System.EventHandler(this.btnAsc_NSX_Click);
            // 
            // btnDes_NSX
            // 
            this.btnDes_NSX.Image = ((System.Drawing.Image)(resources.GetObject("btnDes_NSX.Image")));
            this.btnDes_NSX.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDes_NSX.Location = new System.Drawing.Point(592, 163);
            this.btnDes_NSX.Name = "btnDes_NSX";
            this.btnDes_NSX.Size = new System.Drawing.Size(99, 44);
            this.btnDes_NSX.TabIndex = 22;
            this.btnDes_NSX.Text = "Dưới lên";
            this.btnDes_NSX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDes_NSX.UseVisualStyleBackColor = true;
            this.btnDes_NSX.Click += new System.EventHandler(this.btnDes_NSX_Click);
            // 
            // frmNhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 542);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblFrmNSX);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNhaSanXuat";
            this.Text = "Nhà sản xuất";
            this.Load += new System.EventHandler(this.frmNhaSanXuat_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNSX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThem_NSX;
        private System.Windows.Forms.Button btnLuu_NSX;
        private System.Windows.Forms.Button btnXoa_NSX;
        private System.Windows.Forms.Button btnSua_NSX;
        private System.Windows.Forms.Label lblFrmNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail_NSX;
        private System.Windows.Forms.Label lblEmail_NSX;
        private System.Windows.Forms.TextBox txtMaNSX_NSX;
        private System.Windows.Forms.Label lblMaNSX_NSX;
        private System.Windows.Forms.TextBox txtDienthoai_NSX;
        private System.Windows.Forms.TextBox txtDiachi_NSX;
        private System.Windows.Forms.TextBox txtTenNSX_NSX;
        private System.Windows.Forms.Label lblDienthoai_NSX;
        private System.Windows.Forms.Label lblDiachi_NSX;
        private System.Windows.Forms.Label lblTenNSX_NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lblStatus_NSX;
        private System.Windows.Forms.DataGridView dgvNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaNSX_NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenNSX_NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDthoai_NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail_NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDchi_NSX;
        private System.Windows.Forms.Button btnAsc_NSX;
        private System.Windows.Forms.Button btnDes_NSX;
    }
}