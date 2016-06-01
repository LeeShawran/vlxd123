using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_VatLieuXayDung
{
    public partial class frmCauHinh : Form
    {
        public frmCauHinh()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Connect.Check_ketnoi(cbSVname.Text, txtId.Text, txtPass.Text) == 0)
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp, vui lòng nhập lại","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                //txtId.Clear();
                //txtPass.Clear();
                //cbSVname.Text = "";
            }
            else
            {
                Connect.setConnect(cbSVname.Text, txtId.Text, txtPass.Text);
                MessageBox.Show("Thay đổi chuỗi kết nối thành công ! Ứng dụng sẽ khởi động lại", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Application.Exit();
                Application.Restart();
            }
        }
    }
}
