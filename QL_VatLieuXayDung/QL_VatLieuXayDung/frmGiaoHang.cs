using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace QL_VatLieuXayDung
{
    public partial class frmGiaoHang : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        OleDbCommand cmd;
        DataTable dt;
        float tong = 0;
        bool q = false;
        string mahd;

        private frmDatHangKH frmdathang;
        public frmGiaoHang()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }
        public frmGiaoHang(frmDatHangKH frmdathang)
        {
            InitializeComponent();
            conn = Connect.getConnect();
            this.frmdathang = frmdathang;
        }
        public frmGiaoHang(string madat)
        {
            InitializeComponent();
            conn = Connect.getConnect();
            txtMaDonDat.Text = madat;
        }

        public void loadCT_HoaDon()
        {
            //lấy mã Hoa đơn từ đơn đặt KH
            string lenh = "select MAHD from T_HOA_DON, T_DON_DAT_HANG_KH where T_DON_DAT_HANG_KH.MADDH=T_HOA_DON.MADDH and T_DON_DAT_HANG_KH.MADDH='" + txtMaDonDat.Text + "'";
            cmd = new OleDbCommand(lenh, conn);
            mahd = cmd.ExecuteScalar().ToString();
            //lấy bảng CT hóa đơn từ mã HD
            string lenh2 = "select MASP,SOLUONG_CONGIAO from T_CT_HOA_DON where MAHD='" + mahd + "' order by MASP asc";
            adapter = new OleDbDataAdapter(lenh2, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvCT_HOADON.DataSource = dt;
        }


        public void load_PhieuGiao()
        {
            string st = "select * from T_PHIEU_GIAO where MADDH='" + txtMaDonDat.Text + "'";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvPhieu_Giao.DataSource = dt;
        }

        public void loadCT_PHIEUGIAO(string maphieugiao)
        {
            string st = "select MASP,SOLUONG_CONGIAO,SOLUONGGIAO from T_CT_PHIEU_GIAO where MAPHIEUGIAO='" + maphieugiao + "' order by MASP asc";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvCT_PhieuGiao.DataSource = dt;
        }
        public void loadLai()
        {
            btnThem.Enabled = true;
            load_PhieuGiao();
            loadCT_HoaDon();
            try
            {
                dgvCT_PhieuGiao.DataSource = null;
            }
            catch { }


        }
        private void frmGiaoHang_Load(object sender, EventArgs e)
        {
            conn.Open();
            dgvPhieu_Giao.Columns["ngaygiao"].DefaultCellStyle.Format = @"dd/MM/yyyy";
            txtNgayGiao.Format = DateTimePickerFormat.Custom;
            txtNgayGiao.CustomFormat = "dd/MM/yyyy";
            txtNhanVien.Text = Program.mainForm.ma;

            /// MA TU DONG
            string lenh = "select MAPHIEUGIAO from T_PHIEU_GIAO order by MAPHIEUGIAO desc";
            cmd = new OleDbCommand(lenh, conn);
            string macuoi = (string)cmd.ExecuteScalar();
            if (macuoi == null)
            {
                txtPhieuGiao.Text = "PGH0001";
            }
            else
            {
                int somacuoi = int.Parse(macuoi.Replace("PGH", ""));
                if (somacuoi < 9)
                    txtPhieuGiao.Text = "PGH000" + (somacuoi + 1);
                else if (somacuoi >= 9 && somacuoi < 99)
                    txtPhieuGiao.Text = "PGH00" + (somacuoi + 1);
                else if (somacuoi >= 99 && somacuoi < 999)
                    txtPhieuGiao.Text = "PGH0" + (somacuoi + 1);
                else
                    txtPhieuGiao.Text = "PGH" + (somacuoi + 1);
            }

            ////
            loadLai();
            //lay khach hang
            string kh = "select TENKH,DIACHI from T_KHACH_HANG,T_DON_DAT_HANG_KH where T_KHACH_HANG.MAKH=T_DON_DAT_HANG_KH.MAKH and MADDH='" + txtMaDonDat.Text + "'";
            adapter = new OleDbDataAdapter(kh, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            txtKhachHang.Text = dt.Rows[0].Field<string>(0);
            txtDiaChi.Text = dt.Rows[0].Field<string>(1);

            //kiem tra lan giao cuoi
            string lenh6 = "select CONLAI from T_DON_DAT_HANG_KH where MADDH='" + txtMaDonDat.Text + "'";
            OleDbCommand cmd6 = new OleDbCommand(lenh6, conn);
            int x = Convert.ToInt32(cmd6.ExecuteScalar().ToString());
            if (x == 1)
            {
                dgvCT_HOADON.ReadOnly = true;
                adapter = new OleDbDataAdapter("select * from T_CT_HOA_DON where MAHD='" + mahd + "'", conn);
                DataTable dt2 = new DataTable();
                adapter.Fill(dt2);
              
                for (int i = 0; i < dt2.Rows.Count; i++)
                {  
                    string lenh7 = "select SOLUONG_CONGIAO from T_CT_HOA_DON where MAHD='" + mahd + "' and MASP='" + dt2.Rows[i].Field<string>(1) + "'";
                    OleDbCommand cmd7 = new OleDbCommand(lenh7, conn);
                    int giao = Convert.ToInt32(cmd7.ExecuteScalar().ToString());
       
                    dgvCT_HOADON.Rows[i].Cells["soluonggiao"].Value = giao;
                }
            }
            conn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvCT_HOADON.Rows.Count; i++)
            {
                if (dgvCT_HOADON.Rows[i].Cells["soluonggiao"].Value == null)
                {
                    MessageBox.Show("chưa nhập số lượng giao cho sản phẩm " + dgvCT_HOADON.Rows[i].Cells["masp"].Value.ToString() + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    return;
                }
                else
                {
                    float slgiao = float.Parse(dgvCT_HOADON.Rows[i].Cells["soluonggiao"].Value.ToString());
                    float slmua = float.Parse(dgvCT_HOADON.Rows[i].Cells["soluongmua"].Value.ToString());

                    if (slgiao > slmua)
                    {
                        MessageBox.Show("Sản phẩm "+ dgvCT_HOADON.Rows[i].Cells["masp"].Value.ToString() + "giao quá số lượng mua hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                     
                        q = false;
                        return;
                    }
                    else { q = true; }
                }

            }

            if (q == true)
            {
                bool dagiaotatca = false;
                float tongslgiao = 0; float tongslmua = 0;
                for (int i = 0; i < dgvCT_HOADON.Rows.Count; i++)
                {
                    tongslgiao = tongslgiao + float.Parse(dgvCT_HOADON.Rows[i].Cells["soluonggiao"].Value.ToString());
                    tongslmua = tongslmua + float.Parse(dgvCT_HOADON.Rows[i].Cells["soluongmua"].Value.ToString());
                }
                if (tongslgiao == tongslmua)
                {
                    dagiaotatca = true;
                }
                conn.Open();
                //
                // them vao phieu giao
                cmd = new OleDbCommand("Insert into T_PHIEU_GIAO values('" + txtPhieuGiao.Text + "','" + txtMaDonDat.Text + "',TO_DATE('" + txtNgayGiao.Text + "','DD-MM-RR'),'" + txtNhanVien.Text + "')", conn);
                cmd.ExecuteNonQuery();

                adapter = new OleDbDataAdapter("select * from T_CT_HOA_DON where MAHD='" + mahd + "'", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int a = 0; int b = 0; int c = 0;
                    //them vao CT phieu gao
                    cmd = new OleDbCommand("insert into T_CT_PHIEU_GIAO values ('" + txtPhieuGiao.Text + "','" + dt.Rows[i].Field<string>(1) + "'," + int.Parse(dgvCT_HOADON.Rows[i].Cells["soluongmua"].Value.ToString()) + "," + int.Parse(dgvCT_HOADON.Rows[i].Cells["soluonggiao"].Value.ToString()) + ")", conn);
                    cmd.ExecuteNonQuery();
                    //lay sl tu bang sp gan vao a
                    string lenh1 = "select SOLUONG_CONGIAO from T_CT_HOA_DON where MASP='" + dt.Rows[i].Field<string>(1) + "' and MAHD='" + mahd + "'";
                    //lay sldat tu chi tiet dat gan vao b
                    string lenh2 = "select SOLUONGGIAO from T_CT_PHIEU_GIAO where MASP='" + dt.Rows[i].Field<string>(1) + "' and MAPHIEUGIAO='" + txtPhieuGiao.Text + "'";

                    OleDbCommand cmd1 = new OleDbCommand(lenh1, conn);
                    a = Convert.ToInt32(cmd1.ExecuteScalar().ToString());

                    OleDbCommand cmd2 = new OleDbCommand(lenh2, conn);
                    b = Convert.ToInt32(cmd2.ExecuteScalar().ToString()); ;

                    c = a - b;

                    // update sl trong ban sp
                    string lenh3 = "update T_CT_HOA_DON set SOLUONG_CONGIAO=" + c + " where MASP='" + dt.Rows[i].Field<string>(1) + "' and MAHD='" + mahd + "'";
                    OleDbCommand cmd3 = new OleDbCommand(lenh3, conn);
                    cmd3.ExecuteNonQuery();

                }
                //update tinh trang nhap
                string lenh6 = "select CONLAI from T_DON_DAT_HANG_KH where MADDH='" + txtMaDonDat.Text + "'";
                OleDbCommand cmd6 = new OleDbCommand(lenh6, conn);
                int x = Convert.ToInt32(cmd6.ExecuteScalar().ToString());
                x = x - 1;

                //x=0 la lan giao cuoi cung
                if (x == 0)
                {
                    string lenh5 = "update T_DON_DAT_HANG_KH set CONLAI=" + x + ", TINHTRANGGIAO='Da giao' where MADDH='" + txtMaDonDat.Text + "'";
                    OleDbCommand cmd5 = new OleDbCommand(lenh5, conn);
                    cmd5.ExecuteNonQuery();
                }
                else
                {
                    if (dagiaotatca == true)
                    {

                        string lenh8 = "update T_DON_DAT_HANG_KH set CONLAI=" + x + ", TINHTRANGGIAO='Da giao' where MADDH='" + txtMaDonDat.Text + "'";
                        OleDbCommand cmd8 = new OleDbCommand(lenh8, conn);
                        cmd8.ExecuteNonQuery();
                    }
                    else
                    {
                        string lenh5 = "update T_DON_DAT_HANG_KH set CONLAI=" + x + ",TINHTRANGGIAO='Dang giao' where MADDH='" + txtMaDonDat.Text + "'";
                        OleDbCommand cmd5 = new OleDbCommand(lenh5, conn);
                        cmd5.ExecuteNonQuery();
                    }

                }
                MessageBox.Show("Tạo phiếu giao thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                loadLai();
              
                conn.Close();
                btnThem.Enabled = false;
            }
        }

        private void dgvPhieu_Giao_Click(object sender, EventArgs e)
        {

            loadCT_PHIEUGIAO(txtPhieuGiao.Text);
        }

        private void frmGiaoHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void frmGiaoHang_FormClosed(object sender, FormClosedEventArgs e)
        {
 
        }

        private void dgvCT_HOADON_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.ForeColor = Color.Gray;
            style1.BackColor = Color.LightBlue;
            for (int i = dgvCT_HOADON.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) dgvCT_HOADON.Rows[i].DefaultCellStyle = style1;
            }
        }

        private void dgvPhieu_Giao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.ForeColor = Color.Gray;
            style1.BackColor = Color.LightBlue;
            for (int i = dgvPhieu_Giao.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) dgvPhieu_Giao.Rows[i].DefaultCellStyle = style1;
            }
        }

        private void dgvCT_PhieuGiao_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.ForeColor = Color.Gray;
            style1.BackColor = Color.LightBlue;
            for (int i = dgvCT_PhieuGiao.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) dgvCT_PhieuGiao.Rows[i].DefaultCellStyle = style1;
            }
        }
    }
}
