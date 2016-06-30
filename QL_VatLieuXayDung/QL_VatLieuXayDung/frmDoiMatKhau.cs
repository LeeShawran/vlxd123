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
    public partial class frmDoiMatKhau : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        string manv;
        public frmDoiMatKhau()
        {
            InitializeComponent();
            conn = Connect.getConnect();

        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            manv = Program.mainForm.ma;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (txtMatKhauCu.Text.Length == 0 || txtMatKhauMoi.Text.Length == 0 || txtNhapLaiMatKhau.Text.Length == 0)
                MessageBox.Show("Chưa nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtMatKhauCu.Text.Length == 0)
                MessageBox.Show("Chưa nhập mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtMatKhauMoi.Text.Length == 0) MessageBox.Show("Chưa nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtNhapLaiMatKhau.Text.Length == 0) MessageBox.Show("Chưa nhập lại mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtMatKhauMoi.Text != txtNhapLaiMatKhau.Text) MessageBox.Show("Mật khẩu nhập lại không trùng với mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                cmd = new OleDbCommand("SELECT MATKHAU FROM T_NHAN_VIEN WHERE MANV ='" + manv + "'", conn);
                string mk = cmd.ExecuteScalar().ToString();
                
                if (txtMatKhauCu.Text == mk)
                {
                    cmd = new OleDbCommand("UPDATE T_NHAN_VIEN SET MATKHAU='" + txtMatKhauMoi.Text + "' WHERE MANV='" + manv + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMatKhauCu.Clear();
                    txtMatKhauMoi.Clear();
                    txtNhapLaiMatKhau.Clear();
                   
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            conn.Close();
        }
    }
}
