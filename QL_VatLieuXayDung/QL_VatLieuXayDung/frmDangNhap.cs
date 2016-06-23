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
        string manv;
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
                MessageBox.Show("Nhập thiếu thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                Boolean q = false;
                kq = Connect.Check_Config();

                if (kq == 1 || kq == 2)
                {
                    MessageBox.Show("Chuỗi cấu hình không tồn tại hoặc không đúng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                            manv = dt.Rows[i].Field<string>(0);
                        }
                    }
                    if (q == true)
                    {
                        this.Hide();
                        if (Program.mainForm == null || Program.mainForm.IsDisposed)
                        {
                            Program.mainForm = new FormMain();
                  
                        }
                        Program.mainForm.ma = manv;
                        //phan quyen
                        DataTable phanquyen = new DataTable();
                        OleDbCommand c = new OleDbCommand("select T_PHAN_QUYEN.* from T_NHOM_TAI_KHOAN,T_PHAN_QUYEN,T_NHAN_VIEN where T_NHOM_TAI_KHOAN.MANHOM=T_PHAN_QUYEN.MANHOM and T_NHOM_TAI_KHOAN.MANHOM=T_NHAN_VIEN.MANHOM and T_NHAN_VIEN.MANV='" + txtMaNhanVien_DangNhap.Text + "'", conn);
                        OleDbDataAdapter da = new OleDbDataAdapter(c);
                        da.Fill(phanquyen);
                        //////////

                        foreach (DataRow row in phanquyen.Rows)
                        {
                            if (row.Field<String>(1) == "MH01" && row.Field<Decimal>(2) == 0)
                                Program.mainForm.MH01 = false;
                            if (row.Field<String>(1) == "MH02" && row.Field<Decimal>(2) == 0)
                                Program.mainForm.MH02 = false;
                            if (row.Field<String>(1) == "MH03" && row.Field<Decimal>(2) == 0)
                                Program.mainForm.MH03 = false;
                            if (row.Field<String>(1) == "MH04" && row.Field<Decimal>(2) == 0)
                                Program.mainForm.MH04 = false;

                        }
                        Program.mainForm.Show();

                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không tồn tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn thoát hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtMaNhanVien_DangNhap.Clear();
            this.txtMatKhau_DangNhap.Clear();
            this.txtMaNhanVien_DangNhap.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
        }
    }
}
