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
    public partial class frmDinhGia : Form
    {

        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable dt;
        OleDbCommand cmd;
        int abc;
        public frmDinhGia()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }
        public void load_lai()
        {
            string s = "select T_SAN_PHAM.MASP,TENSP from T_SAN_PHAM,T_GIA_NHAP where T_SAN_PHAM.MASP=T_GIA_NHAP.MASP AND T_GIA_NHAP.NGAYAPDUNG =(SELECT MAX(T_GIA_NHAP.NGAYAPDUNG) FROM  T_GIA_NHAP WHERE T_GIA_NHAP.NGAYAPDUNG <=(SYSDATE) and T_SAN_PHAM.MASP=T_GIA_NHAP.MASP) order by T_SAN_PHAM.MASP ASC";
            adapter = new OleDbDataAdapter(s, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvGia.DataSource = dt;

            button1.Enabled = false;
        }
        private void frmDinhGia_Load(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            txtNgayLap.Format = DateTimePickerFormat.Custom;
            txtNgayLap.CustomFormat = "dd/MM/yyyy";

            load_lai();
            conn.Close();         
        }

        private void dgvGia_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            txtMaSP.Text=dgvGia.CurrentRow.Cells[0].Value.ToString();
            txtTenSP.Text=dgvGia.CurrentRow.Cells[1].Value.ToString();
            conn.Open();
            // lay gia nhap
            string lenh1 = "select DONGIANHAP from T_GIA_NHAP where MASP='"+txtMaSP.Text+"' ORDER BY NGAYAPDUNG desc";
            OleDbCommand cmd1 = new OleDbCommand(lenh1, conn);
            int a = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
            txtGiaNhap.Text = "" + a;

            //kiem tra co gia ban nao chua

            string lenh2 = "select count(*) from T_GIA_BAN where MASP='" + txtMaSP.Text + "' ORDER BY NGAYHIEULUC desc";
            OleDbCommand cmd2 = new OleDbCommand(lenh2, conn);
            abc = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
            if (abc == 0)
            {
                txtGiaBan.Text = "" + 0;
            }
            else 
            {
                string lenh3 = "select DONGIABAN from T_GIA_BAN where MASP='" + txtMaSP.Text + "' ORDER BY NGAYHIEULUC desc";
                OleDbCommand cmd3 = new OleDbCommand(lenh3, conn);
                int b = Convert.ToInt32(cmd3.ExecuteScalar().ToString());
                txtGiaBan.Text = "" + b;
            }
            // hien thi gia ban
          
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            
            if (abc == 0)
            {
                string lenh4 = "Insert into T_GIA_BAN values('" + txtMaSP.Text + "',TO_DATE('" + txtNgayLap.Text + "','DD-MM-RR')," + txtGiaBan.Text + ")";
                OleDbCommand cmd4 = new OleDbCommand(lenh4, conn);
                cmd4.ExecuteNonQuery();
                MessageBox.Show("Cập nhật giá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_lai(); conn.Close();

            }
            else 
            {
                //cmd = new OleDbCommand("select NGAYHIEULUC from T_GIA_BAN where MASP='" + txtMaSP.Text + "'", conn);
                //string ngay = cmd.ExecuteScalar().ToString();
                //MessageBox.Show(ngay + "");
                string lenh5 = "Update T_GIA_BAN set DONGIABAN=" + float.Parse(txtGiaBan.Text) + ", NGAYHIEULUC=TO_DATE('" + txtNgayLap.Text + "','DD-MM-RR') where MASP='" + txtMaSP.Text + "' and T_GIA_BAN.NGAYHIEULUC =(SELECT MAX(T_GIA_BAN.NGAYHIEULUC) FROM  T_GIA_BAN WHERE T_GIA_BAN.NGAYHIEULUC <=(SYSDATE) and MASP='"+txtMaSP.Text+"')";
                OleDbCommand cmd5 = new OleDbCommand(lenh5, conn);
                cmd5.ExecuteNonQuery();
                MessageBox.Show("Cập nhật giá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_lai();
                conn.Close();
            }

            button1.Enabled = false;
            conn.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                float giaban = float.Parse(txtGiaNhap.Text) + (float.Parse(txtGiaNhap.Text) * float.Parse(txtLai.Text) / 100);
                txtGiaBan.Text = giaban.ToString();
            }
            catch { }
            
        }

        private void txtLai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true; 
        }

        private void dgvGia_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.ForeColor = Color.Gray;
            style1.BackColor = Color.LightBlue;
            for (int i = dgvGia.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) dgvGia.Rows[i].DefaultCellStyle = style1;
            }
        }
    }
}
