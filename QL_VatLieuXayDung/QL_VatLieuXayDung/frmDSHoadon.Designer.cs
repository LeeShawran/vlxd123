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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
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
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_HD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvHoaDon);
            this.groupBox4.Location = new System.Drawing.Point(62, 89);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(495, 244);
            this.groupBox4.TabIndex = 117;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách hoa don";
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
            this.dgvHoaDon.Location = new System.Drawing.Point(16, 29);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(455, 195);
            this.dgvHoaDon.TabIndex = 28;
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
            this.groupBox5.Location = new System.Drawing.Point(599, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(484, 475);
            this.groupBox5.TabIndex = 118;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết hoa don";
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
            this.dgvCT_HD.Location = new System.Drawing.Point(22, 24);
            this.dgvCT_HD.Name = "dgvCT_HD";
            this.dgvCT_HD.Size = new System.Drawing.Size(447, 434);
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
            // frmDSHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 542);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Name = "frmDSHoadon";
            this.Text = "frmDSHoadon";
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT_HD)).EndInit();
            this.ResumeLayout(false);

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
    }
}