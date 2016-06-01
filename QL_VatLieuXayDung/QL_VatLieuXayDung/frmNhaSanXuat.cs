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
    public partial class frmNhaSanXuat : Form
    {
        OleDbConnection conn;
        public frmNhaSanXuat()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void Refresh_Nha_SX()
        {
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_NHA_SAN_XUAT", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvNSX.DataSource = dt;
            conn.Close();
        }

        private void frmNhaSanXuat_Load(object sender, EventArgs e)
        {
            Refresh_Nha_SX();
            btnLuu_NSX.Enabled = false;
        }

        private bool Kiem_tra_khoa_chinh()
        {
            bool tatkt = false;
            string MaNSX = txtMaNSX_NSX.Text;
            OleDbCommand cmd = new OleDbCommand("select * from T_NHA_SAN_XUAT", conn);
            OleDbDataReader PK = cmd.ExecuteReader();
            while (PK.Read())
            {
                if (MaNSX == PK.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            return tatkt;
        }

        private void btnThem_NSX_Click(object sender, EventArgs e)
        {
            if (this.txtMaNSX_NSX.TextLength == 0 || this.txtTenNSX_NSX.TextLength == 0)
            {
                this.lblStatus_NSX.ForeColor = Color.Red;
                this.lblStatus_NSX.Text = "Bạn chưa nhập thông tin nhà sản xuất !";
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Insert into T_NHA_SAN_XUAT values('" + txtMaNSX_NSX.Text + "','" + txtTenNSX_NSX.Text + "','" + txtDienthoai_NSX.Text + "','" + txtEmail_NSX.Text + "','" + txtDiachi_NSX.Text + "')", conn);
                if (Kiem_tra_khoa_chinh())
                {
                    this.lblStatus_NSX.ForeColor = Color.Red;
                    this.lblStatus_NSX.Text = "Đã có mã nhả sản xuất này !";
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Refresh_Nha_SX();
                    txtMaNSX_NSX.Clear();
                    txtTenNSX_NSX.Clear();
                    txtDienthoai_NSX.Clear();
                    txtEmail_NSX.Clear();
                    txtDiachi_NSX.Clear();
                }
            }
        }

        private void dgvNSX_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvNSX.Rows[e.RowIndex];
                txtMaNSX_NSX.Text = row.Cells[0].Value.ToString();
                txtTenNSX_NSX.Text = row.Cells[1].Value.ToString(); 
                txtDienthoai_NSX.Text = row.Cells[2].Value.ToString();
                txtEmail_NSX.Text = row.Cells[3].Value.ToString();
                txtDiachi_NSX.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnXoa_NSX_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Delete from T_NHA_SAN_XUAT where MANSX='" + txtMaNSX_NSX.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Refresh_Nha_SX();
            txtMaNSX_NSX.Clear();
            txtTenNSX_NSX.Clear();
            txtDienthoai_NSX.Clear();
            txtEmail_NSX.Clear();
            txtDiachi_NSX.Clear();
        }

        private void btnSua_NSX_Click(object sender, EventArgs e)
        {
            txtMaNSX_NSX.ReadOnly = true;
            btnThem_NSX.Enabled = false;
            btnXoa_NSX.Enabled = false;
            btnSua_NSX.Enabled = false;
            btnLuu_NSX.Enabled = true;
        }

        private void btnLuu_NSX_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Update T_NHA_SAN_XUAT set TENNSX='" + txtTenNSX_NSX.Text + "', DTHOAINSX='" + txtDienthoai_NSX.Text + "', EMAILNSX='" + txtEmail_NSX.Text + "', DCHINSX='" + txtDiachi_NSX.Text + "' where MANSX='" + txtMaNSX_NSX.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Refresh_Nha_SX();
            txtMaNSX_NSX.Clear();
            txtTenNSX_NSX.Clear();
            txtDienthoai_NSX.Clear();
            txtEmail_NSX.Clear();
            txtDiachi_NSX.Clear();
            txtMaNSX_NSX.ReadOnly = false;
            btnThem_NSX.Enabled = true;
            btnXoa_NSX.Enabled = true;
            btnSua_NSX.Enabled = true;
            btnLuu_NSX.Enabled = false;
        }

        private void btnAsc_NSX_Click(object sender, EventArgs e)
        {
            dgvNSX.Sort(dgvNSX.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void btnDes_NSX_Click(object sender, EventArgs e)
        {
            dgvNSX.Sort(dgvNSX.Columns[0], System.ComponentModel.ListSortDirection.Descending);
        }
    }
}
