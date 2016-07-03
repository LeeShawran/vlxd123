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
    public partial class frmKhachHang : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        System.Data.DataTable dt;
        OleDbCommand cmd;
        int luu = 0;
        String phai = null;
        public frmKhachHang()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void LoadTable()
        {
            btnThem_KH.Enabled = true;
            btnLuu_KH.Enabled = false;
            btnSua_KH.Enabled = false;
            btnXoa_KH.Enabled = false;
            adapter = new OleDbDataAdapter("select * from T_KHACH_HANG", conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvKH.DataSource = dt;
            var source = new AutoCompleteStringCollection();
            foreach (DataRow i in dt.Rows)
                source.Add(i.Field<string>(1));
            txttimkiem.AutoCompleteCustomSource = source;
            luu = 0;
            groupBox1.Enabled = false;
            dgvKH.Enabled = true;
            txtMaKH_KH.Clear();
            txtTenKH_KH.Clear();
            txtCMND_KH.Clear();
            txtDiachi_KH.Clear();
            txtDienthoai_KH.Clear();
            txtGhichu_KH.Clear();
        }

        //public void Refresh_KH()
        //{
        //    conn.Open();
        //    OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_KHACH_HANG", conn);
        //    DataTable dt = new DataTable();
        //    adapter.Fill(dt);
        //    dgvKH.DataSource = dt;
        //    conn.Close();
        //}

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            conn.Open();
            LoadTable();
            conn.Close();
        }

        private void btnThem_KH_Click(object sender, EventArgs e)
        {
            luu = 1;
            conn.Open();
            /// MA TU DONG
            string lenh = "select MAKH from T_KHACH_HANG order by MAKH desc";
            cmd = new OleDbCommand(lenh, conn);
            string macuoi = (string)cmd.ExecuteScalar();

            if (macuoi == null)
            {
                txtMaKH_KH.Text = "KH0001";
            }
            else
            {
                int somacuoi = int.Parse(macuoi.Replace("KH", ""));
                if (somacuoi < 9)
                    txtMaKH_KH.Text = "KH000" + (somacuoi + 1);
                else if (somacuoi >= 9 && somacuoi < 99)
                    txtMaKH_KH.Text = "KH00" + (somacuoi + 1);
                else if (somacuoi >= 99 && somacuoi < 999)
                    txtMaKH_KH.Text = "KH0" + (somacuoi + 1);
                else
                    txtMaKH_KH.Text = "KH" + (somacuoi + 1);
            }
            ////   
            conn.Close();
            groupBox1.Enabled = true;
            btnThem_KH.Enabled = false;
            btnXoa_KH.Enabled = false;
            btnSua_KH.Enabled = false;
            btnLuu_KH.Enabled = true;
            dgvKH.Enabled = false;
            txtMaKH_KH.Enabled = false;
            txtTenKH_KH.Clear();
            txtTenKH_KH.Focus();
            txtCMND_KH.Clear();
            txtDiachi_KH.Clear();
            txtDienthoai_KH.Clear();
            txtGhichu_KH.Clear();
            
            
            //if (this.txtMaKH_KH.TextLength == 0 || this.txtTenKH_KH.TextLength == 0)
            //{
            //    MessageBox.Show("Bạn chưa nhập thông tin khách hàng !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            //}
            //else
            //{
            //    conn.Open();
            //    if (rdcNam_KH.Checked==true) phai="Nam"; else phai="Nữ";
            //    OleDbCommand cmd = new OleDbCommand("Insert into T_KHACH_HANG values('" + txtMaKH_KH.Text + "','" + txtTenKH_KH.Text + "','" + phai + "','" + txtCMND_KH.Text + "','" + txtDiachi_KH.Text + "','" + txtDienthoai_KH.Text + "','" + txtGhichu_KH.Text + "')", conn);
            //    if (Kiem_tra_khoa_chinh())
            //    {
            //        MessageBox.Show("Đã có mã khách hàng này !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else
            //    {
            //        cmd.ExecuteNonQuery();
            //        conn.Close();
            //        Refresh_KH();
            //        txtMaKH_KH.Clear();
            //        txtTenKH_KH.Clear();
            //        txtCMND_KH.Clear();
            //        txtDiachi_KH.Clear();
            //        txtDienthoai_KH.Clear();
            //        txtGhichu_KH.Clear();
            //    }
            //}
        }

        //private void dgvKH_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    try
        //    {
        //        DataGridViewRow row = new DataGridViewRow();
        //        row = dgvKH.Rows[e.RowIndex];
        //        txtMaKH_KH.Text = row.Cells[0].Value.ToString();
        //        txtTenKH_KH.Text = row.Cells[1].Value.ToString();
        //        if (row.Cells[1].Value.ToString() == "Nam")
        //        {
        //            rdcNam_KH.Checked = true;
        //        }
        //        else
        //        {
        //            rdcNu_KH.Checked = true;
        //        }
        //        txtDiachi_KH.Text = row.Cells[2].Value.ToString();
        //        txtDienthoai_KH.Text = row.Cells[3].Value.ToString();
        //        txtGhichu_KH.Text = row.Cells[4].Value.ToString();
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}

        private void btnXoa_KH_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new OleDbCommand("Delete from T_KHACH_HANG where MAKH='" + txtMaKH_KH.Text + "'", conn);
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

        private void btnSua_KH_Click(object sender, EventArgs e)
        {
            luu = 2;
            groupBox1.Enabled = true;
            txtTenKH_KH.Focus();
            btnThem_KH.Enabled = false;
            btnXoa_KH.Enabled = false;
            btnSua_KH.Enabled = false;
            btnLuu_KH.Enabled = true;
            dgvKH.Enabled = false;
        }

        private void btnLuu_KH_Click(object sender, EventArgs e)
        {
            if (luu == 1)
            {
                them();
                dgvKH.Enabled = true;
            }
            else if (luu == 2)
            {
                sua();
                dgvKH.Enabled = true;
            }
            
            //conn.Open();
            //if (rdcNam_KH.Checked == true) phai = "Nam"; else phai = "Nữ";
            //OleDbCommand cmd = new OleDbCommand("Update T_KHACH_HANG set TENKH='" + txtTenKH_KH.Text + "', PHAIKH='" + phai + "', CMNDKH='" + txtCMND_KH.Text + "', DIACHIKH='" + txtDiachi_KH.Text + "' , DTHOAIKH='"+ txtDienthoai_KH.Text+ "', GHICHUKH='"+txtGhichu_KH.Text+ "' where MAKH='" + txtMaKH_KH.Text + "'", conn);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //Refresh_KH();
            //txtMaKH_KH.Clear();
            //txtTenKH_KH.Clear();
            //txtCMND_KH.Clear();
            //txtDiachi_KH.Clear();
            //txtDienthoai_KH.Clear();
            //txtGhichu_KH.Clear();   
            //txtMaKH_KH.ReadOnly = false;
            //btnThem_KH.Enabled = true;
            //btnXoa_KH.Enabled = true;
            //btnSua_KH.Enabled = true;
            //btnLuu_KH.Enabled = false;
        }

        public void them()
        {
            if (this.txtMaKH_KH.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập tên khách hàng");
                return;
            }
            else if (this.txtCMND_KH.TextLength != 11 && this.txtCMND_KH.TextLength != 9)
            {
                MessageBox.Show("Độ dài số CMND không đúng");
                return;
            }
            else if (this.txtDienthoai_KH.TextLength != 11)
            {
                MessageBox.Show("Độ dài số điện thoại không đúng");
                return;
            }
            else
            {
                conn.Open();
                if (rdcNam_KH.Checked == true) phai = "Nam"; else phai = "Nữ";
                cmd = new OleDbCommand("Insert into T_KHACH_HANG values('" + txtMaKH_KH.Text + "','" + txtTenKH_KH.Text + "','" + phai + "','" + txtCMND_KH.Text + "','" + txtDiachi_KH.Text + "','" + txtDienthoai_KH.Text + "','" + txtGhichu_KH.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTable();
                conn.Close();
            }
        }

        public void sua()
        {
            if (this.txtMaKH_KH.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập tên khách hàng");
                return;
            }
            else if (this.txtCMND_KH.TextLength != 11 && this.txtCMND_KH.TextLength != 9)
            {
                MessageBox.Show("Độ dài số CMND không đúng");
                return;
            }
            else if (this.txtDienthoai_KH.TextLength != 11)
            {
                MessageBox.Show("Độ dài số điện thoại không đúng");
                return;
            }
            else
            {
                conn.Open();
                if (rdcNam_KH.Checked == true) phai = "Nam"; else phai = "Nữ";
                OleDbCommand cmd = new OleDbCommand("Update T_KHACH_HANG set TENKH='" + txtTenKH_KH.Text + "', PHAI='" + phai + "', CMND='" + txtCMND_KH.Text + "', DIACHI='" + txtDiachi_KH.Text + "' , DIENTHOAI='"+ txtDienthoai_KH.Text+ "', GHICHU='"+txtGhichu_KH.Text+ "' where MAKH='" + txtMaKH_KH.Text + "'", conn);
                cmd.ExecuteNonQuery();
                LoadTable();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void btnAsc_KH_Click(object sender, EventArgs e)
        {
            dgvKH.Sort(dgvKH.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void btnDes_KH_Click(object sender, EventArgs e)
        {
            dgvKH.Sort(dgvKH.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void bntLammoi_Click(object sender, EventArgs e)
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
            if (dgvKH.Rows.Count <= 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Title = "Chọn đường dẫn lưu tệp excel";
                s.InitialDirectory = @"c:\";
                s.FileName = "Danh_sach_khach_hang.xlsx";
                s.Filter = "Excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                s.FilterIndex = 2;
                s.RestoreDirectory = true;
                if (s.ShowDialog() == DialogResult.OK)
                {
                    xuatExcel(dgvKH, s.FileName);
                    MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        public void loadThongtinkhichon(DataGridViewRow row)
        {
            try
            {
                conn.Open();
                txtMaKH_KH.Text = row.Cells[0].Value.ToString();
                txtTenKH_KH.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString() == "Nam")
                {
                    rdcNam_KH.Checked = true;
                }
                else
                {
                    rdcNu_KH.Checked = true;
                }
                txtCMND_KH.Text = row.Cells[3].Value.ToString();
                txtDiachi_KH.Text = row.Cells[4].Value.ToString();
                txtDienthoai_KH.Text = row.Cells[5].Value.ToString();
                txtGhichu_KH.Text = row.Cells[6].Value.ToString();
                conn.Close();
            }
            catch
            {
                conn.Close();
            }
        }
        
        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            dgvKH.CurrentRow.Selected = false;
            DataGridViewRow rowchon;
            adapter = new OleDbDataAdapter("select * from T_KHACH_HANG", conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            Boolean kq = false;
            dgvKH.ClearSelection();

            if (e.KeyCode == Keys.Enter)
            {

                for (int i = 0; i < dgvKH.Rows.Count; i++)
                {
                    if (dgvKH.Rows[i].Cells[1].Value.ToString().ToLower() == txttimkiem.Text.ToLower())
                    {
                        dgvKH.FirstDisplayedScrollingRowIndex = i;
                        kq = true;
                        dgvKH.Rows[i].Selected = true;
                        rowchon = new DataGridViewRow();
                        rowchon = dgvKH.Rows[i];
                        loadThongtinkhichon(rowchon);
                        break;
                    }
                }


                if (kq == false)
                    MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvKH_Click(object sender, EventArgs e)
        {
            try
            {
                
                loadThongtinkhichon(dgvKH.CurrentRow);
                if (txtMaKH_KH.Text != "KH0000")
                {
                    groupBox1.Enabled = false;
                    btnXoa_KH.Enabled = true;
                    btnSua_KH.Enabled = true;
                }
                else
                {
                    groupBox1.Enabled = false;
                    btnXoa_KH.Enabled = false;
                    btnSua_KH.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void txtCMND_KH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true; 
        }

        private void txtDienthoai_KH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true; 
        }

        private void dgvKH_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.ForeColor = Color.Gray;
            style1.BackColor = Color.LightBlue;
            for (int i = dgvKH.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) dgvKH.Rows[i].DefaultCellStyle = style1;
            }
        }

    }
}
