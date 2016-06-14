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
        OleDbDataAdapter adapter;
        DataTable dt;
        OleDbCommand cmd;
        String phai = null;

        int luu = 0;
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

        private bool Kiem_tra_khoa_chinh()
        {
            bool tatkt = false;
            string MaNV = txtMaNV.Text;
            OleDbCommand cmd = new OleDbCommand("select * from T_NHAN_VIEN", conn);
            OleDbDataReader PK = cmd.ExecuteReader();
            while (PK.Read())
            {
                if (MaNV == PK.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            return tatkt;
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

        private void btnThem_NV_Click(object sender, EventArgs e)
        {
            luu = 1;
            conn.Open();
            adapter = new OleDbDataAdapter("select * from T_NHAN_VIEN", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count < 100)
                txtMaNV.Text = "NV000" + (dt.Rows.Count + 1);
            else if (dt.Rows.Count < 10)
                txtMaNV.Text = "NV00" + (dt.Rows.Count + 1);
            else txtMaNV.Text = "NV0" + (dt.Rows.Count + 1);
            conn.Close();
            groupBox1.Enabled = true;
            btnThem_NV.Enabled = false;
            btnXoa_NV.Enabled = false;
            btnSua_NV.Enabled = false;
            btnLuu_NV.Enabled = true;
            dgvNV.Enabled = false;
        }

        private void btnXoa_NV_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new OleDbCommand("Delete from T_NHAN_VIEN where MANV='" + txtMaNV.Text + "'", conn);
            cmd.ExecuteNonQuery();
            loadTable();
            conn.Close();
            
        }

        public void loadChucVu()
        {
            string st = "select * from T_NHOM_TAI_KHOAN";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            cmbChucvu.DataSource = dt;
            cmbChucvu.DisplayMember = "TENNHOM";
            cmbChucvu.ValueMember = "MANHOM";
        }

        public void loadTable()
        {
            adapter = new OleDbDataAdapter("select * from T_NHAN_VIEN", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvNV.DataSource = dt;

            if (dt.Rows.Count < 100)
                txtMaNV.Text = "NV000" + (dt.Rows.Count + 1);
            else if (dt.Rows.Count < 10)
                txtMaNV.Text = "NV00" + (dt.Rows.Count + 1);
            else txtMaNV.Text = "NV0" + (dt.Rows.Count + 1);
            loadChucVu();


            luu = 0;
            groupBox1.Enabled = false;

            btnThem_NV.Enabled = true;
            btnLuu_NV.Enabled = false;
            btnSua_NV.Enabled = false;
            btnXoa_NV.Enabled = false;

            dgvNV.Enabled = true;

            txtMaNV.Clear();
            txtTenNV.Clear();
            txtEmail.Clear();
            txtDienthoai.Clear();
            cmbChucvu.DisplayMember = cmbChucvu.Items[0].ToString();
        }


        public void them()
        {
            if (this.txtMaNV.TextLength == 0 || this.txtMaNV.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập thông tin sản phẩm");
                return;
            }
            else
            {
                if (rdcNam.Checked == true) phai = "Nam"; else phai = "Nu";
                cmd = new OleDbCommand("Insert into T_NHAN_VIEN values('" + txtMaNV.Text + "','" + txtTenNV.Text + "','" + phai + "','" + txtDienthoai.Text + "','" + cmbChucvu.SelectedValue.ToString() + "','"+ txtMatkhau_NV.Text+  "')", conn);
                if (Kiem_tra_khoa_chinh())
                {
                    MessageBox.Show("Đã có mã nhân viên này");
                    return;
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    loadTable();

                }
            }
        }
        public void sua()
        {
            if (this.txtMaNV.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập thông tin nhân viên");
                return;
            }
            else
            {
                if (rdcNam.Checked == true) phai = "Nam"; else phai = "Nu";
                OleDbCommand cmd = new OleDbCommand("Update T_NHAN_VIEN set TENNV='" + txtTenNV.Text + "', EMAILNV ='" + txtEmail + "', PHAI='" + phai + "', DIENTHOAINV='" + txtDienthoai.Text + "', MANHOM='" + cmbChucvu.SelectedValue.ToString() + "',MATKHAU='"+txtMatkhau_NV.Text+"' where MANV='" + txtMaNV.Text + "'", conn);
                cmd.ExecuteNonQuery();
                loadTable();
            }

        }

        private void btnLuu_NV_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (luu == 1)
            {
                them();
                dgvNV.Enabled = true;
            }
            else if (luu == 2)
            {
                sua();
                dgvNV.Enabled = true;
            }


            conn.Close();
        }

        private void btnSua_NV_Click(object sender, EventArgs e)
        {
            luu = 2;
            groupBox1.Enabled = true;
            btnThem_NV.Enabled = false;
            btnXoa_NV.Enabled = false;
            btnSua_NV.Enabled = false;
            btnLuu_NV.Enabled = true;
            dgvNV.Enabled = false;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            conn.Open();
            loadTable();
            conn.Close();
        }
    }
}
