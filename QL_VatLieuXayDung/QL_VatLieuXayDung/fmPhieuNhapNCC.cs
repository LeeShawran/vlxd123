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
        }
        private void fmPhieuNhapNCC_Load(object sender, EventArgs e)
        {
            conn.Open();
            loadLai();
            txtNgayLap.Format = DateTimePickerFormat.Custom;
            txtNgayLap.CustomFormat = "dd/MM/yyyy";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            loadCT_DonDatHang();
            conn.Close();
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
            //conn.Open();
            //adapter = new OleDbDataAdapter("select * from T_DON_DAT_HANG_NCC", conn);
            //dt = new DataTable();
            //adapter.Fill(dt);

            //if (dt.Rows.Count < 100)
            //    txtMaPhieu.Text = "DHNCC000" + (dt.Rows.Count + 1);
            //else if (dt.Rows.Count < 10)
            //    txtMaPhieu.Text = "DHNCC00" + (dt.Rows.Count + 1);
            //else txtMaPhieu.Text = "DHNCC0" + (dt.Rows.Count + 1);
            //conn.Close();

            //groupBoxThongTinDH.Enabled = true;
            //btnThemDDH.Enabled = false;
            //btnXoaDDH.Enabled = false;
            //btnSuaDDH.Enabled = false;
            //btnLuuDDH.Enabled = true;
            //dgvDonDatHang.Enabled = false;

        }
    }
}
