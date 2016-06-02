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
    public partial class frmNhanVien : Form
    {
        OleDbConnection conn;
        public frmNhanVien()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void Refresh_Nha_SX()
        {
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_NHAN_VIEN", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvNV.DataSource = dt;
            conn.Close();
        }

        private void cmbChucvu_NV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
