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
    public partial class frmNhaCungCap : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        System.Data.DataTable dt;
        OleDbCommand cmd;

        int luu = 0;
        public frmNhaCungCap()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void LoadTable()
        {
            btnThem_NCC.Enabled = true;
            btnLuu_NCC.Enabled = false;
            btnSua_NCC.Enabled = false;
            btnXoa_NCC.Enabled = false;
            adapter = new OleDbDataAdapter("select * from T_NHA_CUNG_CAP", conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvNCC.DataSource = dt;
            var source = new AutoCompleteStringCollection();
            foreach (DataRow i in dt.Rows)
                source.Add(i.Field<string>(1));
            txttimkiem.AutoCompleteCustomSource = source;
            luu = 0;
            groupBox1.Enabled = false;
            dgvNCC.Enabled = true;
            txtMaNCC_NCC.Clear();
            txtTenNCC_NCC.Clear();
            txtDienthoai_NCC.Clear();
            txtDiachi_NCC.Clear();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            conn.Open();
            LoadTable();
            conn.Close();
        }

        

        private void btnThem_NCC_Click(object sender, EventArgs e)
        {
            luu = 1;
            conn.Open();
            /// MA TU DONG
            string lenh = "select MANCC from T_NHA_CUNG_CAP order by MANCC desc";
            cmd = new OleDbCommand(lenh, conn);
            string macuoi = (string)cmd.ExecuteScalar();

            if (macuoi == null)
            {
                txtMaNCC_NCC.Text = "NCC0001";
            }
            else
            {
                int somacuoi = int.Parse(macuoi.Replace("NCC", ""));
                if (somacuoi < 9)
                    txtMaNCC_NCC.Text = "NCC000" + (somacuoi + 1);
                else if (somacuoi >= 9 && somacuoi < 99)
                    txtMaNCC_NCC.Text = "NCC00" + (somacuoi + 1);
                else if (somacuoi >= 99 && somacuoi < 999)
                    txtMaNCC_NCC.Text = "NCC0" + (somacuoi + 1);
                else
                    txtMaNCC_NCC.Text = "NCC" + (somacuoi + 1);
            }
            ////   
            conn.Close();
            groupBox1.Enabled = true;
            btnThem_NCC.Enabled = false;
            btnXoa_NCC.Enabled = false;
            btnSua_NCC.Enabled = false;
            btnLuu_NCC.Enabled = true;
            dgvNCC.Enabled = false;
            txtMaNCC_NCC.Enabled = false;
            txtTenNCC_NCC.Clear();
            txtTenNCC_NCC.Focus();
            txtDienthoai_NCC.Clear();
            txtDiachi_NCC.Clear();
        }

        

        private void btnXoa_NCC_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new OleDbCommand("Delete from T_NHA_CUNG_CAP where MANCC='" + txtMaNCC_NCC.Text + "'", conn);
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

        private void btnSua_NCC_Click(object sender, EventArgs e)
        {
            luu = 2;
            groupBox1.Enabled = true;
            txtTenNCC_NCC.Focus();
            btnThem_NCC.Enabled = false;
            btnXoa_NCC.Enabled = false;
            btnSua_NCC.Enabled = false;
            btnLuu_NCC.Enabled = true;
            dgvNCC.Enabled = false;
        }

        private void btnLuu_NCC_Click(object sender, EventArgs e)
        {
            if (luu == 1)
            {
                them();
                dgvNCC.Enabled = true;
            }
            else if (luu == 2)
            {
                sua();
                dgvNCC.Enabled = true;
            }
        }

        public void them()
        {
            if (this.txtTenNCC_NCC.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập tên nhà cung cấp");
                return;
            }
            else
            {
                conn.Open();
                cmd = new OleDbCommand("Insert into T_NHA_CUNG_CAP values('" + txtMaNCC_NCC.Text + "','" + txtTenNCC_NCC.Text + "','" + txtDiachi_NCC.Text + "','" + txtDienthoai_NCC.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable();
                conn.Close();
            }
        }

        public void sua()
        {
            if (this.txtTenNCC_NCC.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập tên nhà cung cấp !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Update T_NHA_CUNG_CAP set TENNCC='" + txtTenNCC_NCC.Text + "', DIACHI='" + txtDiachi_NCC.Text + "',DIENTHOAI='" + txtDienthoai_NCC.Text + "' where MANCC='" + txtMaNCC_NCC.Text + "'", conn);
                cmd.ExecuteNonQuery();
                LoadTable();
                MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void btnAsc_NCC_Click(object sender, EventArgs e)
        {
            dgvNCC.Sort(dgvNCC.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void btnDes_NCC_Click(object sender, EventArgs e)
        {
            dgvNCC.Sort(dgvNCC.Columns[0], System.ComponentModel.ListSortDirection.Descending);
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
            if (dgvNCC.Rows.Count <= 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Title = "Chọn đường dẫn lưu tệp excel";
                s.InitialDirectory = @"c:\";
                s.FileName = "Danh_sach_nha_cung_cap.xlsx";
                s.Filter = "Excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                s.FilterIndex = 2;
                s.RestoreDirectory = true;
                if (s.ShowDialog() == DialogResult.OK)
                {
                    xuatExcel(dgvNCC, s.FileName);
                    MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void loadThongtinkhichon(DataGridViewRow row)
        {
            try
            {
                conn.Open();
                txtMaNCC_NCC.Text = row.Cells[0].Value.ToString();
                txtTenNCC_NCC.Text = row.Cells[1].Value.ToString();
                txtDiachi_NCC.Text = row.Cells[2].Value.ToString();
                txtDienthoai_NCC.Text = row.Cells[3].Value.ToString();
                conn.Close();

            }
            catch
            {
                conn.Close();
            }
        }
        
        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            dgvNCC.CurrentRow.Selected = false;
            DataGridViewRow rowchon;
            adapter = new OleDbDataAdapter("select * from T_NHA_CUNG_CAP", conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            Boolean kq = false;
            dgvNCC.ClearSelection();

            if (e.KeyCode == Keys.Enter)
            {

                for (int i = 0; i < dgvNCC.Rows.Count; i++)
                {
                    if (dgvNCC.Rows[i].Cells[1].Value.ToString().ToLower() == txttimkiem.Text.ToLower())
                    {
                        dgvNCC.FirstDisplayedScrollingRowIndex = i;
                        kq = true;
                        dgvNCC.Rows[i].Selected = true;
                        rowchon = new DataGridViewRow();
                        rowchon = dgvNCC.Rows[i];
                        loadThongtinkhichon(rowchon);
                        break;
                    }
                }


                if (kq == false)
                    MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvNCC_Click(object sender, EventArgs e)
        {
            try
            {
                btnXoa_NCC.Enabled = true;
                btnSua_NCC.Enabled = true;
                loadThongtinkhichon(dgvNCC.CurrentRow);
            }
            catch
            {
            }
        }

        private void dgvNCC_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.ForeColor = Color.Gray;
            style1.BackColor = Color.LightBlue;
            for (int i = dgvNCC.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) dgvNCC.Rows[i].DefaultCellStyle = style1;
            }
        }
    }
}
