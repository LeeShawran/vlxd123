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
            //dgvDonDatHang.Columns["Column4"].DefaultCellStyle.Format = @"dd/MM/yyyy";
            //adapter = new OleDbDataAdapter("select * from T_DON_DAT_HANG_NCC", conn);
            //dt = new DataTable();
            //adapter.Fill(dt);
            //dgvDonDatHang.DataSource = dt;
            //groupBoxCT_DDH.Enabled = false;


            //luu = 0;
            //groupBoxThongTinDH.Enabled = false;


            //loadNCC();

            //btnThemDDH.Enabled = true;
            //btnLuuDDH.Enabled = false;
            //btnSuaDDH.Enabled = false;
            //btnXoaDDH.Enabled = false;
            //btnPhieuNhap.Enabled = false;

            //dgvDonDatHang.Enabled = true;

            //txtMaPhieu.Clear();
            //txtTongTien.Clear();
            //cbTinhTRrang.DisplayMember = cbTinhTRrang.Items[0].ToString();
            //cbNCC.DisplayMember = cbNCC.Items[0].ToString();
        }
        private void fmPhieuNhapNCC_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            loadCT_DonDatHang();
            conn.Close();
        }
    }
}
