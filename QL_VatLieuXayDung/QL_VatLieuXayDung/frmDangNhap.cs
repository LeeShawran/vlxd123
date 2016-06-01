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
    public partial class frmDangNhap : Form
    {
        int kq;
        OleDbConnection conn;
        public frmDangNhap()
        {
            conn = Connect.getConnect();
            InitializeComponent();
            
        }
      
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (this.txtMaNhanVien_DangNhap.TextLength == 0 || this.txtMatKhau_DangNhap.TextLength == 0)
            {
                this.lblStatus_DangNhap.ForeColor = Color.Red;
                this.lblStatus_DangNhap.Text = "Bạn chưa nhập tài khoản hoặc mật khẩu";
            }
            else
            {
                Boolean q = false;
                kq = Connect.Check_Config();

                if (kq == 1 || kq == 2)
                {
                    MessageBox.Show("Chuỗi cấu hình không tồn tại hoặc không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    this.Hide();
                    frmCauHinh f = new frmCauHinh();
                    f.Show();
                }
                else
                {
                    conn.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_NHAN_VIEN", conn);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    for (int i = 0; i < dt.Rows.Count; i++)// dem tung dong table
                    {
                        //MessageBox.Show("" + dt.Rows[i].Field<string>(0) + "_" + dt.Rows[i].Field<string>(6));
                        if (dt.Rows[i].Field<string>(0) == txtMaNhanVien_DangNhap.Text && dt.Rows[i].Field<string>(6) == txtMatKhau_DangNhap.Text)// (0) la cot tai khoan
                        {
                            q = true;
                        }
                    }
                    if (q == true)
                    {
                        this.Hide();
                        FormMain f = new FormMain();
                        f.Show();
                    }
                    else
                    {
                        this.lblStatus_DangNhap.ForeColor = Color.Red;
                        this.lblStatus_DangNhap.Text = "Tài khoản không tồn tại";
                        this.txtMaNhanVien_DangNhap.Clear();
                        this.txtMaNhanVien_DangNhap.Focus();
                        this.txtMatKhau_DangNhap.Clear();
                    }
                    conn.Close();
                }
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnDangNhap;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.Reset();
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn thoát hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtMaNhanVien_DangNhap.Clear();
            this.txtMatKhau_DangNhap.Clear();
            this.txtMaNhanVien_DangNhap.Focus();
            this.lblStatus_DangNhap.ResetText();
        }
    }
}
