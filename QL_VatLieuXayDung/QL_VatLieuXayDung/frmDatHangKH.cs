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
    public partial class frmDatHangKH : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        OleDbCommand cmd;
        DataTable dt;
        int luu = 0;
        float tong = 0;
        public frmDatHangKH()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void loadKH()
        {
            string st = "select * from T_KHACH_HANG";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            cbKH.DataSource = dt;
            cbKH.DisplayMember = "TENKH";
            cbKH.ValueMember = "MAKH";
        }

        public void loadSP()
        {
            string st = "select T_SAN_PHAM.MASP,TENSP,SOLUONG,DONGIABAN from T_SAN_PHAM, T_GIA_BAN where T_SAN_PHAM.MASP=T_GIA_BAN.MASP AND T_GIA_BAN.NGAYHIEULUC =(SELECT MAX(T_GIA_BAN.NGAYHIEULUC) FROM  T_GIA_BAN WHERE  T_GIA_BAN.NGAYHIEULUC <=TO_DATE ('"+ dtpNgaydat.Text +"', 'DD/MM/YYYY'))";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvSanPHam.DataSource = dt;

        }
        public void loadLai()
        {
           
           
        }

        private void frmDatHangKH_Load(object sender, EventArgs e)
        {
            dtpNgaydat.Format = DateTimePickerFormat.Custom;
            dtpNgaydat.CustomFormat = "dd/MM/yyyy";
            conn.Open();
            loadKH();
            loadSP();
            conn.Close();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
