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
        int luu = 0;
        public fmPhieuNhapNCC(string a)
        {
            InitializeComponent();
            conn = Connect.getConnect();
            txtMaDonDat.Text = a;
        }

        public void loadCT_DonDatHang()
        {
            string st = "select MASP,SOLUONG,DONGIANHAP from T_CT_DAT_HANG_NCC where MADATNCC='"+txtMaDonDat.Text+"'";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvCT_DatHang.DataSource = dt; 
        }

        public void load_PhieuNhap()
        {
            string st = "select * from T_PHIEU_NHAP";
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


        public void loadLai()
        {
            dgvNhapHang.Columns["ngaylapcol"].DefaultCellStyle.Format = @"dd/MM/yyyy";
            adapter = new OleDbDataAdapter("select * from T_PHIEU_NHAP", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvNhapHang.DataSource = dt;       

            if (dt.Rows.Count < 100)
                txtMaPN.Text = "PNNCC000" + (dt.Rows.Count + 1);
            else if (dt.Rows.Count < 10)
                txtMaPN.Text = "PNNCC00" + (dt.Rows.Count + 1);
            else txtMaPN.Text = "PNNCC0" + (dt.Rows.Count + 1);

            btnThem.Enabled = true;
            load_PhieuNhap();
        }
        private void fmPhieuNhapNCC_Load(object sender, EventArgs e)
        {
            conn.Open();

            loadLai();
            loadCT_DonDatHang();
            txtNgayLap.Format = DateTimePickerFormat.Custom;
            txtNgayLap.CustomFormat = "dd/MM/yyyy";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private bool Kiem_tra_khoa_chinh()
        {
            bool a = false;
            string s = txtMaPN.Text;
            cmd = new OleDbCommand("select * from T_PHIEU_NHAP", conn);
            OleDbDataReader PK = cmd.ExecuteReader();
            while (PK.Read())
            {
                if (s == PK.GetString(0))
                {
                    a = true;
                    break;
                }
            }
            return a;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            conn.Open();
            // them vao phieu nhap
            cmd = new OleDbCommand("Insert into T_PHIEU_NHAP values('" + txtMaPN.Text + "',TO_DATE('" + txtNgayLap.Text + "','DD-MM-RR'),'" + txtNhanVien.Text + "','" + txtMaDonDat.Text + "')", conn);
            cmd.ExecuteNonQuery();

            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_CT_DAT_HANG_NCC where MADATNCC='" + txtMaDonDat.Text + "'", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ////them vao chi tiet phieu nhap

                OleDbCommand cm8 = new OleDbCommand("insert into T_CT_PHIEU_NHAP values ('" + txtMaPN.Text + "','" + dt.Rows[i].Field<string>(1) + "'," + float.Parse(dgvCT_DatHang.Rows[i].Cells[2].Value.ToString()) + "," + int.Parse(dgvCT_DatHang.Rows[i].Cells[1].Value.ToString()) + ")", conn);
                cm8.ExecuteNonQuery();

                ////cap nhat so luong trong bang san pham
                string lenh1 = "select SOLUONG from T_SAN_PHAM where MASP='" + dt.Rows[i].Field<string>(1) + "'";
                string lenh2 = "select SOLUONG from T_CT_DAT_HANG_NCC where MASP='" + dt.Rows[i].Field<string>(1) + "'";
                OleDbCommand cmd1 = new OleDbCommand(lenh1, conn);
                int a = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
                OleDbCommand cmd2 = new OleDbCommand(lenh2, conn);
                int b = Convert.ToInt32(cmd2.ExecuteScalar().ToString()); ;
                int c = a + b;
                ////MessageBox.Show("" + dt.Rows[i].Field<string>(1));
                ////MessageBox.Show("" + a + "," + b);

                string lenh3 = "update T_SAN_PHAM set SOLUONG=" + c + " where MASP='" + dt.Rows[i].Field<string>(1) + "'";
                OleDbCommand cmd3 = new OleDbCommand(lenh3, conn);
                cmd3.ExecuteNonQuery();
                ////them vap bang gia nhap
                OleDbDataAdapter adapter2 = new OleDbDataAdapter("select * from T_GIA_NHAP", conn);
                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);

                string gia;
                if (dt2.Rows.Count < 100)
                   gia = "GIAN000" + (dt2.Rows.Count + 1);
                else if (dt2.Rows.Count < 10)
                    gia = "GIANC00" + (dt2.Rows.Count + 1);
                else gia= "GIAN0" + (dt2.Rows.Count + 1);
                MessageBox.Show(gia);


                string lenh4 = "Insert into T_GIA_NHAP values('"+ gia +"','" + dt.Rows[i].Field<string>(1) + "',TO_DATE('" + txtNgayLap.Text + "','DD-MM-RR')," + float.Parse(dgvCT_DatHang.Rows[i].Cells[2].Value.ToString()) + ")";
                OleDbCommand cmd4 = new OleDbCommand(lenh4, conn);
                cmd4.ExecuteNonQuery();

            }
          conn.Close();
          btnThem.Enabled = false;

        }

        private void dgvNhapHang_Click(object sender, EventArgs e)
        {
            conn.Open();
            loadCT_PhieuNhap(dgvNhapHang.CurrentRow.Cells[0].Value.ToString());
            conn.Close();
        }

        private void bntLammoi_Click(object sender, EventArgs e)
        {
            loadLai();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
