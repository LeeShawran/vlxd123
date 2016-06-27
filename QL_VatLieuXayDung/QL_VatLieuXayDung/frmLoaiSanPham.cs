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
    public partial class frmLoaiSanPham : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        System.Data.DataTable dt;
        OleDbCommand cmd;

        int luu = 0;
        public frmLoaiSanPham()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void LoadTable()
        {
            btnThem_LoaiSP.Enabled = true;
            btnLuu_LoaiSP.Enabled = false;
            btnSua_LoaiSP.Enabled = false;
            btnXoa_LoaiSP.Enabled = false;
            adapter = new OleDbDataAdapter("select * from T_LOAI_SP", conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvLoaiSP.DataSource = dt;
            var source = new AutoCompleteStringCollection();
            foreach (DataRow i in dt.Rows)
                source.Add(i.Field<string>(1));
            txttimkiem.AutoCompleteCustomSource = source;
            luu = 0;
            groupBox1.Enabled = false;
            dgvLoaiSP.Enabled = true;
            txtMaLoai.Clear();
            txtTenLoai.Clear();
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            conn.Open();
            LoadTable();
            conn.Close();
        }

        private void btnThem_LoaiSP_Click(object sender, EventArgs e)
        {
            luu = 1;
            conn.Open();
            /// MA TU DONG
            string lenh = "select MALOAI from T_LOAI_SP order by MALOAI desc";
            cmd = new OleDbCommand(lenh, conn);
            string macuoi = (string)cmd.ExecuteScalar();
            
            if (macuoi == null)
            {
                txtMaLoai.Text = "LSP0001";
            }
            else
            {
                int somacuoi = int.Parse(macuoi.Replace("LSP", ""));
                if (somacuoi < 9)
                    txtMaLoai.Text = "LSP000" + (somacuoi + 1);
                else if (somacuoi >= 9 && somacuoi < 99)
                    txtMaLoai.Text = "LSP00" + (somacuoi + 1);
                else if (somacuoi >= 99 && somacuoi < 999)
                    txtMaLoai.Text = "LSP0" + (somacuoi + 1);
                else
                    txtMaLoai.Text = "LSP" + (somacuoi + 1);
            }
            ////   
            conn.Close();
            groupBox1.Enabled = true;
            btnThem_LoaiSP.Enabled = false;
            btnXoa_LoaiSP.Enabled = false;
            btnSua_LoaiSP.Enabled = false;
            btnLuu_LoaiSP.Enabled = true;
            dgvLoaiSP.Enabled = false;
            txtMaLoai.Enabled = false;
            txtTenLoai.Clear();
            txtTenLoai.Focus();
        }

        private void btnXoa_LoaiSP_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new OleDbCommand("Delete from T_LOAI_SP where MALOAI='" + txtMaLoai.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Không thể xóa sản phẩm này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void btnSua_LoaiSP_Click(object sender, EventArgs e)
        {
            luu = 2;
            groupBox1.Enabled = true;
            txtTenLoai.Focus();
            btnThem_LoaiSP.Enabled = false;
            btnXoa_LoaiSP.Enabled = false;
            btnSua_LoaiSP.Enabled = false;
            btnLuu_LoaiSP.Enabled = true;
            dgvLoaiSP.Enabled = false;
        }

        private void btnLuu_LoaiSP_Click(object sender, EventArgs e)
        {
            if (luu == 1)
            {
                them();
                dgvLoaiSP.Enabled = true;
            }
            else if (luu == 2)
            {
                sua();
                dgvLoaiSP.Enabled = true;
            }
        }

        public void them()
        {
            if (this.txtTenLoai.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập tên nhà sản xuất");
                return;
            }
            else
            {
                conn.Open();
                cmd = new OleDbCommand("Insert into T_LOAI_SP values('" + txtMaLoai.Text + "','" + txtTenLoai.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable();
                conn.Close();
            }
        }

        public void sua()
        {
            if (this.txtTenLoai.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập tên sản phẩm");
                return;
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Update T_LOAI_SP set TENLOAI='" + txtTenLoai.Text + "' where MALOAI='" + txtMaLoai.Text + "'", conn);
                cmd.ExecuteNonQuery();
                LoadTable();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void btnAsc_LoaiSP_Click(object sender, EventArgs e)
        {
            dgvLoaiSP.Sort(dgvLoaiSP.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void btnDes_LoaiSP_Click(object sender, EventArgs e)
        {
            dgvLoaiSP.Sort(dgvLoaiSP.Columns[0], System.ComponentModel.ListSortDirection.Descending);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            conn.Open();
            LoadTable();
            conn.Close();
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

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.Title = "Chọn đường dẫn lưu tệp excel";
            s.InitialDirectory = @"c:\";
            s.FileName = "Danh_sach_loai_san_pham.xlsx";
            s.Filter = "Excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            s.FilterIndex = 2;
            s.RestoreDirectory = true;
            if (s.ShowDialog() == DialogResult.OK)
            {
                xuatExcel(dgvLoaiSP, s.FileName);
                MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void loadThongtinkhichon(DataGridViewRow row)
        {
            try
            {
                conn.Open();
                txtMaLoai.Text = row.Cells[0].Value.ToString();
                txtTenLoai.Text = row.Cells[1].Value.ToString();
                conn.Close();

            }
            catch
            {
                conn.Close();
            }
        }

        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            dgvLoaiSP.CurrentRow.Selected = false;
            DataGridViewRow rowchon;
            adapter = new OleDbDataAdapter("select * from T_LOAI_SP", conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            Boolean kq = false;
            dgvLoaiSP.ClearSelection();

            if (e.KeyCode == Keys.Enter)
            {

                for (int i = 0; i < dgvLoaiSP.Rows.Count; i++)
                {
                    if (dgvLoaiSP.Rows[i].Cells[1].Value.ToString().ToLower() == txttimkiem.Text.ToLower())
                    {
                        dgvLoaiSP.FirstDisplayedScrollingRowIndex = i;
                        kq = true;
                        dgvLoaiSP.Rows[i].Selected = true;
                        rowchon = new DataGridViewRow();
                        rowchon = dgvLoaiSP.Rows[i];
                        loadThongtinkhichon(rowchon);
                        break;
                    }
                }


                if (kq == false)
                    MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvLoaiSP_Click(object sender, EventArgs e)
        {
            try
            {
                btnXoa_LoaiSP.Enabled = true;
                btnSua_LoaiSP.Enabled = true;
                loadThongtinkhichon(dgvLoaiSP.CurrentRow);
            }
            catch
            {
            }
        }


    }
}
