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
    public partial class frmNhaSanXuat : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        System.Data.DataTable dt;
        OleDbCommand cmd;

        int luu = 0;
        public frmNhaSanXuat()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void LoadTable()
        {
            btnThem_NSX.Enabled = true;
            btnLuu_NSX.Enabled = false;
            btnSua_NSX.Enabled = false;
            btnXoa_NSX.Enabled = false;
            adapter = new OleDbDataAdapter("select * from T_NHA_SAN_XUAT", conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvNSX.DataSource = dt;
            var source = new AutoCompleteStringCollection();
            foreach (DataRow i in dt.Rows)
                source.Add(i.Field<string>(1));
            txttimkiem.AutoCompleteCustomSource = source;
            luu = 0;
            groupBox1.Enabled = false;
            dgvNSX.Enabled = true;
            txtMaNSX_NSX.Clear();
            txtTenNSX_NSX.Clear();
        }

        private void frmNhaSanXuat_Load(object sender, EventArgs e)
        {
            conn.Open();
            LoadTable();
            conn.Close();
        }

        private void btnThem_NSX_Click(object sender, EventArgs e)
        {
            luu = 1;
            conn.Open();
            /// MA TU DONG
            string lenh = "select MANSX from T_NHA_SAN_XUAT order by MANSX desc";
            cmd = new OleDbCommand(lenh, conn);
            string macuoi = (string)cmd.ExecuteScalar();
            
            if (macuoi == null)
            {
                txtMaNSX_NSX.Text = "NSX0001";
            }
            else
            {
                int somacuoi = int.Parse(macuoi.Replace("NSX", ""));
                if (somacuoi < 9)
                    txtMaNSX_NSX.Text = "NSX000" + (somacuoi + 1);
                else if (somacuoi >= 9 && somacuoi < 99)
                    txtMaNSX_NSX.Text = "NSX00" + (somacuoi + 1);
                else if (somacuoi >= 99 && somacuoi < 999)
                    txtMaNSX_NSX.Text = "NSX0" + (somacuoi + 1);
                else
                    txtMaNSX_NSX.Text = "NSX" + (somacuoi + 1);
            }
            ////   
            conn.Close();
            groupBox1.Enabled = true;
            btnThem_NSX.Enabled = false;
            btnXoa_NSX.Enabled = false;
            btnSua_NSX.Enabled = false;
            btnLuu_NSX.Enabled = true;
            dgvNSX.Enabled = false;
            txtMaNSX_NSX.Enabled = false;
            txtTenNSX_NSX.Clear();
            txtTenNSX_NSX.Focus();
        }

        

        private void btnXoa_NSX_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new OleDbCommand("Delete from T_NHA_SAN_XUAT where MANSX='" + txtMaNSX_NSX.Text + "'", conn);
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

        private void btnSua_NSX_Click(object sender, EventArgs e)
        {
            luu = 2;
            groupBox1.Enabled = true;
            txtTenNSX_NSX.Focus();
            btnThem_NSX.Enabled = false;
            btnXoa_NSX.Enabled = false;
            btnSua_NSX.Enabled = false;
            btnLuu_NSX.Enabled = true;
            dgvNSX.Enabled = false;
        }

        private void btnLuu_NSX_Click(object sender, EventArgs e)
        {
            if (luu == 1)
            {
                them();
                dgvNSX.Enabled = true;
            }
            else if (luu == 2)
            {
                sua();
                dgvNSX.Enabled = true;
            }
        }

        public void them()
        {
            if (this.txtTenNSX_NSX.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập tên nhà sản xuất");
                return;
            }
            else
            {
                conn.Open();
                cmd = new OleDbCommand("Insert into T_NHA_SAN_XUAT values('" + txtMaNSX_NSX.Text + "','" + txtTenNSX_NSX.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable();
                conn.Close();
            }
        }

        public void sua()
        {
            if (this.txtTenNSX_NSX.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập tên nhà sản xuất !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Update T_NHA_SAN_XUAT set TENNSX='" + txtTenNSX_NSX.Text + "' where MANSX='" + txtMaNSX_NSX.Text + "'", conn);
                cmd.ExecuteNonQuery();
                LoadTable();
                MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }         
        }

        private void btnAsc_NSX_Click(object sender, EventArgs e)
        {
            dgvNSX.Sort(dgvNSX.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void btnDes_NSX_Click(object sender, EventArgs e)
        {
            dgvNSX.Sort(dgvNSX.Columns[0], System.ComponentModel.ListSortDirection.Descending);
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
            if (dgvNSX.Rows.Count <= 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Title = "Chọn đường dẫn lưu tệp excel";
                s.InitialDirectory = @"c:\";
                s.FileName = "Danh_sach_nha_san_xuat.xlsx";
                s.Filter = "Excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                s.FilterIndex = 2;
                s.RestoreDirectory = true;
                if (s.ShowDialog() == DialogResult.OK)
                {
                    xuatExcel(dgvNSX, s.FileName);
                    MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void loadThongtinkhichon(DataGridViewRow row)
        {
            try
            {
                conn.Open();
                txtMaNSX_NSX.Text = row.Cells[0].Value.ToString();
                txtTenNSX_NSX.Text = row.Cells[1].Value.ToString();
                conn.Close();

            }
            catch
            {
                conn.Close();
            }
        }

        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            dgvNSX.CurrentRow.Selected = false;
            DataGridViewRow rowchon;
            adapter = new OleDbDataAdapter("select * from T_NHA_SAN_XUAT", conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            Boolean kq = false;
            dgvNSX.ClearSelection();

            if (e.KeyCode == Keys.Enter)
            {

                for (int i = 0; i < dgvNSX.Rows.Count; i++)
                {
                    if (dgvNSX.Rows[i].Cells[1].Value.ToString().ToLower() == txttimkiem.Text.ToLower())
                    {
                        dgvNSX.FirstDisplayedScrollingRowIndex = i;
                        kq = true;
                        dgvNSX.Rows[i].Selected = true;
                        rowchon = new DataGridViewRow();
                        rowchon = dgvNSX.Rows[i];
                        loadThongtinkhichon(rowchon);
                        break;
                    }
                }


                if (kq == false)
                    MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvNSX_Click(object sender, EventArgs e)
        {
            try
            {
                btnXoa_NSX.Enabled = true;
                btnSua_NSX.Enabled = true;
                loadThongtinkhichon(dgvNSX.CurrentRow);
            }
            catch
            {
            }
        }


    }
}
