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
    public partial class frmPhanQuyen : Form
    {
        OleDbConnection conn;
        public frmPhanQuyen()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_NHOM_TAI_KHOAN", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvNhomTK.DataSource = dt;
            conn.Close();
            this.dgvNhomTK.AutoGenerateColumns = false;
        }

        private void dgvNhomTK_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvNhomTK.Rows)
            {
                if (dgvNhomTK.SelectedRows.Contains(item))
                {
                    try
                    {
                        string manhom = item.Cells[0].Value.ToString();
                        OleDbDataAdapter adapter = new OleDbDataAdapter("select T_MAN_HINH.MAMH,T_MAN_HINH.TENMH,T_PHAN_QUYEN.COQUYEN from T_PHAN_QUYEN,T_MAN_HINH,T_NHOM_TAI_KHOAN where T_MAN_HINH.MAMH = T_PHAN_QUYEN.MAMH AND T_PHAN_QUYEN.MANHOM = T_NHOM_TAI_KHOAN.MANHOM AND T_PHAN_QUYEN.MANHOM='" + manhom + "'", conn);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvPhanQuyen.DataSource = dt;
                        conn.Close();
                        
                    }
                    catch { }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
