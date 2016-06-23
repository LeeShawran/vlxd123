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
    public partial class frmLoaiSanPham : Form
    {
        OleDbConnection conn;
        public frmLoaiSanPham()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void Refresh_Loai_SP()
        {
           
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_LOAI_SP", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvLoaiSP.DataSource = dt;
            
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            conn.Open();
            Refresh_Loai_SP();
            btnLuu_LoaiSP.Enabled=false;
            conn.Close();
        }

        private bool Kiem_tra_khoa_chinh()
        {
            bool tatkt = false;
            string MaLoai = txtMaLoai_LoaiSP.Text;
            OleDbCommand cmd = new OleDbCommand("select * from T_LOAI_SP", conn);
            OleDbDataReader PK = cmd.ExecuteReader();
            while (PK.Read())
            {
                if (MaLoai == PK.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            return tatkt;
        }

        private void btnThem_LoaiSP_Click(object sender, EventArgs e)
        {
            if (this.txtMaLoai_LoaiSP.TextLength == 0 || this.txtTenLoai_LoaiSP.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập thông tin loại sản phẩm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Insert into T_LOAI_SP values('" + txtMaLoai_LoaiSP.Text + "',N'" + txtTenLoai_LoaiSP.Text + "')", conn);
                if (Kiem_tra_khoa_chinh())
                {
                    MessageBox.Show("Đã có mã loại sản phẩm này !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    Refresh_Loai_SP();
                    txtMaLoai_LoaiSP.Clear();
                    txtTenLoai_LoaiSP.Clear();
                }
                conn.Close();
            }
        }

        private void dgvLoaiSP_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvLoaiSP.Rows[e.RowIndex];
                txtMaLoai_LoaiSP.Text = row.Cells[0].Value.ToString();
                txtTenLoai_LoaiSP.Text = row.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnXoa_LoaiSP_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Delete from T_LOAI_SP where MALOAI='" + txtMaLoai_LoaiSP.Text +"'", conn);
            cmd.ExecuteNonQuery();
           
            Refresh_Loai_SP();
            conn.Close();
            txtMaLoai_LoaiSP.Clear();
            txtTenLoai_LoaiSP.Clear();
        }

        private void btnSua_LoaiSP_Click(object sender, EventArgs e)
        {
            txtMaLoai_LoaiSP.ReadOnly = true;
            btnThem_LoaiSP.Enabled = false;
            btnXoa_LoaiSP.Enabled = false;
            btnSua_LoaiSP.Enabled = false;
            btnLuu_LoaiSP.Enabled = true;
        }

        private void btnLuu_LoaiSP_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Update T_LOAI_SP set TENLOAI='" + txtTenLoai_LoaiSP.Text + "' where MALOAI='" + txtMaLoai_LoaiSP.Text + "'", conn);
            cmd.ExecuteNonQuery();
           
            Refresh_Loai_SP();
            conn.Close();
            txtMaLoai_LoaiSP.Clear();
            txtTenLoai_LoaiSP.Clear();
            txtMaLoai_LoaiSP.ReadOnly = false;
            btnThem_LoaiSP.Enabled = true;
            btnXoa_LoaiSP.Enabled = true;
            btnSua_LoaiSP.Enabled = true;
            btnLuu_LoaiSP.Enabled = false;
            conn.Close();
        }

        private void btnAsc_LoaiSP_Click(object sender, EventArgs e)
        {
            dgvLoaiSP.Sort(dgvLoaiSP.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void btnDes_LoaiSP_Click(object sender, EventArgs e)
        {
            dgvLoaiSP.Sort(dgvLoaiSP.Columns[0], System.ComponentModel.ListSortDirection.Descending);
        }
            
    }
}
