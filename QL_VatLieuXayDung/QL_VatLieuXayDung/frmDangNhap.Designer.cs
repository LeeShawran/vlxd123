namespace QL_VatLieuXayDung
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblMatKhau_DangNhap = new System.Windows.Forms.Label();
            this.lblMaNhanVien_DangNhap = new System.Windows.Forms.Label();
            this.txtMatKhau_DangNhap = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien_DangNhap = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblStatus_DangNhap = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(232, 118);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 28);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Đóng";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Image = ((System.Drawing.Image)(resources.GetObject("btnDangNhap.Image")));
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangNhap.Location = new System.Drawing.Point(11, 118);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(96, 28);
            this.btnDangNhap.TabIndex = 12;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // lblMatKhau_DangNhap
            // 
            this.lblMatKhau_DangNhap.AutoSize = true;
            this.lblMatKhau_DangNhap.Location = new System.Drawing.Point(29, 48);
            this.lblMatKhau_DangNhap.Name = "lblMatKhau_DangNhap";
            this.lblMatKhau_DangNhap.Size = new System.Drawing.Size(55, 13);
            this.lblMatKhau_DangNhap.TabIndex = 11;
            this.lblMatKhau_DangNhap.Text = "Mật khẩu:";
            // 
            // lblMaNhanVien_DangNhap
            // 
            this.lblMaNhanVien_DangNhap.AutoSize = true;
            this.lblMaNhanVien_DangNhap.Location = new System.Drawing.Point(29, 22);
            this.lblMaNhanVien_DangNhap.Name = "lblMaNhanVien_DangNhap";
            this.lblMaNhanVien_DangNhap.Size = new System.Drawing.Size(75, 13);
            this.lblMaNhanVien_DangNhap.TabIndex = 10;
            this.lblMaNhanVien_DangNhap.Text = "Mã nhân viên:";
            // 
            // txtMatKhau_DangNhap
            // 
            this.txtMatKhau_DangNhap.Location = new System.Drawing.Point(110, 45);
            this.txtMatKhau_DangNhap.Name = "txtMatKhau_DangNhap";
            this.txtMatKhau_DangNhap.PasswordChar = '*';
            this.txtMatKhau_DangNhap.Size = new System.Drawing.Size(160, 20);
            this.txtMatKhau_DangNhap.TabIndex = 9;
            // 
            // txtMaNhanVien_DangNhap
            // 
            this.txtMaNhanVien_DangNhap.Location = new System.Drawing.Point(110, 19);
            this.txtMaNhanVien_DangNhap.Name = "txtMaNhanVien_DangNhap";
            this.txtMaNhanVien_DangNhap.Size = new System.Drawing.Size(160, 20);
            this.txtMaNhanVien_DangNhap.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus_DangNhap);
            this.groupBox1.Controls.Add(this.txtMaNhanVien_DangNhap);
            this.groupBox1.Controls.Add(this.txtMatKhau_DangNhap);
            this.groupBox1.Controls.Add(this.lblMaNhanVien_DangNhap);
            this.groupBox1.Controls.Add(this.lblMatKhau_DangNhap);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 100);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // lblStatus_DangNhap
            // 
            this.lblStatus_DangNhap.AutoSize = true;
            this.lblStatus_DangNhap.Location = new System.Drawing.Point(29, 74);
            this.lblStatus_DangNhap.Name = "lblStatus_DangNhap";
            this.lblStatus_DangNhap.Size = new System.Drawing.Size(10, 13);
            this.lblStatus_DangNhap.TabIndex = 12;
            this.lblStatus_DangNhap.Text = ".";
            // 
            // btnReset
            // 
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(136, 118);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(73, 28);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 159);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDangNhap);
            this.Name = "frmDangNhap";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label lblMatKhau_DangNhap;
        private System.Windows.Forms.Label lblMaNhanVien_DangNhap;
        private System.Windows.Forms.TextBox txtMatKhau_DangNhap;
        private System.Windows.Forms.TextBox txtMaNhanVien_DangNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblStatus_DangNhap;
    }
}