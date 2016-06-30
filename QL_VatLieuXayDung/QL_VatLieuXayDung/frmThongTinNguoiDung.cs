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
using System.IO;

namespace QL_VatLieuXayDung
{
    public partial class frmThongTinNguoiDung : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        string manv;
        public frmThongTinNguoiDung()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }
        int so;
        public void loadlai()
        {
            cmd = new OleDbCommand("select DIENTHOAINV from T_NHAN_VIEN where MANV='" + manv + "'", conn);
            string d = (string)cmd.ExecuteScalar();
            txtsdt.Text = d;

            cmd = new OleDbCommand("select EMAILNV from T_NHAN_VIEN where MANV='" + manv + "'", conn);
            string f = (string)cmd.ExecuteScalar();
            txtemail.Text = f;
        }
        private void frmThongTinNguoiDung_Load(object sender, EventArgs e)
        {
            so = 0;
            manv = Program.mainForm.ma;
            conn.Open();
            lbma.Text = manv;
            cmd = new OleDbCommand("select TENNV from T_NHAN_VIEN where MANV='" + manv + "'", conn);
            string a = (string)cmd.ExecuteScalar();

            lbten.Text = a;         
            
            cmd = new OleDbCommand("select PHAI from T_NHAN_VIEN where MANV='" + manv + "'", conn);
            string b = (string)cmd.ExecuteScalar();
            lbgioitinh.Text = b;


            cmd = new OleDbCommand("select MANHOM from T_NHAN_VIEN where MANV='" + manv + "'", conn);
            string c = (string)cmd.ExecuteScalar();
           
            cmd = new OleDbCommand("select TENNHOM from T_NHOM_TAI_KHOAN where MANHOM='" + c + "'", conn);
            string c2 = (string)cmd.ExecuteScalar();
            lbchucvu.Text = c2;

            loadlai();
            
            try
            {
                string duongdan = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\hinhnhanvien\\" + manv + ".jpg";
                Stream s = File.Open(duongdan, FileMode.Open);
                Image hinh = Image.FromStream(s);
                s.Close();
                pictureBox1.Image = hinh;
            }
            catch
            {
                string duongdan2 = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\hinhnhanvien\\avatar.jpg";
                Stream s = File.Open(duongdan2, FileMode.Open);
                Image hinh = Image.FromStream(s);
                s.Close();
                pictureBox1.Image = hinh;

            }
            conn.Close();
        }

        private void btnSua_NV_Click(object sender, EventArgs e)
        {
            if (so == 0)
            {
                txtemail.Enabled = true;
                txtsdt.Enabled = true;
                so = 1;
                btnSua_NV.Text = "Lưu";
            }
            else 
            {
                if (this.txtemail.TextLength == 0 || txtsdt.Text == "")
                {
                    MessageBox.Show("Chưa nhập đầy đủ thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Update T_NHAN_VIEN set EMAILNV ='" + txtemail.Text + "', DIENTHOAINV='" + txtsdt.Text + "' where MANV='" + manv + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadlai();
                    so = 0;
                    btnSua_NV.Text = "Sửa";
                    txtemail.Enabled = false;
                    txtsdt.Enabled = false;
                    conn.Close();
                }
            }
        }
    }
}
