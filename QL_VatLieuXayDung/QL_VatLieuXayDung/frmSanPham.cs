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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace QL_VatLieuXayDung
{
    public partial class frmSanPham : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        System.Data.DataTable dt;
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
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            cbNhaCC.DataSource = dt;
            cbNhaCC.DisplayMember = "TENNCC";
            cbNhaCC.ValueMember = "MANCC";
        }
        public void loadLoai()
        {
            string st = "select * from T_LOAI_SP";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            cbLoai.DataSource = dt;
            cbLoai.DisplayMember = "TENLOAI";
            cbLoai.ValueMember = "MALOAI";
        }
        public void loadNSX()
        {
            string st = "select * from T_NHA_SAN_XUAT";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            cbNhaSX.DataSource = dt;
            cbNhaSX.DisplayMember = "TENNSX";
            cbNhaSX.ValueMember = "MANSX";
        }

       
        public void loadTable()
        {

            loadLoai();
            loadNCC();
            loadNSX();
   
            adapter = new OleDbDataAdapter("select * from T_SAN_PHAM", conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvSanPham.DataSource = dt;
            var source = new AutoCompleteStringCollection();
            foreach (DataRow i in dt.Rows)
                source.Add(i.Field<string>(1));
            txttimkiem.AutoCompleteCustomSource = source;

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
            txtDonGiaBan.Clear();
            txttimkiem.Clear();
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
            conn.Close();
            conn.Open();
            /// MA TU DONG
            string lenh = "select MASP from T_SAN_PHAM order by MASP desc";
            cmd = new OleDbCommand(lenh, conn);
            string macuoi = (string)cmd.ExecuteScalar();
            
            if (macuoi == null)
            {
                txtMaSP.Text = "SP0001";
            }
            else
            {
                int somacuoi = int.Parse(macuoi.Replace("SP", ""));
                if (somacuoi < 9)
                    txtMaSP.Text = "SP000" + (somacuoi + 1);
                else if (somacuoi >= 9 && somacuoi < 99)
                    txtMaSP.Text = "SP00" + (somacuoi + 1);
                else if (somacuoi >= 99 && somacuoi < 999)
                    txtMaSP.Text = "SP0" + (somacuoi + 1);
                else
                    txtMaSP.Text = "SP" + (somacuoi + 1);
            }
            ////   
            conn.Close();
            groupBox1.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            dgvSanPham.Enabled = false;
            txtTenSP.Clear();
            txtSoluong.Clear();
            txtDongianhap.Clear();
            txtDonGiaBan.Clear();
            txttimkiem.Clear();

            cbLoai.DisplayMember = cbLoai.Items[0].ToString();
            cbNhaCC.DisplayMember = cbNhaCC.Items[0].ToString();
            cbNhaSX.DisplayMember = cbNhaSX.Items[0].ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            luu = 2;
            groupBox1.Enabled = true;
            txtTenSP.Focus();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            dgvSanPham.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
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
        }

        public void them()
        {
            if (this.txtTenSP.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập tên sản phẩm");
                return;
            }
            else
            {
                conn.Open();
                cmd = new OleDbCommand("Insert into T_SAN_PHAM values('" + txtMaSP.Text + "','" + txtTenSP.Text + "','" + cbLoai.SelectedValue.ToString() + "','" + cbNhaSX.SelectedValue.ToString() + "','" + cbNhaCC.SelectedValue.ToString() + "'," + 0 + ")", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadTable();
                conn.Close();
            }
        }
        public void sua()
        {
            if (this.txtTenSP.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập tên sản phẩm");
                return;
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Update T_SAN_PHAM set TENSP='" + txtTenSP.Text + "', MALOAI ='" + cbLoai.SelectedValue.ToString() + "', MANSX='" + cbNhaSX.SelectedValue.ToString() + "', MANCC='" + cbNhaCC.SelectedValue.ToString() + "' where MASP='" + txtMaSP.Text + "'", conn);
                cmd.ExecuteNonQuery();
                loadTable();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
           
        }
        private void dgvSanPham_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new OleDbCommand("Delete from T_SAN_PHAM where MASP='" + txtMaSP.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadTable();
                conn.Close();
            }
            catch 
            {
                MessageBox.Show("Không thể xóa sản phẩm này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
         
        }

        private void bntLammoi_Click(object sender, EventArgs e)
        {
            conn.Open();
            loadTable();
            conn.Close();
        }

        public void loadThongtinkhichon(DataGridViewRow row)
        {       
            try
            {
                conn.Open();
               
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

                try
                {
                    string lenh1 = "select DONGIANHAP from T_GIA_NHAP where MASP='" + dgvSanPham.CurrentRow.Cells[0].Value.ToString() + "' ORDER BY NGAYAPDUNG desc";
                    OleDbCommand cmd1 = new OleDbCommand(lenh1, conn);
                    int a = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
                    txtDongianhap.Text = "" + a;
                }
                catch
                {
                    txtDongianhap.Text = "" + 0;
                }

                try
                {
                    string lenh2 = "select DONGIABAN from T_GIA_BAN where MASP='" + dgvSanPham.CurrentRow.Cells[0].Value.ToString() + "' ORDER BY NGAYHIEULUC desc";
                    OleDbCommand cmd2 = new OleDbCommand(lenh2, conn);
                    int b = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
                    txtDonGiaBan.Text = "" + b;
                }
                catch
                {
                    txtDonGiaBan.Text = "" + 0;
                }
               
                conn.Close(); 
 
            }
            catch
            {
                conn.Close();
            }
        }
        private void dgvSanPham_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            loadThongtinkhichon(dgvSanPham.CurrentRow);
        }

        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            dgvSanPham.CurrentRow.Selected = false;
            DataGridViewRow rowchon;
            adapter = new OleDbDataAdapter("select * from T_SAN_PHAM", conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            Boolean kq=false;
            dgvSanPham.ClearSelection();

            if (e.KeyCode == Keys.Enter)
            {

                for (int i = 0; i < dgvSanPham.Rows.Count; i++)
                {
                    if (dgvSanPham.Rows[i].Cells[1].Value.ToString().ToLower() == txttimkiem.Text.ToLower())
                    {
                        dgvSanPham.FirstDisplayedScrollingRowIndex = i;
                        kq = true;
                        dgvSanPham.Rows[i].Selected = true;
                        rowchon = new DataGridViewRow();
                        rowchon = dgvSanPham.Rows[i];
                        loadThongtinkhichon(rowchon);
                        break;
                    }
                }
               

                if (kq == false)
                    MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
        }

        private void btnAsc_LoaiSP_Click(object sender, EventArgs e)
        {
            dgvSanPham.Sort(dgvSanPham.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void btnDes_LoaiSP_Click(object sender, EventArgs e)
        {
            dgvSanPham.Sort(dgvSanPham.Columns[0], System.ComponentModel.ListSortDirection.Descending);
        }

        private void xuatExcel(DataGridView g, string duongDan)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan);
            obj.ActiveWorkbook.Saved = true;
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.Rows.Count <= 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Title = "Chọn đường dẫn lưu tệp excel";
                s.InitialDirectory = @"c:\";
                s.FileName = "sanpham.xlsx";
                s.Filter = "Excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                s.FilterIndex = 2;
                s.RestoreDirectory = true;
                if (s.ShowDialog() == DialogResult.OK)
                {
                    xuatExcel(dgvSanPham, s.FileName);
                    MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.ForeColor = Color.Gray;
            style1.BackColor = Color.LightBlue;
            for (int i = dgvSanPham.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) dgvSanPham.Rows[i].DefaultCellStyle = style1;
            }
        }

    }
}
