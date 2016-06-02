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
    public partial class frmDatHangNCC : Form
    {
        OleDbConnection conn;
        public frmDatHangNCC()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }
        public void loadLai()
        {
            conn.Open();
            dgvDatNCC.Columns["Column4"].DefaultCellStyle.Format = @"dd/MM/yyyy";
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_DON_DAT_HANG_NCC", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvDatNCC.DataSource = dt;
            conn.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmDatHangNCC_Load(object sender, EventArgs e)
        {
            loadLai();
            btnLuuPD.Enabled = false;
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.CustomFormat = "dd/MM/yyyy";
        }

        private bool Kiem_tra_khoa_chinh()
        {
            bool a = false;
            string MaPD = txtMaPD.Text;
            OleDbCommand cmd = new OleDbCommand("select * from T_DON_DAT_HANG_NCC", conn);
            OleDbDataReader PK = cmd.ExecuteReader();
            while (PK.Read())
            {
                if (MaPD == PK.GetString(0))
                {
                    a = true;
                    break;
                }
            }
            return a;
        }

        private void btnThemPD_Click(object sender, EventArgs e)
        {

        }
    }
}
