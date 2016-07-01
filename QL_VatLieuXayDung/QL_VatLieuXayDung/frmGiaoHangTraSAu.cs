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
    public partial class frmGiaoHangTraSau : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        OleDbCommand cmd;
        DataTable dt;
        float tong = 0;
        bool q = false;
        public frmGiaoHangTraSau()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public frmGiaoHangTraSau(string madat)
        {
            InitializeComponent();
            conn = Connect.getConnect();
            txtMaDonDat.Text = madat;
        }

        public void loadCT_DONDATHANG()
        {

            string lenh2 = "select T_CT_DAT_HANG_KH.MASP,T_CT_DAT_HANG_KH.SOLUONG,T_CT_DAT_HANG_KH.DONGIABAN,T_SAN_PHAM.SOLUONG from T_CT_DAT_HANG_KH,T_SAN_PHAM  where T_CT_DAT_HANG_KH.MASP=T_SAN_PHAM.MASP AND MADDH='" + txtMaDonDat.Text + "' order by T_CT_DAT_HANG_KH.MASP asc";
            adapter = new OleDbDataAdapter(lenh2, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvCT_DATHANG.DataSource = dt;
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

        }

        private void frmGiaoHangTraSAu_Load(object sender, EventArgs e)
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
            //lay khach hang
            string kh = "select TENKH,DIACHI from T_KHACH_HANG,T_DON_DAT_HANG_KH where T_KHACH_HANG.MAKH=T_DON_DAT_HANG_KH.MAKH and MADDH='" + txtMaDonDat.Text + "'";
            adapter = new OleDbDataAdapter(kh, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            txtKhachHang.Text = dt.Rows[0].Field<string>(0);
            txtDiaChi.Text = dt.Rows[0].Field<string>(1);
            //
            loadLai();
            loadCT_DONDATHANG();
            conn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvCT_DATHANG.Rows.Count; i++)
            {
                float slgiao = float.Parse(dgvCT_DATHANG.Rows[i].Cells["soluong"].Value.ToString());
                float slkho = float.Parse(dgvCT_DATHANG.Rows[i].Cells["soluongkho"].Value.ToString());


                if (slgiao > slkho)
                {
                    MessageBox.Show("Sản phẩm " + dgvCT_DATHANG.Rows[i].Cells["masp"].Value.ToString() + "không đủ số lượng để giao", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    q = false;
                    return;
                }
                else { q = true; }
            }
            if (q == true)
            {

                conn.Open();

                // them vao phieu giao
                cmd = new OleDbCommand("Insert into T_PHIEU_GIAO values('" + txtPhieuGiao.Text + "','" + txtMaDonDat.Text + "',TO_DATE('" + txtNgayGiao.Text + "','DD-MM-RR'),'" + txtNhanVien.Text + "')", conn);
                cmd.ExecuteNonQuery();

                adapter = new OleDbDataAdapter("select * from T_CT_DAT_HANG_KH where MADDH='" + txtMaDonDat.Text + "'", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int a = 0; int b = 0; int c = 0;
                    //them vao chi tiet phieu giao
                    cmd = new OleDbCommand("insert into T_CT_PHIEU_GIAO values ('" + txtPhieuGiao.Text + "','" + dt.Rows[i].Field<string>(1) + "'," + int.Parse(dgvCT_DATHANG.Rows[i].Cells["soluong"].Value.ToString()) + "," + int.Parse(dgvCT_DATHANG.Rows[i].Cells["soluong"].Value.ToString()) + ")", conn);
                    cmd.ExecuteNonQuery();
                    ////lay sl tu bang sp gan vao a
                    //string lenh1 = "select SOLUONG_CONGIAO from T_CT_HOA_DON where MASP='" + dt.Rows[i].Field<string>(1) + "' and MAHD='" + mahd + "'";
                    ////lay sldat tu chi tiet dat gan vao b
                    //string lenh2 = "select SOLUONGGIAO from T_CT_PHIEU_GIAO where MASP='" + dt.Rows[i].Field<string>(1) + "' and MAPHIEUGIAO='" + txtPhieuGiao.Text + "'";

                    //OleDbCommand cmd1 = new OleDbCommand(lenh1, conn);
                    //a = Convert.ToInt32(cmd1.ExecuteScalar().ToString());

                    //OleDbCommand cmd2 = new OleDbCommand(lenh2, conn);
                    //b = Convert.ToInt32(cmd2.ExecuteScalar().ToString()); ;

                    //c = a - b;

                    //// update sl trong ban sp
                    //string lenh3 = "update T_CT_HOA_DON set SOLUONG_CONGIAO=" + c + " where MASP='" + dt.Rows[i].Field<string>(1) + "' and MAHD='" + mahd + "'";
                    //OleDbCommand cmd3 = new OleDbCommand(lenh3, conn);
                    //cmd3.ExecuteNonQuery();

                }
                //update tinh trang giao
                string lenh6 = "select CONLAI from T_DON_DAT_HANG_KH where MADDH='" + txtMaDonDat.Text + "'";
                OleDbCommand cmd6 = new OleDbCommand(lenh6, conn);
                int x = Convert.ToInt32(cmd6.ExecuteScalar().ToString());
                x = x - 1;


                if (x == 0)
                {
                    string lenh5 = "update T_DON_DAT_HANG_KH set CONLAI=" + x + ", TINHTRANGGIAO='Dang giao' where MADDH='" + txtMaDonDat.Text + "'";
                    OleDbCommand cmd5 = new OleDbCommand(lenh5, conn);
                    cmd5.ExecuteNonQuery();
                }
                else
                {
                    string lenh5 = "update T_DON_DAT_HANG_KH set CONLAI=" + x + " where MADDH='" + txtMaDonDat.Text + "'";
                    OleDbCommand cmd5 = new OleDbCommand(lenh5, conn);
                    cmd5.ExecuteNonQuery();

                }
                MessageBox.Show("Tạo phiếu giao thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                loadLai();
                load_PhieuGiao();
                loadCT_PHIEUGIAO(dgvPhieu_Giao.Rows[0].Cells[0].Value.ToString());
                conn.Close();
                btnThem.Enabled = false;

            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
