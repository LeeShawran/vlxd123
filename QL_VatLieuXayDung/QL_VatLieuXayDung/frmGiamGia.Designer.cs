namespace QL_VatLieuXayDung
{
    partial class frmGiamGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiamGia));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvGG = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblKetthuc_GG = new System.Windows.Forms.Label();
            this.dtpKetthuc_GG = new System.Windows.Forms.DateTimePicker();
            this.lblBatdau_GG = new System.Windows.Forms.Label();
            this.dtpBatdau_GG = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtChietkhau_GG = new System.Windows.Forms.TextBox();
            this.lblChietkhau_GG = new System.Windows.Forms.Label();
            this.txtMaGG_GG = new System.Windows.Forms.TextBox();
            this.lblMaGG_GG = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnLuu_GG = new System.Windows.Forms.Button();
            this.btnXoa_GG = new System.Windows.Forms.Button();
            this.btnSua_GG = new System.Windows.Forms.Button();
            this.btnThem_GG = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGG)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(571, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỢT GIẢM GIÁ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvGG);
            this.groupBox2.Location = new System.Drawing.Point(430, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 188);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các đợt giảm giá";
            // 
            // dgvGG
            // 
            this.dgvGG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvGG.Location = new System.Drawing.Point(24, 19);
            this.dgvGG.Name = "dgvGG";
            this.dgvGG.Size = new System.Drawing.Size(484, 150);
            this.dgvGG.TabIndex = 0;
            this.dgvGG.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGG_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAGG";
            this.Column1.HeaderText = "Mã giảm giá";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CHIETKHAU";
            this.Column2.HeaderText = "Chiết khấu";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NGAYBD";
            this.Column3.HeaderText = "Ngày bắt đầu";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NGAYKT";
            this.Column4.HeaderText = "Ngày kết thúc";
            this.Column4.Name = "Column4";
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiamGia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblGiamGia.Location = new System.Drawing.Point(571, 24);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(229, 33);
            this.lblGiamGia.TabIndex = 0;
            this.lblGiamGia.Text = "ĐỢT GIẢM GIÁ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblKetthuc_GG);
            this.groupBox4.Controls.Add(this.dtpKetthuc_GG);
            this.groupBox4.Controls.Add(this.lblBatdau_GG);
            this.groupBox4.Controls.Add(this.dtpBatdau_GG);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtChietkhau_GG);
            this.groupBox4.Controls.Add(this.lblChietkhau_GG);
            this.groupBox4.Controls.Add(this.txtMaGG_GG);
            this.groupBox4.Controls.Add(this.lblMaGG_GG);
            this.groupBox4.Location = new System.Drawing.Point(430, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(328, 148);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin đợt giảm giá";
            // 
            // lblKetthuc_GG
            // 
            this.lblKetthuc_GG.AutoSize = true;
            this.lblKetthuc_GG.Location = new System.Drawing.Point(48, 112);
            this.lblKetthuc_GG.Name = "lblKetthuc_GG";
            this.lblKetthuc_GG.Size = new System.Drawing.Size(77, 13);
            this.lblKetthuc_GG.TabIndex = 9;
            this.lblKetthuc_GG.Text = "Ngày kết thúc:";
            // 
            // dtpKetthuc_GG
            // 
            this.dtpKetthuc_GG.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKetthuc_GG.Location = new System.Drawing.Point(131, 107);
            this.dtpKetthuc_GG.Name = "dtpKetthuc_GG";
            this.dtpKetthuc_GG.Size = new System.Drawing.Size(154, 20);
            this.dtpKetthuc_GG.TabIndex = 8;
            this.dtpKetthuc_GG.ValueChanged += new System.EventHandler(this.dtpKetthuc_GG_ValueChanged);
            // 
            // lblBatdau_GG
            // 
            this.lblBatdau_GG.AutoSize = true;
            this.lblBatdau_GG.Location = new System.Drawing.Point(48, 86);
            this.lblBatdau_GG.Name = "lblBatdau_GG";
            this.lblBatdau_GG.Size = new System.Drawing.Size(75, 13);
            this.lblBatdau_GG.TabIndex = 7;
            this.lblBatdau_GG.Text = "Ngày bắt đầu:";
            // 
            // dtpBatdau_GG
            // 
            this.dtpBatdau_GG.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBatdau_GG.Location = new System.Drawing.Point(131, 81);
            this.dtpBatdau_GG.Name = "dtpBatdau_GG";
            this.dtpBatdau_GG.Size = new System.Drawing.Size(154, 20);
            this.dtpBatdau_GG.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "(%)";
            // 
            // txtChietkhau_GG
            // 
            this.txtChietkhau_GG.Location = new System.Drawing.Point(129, 55);
            this.txtChietkhau_GG.Name = "txtChietkhau_GG";
            this.txtChietkhau_GG.Size = new System.Drawing.Size(129, 20);
            this.txtChietkhau_GG.TabIndex = 3;
            // 
            // lblChietkhau_GG
            // 
            this.lblChietkhau_GG.AutoSize = true;
            this.lblChietkhau_GG.Location = new System.Drawing.Point(50, 58);
            this.lblChietkhau_GG.Name = "lblChietkhau_GG";
            this.lblChietkhau_GG.Size = new System.Drawing.Size(61, 13);
            this.lblChietkhau_GG.TabIndex = 2;
            this.lblChietkhau_GG.Text = "Chiết khấu:";
            // 
            // txtMaGG_GG
            // 
            this.txtMaGG_GG.Location = new System.Drawing.Point(129, 29);
            this.txtMaGG_GG.Name = "txtMaGG_GG";
            this.txtMaGG_GG.Size = new System.Drawing.Size(156, 20);
            this.txtMaGG_GG.TabIndex = 1;
            // 
            // lblMaGG_GG
            // 
            this.lblMaGG_GG.AutoSize = true;
            this.lblMaGG_GG.Location = new System.Drawing.Point(50, 32);
            this.lblMaGG_GG.Name = "lblMaGG_GG";
            this.lblMaGG_GG.Size = new System.Drawing.Size(67, 13);
            this.lblMaGG_GG.TabIndex = 0;
            this.lblMaGG_GG.Text = "Mã giảm giá:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnLuu_GG);
            this.groupBox6.Controls.Add(this.btnXoa_GG);
            this.groupBox6.Controls.Add(this.btnSua_GG);
            this.groupBox6.Controls.Add(this.btnThem_GG);
            this.groupBox6.Location = new System.Drawing.Point(775, 71);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(180, 148);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thao tác";
            // 
            // btnLuu_GG
            // 
            this.btnLuu_GG.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu_GG.Image")));
            this.btnLuu_GG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu_GG.Location = new System.Drawing.Point(97, 81);
            this.btnLuu_GG.Name = "btnLuu_GG";
            this.btnLuu_GG.Size = new System.Drawing.Size(66, 49);
            this.btnLuu_GG.TabIndex = 6;
            this.btnLuu_GG.Text = "Lưu";
            this.btnLuu_GG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu_GG.UseVisualStyleBackColor = true;
            this.btnLuu_GG.Click += new System.EventHandler(this.btnLuu_GG_Click);
            // 
            // btnXoa_GG
            // 
            this.btnXoa_GG.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa_GG.Image")));
            this.btnXoa_GG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa_GG.Location = new System.Drawing.Point(97, 22);
            this.btnXoa_GG.Name = "btnXoa_GG";
            this.btnXoa_GG.Size = new System.Drawing.Size(66, 49);
            this.btnXoa_GG.TabIndex = 5;
            this.btnXoa_GG.Text = "Xóa";
            this.btnXoa_GG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa_GG.UseVisualStyleBackColor = true;
            this.btnXoa_GG.Click += new System.EventHandler(this.btnXoa_GG_Click);
            // 
            // btnSua_GG
            // 
            this.btnSua_GG.Image = ((System.Drawing.Image)(resources.GetObject("btnSua_GG.Image")));
            this.btnSua_GG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua_GG.Location = new System.Drawing.Point(16, 81);
            this.btnSua_GG.Name = "btnSua_GG";
            this.btnSua_GG.Size = new System.Drawing.Size(65, 49);
            this.btnSua_GG.TabIndex = 4;
            this.btnSua_GG.Text = "Sửa";
            this.btnSua_GG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua_GG.UseVisualStyleBackColor = true;
            this.btnSua_GG.Click += new System.EventHandler(this.btnSua_GG_Click);
            // 
            // btnThem_GG
            // 
            this.btnThem_GG.Image = ((System.Drawing.Image)(resources.GetObject("btnThem_GG.Image")));
            this.btnThem_GG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem_GG.Location = new System.Drawing.Point(16, 22);
            this.btnThem_GG.Name = "btnThem_GG";
            this.btnThem_GG.Size = new System.Drawing.Size(65, 49);
            this.btnThem_GG.TabIndex = 0;
            this.btnThem_GG.Text = "Thêm";
            this.btnThem_GG.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem_GG.UseVisualStyleBackColor = true;
            this.btnThem_GG.Click += new System.EventHandler(this.btnThem_GG_Click);
            // 
            // frmGiamGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 542);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblGiamGia);
            this.Controls.Add(this.label1);
            this.Name = "frmGiamGia";
            this.Text = "Đợt giảm giá";
            this.Load += new System.EventHandler(this.frmGiamGia_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGG)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvGG;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblKetthuc_GG;
        private System.Windows.Forms.DateTimePicker dtpKetthuc_GG;
        private System.Windows.Forms.Label lblBatdau_GG;
        private System.Windows.Forms.DateTimePicker dtpBatdau_GG;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtChietkhau_GG;
        private System.Windows.Forms.Label lblChietkhau_GG;
        private System.Windows.Forms.TextBox txtMaGG_GG;
        private System.Windows.Forms.Label lblMaGG_GG;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnLuu_GG;
        private System.Windows.Forms.Button btnXoa_GG;
        private System.Windows.Forms.Button btnSua_GG;
        private System.Windows.Forms.Button btnThem_GG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;

    }
}