namespace QL_VatLieuXayDung
{
    partial class frmThongKeTonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeTonKho));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choxuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chonhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gianhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongton = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSanpham = new System.Windows.Forms.Label();
            this.lblTimtheoten = new System.Windows.Forms.Label();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.bntLammoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.soluong,
            this.choxuat,
            this.chonhap,
            this.gianhap,
            this.giaban,
            this.loi,
            this.tongton});
            this.dataGridView1.Location = new System.Drawing.Point(66, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1175, 384);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
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
            // soluong
            // 
            this.soluong.DataPropertyName = "SOLUONG";
            this.soluong.HeaderText = "Tồn kho";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            // 
            // choxuat
            // 
            this.choxuat.DataPropertyName = "choxuat";
            this.choxuat.HeaderText = "Chờ xuất kho";
            this.choxuat.Name = "choxuat";
            this.choxuat.ReadOnly = true;
            // 
            // chonhap
            // 
            this.chonhap.HeaderText = "Chờ nhập kho";
            this.chonhap.Name = "chonhap";
            this.chonhap.ReadOnly = true;
            // 
            // gianhap
            // 
            this.gianhap.HeaderText = "Giá nhập";
            this.gianhap.Name = "gianhap";
            this.gianhap.ReadOnly = true;
            // 
            // giaban
            // 
            this.giaban.HeaderText = "Giá bán";
            this.giaban.Name = "giaban";
            this.giaban.ReadOnly = true;
            // 
            // loi
            // 
            this.loi.HeaderText = "Lợi nhuận";
            this.loi.Name = "loi";
            this.loi.ReadOnly = true;
            // 
            // tongton
            // 
            this.tongton.HeaderText = "Tổng giá trị tồn kho";
            this.tongton.Name = "tongton";
            this.tongton.ReadOnly = true;
            // 
            // lblSanpham
            // 
            this.lblSanpham.AutoSize = true;
            this.lblSanpham.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanpham.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSanpham.Location = new System.Drawing.Point(490, 19);
            this.lblSanpham.Name = "lblSanpham";
            this.lblSanpham.Size = new System.Drawing.Size(324, 33);
            this.lblSanpham.TabIndex = 88;
            this.lblSanpham.Text = "THỐNG KÊ TỒN KHO";
            // 
            // lblTimtheoten
            // 
            this.lblTimtheoten.AutoSize = true;
            this.lblTimtheoten.Location = new System.Drawing.Point(98, 86);
            this.lblTimtheoten.Name = "lblTimtheoten";
            this.lblTimtheoten.Size = new System.Drawing.Size(118, 13);
            this.lblTimtheoten.TabIndex = 91;
            this.lblTimtheoten.Text = "Tìm theo tên sản phẩm:";
            // 
            // txttimkiem
            // 
            this.txttimkiem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txttimkiem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txttimkiem.Location = new System.Drawing.Point(232, 83);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(272, 20);
            this.txttimkiem.TabIndex = 92;
            this.txttimkiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttimkiem_KeyDown);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcel.Location = new System.Drawing.Point(655, 75);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(91, 35);
            this.btnExcel.TabIndex = 93;
            this.btnExcel.Text = "Xuất excel";
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // bntLammoi
            // 
            this.bntLammoi.Image = ((System.Drawing.Image)(resources.GetObject("bntLammoi.Image")));
            this.bntLammoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntLammoi.Location = new System.Drawing.Point(542, 75);
            this.bntLammoi.Name = "bntLammoi";
            this.bntLammoi.Size = new System.Drawing.Size(91, 35);
            this.bntLammoi.TabIndex = 94;
            this.bntLammoi.Text = "Làm mới";
            this.bntLammoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntLammoi.UseVisualStyleBackColor = true;
            this.bntLammoi.Click += new System.EventHandler(this.bntLammoi_Click);
            // 
            // frmThongKeTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 542);
            this.Controls.Add(this.bntLammoi);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.lblTimtheoten);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.lblSanpham);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmThongKeTonKho";
            this.Text = "Thống kê tồn kho";
            this.Load += new System.EventHandler(this.frmThongKeTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn choxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn chonhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn gianhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn loi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongton;
        private System.Windows.Forms.Label lblSanpham;
        private System.Windows.Forms.Label lblTimtheoten;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button bntLammoi;
    }
}