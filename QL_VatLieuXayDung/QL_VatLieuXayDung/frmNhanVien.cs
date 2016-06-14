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
     

        public void loadLai()
        {
           
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_NHAN_VIEN", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvNV.DataSource = dt;
           
        }

        private void cmbChucvu_NV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            conn.Open();
            loadLai();
            OleDbCommand cmd = new OleDbCommand("select TENNV from T_NHAN_VIEN where MANV='NV0002'", conn);
            string tennhom = (string)cmd.ExecuteScalar();
            textBox1.Text = tennhom;
            conn.Close();
        }

        private void dgvNV_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataGridViewRow row = new DataGridViewRow();
            row = dgvNV.CurrentRow;
            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtTenNV.Text = row.Cells[1].Value.ToString();
            txtEmail.Text = row.Cells[2].Value.ToString();
            if (row.Cells[3].Value.ToString() == "Nam")
            {
                rdcNam.Checked = true;
            }
            else
            {
                rdcNu.Checked = true;
            }
     
            txtDienthoai.Text = row.Cells[4].Value.ToString();

            OleDbCommand cmd = new OleDbCommand("select TENNHOM from T_NHOM_TAI_KHOAN where MANHOM='" + row.Cells[5].Value.ToString() + "'", conn);
            string tennhom = (string)cmd.ExecuteScalar();
            cmbChucvu.Text = tennhom;
            txtMatkhau_NV.Text = row.Cells[6].Value.ToString();
            conn.Close();
        }
    }
}
