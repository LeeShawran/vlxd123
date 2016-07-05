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
    public partial class frmNhomTaiKhoan : Form
    {
        OleDbConnection conn;
        int luu = 0;
        public frmNhomTaiKhoan()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void Refresh_NTK()
        {
            
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_NHOM_TAI_KHOAN", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvNTK.DataSource = dt;

            groupBox1.Enabled = false;

            btnThem_NTK.Enabled = true;
            btnLuu_NTK.Enabled = false;
            btnSua_NTK.Enabled = false;
            btnXoa_NTK.Enabled = false;
            txtMaNTK_NTK.Clear();
            txtTenNTK_NTK.Clear();
            luu = 0;
        }

        private void frmNhomTaiKhoan_Load(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            btnLuu_NTK.Enabled = false;
            Refresh_NTK();
            conn.Close();
        }

        private bool Kiem_tra_khoa_chinh()
        {
            bool tatkt = false;
            string MaNTK = txtMaNTK_NTK.Text;
            OleDbCommand cmd = new OleDbCommand("select * from T_NHOM_TAI_KHOAN", conn);
            OleDbDataReader PK = cmd.ExecuteReader();
            while (PK.Read())
            {
                if (MaNTK == PK.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            return tatkt;
        }
        public void them()
        {
            if(txtTenNTK_NTK.Text=="" || txtMaNTK_NTK.Text=="")
            {
                MessageBox.Show("Chưa nhập đủ thông tin nhóm tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
             OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_MAN_HINH", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            Int32 b = 0;
            conn.Open();
            //OleDbCommand cm = new OleDbCommand("insert into T_NHOM_TAI_KHOAN(MANHOM,TENNHOM) values ('" + txtmanhom.Text + "','" + txttennhom.Text + "')", conn);

            OleDbCommand cm2 = new OleDbCommand("insert into T_NHOM_TAI_KHOAN(MANHOM,TENNHOM) values ('" + txtMaNTK_NTK.Text + "','" + txtTenNTK_NTK.Text + "')", conn);
            cm2.ExecuteNonQuery();
            //MessageBox.Show(""+b);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //MessageBox.Show("" + dt.Rows[i].Field<string>(0));
                OleDbCommand cm8 = new OleDbCommand("insert into T_PHAN_QUYEN(MANHOM,MAMH,COQUYEN) values ('" + txtMaNTK_NTK.Text + "','" + dt.Rows[i].Field<string>(0) + "'," + 0 + ")", conn);

                cm8.ExecuteNonQuery();
            }
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Refresh_NTK();
            conn.Close();   
            }
                   
        }
        public void sua()
        {//
            if (this.txtTenNTK_NTK.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập tên nhóm tài khoản");
                return;
            }
            else
            {
                conn.Close();
                conn.Open();
                OleDbCommand cm2 = new OleDbCommand("update T_NHOM_TAI_KHOAN set TENNHOM=N'" + txtTenNTK_NTK.Text + "' where MANHOM='" + txtMaNTK_NTK.Text + "'", conn);
                cm2.ExecuteNonQuery();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh_NTK();
                conn.Close();
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            luu = 1;
            groupBox1.Enabled = true;
            btnThem_NTK.Enabled = false;
            btnXoa_NTK.Enabled = false;
            btnSua_NTK.Enabled = false;
            btnLuu_NTK.Enabled = true;
            dgvNTK.Enabled = false;
            txtTenNTK_NTK.Clear();
            txtMaNTK_NTK.Clear();
            txtMaNTK_NTK.Enabled = true;
            txtTenNTK_NTK.Enabled = true;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_MAN_HINH", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Int32 b = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {                  
                    OleDbCommand cm8 = new OleDbCommand("delete from T_PHAN_QUYEN where MANHOM='" + txtMaNTK_NTK.Text + "'", conn);
                    cm8.ExecuteNonQuery();
                }

                OleDbCommand cm2 = new OleDbCommand("delete from T_NHOM_TAI_KHOAN where MANHOM='" + txtMaNTK_NTK.Text + "'", conn);
                cm2.ExecuteNonQuery();
                MessageBox.Show("Xóa Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Refresh_NTK();
                conn.Close();
                
            }
            catch
            {
                conn.Close();
                conn.Open();
                MessageBox.Show("Không thể xóa nhóm tài khoản này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_MAN_HINH", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //MessageBox.Show("" + dt.Rows[i].Field<string>(0));
                    OleDbCommand cm8 = new OleDbCommand("insert into T_PHAN_QUYEN(MANHOM,MAMH,COQUYEN) values ('" + txtMaNTK_NTK.Text + "','" + dt.Rows[i].Field<string>(0) + "'," + 0 + ")", conn);

                    cm8.ExecuteNonQuery();
                }
                
                conn.Close();
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (luu == 1)
            {
                them();
                dgvNTK.Enabled = true;
            }
            else if (luu == 2)
            {
                sua();
                dgvNTK.Enabled = true;
            }
        }

        private void dgvNhomTK_Click(object sender, EventArgs e)
        {
            txtMaNTK_NTK.Text = dgvNTK.CurrentRow.Cells[0].Value.ToString();
            txtTenNTK_NTK.Text = dgvNTK.CurrentRow.Cells[1].Value.ToString();
            btnSua_NTK.Enabled = true;
            btnXoa_NTK.Enabled=true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            luu = 2;
            groupBox1.Enabled = true;
            txtTenNTK_NTK.Focus();
            txtMaNTK_NTK.Enabled = false;
            btnThem_NTK.Enabled = false;
            btnXoa_NTK.Enabled = false;
            btnSua_NTK.Enabled = false;
            btnLuu_NTK.Enabled = true;
            dgvNTK.Enabled = false;
            //
         
        }

        private void dgvNTK_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.ForeColor = Color.Gray;
            style1.BackColor = Color.LightBlue;
            for (int i = dgvNTK.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) dgvNTK.Rows[i].DefaultCellStyle = style1;
            }
        }
    }
}
