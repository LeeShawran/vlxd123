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
          
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_NHA_SAN_XUAT", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvNSX.DataSource = dt;
           
        }

        private void frmNhaSanXuat_Load(object sender, EventArgs e)
        {
            conn.Open();
            Refresh_Nha_SX();
            btnLuu_NSX.Enabled = false;
            conn.Close();
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
                MessageBox.Show("Bạn chưa nhập thông tin nhà sản xuất !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Insert into T_NHA_SAN_XUAT values('" + txtMaNSX_NSX.Text + "','" + txtTenNSX_NSX.Text + "')", conn);
                if (Kiem_tra_khoa_chinh())
                {
                    MessageBox.Show("Đã có mã nhả sản xuất này !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    Refresh_Nha_SX();
                    txtMaNSX_NSX.Clear();
                    txtTenNSX_NSX.Clear();
             
                }
                conn.Close();
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
            Refresh_Nha_SX();
            conn.Close();
            txtMaNSX_NSX.Clear();
            txtTenNSX_NSX.Clear();
 
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
            OleDbCommand cmd = new OleDbCommand("Update T_NHA_SAN_XUAT set TENNSX='" + txtTenNSX_NSX.Text + "' where MANSX='" + txtMaNSX_NSX.Text + "'", conn);
            cmd.ExecuteNonQuery();
            Refresh_Nha_SX();
            conn.Close();
          
            txtMaNSX_NSX.Clear();
            txtTenNSX_NSX.Clear();
      
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
