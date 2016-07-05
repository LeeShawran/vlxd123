namespace QL_VatLieuXayDung
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.txtNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblMaNhanVien_DangNhap = new System.Windows.Forms.Label();
            this.lblMatKhau_DangNhap = new System.Windows.Forms.Label();
            this.lblNhanvien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(187, 125);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.PasswordChar = '*';
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(300, 29);
            this.txtNhapLaiMatKhau.TabIndex = 49;
            this.txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nhập lại mật khẩu:";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauCu.Location = new System.Drawing.Point(187, 55);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(300, 29);
            this.txtMatKhauCu.TabIndex = 43;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(505, 55);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(66, 41);
            this.btnLuu.TabIndex = 48;
            this.btnLuu.Text = " Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(187, 90);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(300, 29);
            this.txtMatKhauMoi.TabIndex = 44;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // lblMaNhanVien_DangNhap
            // 
            this.lblMaNhanVien_DangNhap.AutoSize = true;
            this.lblMaNhanVien_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien_DangNhap.Location = new System.Drawing.Point(64, 58);
            this.lblMaNhanVien_DangNhap.Name = "lblMaNhanVien_DangNhap";
            this.lblMaNhanVien_DangNhap.Size = new System.Drawing.Size(117, 24);
            this.lblMaNhanVien_DangNhap.TabIndex = 45;
            this.lblMaNhanVien_DangNhap.Text = "Mật khẩu cũ:";
            // 
            // lblMatKhau_DangNhap
            // 
            this.lblMatKhau_DangNhap.AutoSize = true;
            this.lblMatKhau_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau_DangNhap.Location = new System.Drawing.Point(54, 93);
            this.lblMatKhau_DangNhap.Name = "lblMatKhau_DangNhap";
            this.lblMatKhau_DangNhap.Size = new System.Drawing.Size(127, 24);
            this.lblMatKhau_DangNhap.TabIndex = 46;
            this.lblMatKhau_DangNhap.Text = "Mật khẩu mới:";
            // 
            // lblNhanvien
            // 
            this.lblNhanvien.AutoSize = true;
            this.lblNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanvien.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNhanvien.Location = new System.Drawing.Point(181, 9);
            this.lblNhanvien.Name = "lblNhanvien";
            this.lblNhanvien.Size = new System.Drawing.Size(236, 33);
            this.lblNhanvien.TabIndex = 86;
            this.lblNhanvien.Text = "ĐỔI MẬT KHẨU";
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 170);
            this.Controls.Add(this.lblNhanvien);
            this.Controls.Add(this.txtNhapLaiMatKhau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.lblMaNhanVien_DangNhap);
            this.Controls.Add(this.lblMatKhau_DangNhap);
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmDoiMatKhau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNhapLaiMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lblMaNhanVien_DangNhap;
        private System.Windows.Forms.Label lblMatKhau_DangNhap;
        private System.Windows.Forms.Label lblNhanvien;
    }
}