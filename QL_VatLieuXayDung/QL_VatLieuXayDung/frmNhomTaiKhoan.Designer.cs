namespace QL_VatLieuXayDung
{
    partial class frmNhomTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhomTaiKhoan));
            this.lblNTK = new System.Windows.Forms.Label();
            this.txtTenNTK_NTK = new System.Windows.Forms.TextBox();
            this.txtMaNTK_NTK = new System.Windows.Forms.TextBox();
            this.lblMaNTK = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTenNTK = new System.Windows.Forms.Label();
            this.btnLuu_NTK = new System.Windows.Forms.Button();
            this.btnSua_NTK = new System.Windows.Forms.Button();
            this.btnXoa_NTK = new System.Windows.Forms.Button();
            this.btnThem_NTK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbDSKH = new System.Windows.Forms.GroupBox();
            this.dgvNTK = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbDSKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNTK)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNTK
            // 
            this.lblNTK.AutoSize = true;
            this.lblNTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNTK.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNTK.Location = new System.Drawing.Point(576, 23);
            this.lblNTK.Name = "lblNTK";
            this.lblNTK.Size = new System.Drawing.Size(282, 33);
            this.lblNTK.TabIndex = 82;
            this.lblNTK.Text = "NHÓM TÀI KHOẢN";
            // 
            // txtTenNTK_NTK
            // 
            this.txtTenNTK_NTK.Location = new System.Drawing.Point(124, 64);
            this.txtTenNTK_NTK.Name = "txtTenNTK_NTK";
            this.txtTenNTK_NTK.Size = new System.Drawing.Size(137, 20);
            this.txtTenNTK_NTK.TabIndex = 52;
            // 
            // txtMaNTK_NTK
            // 
            this.txtMaNTK_NTK.Location = new System.Drawing.Point(124, 41);
            this.txtMaNTK_NTK.Name = "txtMaNTK_NTK";
            this.txtMaNTK_NTK.Size = new System.Drawing.Size(137, 20);
            this.txtMaNTK_NTK.TabIndex = 51;
            // 
            // lblMaNTK
            // 
            this.lblMaNTK.AutoSize = true;
            this.lblMaNTK.Location = new System.Drawing.Point(17, 44);
            this.lblMaNTK.Name = "lblMaNTK";
            this.lblMaNTK.Size = new System.Drawing.Size(101, 13);
            this.lblMaNTK.TabIndex = 50;
            this.lblMaNTK.Text = "Mã nhóm tài khoản:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtTenNTK_NTK);
            this.groupBox1.Controls.Add(this.txtMaNTK_NTK);
            this.groupBox1.Controls.Add(this.lblMaNTK);
            this.groupBox1.Controls.Add(this.lblTenNTK);
            this.groupBox1.Location = new System.Drawing.Point(493, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 119);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // lblTenNTK
            // 
            this.lblTenNTK.AutoSize = true;
            this.lblTenNTK.Location = new System.Drawing.Point(18, 67);
            this.lblTenNTK.Name = "lblTenNTK";
            this.lblTenNTK.Size = new System.Drawing.Size(105, 13);
            this.lblTenNTK.TabIndex = 46;
            this.lblTenNTK.Text = "Tên nhóm tài khoản:";
            // 
            // btnLuu_NTK
            // 
            this.btnLuu_NTK.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu_NTK.Image")));
            this.btnLuu_NTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu_NTK.Location = new System.Drawing.Point(93, 64);
            this.btnLuu_NTK.Name = "btnLuu_NTK";
            this.btnLuu_NTK.Size = new System.Drawing.Size(67, 40);
            this.btnLuu_NTK.TabIndex = 16;
            this.btnLuu_NTK.Text = "Lưu";
            this.btnLuu_NTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu_NTK.UseVisualStyleBackColor = true;
            this.btnLuu_NTK.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua_NTK
            // 
            this.btnSua_NTK.Image = ((System.Drawing.Image)(resources.GetObject("btnSua_NTK.Image")));
            this.btnSua_NTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua_NTK.Location = new System.Drawing.Point(20, 65);
            this.btnSua_NTK.Name = "btnSua_NTK";
            this.btnSua_NTK.Size = new System.Drawing.Size(67, 39);
            this.btnSua_NTK.TabIndex = 14;
            this.btnSua_NTK.Text = "Sửa";
            this.btnSua_NTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua_NTK.UseVisualStyleBackColor = true;
            this.btnSua_NTK.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa_NTK
            // 
            this.btnXoa_NTK.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa_NTK.Image")));
            this.btnXoa_NTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa_NTK.Location = new System.Drawing.Point(93, 18);
            this.btnXoa_NTK.Name = "btnXoa_NTK";
            this.btnXoa_NTK.Size = new System.Drawing.Size(67, 39);
            this.btnXoa_NTK.TabIndex = 13;
            this.btnXoa_NTK.Text = "Xóa";
            this.btnXoa_NTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa_NTK.UseVisualStyleBackColor = true;
            this.btnXoa_NTK.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem_NTK
            // 
            this.btnThem_NTK.Image = ((System.Drawing.Image)(resources.GetObject("btnThem_NTK.Image")));
            this.btnThem_NTK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem_NTK.Location = new System.Drawing.Point(20, 19);
            this.btnThem_NTK.Name = "btnThem_NTK";
            this.btnThem_NTK.Size = new System.Drawing.Size(67, 38);
            this.btnThem_NTK.TabIndex = 12;
            this.btnThem_NTK.Text = "Thêm";
            this.btnThem_NTK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem_NTK.UseVisualStyleBackColor = true;
            this.btnThem_NTK.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnLuu_NTK);
            this.groupBox2.Controls.Add(this.btnSua_NTK);
            this.groupBox2.Controls.Add(this.btnXoa_NTK);
            this.groupBox2.Controls.Add(this.btnThem_NTK);
            this.groupBox2.Location = new System.Drawing.Point(864, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 119);
            this.groupBox2.TabIndex = 80;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // gbDSKH
            // 
            this.gbDSKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDSKH.Controls.Add(this.dgvNTK);
            this.gbDSKH.Location = new System.Drawing.Point(493, 184);
            this.gbDSKH.Name = "gbDSKH";
            this.gbDSKH.Size = new System.Drawing.Size(469, 240);
            this.gbDSKH.TabIndex = 81;
            this.gbDSKH.TabStop = false;
            this.gbDSKH.Text = "Danh sách tài khoản";
            // 
            // dgvNTK
            // 
            this.dgvNTK.AllowUserToAddRows = false;
            this.dgvNTK.AllowUserToDeleteRows = false;
            this.dgvNTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvNTK.Location = new System.Drawing.Point(20, 19);
            this.dgvNTK.Name = "dgvNTK";
            this.dgvNTK.ReadOnly = true;
            this.dgvNTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNTK.Size = new System.Drawing.Size(405, 202);
            this.dgvNTK.TabIndex = 48;
            this.dgvNTK.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvNTK_CellFormatting);
            this.dgvNTK.Click += new System.EventHandler(this.dgvNhomTK_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MANHOM";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhóm";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TENNHOM";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên nhóm";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // frmNhomTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 542);
            this.Controls.Add(this.lblNTK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbDSKH);
            this.Name = "frmNhomTaiKhoan";
            this.Text = "frmNhomTaiKhoan";
            this.Load += new System.EventHandler(this.frmNhomTaiKhoan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.gbDSKH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNTK;
        private System.Windows.Forms.TextBox txtTenNTK_NTK;
        private System.Windows.Forms.TextBox txtMaNTK_NTK;
        private System.Windows.Forms.Label lblMaNTK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTenNTK;
        private System.Windows.Forms.Button btnLuu_NTK;
        private System.Windows.Forms.Button btnSua_NTK;
        private System.Windows.Forms.Button btnXoa_NTK;
        private System.Windows.Forms.Button btnThem_NTK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbDSKH;
        private System.Windows.Forms.DataGridView dgvNTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}