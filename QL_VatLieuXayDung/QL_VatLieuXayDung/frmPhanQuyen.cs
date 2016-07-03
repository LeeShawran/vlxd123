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

        public void loadTable()
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_NHOM_TAI_KHOAN", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvNhomTK.DataSource = dt;
        }
        private void frmPhanQuyen_Load(object sender, EventArgs e)
        {
            conn.Open();
            loadTable();
            conn.Close();
           
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
                        OleDbDataAdapter adapter = new OleDbDataAdapter("select T_MAN_HINH.MAMH,T_MAN_HINH.TENMH,T_PHAN_QUYEN.COQUYEN from T_PHAN_QUYEN,T_MAN_HINH,T_NHOM_TAI_KHOAN where T_MAN_HINH.MAMH = T_PHAN_QUYEN.MAMH AND T_PHAN_QUYEN.MANHOM = T_NHOM_TAI_KHOAN.MANHOM AND T_PHAN_QUYEN.MANHOM='" + manhom + "' ORDER BY T_MAN_HINH.MAMH ASC", conn);
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
            conn.Open();

            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_MAN_HINH", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                OleDbCommand cm2 = new OleDbCommand("update T_PHAN_QUYEN set COQUYEN='" + dgvPhanQuyen.Rows[i].Cells[2].Value + "' where (MANHOM='" + dgvNhomTK.CurrentRow.Cells[0].Value.ToString() + "' AND MAMH= '" + dt.Rows[i].Field<string>(0) + "')", conn);
                cm2.ExecuteNonQuery();

            }
            loadTable();
            conn.Close();
        }

        private void dgvNhomTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNhomTK_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.ForeColor = Color.Gray;
            style1.BackColor = Color.LightBlue;
            for (int i = dgvNhomTK.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) dgvNhomTK.Rows[i].DefaultCellStyle = style1;
            }
        }
    }
}
