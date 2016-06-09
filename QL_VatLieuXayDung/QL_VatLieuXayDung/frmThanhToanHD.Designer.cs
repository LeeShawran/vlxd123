namespace QL_VatLieuXayDung
{
    partial class frmThanhToanHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThantoan_TTDDHNCC = new System.Windows.Forms.GroupBox();
            this.lblTT_TTDDHNCC = new System.Windows.Forms.Label();
            this.dgvTTDDHNCC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTT_TTDDHNCC = new System.Windows.Forms.TextBox();
            this.txtTra_TTDDHNCC = new System.Windows.Forms.TextBox();
            this.lblTra_TTDDHNCC = new System.Windows.Forms.Label();
            this.txtNo_TTDDHNCC = new System.Windows.Forms.TextBox();
            this.lblNo_TTDDHNCC = new System.Windows.Forms.Label();
            this.btnThanhtoan_TTDDHNCC = new System.Windows.Forms.Button();
            this.txtStatus_TTDDHNCC = new System.Windows.Forms.TextBox();
            this.lblStatus_TTDDHNCC = new System.Windows.Forms.Label();
            this.btnCapnhat_TTDDHNCC = new System.Windows.Forms.Button();
            this.btnThantoan_TTDDHNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTDDHNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(468, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "THANH TOÁN NHÀ CUNG CẤP";
            // 
            // btnThantoan_TTDDHNCC
            // 
            this.btnThantoan_TTDDHNCC.Controls.Add(this.btnCapnhat_TTDDHNCC);
            this.btnThantoan_TTDDHNCC.Controls.Add(this.txtStatus_TTDDHNCC);
            this.btnThantoan_TTDDHNCC.Controls.Add(this.lblStatus_TTDDHNCC);
            this.btnThantoan_TTDDHNCC.Controls.Add(this.btnThanhtoan_TTDDHNCC);
            this.btnThantoan_TTDDHNCC.Controls.Add(this.txtNo_TTDDHNCC);
            this.btnThantoan_TTDDHNCC.Controls.Add(this.lblNo_TTDDHNCC);
            this.btnThantoan_TTDDHNCC.Controls.Add(this.txtTra_TTDDHNCC);
            this.btnThantoan_TTDDHNCC.Controls.Add(this.lblTra_TTDDHNCC);
            this.btnThantoan_TTDDHNCC.Controls.Add(this.txtTT_TTDDHNCC);
            this.btnThantoan_TTDDHNCC.Controls.Add(this.dgvTTDDHNCC);
            this.btnThantoan_TTDDHNCC.Controls.Add(this.lblTT_TTDDHNCC);
            this.btnThantoan_TTDDHNCC.Location = new System.Drawing.Point(383, 45);
            this.btnThantoan_TTDDHNCC.Name = "btnThantoan_TTDDHNCC";
            this.btnThantoan_TTDDHNCC.Size = new System.Drawing.Size(618, 296);
            this.btnThantoan_TTDDHNCC.TabIndex = 1;
            this.btnThantoan_TTDDHNCC.TabStop = false;
            this.btnThantoan_TTDDHNCC.Text = "Danh sách đơn đặt hàng nhà cung cấp";
            // 
            // lblTT_TTDDHNCC
            // 
            this.lblTT_TTDDHNCC.AutoSize = true;
            this.lblTT_TTDDHNCC.Location = new System.Drawing.Point(27, 28);
            this.lblTT_TTDDHNCC.Name = "lblTT_TTDDHNCC";
            this.lblTT_TTDDHNCC.Size = new System.Drawing.Size(67, 13);
            this.lblTT_TTDDHNCC.TabIndex = 0;
            this.lblTT_TTDDHNCC.Text = "Tiền cần trả:";
            // 
            // dgvTTDDHNCC
            // 
            this.dgvTTDDHNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTDDHNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTTDDHNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTDDHNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTTDDHNCC.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTTDDHNCC.Location = new System.Drawing.Point(30, 122);
            this.dgvTTDDHNCC.Name = "dgvTTDDHNCC";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTTDDHNCC.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTTDDHNCC.Size = new System.Drawing.Size(566, 150);
            this.dgvTTDDHNCC.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã đơn đặt hàng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày lập";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nhà cung cấp";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mã nhân viên";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tổng tiền";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tình trạng";
            this.Column6.Name = "Column6";
            // 
            // txtTT_TTDDHNCC
            // 
            this.txtTT_TTDDHNCC.Location = new System.Drawing.Point(100, 25);
            this.txtTT_TTDDHNCC.Name = "txtTT_TTDDHNCC";
            this.txtTT_TTDDHNCC.Size = new System.Drawing.Size(149, 20);
            this.txtTT_TTDDHNCC.TabIndex = 2;
            // 
            // txtTra_TTDDHNCC
            // 
            this.txtTra_TTDDHNCC.Location = new System.Drawing.Point(100, 51);
            this.txtTra_TTDDHNCC.Name = "txtTra_TTDDHNCC";
            this.txtTra_TTDDHNCC.Size = new System.Drawing.Size(149, 20);
            this.txtTra_TTDDHNCC.TabIndex = 4;
            // 
            // lblTra_TTDDHNCC
            // 
            this.lblTra_TTDDHNCC.AutoSize = true;
            this.lblTra_TTDDHNCC.Location = new System.Drawing.Point(27, 54);
            this.lblTra_TTDDHNCC.Name = "lblTra_TTDDHNCC";
            this.lblTra_TTDDHNCC.Size = new System.Drawing.Size(46, 13);
            this.lblTra_TTDDHNCC.TabIndex = 3;
            this.lblTra_TTDDHNCC.Text = "Tiền trả:";
            // 
            // txtNo_TTDDHNCC
            // 
            this.txtNo_TTDDHNCC.Enabled = false;
            this.txtNo_TTDDHNCC.Location = new System.Drawing.Point(395, 25);
            this.txtNo_TTDDHNCC.Name = "txtNo_TTDDHNCC";
            this.txtNo_TTDDHNCC.Size = new System.Drawing.Size(149, 20);
            this.txtNo_TTDDHNCC.TabIndex = 6;
            // 
            // lblNo_TTDDHNCC
            // 
            this.lblNo_TTDDHNCC.AutoSize = true;
            this.lblNo_TTDDHNCC.Location = new System.Drawing.Point(345, 28);
            this.lblNo_TTDDHNCC.Name = "lblNo_TTDDHNCC";
            this.lblNo_TTDDHNCC.Size = new System.Drawing.Size(44, 13);
            this.lblNo_TTDDHNCC.TabIndex = 5;
            this.lblNo_TTDDHNCC.Text = "Còn nợ:";
            // 
            // btnThanhtoan_TTDDHNCC
            // 
            this.btnThanhtoan_TTDDHNCC.Location = new System.Drawing.Point(395, 51);
            this.btnThanhtoan_TTDDHNCC.Name = "btnThanhtoan_TTDDHNCC";
            this.btnThanhtoan_TTDDHNCC.Size = new System.Drawing.Size(75, 23);
            this.btnThanhtoan_TTDDHNCC.TabIndex = 7;
            this.btnThanhtoan_TTDDHNCC.Text = "Thanh toán";
            this.btnThanhtoan_TTDDHNCC.UseVisualStyleBackColor = true;
            // 
            // txtStatus_TTDDHNCC
            // 
            this.txtStatus_TTDDHNCC.Enabled = false;
            this.txtStatus_TTDDHNCC.Location = new System.Drawing.Point(100, 77);
            this.txtStatus_TTDDHNCC.Name = "txtStatus_TTDDHNCC";
            this.txtStatus_TTDDHNCC.Size = new System.Drawing.Size(149, 20);
            this.txtStatus_TTDDHNCC.TabIndex = 9;
            // 
            // lblStatus_TTDDHNCC
            // 
            this.lblStatus_TTDDHNCC.AutoSize = true;
            this.lblStatus_TTDDHNCC.Location = new System.Drawing.Point(29, 80);
            this.lblStatus_TTDDHNCC.Name = "lblStatus_TTDDHNCC";
            this.lblStatus_TTDDHNCC.Size = new System.Drawing.Size(58, 13);
            this.lblStatus_TTDDHNCC.TabIndex = 8;
            this.lblStatus_TTDDHNCC.Text = "Tình trạng:";
            // 
            // btnCapnhat_TTDDHNCC
            // 
            this.btnCapnhat_TTDDHNCC.Location = new System.Drawing.Point(395, 80);
            this.btnCapnhat_TTDDHNCC.Name = "btnCapnhat_TTDDHNCC";
            this.btnCapnhat_TTDDHNCC.Size = new System.Drawing.Size(75, 23);
            this.btnCapnhat_TTDDHNCC.TabIndex = 10;
            this.btnCapnhat_TTDDHNCC.Text = "Cập nhật";
            this.btnCapnhat_TTDDHNCC.UseVisualStyleBackColor = true;
            // 
            // frmThanhToanNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 542);
            this.Controls.Add(this.btnThantoan_TTDDHNCC);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmThanhToanNCC";
            this.Text = "Thanh toán đơn đặt hàng nhà cung cấp";
            this.btnThantoan_TTDDHNCC.ResumeLayout(false);
            this.btnThantoan_TTDDHNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTDDHNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox btnThantoan_TTDDHNCC;
        private System.Windows.Forms.DataGridView dgvTTDDHNCC;
        private System.Windows.Forms.Label lblTT_TTDDHNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtNo_TTDDHNCC;
        private System.Windows.Forms.Label lblNo_TTDDHNCC;
        private System.Windows.Forms.TextBox txtTra_TTDDHNCC;
        private System.Windows.Forms.Label lblTra_TTDDHNCC;
        private System.Windows.Forms.TextBox txtTT_TTDDHNCC;
        private System.Windows.Forms.TextBox txtStatus_TTDDHNCC;
        private System.Windows.Forms.Label lblStatus_TTDDHNCC;
        private System.Windows.Forms.Button btnThanhtoan_TTDDHNCC;
        private System.Windows.Forms.Button btnCapnhat_TTDDHNCC;

    }
}