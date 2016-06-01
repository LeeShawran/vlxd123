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
    public partial class frmKhachHang : Form
    {
        OleDbConnection conn;
        String phai = null;
        public frmKhachHang()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void Refresh_KH()
        {
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_KHACH_HANG", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvKH.DataSource = dt;
            conn.Close();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            Refresh_KH();
            btnLuu_KH.Enabled = false;
        }

        private bool Kiem_tra_khoa_chinh()
        {
            bool tatkt = false;
            string MaKH = txtMaKH_KH.Text;
            OleDbCommand cmd = new OleDbCommand("select * from T_KHACH_HANG", conn);
            OleDbDataReader PK = cmd.ExecuteReader();
            while (PK.Read())
            {
                if (MaKH == PK.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            return tatkt;
        }

        private void btnThem_KH_Click(object sender, EventArgs e)
        {
            if (this.txtMaKH_KH.TextLength == 0 || this.txtTenKH_KH.TextLength == 0)
            {
                this.lblStatus_KH.ForeColor = Color.Red;
                this.lblStatus_KH.Text = "Bạn chưa nhập thông tin khách hàng !";
            }
            else
            {
                conn.Open();
                if (rdcNam_KH.Checked==true) phai="Nam"; else phai="Nữ";
                OleDbCommand cmd = new OleDbCommand("Insert into T_KHACH_HANG values('" + txtMaKH_KH.Text + "','" + txtTenKH_KH.Text + "','" + phai + "','" + txtCMND_KH.Text + "','" + txtDiachi_KH.Text + "','" + txtDienthoai_KH.Text + "','" + txtGhichu_KH.Text + "')", conn);
                if (Kiem_tra_khoa_chinh())
                {
                    this.lblStatus_KH.ForeColor = Color.Red;
                    this.lblStatus_KH.Text = "Đã có mã khách hàng này !";
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Refresh_KH();
                    txtMaKH_KH.Clear();
                    txtTenKH_KH.Clear();
                    txtCMND_KH.Clear();
                    txtDiachi_KH.Clear();
                    txtDienthoai_KH.Clear();
                    txtGhichu_KH.Clear();
                }
            }
        }

        private void dgvKH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvKH.Rows[e.RowIndex];
                txtMaKH_KH.Text = row.Cells[0].Value.ToString();
                txtTenKH_KH.Text = row.Cells[1].Value.ToString();
                if (row.Cells[1].Value.ToString() == "Nam")
                {
                    rdcNam_KH.Checked = true;
                }
                else
                {
                    rdcNu_KH.Checked = true;
                }
                txtDiachi_KH.Text = row.Cells[2].Value.ToString();
                txtDienthoai_KH.Text = row.Cells[3].Value.ToString();
                txtGhichu_KH.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnXoa_KH_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Delete from T_KHACH_HANG where MAKH='" + txtMaKH_KH.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Refresh_KH();
            txtMaKH_KH.Clear();
            txtTenKH_KH.Clear();
            txtCMND_KH.Clear();
            txtDiachi_KH.Clear();
            txtDienthoai_KH.Clear();
            txtGhichu_KH.Clear();   
        }

        private void btnSua_KH_Click(object sender, EventArgs e)
        {
            txtMaKH_KH.ReadOnly = true;
            btnThem_KH.Enabled = false;
            btnXoa_KH.Enabled = false;
            btnSua_KH.Enabled = false;
            btnLuu_KH.Enabled = true;
        }

        private void btnLuu_KH_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (rdcNam_KH.Checked == true) phai = "Nam"; else phai = "Nữ";
            OleDbCommand cmd = new OleDbCommand("Update T_KHACH_HANG set TENKH='" + txtTenKH_KH.Text + "', PHAIKH='" + phai + "', CMNDKH='" + txtCMND_KH.Text + "', DIACHIKH='" + txtDiachi_KH.Text + "' , DTHOAIKH='"+ txtDienthoai_KH.Text+ "', GHICHUKH='"+txtGhichu_KH.Text+ "' where MAKH='" + txtMaKH_KH.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Refresh_KH();
            txtMaKH_KH.Clear();
            txtTenKH_KH.Clear();
            txtCMND_KH.Clear();
            txtDiachi_KH.Clear();
            txtDienthoai_KH.Clear();
            txtGhichu_KH.Clear();   
            txtMaKH_KH.ReadOnly = false;
            btnThem_KH.Enabled = true;
            btnXoa_KH.Enabled = true;
            btnSua_KH.Enabled = true;
            btnLuu_KH.Enabled = false;
        }

        


    }
}
