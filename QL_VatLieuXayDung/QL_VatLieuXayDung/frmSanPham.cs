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
    public partial class frmSanPham : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        DataTable dt;
        OleDbCommand cmd;

        int luu = 0;
        public frmSanPham()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void loadNCC()
        {
            string st = "select * from T_NHA_CUNG_CAP";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            cbNhaCC.DataSource = dt;
            cbNhaCC.DisplayMember = "TENNCC";
            cbNhaCC.ValueMember = "MANCC";
        }
        public void loadLoai()
        {
            string st = "select * from T_LOAI_SP";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            cbLoai.DataSource = dt;
            cbLoai.DisplayMember = "TENLOAI";
            cbLoai.ValueMember = "MALOAI";
        }
        public void loadNSX()
        {
            string st = "select * from T_NHA_SAN_XUAT";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            cbNhaSX.DataSource = dt;
            cbNhaSX.DisplayMember = "TENNSX";
            cbNhaSX.ValueMember = "MANSX";
        }

        public void loadTable()
        {
            adapter = new OleDbDataAdapter("select * from T_SAN_PHAM", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvSanPham.DataSource = dt;

            if (dt.Rows.Count < 100)
                txtMaSP.Text = "SP000" + (dt.Rows.Count + 1);
            else if (dt.Rows.Count < 10)
                txtMaSP.Text = "SP00" + (dt.Rows.Count + 1);
            else txtMaSP.Text = "SP0" + (dt.Rows.Count + 1);
            loadLoai();
            loadNCC();
            loadNSX();

            luu = 0;
            groupBox1.Enabled = false;

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            dgvSanPham.Enabled = true;

            txtMaSP.Clear();
            txtTenSP.Clear();
            txtSoluong.Clear();
            txtDongianhap.Clear(); 
            cbLoai.DisplayMember = cbLoai.Items[0].ToString();
            cbNhaCC.DisplayMember = cbNhaCC.Items[0].ToString();
            cbNhaSX.DisplayMember = cbNhaSX.Items[0].ToString();


        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            conn.Open();
            loadTable();
            conn.Close();
            btnLuu.Enabled = false;
        }


        private bool Kiem_tra_khoa_chinh()
        {
            bool tatkt = false;
            string MaSP = txtMaSP.Text;
            OleDbCommand cmd = new OleDbCommand("select * from T_SAN_PHAM", conn);
            OleDbDataReader PK = cmd.ExecuteReader();
            while (PK.Read())
            {
                if (MaSP == PK.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            return tatkt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            luu = 1;
            conn.Open();
            adapter = new OleDbDataAdapter("select * from T_SAN_PHAM", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count < 100)
                txtMaSP.Text = "SP000" + (dt.Rows.Count + 1);
            else if (dt.Rows.Count < 10)
                txtMaSP.Text = "SP00" + (dt.Rows.Count + 1);
            else txtMaSP.Text = "SP0" + (dt.Rows.Count + 1);
            conn.Close();
            groupBox1.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            dgvSanPham.Enabled = false;
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            luu = 2;
            groupBox1.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            dgvSanPham.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            conn.Open();
            if (luu == 1)
            {
                them();
                dgvSanPham.Enabled = true;
            }
            else if (luu == 2)
            {
                sua();
                dgvSanPham.Enabled = true;
            }
  
           
            conn.Close();
        }

        public void them()
        {
            if (this.txtMaSP.TextLength == 0 || this.txtMaSP.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập thông tin sản phẩm");
                return;
            }
            else
            {
                cmd = new OleDbCommand("Insert into T_SAN_PHAM values('" + txtMaSP.Text + "','" + txtTenSP.Text + "','" + cbLoai.SelectedValue.ToString() + "','" + cbNhaSX.SelectedValue.ToString() + "','" + cbNhaCC.SelectedValue.ToString() + "'," + 0 + "," + 0 + ")", conn);
                if (Kiem_tra_khoa_chinh())
                {
                    MessageBox.Show("Đã có mã sản phẩm này");
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
            if (this.txtMaSP.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập thông tin sản phẩm");
                return;
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand("Update T_SAN_PHAM set TENSP='" + txtTenSP.Text + "', MALOAI ='" + cbLoai.SelectedValue.ToString() + "', MANSX='" + cbNhaSX.SelectedValue.ToString() + "', MANCC='" + cbNhaCC.SelectedValue.ToString() + "' where MASP='" + txtMaSP.Text + "'", conn);
                cmd.ExecuteNonQuery();
                loadTable();
            }
           
        }
        private void dgvSanPham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new OleDbCommand("Delete from T_SAN_PHAM where MASP='" + txtMaSP.Text + "'", conn);
            cmd.ExecuteNonQuery();

            loadTable();
            conn.Close();
        }

        private void bntLammoi_Click(object sender, EventArgs e)
        {
            conn.Open();
            loadTable();
            conn.Close();
        }

        private void dgvSanPham_Click(object sender, EventArgs e)
        {
            conn.Open();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
     
                DataGridViewRow row = new DataGridViewRow();
                row = dgvSanPham.CurrentRow;

                cmd = new OleDbCommand("select TENLOAI from T_LOAI_SP where MALOAI='" + row.Cells[2].Value.ToString() + "'", conn);
                string tenloai = (string)cmd.ExecuteScalar();

                cmd = new OleDbCommand("select TENNSX from T_NHA_SAN_XUAT where MANSX='" + row.Cells[3].Value.ToString() + "'", conn);
                string tenNSX = (string)cmd.ExecuteScalar();

                cmd = new OleDbCommand("select TENNCC from T_NHA_CUNG_CAP where MANCC='" + row.Cells[4].Value.ToString() + "'", conn);
                string tenNCC = (string)cmd.ExecuteScalar();


                txtMaSP.Text = row.Cells[0].Value.ToString();
                txtTenSP.Text = row.Cells[1].Value.ToString();
                cbLoai.Text = tenloai;
                cbNhaSX.Text = tenNSX;
                cbNhaCC.Text = tenNCC;
                txtSoluong.Text = row.Cells[5].Value.ToString();

                string lenh1 = "select DONGIANHAP from T_GIA_NHAP where MASP='SP0001' ORDER BY NGAYAPDUNG desc";
                OleDbCommand cmd1 = new OleDbCommand(lenh1, conn);
                int a = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
                txtDongianhap.Text = "" + a;
                conn.Close();
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
