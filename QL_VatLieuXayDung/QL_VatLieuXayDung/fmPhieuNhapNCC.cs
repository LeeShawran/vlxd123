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
    public partial class fmPhieuNhapNCC : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        OleDbCommand cmd;
        DataTable dt;
     
        float tong = 0;
        bool q=false;

        public fmPhieuNhapNCC(string a)
        {
            InitializeComponent();
            conn = Connect.getConnect();
            txtMaDonDat.Text = a;
        }

        public void loadCT_DonDatHang() 
        {
            string st = "select MASP,SOLUONG from T_CT_DAT_HANG_NCC where MADATNCC='"+txtMaDonDat.Text+"' order by MASP";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvCT_DatHang.DataSource = dt; 
        }

        public void load_PhieuNhap()
        {
            string st = "select * from T_PHIEU_NHAP where MAPN='"+ txtMaPN.Text+"'";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvNhapHang.DataSource = dt;
        }

        public void loadCT_PhieuNhap(string maphieu)
        {
            string st = "select MASP,DONGIANHAP,SOLUONG from T_CT_PHIEU_NHAP where MAPN='" + maphieu + "'";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvCT_NhapHang.DataSource = dt;
        }

        int ktngaynhap()
        {
            conn.Close();
            conn.Open();
            int a=0;
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_CT_DAT_HANG_NCC where MADATNCC='" + txtMaDonDat.Text + "'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string s = "select count(*) from T_GIA_NHAP where MASP=('" + dt.Rows[i].Field<string>(1) + "') and NGAYAPDUNG=TO_DATE('" + txtNgayLap.Text + "','DD-MM-RR')";
                OleDbCommand cmd = new OleDbCommand(s, conn);
                string o = cmd.ExecuteScalar().ToString();
                a = int.Parse(o);
                if (a >= 1)
                    break;
            }
           
            return a;
            conn.Close();
        }
        private void fmPhieuNhapNCC_Load(object sender, EventArgs e)
        {
            dgvNhapHang.Columns["ngaylapcol"].DefaultCellStyle.Format = @"dd/MM/yyyy";
            txtNgayLap.Format = DateTimePickerFormat.Custom;
            txtNgayLap.CustomFormat = "dd/MM/yyyy";
            btnThem.Enabled = true;
            txtNhanVien.Text = Program.mainForm.ma;
            conn.Open();
            /// MA TU DONG
            
            string lenh = "select MAPN from T_PHIEU_NHAP order by MAPN desc";
            cmd = new OleDbCommand(lenh, conn);
            string macuoi = (string)cmd.ExecuteScalar();

            if (macuoi == null)
            {
                txtMaPN.Text = "PNNCC0001";
            }
            else
            {
                int somacuoi = int.Parse(macuoi.Replace("PNNCC", ""));
                if (somacuoi < 9)
                    txtMaPN.Text = "PNNCC000" + (somacuoi + 1);
                else if (somacuoi >= 9 && somacuoi < 99)
                    txtMaPN.Text = "PNNCC00" + (somacuoi + 1);
                else if (somacuoi >= 99 && somacuoi < 999)
                    txtMaPN.Text = "PNNCC0" + (somacuoi + 1);
                else
                    txtMaPN.Text = "PNNCC" + (somacuoi + 1);
            }
            ////
            load_PhieuNhap();
            loadCT_DonDatHang();
            
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {   
            for (int i = 0; i < dgvCT_DatHang.Rows.Count; i++)
            {

                if (dgvCT_DatHang.Rows[i].Cells["dongianhap"].Value == null || dgvCT_DatHang.Rows[i].Cells["dongianhap"].Value.ToString() == "0")
                {
                    MessageBox.Show("Chưa nhập đơn giá cho sản phẩm " + dgvCT_DatHang.Rows[i].Cells["masp"].Value.ToString() + "", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    q = false;
                    return;
                   
                }
                else
                {
                    q = true;
                }
            }

            if (q == true)
            {
                for (int i = 0; i < dgvCT_DatHang.Rows.Count; i++)
                {
                    float a= float.Parse(dgvCT_DatHang.Rows[i].Cells["soluong"].Value.ToString());
                    float b = float.Parse(dgvCT_DatHang.Rows[i].Cells["dongianhap"].Value.ToString());
                    tong = tong + a*b ;
                }
            }
            conn.Open();
                // them vao phieu nhap
            if (ktngaynhap() >= 1)
            {
                MessageBox.Show("Trong phiếu nhập có sản phẩm đã nhập trong ngày hôm nay, không thể tạo phiếu nhập này. Vui lòng tạo phiếu nhập này vào ngày khác");
                btnThem.Enabled = false;
                return;
            }
            else 
            {
                cmd = new OleDbCommand("Insert into T_PHIEU_NHAP values('" + txtMaPN.Text + "',TO_DATE('" + txtNgayLap.Text + "','DD-MM-RR'),'" + txtNhanVien.Text + "','" + txtMaDonDat.Text + "'," + tong + ")", conn);
                cmd.ExecuteNonQuery();
                //them vao chi tiet phieu nhap

                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_CT_DAT_HANG_NCC where MADATNCC='" + txtMaDonDat.Text + "'", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {       
                        OleDbCommand cm8 = new OleDbCommand("insert into T_CT_PHIEU_NHAP values ('" + txtMaPN.Text + "','" + dt.Rows[i].Field<string>(1) + "'," + float.Parse(dgvCT_DatHang.Rows[i].Cells["dongianhap"].Value.ToString()) + "," + int.Parse(dgvCT_DatHang.Rows[i].Cells["soluong"].Value.ToString()) + ")", conn);
                        cm8.ExecuteNonQuery();

                        string lenh1 = "select SOLUONG from T_SAN_PHAM where MASP='" + dt.Rows[i].Field<string>(1) + "'";
                        string lenh2 = "select SOLUONG from T_CT_DAT_HANG_NCC where MASP='" + dt.Rows[i].Field<string>(1) + "' AND MADATNCC='" + txtMaDonDat.Text + "'";
                        OleDbCommand cmd1 = new OleDbCommand(lenh1, conn);
                        int a = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
                        OleDbCommand cmd2 = new OleDbCommand(lenh2, conn);
                        int b = Convert.ToInt32(cmd2.ExecuteScalar().ToString()); ;
                        int c = a + b;

                        string lenh3 = "update T_SAN_PHAM set SOLUONG=" + c + " where MASP='" + dt.Rows[i].Field<string>(1) + "'";
                        OleDbCommand cmd3 = new OleDbCommand(lenh3, conn);
                        cmd3.ExecuteNonQuery();
                        string lenh4 = "Insert into T_GIA_NHAP values('" + dt.Rows[i].Field<string>(1) + "',TO_DATE('" + txtNgayLap.Text + "','DD-MM-RR')," + float.Parse(dgvCT_DatHang.Rows[i].Cells["dongianhap"].Value.ToString()) + ")";
                        OleDbCommand cmd4 = new OleDbCommand(lenh4, conn);
                        cmd4.ExecuteNonQuery();

                }
                string lenh5 = "update T_DON_DAT_HANG_NCC set TINHTRANGNHAP='Da nhap' where MADATNCC='" + txtMaDonDat.Text + "'";
                OleDbCommand cmd5 = new OleDbCommand(lenh5, conn);
                cmd5.ExecuteNonQuery();
                MessageBox.Show("Tạo phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_PhieuNhap();
                loadCT_PhieuNhap(dgvNhapHang.Rows[0].Cells[0].Value.ToString());
                txtTongtien.Text = "" + tong;
                conn.Close();
                btnThem.Enabled = false;
            }
        }

        private void dgvNhapHang_Click(object sender, EventArgs e)
        {
            conn.Open();
            loadCT_PhieuNhap(dgvNhapHang.CurrentRow.Cells[0].Value.ToString());
            
            conn.Close();
        }

        private void dgvCT_DatHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.ForeColor = Color.Gray;
            style1.BackColor = Color.LightBlue;
            for (int i = dgvCT_DatHang.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) dgvCT_DatHang.Rows[i].DefaultCellStyle = style1;
            }
        }

        private void dgvNhapHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.ForeColor = Color.Gray;
            style1.BackColor = Color.LightBlue;
            for (int i = dgvNhapHang.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) dgvNhapHang.Rows[i].DefaultCellStyle = style1;
            }
        }

        private void dgvCT_NhapHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.ForeColor = Color.Gray;
            style1.BackColor = Color.LightBlue;
            for (int i = dgvCT_NhapHang.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) dgvCT_NhapHang.Rows[i].DefaultCellStyle = style1;
            }
        }

    }
}
