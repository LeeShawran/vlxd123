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
    public partial class frmThongKeSanPham : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        OleDbCommand cmd;
        DataTable dt;
        public frmThongKeSanPham()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void kt_kieu_thong_ke()
        {
            if (radNgay.Checked == true)
            {
                groupBoxNgay.Enabled = true;
                groupBoxThang.Enabled = false;
                groupBoxThoigian.Enabled = false;
            }
            else if (radThang.Checked == true)
            {
                groupBoxNgay.Enabled = false;
                groupBoxThang.Enabled = true;
                groupBoxThoigian.Enabled = false;
            }
            else if (radThoiGian.Checked == true)
            {
                groupBoxNgay.Enabled = false;
                groupBoxThang.Enabled = false;
                groupBoxThoigian.Enabled = true;
            }
        }
        public void load_SanPham()
        {
            string st = "select * from T_SAN_PHAM order by MASP ASC";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvSanPham.DataSource = dt;
        }

        int laytongnhap(string masp)
        {
            int tong = 0;
            adapter = new OleDbDataAdapter("select SOLUONG from T_CT_PHIEU_NHAP,T_PHIEU_NHAP where NGAYLAP=TO_DATE('" + dtpNgay.Text + "','DD-MM-RR') AND MASP='" + masp + "'", conn);
            dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow i in dt.Rows)
                tong += i.Field<int>(0);
           
            return tong;


        }
        int laytongban(string masp)
        {
            int tong = 0;
            adapter = new OleDbDataAdapter("select SOLUONGBAN from T_CT_HOA_DON, T_HOA_DON where NGAYHD=TO_DATE('" + dtpNgay.Text + "','DD-MM-RR') AND MASP='" + masp + "'", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow i in dt.Rows)
                tong += i.Field<int>(0);
            //MessageBox.Show("" + tong);
            return tong;


        }
        private void frmThongKeSanPham_Load(object sender, EventArgs e)
        {
            conn.Open();
            btnThongke.Enabled = false;
            kt_kieu_thong_ke();
            load_SanPham();
            conn.Close();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            txtnhap.Text = laytongnhap(dgvSanPham.CurrentRow.Cells[0].Value.ToString()) + "";
            txtban.Text = laytongban(dgvSanPham.CurrentRow.Cells[0].Value.ToString()) + "";
            txttonkho.Text = dgvSanPham.CurrentRow.Cells["soluong"].Value.ToString() + "";
        }

        private void dgvSanPham_Click(object sender, EventArgs e)
        {
            btnThongke.Enabled = true;
        }
    }
}
