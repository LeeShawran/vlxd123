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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblStatus_GG = new System.Windows.Forms.Label();
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
            this.groupBox3.SuspendLayout();
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
            this.groupBox2.Location = new System.Drawing.Point(430, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(525, 188);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các đợt giảm giá";
            // 
            // dgvGG
            // 
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(775, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 148);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác";
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(97, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(66, 49);
            this.button4.TabIndex = 6;
            this.button4.Text = "Lưu";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(97, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 49);
            this.button3.TabIndex = 5;
            this.button3.Text = "Xóa";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(16, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sửa";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(16, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
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
            this.groupBox4.Controls.Add(this.lblStatus_GG);
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
            this.groupBox4.Size = new System.Drawing.Size(328, 162);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin đợt giảm giá";
            // 
            // lblStatus_GG
            // 
            this.lblStatus_GG.AutoSize = true;
            this.lblStatus_GG.Location = new System.Drawing.Point(50, 84);
            this.lblStatus_GG.Name = "lblStatus_GG";
            this.lblStatus_GG.Size = new System.Drawing.Size(10, 13);
            this.lblStatus_GG.TabIndex = 10;
            this.lblStatus_GG.Text = ".";
            // 
            // lblKetthuc_GG
            // 
            this.lblKetthuc_GG.AutoSize = true;
            this.lblKetthuc_GG.Location = new System.Drawing.Point(48, 136);
            this.lblKetthuc_GG.Name = "lblKetthuc_GG";
            this.lblKetthuc_GG.Size = new System.Drawing.Size(77, 13);
            this.lblKetthuc_GG.TabIndex = 9;
            this.lblKetthuc_GG.Text = "Ngày kết thúc:";
            // 
            // dtpKetthuc_GG
            // 
            this.dtpKetthuc_GG.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKetthuc_GG.Location = new System.Drawing.Point(131, 131);
            this.dtpKetthuc_GG.Name = "dtpKetthuc_GG";
            this.dtpKetthuc_GG.Size = new System.Drawing.Size(154, 20);
            this.dtpKetthuc_GG.TabIndex = 8;
            this.dtpKetthuc_GG.ValueChanged += new System.EventHandler(this.dtpKetthuc_GG_ValueChanged);
            // 
            // lblBatdau_GG
            // 
            this.lblBatdau_GG.AutoSize = true;
            this.lblBatdau_GG.Location = new System.Drawing.Point(48, 110);
            this.lblBatdau_GG.Name = "lblBatdau_GG";
            this.lblBatdau_GG.Size = new System.Drawing.Size(75, 13);
            this.lblBatdau_GG.TabIndex = 7;
            this.lblBatdau_GG.Text = "Ngày bắt đầu:";
            // 
            // dtpBatdau_GG
            // 
            this.dtpBatdau_GG.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBatdau_GG.Location = new System.Drawing.Point(131, 105);
            this.dtpBatdau_GG.Name = "dtpBatdau_GG";
            this.dtpBatdau_GG.Size = new System.Drawing.Size(154, 20);
            this.dtpBatdau_GG.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(184, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "%";
            // 
            // txtChietkhau_GG
            // 
            this.txtChietkhau_GG.Location = new System.Drawing.Point(129, 55);
            this.txtChietkhau_GG.Name = "txtChietkhau_GG";
            this.txtChietkhau_GG.Size = new System.Drawing.Size(49, 20);
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
            this.groupBox6.Size = new System.Drawing.Size(180, 162);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Thao tác";
            // 
            // btnLuu_GG
            // 
            this.btnLuu_GG.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu_GG.Image")));
            this.btnLuu_GG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu_GG.Location = new System.Drawing.Point(97, 93);
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
            this.btnXoa_GG.Location = new System.Drawing.Point(97, 34);
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
            this.btnSua_GG.Location = new System.Drawing.Point(16, 93);
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
            this.btnThem_GG.Location = new System.Drawing.Point(16, 34);
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
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblGiamGia);
            this.Controls.Add(this.label1);
            this.Name = "frmGiamGia";
            this.Text = "Đợt giảm giá";
            this.Load += new System.EventHandler(this.frmGiamGia_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGG)).EndInit();
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Label lblStatus_GG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;

    }
}