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
    public partial class frmNhanVien : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        System.Data.DataTable dt;
        OleDbCommand cmd;
        String phai = null;

        int luu = 0;
        public frmNhanVien()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }
     
        public void loadLai()
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_NHAN_VIEN", conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvNV.DataSource = dt;
           
        }

        private bool Kiem_tra_khoa_chinh()
        {
            bool tatkt = false;
            string MaNV = txtMaNV.Text;
            OleDbCommand cmd = new OleDbCommand("select * from T_NHAN_VIEN", conn);
            OleDbDataReader PK = cmd.ExecuteReader();
            while (PK.Read())
            {
                if (MaNV == PK.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            return tatkt;
        }

        private void cmbChucvu_NV_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            conn.Open();
            loadTable();
            OleDbCommand cmd = new OleDbCommand("select TENNV from T_NHAN_VIEN where MANV='NV0002'", conn);
            string tennhom = (string)cmd.ExecuteScalar();
            conn.Close();
        }

        private void dgvNV_Click(object sender, EventArgs e)
        {
            conn.Open();
            DataGridViewRow row = new DataGridViewRow();
            row = dgvNV.CurrentRow;
            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtTenNV.Text = row.Cells[1].Value.ToString();
            txtEmail.Text = row.Cells[2].Value.ToString();
            if (row.Cells[3].Value.ToString() == "Nam")
            {
                rdcNam.Checked = true;
            }
            else
            {
                rdcNu.Checked = true;
            }
     
            txtDienthoai.Text = row.Cells[4].Value.ToString();

            OleDbCommand cmd = new OleDbCommand("select TENNHOM from T_NHOM_TAI_KHOAN where MANHOM='" + row.Cells[5].Value.ToString() + "'", conn);
            string tennhom = (string)cmd.ExecuteScalar();
            cmbChucvu.Text = tennhom;
            txtMatkhau_NV.Text = row.Cells[6].Value.ToString();
            conn.Close();
        }

        private void btnThem_NV_Click(object sender, EventArgs e)
        {
            luu = 1;
            conn.Open();
            adapter = new OleDbDataAdapter("select * from T_NHAN_VIEN", conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count < 100)
                txtMaNV.Text = "NV000" + (dt.Rows.Count + 1);
            else if (dt.Rows.Count < 10)
                txtMaNV.Text = "NV00" + (dt.Rows.Count + 1);
            else txtMaNV.Text = "NV0" + (dt.Rows.Count + 1);
            conn.Close();
            groupBox1.Enabled = true;
            btnThem_NV.Enabled = false;
            btnXoa_NV.Enabled = false;
            btnSua_NV.Enabled = false;
            btnLuu_NV.Enabled = true;
            dgvNV.Enabled = false;
        }

        private void btnXoa_NV_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new OleDbCommand("Delete from T_NHAN_VIEN where MANV='" + txtMaNV.Text + "'", conn);
            cmd.ExecuteNonQuery();
            loadTable();
            conn.Close();
            
        }

        public void loadChucVu()
        {
            string st = "select * from T_NHOM_TAI_KHOAN";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            cmbChucvu.DataSource = dt;
            cmbChucvu.DisplayMember = "TENNHOM";
            cmbChucvu.ValueMember = "MANHOM";
        }

        public void loadTable()
        {
            loadChucVu();
            adapter = new OleDbDataAdapter("select * from T_NHAN_VIEN", conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvNV.DataSource = dt;
            var source = new AutoCompleteStringCollection();
            foreach (DataRow i in dt.Rows)
                source.Add(i.Field<string>(1));
            txttimkiem.AutoCompleteCustomSource = source;

            if (dt.Rows.Count < 100)
                txtMaNV.Text = "NV000" + (dt.Rows.Count + 1);
            else if (dt.Rows.Count < 10)
                txtMaNV.Text = "NV00" + (dt.Rows.Count + 1);
            else txtMaNV.Text = "NV0" + (dt.Rows.Count + 1);
 
            luu = 0;
            groupBox1.Enabled = false;
            btnThem_NV.Enabled = true;
            btnLuu_NV.Enabled = false;
            btnSua_NV.Enabled = false;
            btnXoa_NV.Enabled = false;
            dgvNV.Enabled = true;
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtEmail.Clear();
            txtDienthoai.Clear();
            cmbChucvu.DisplayMember = cmbChucvu.Items[0].ToString();
        }


        public void them()
        {
            if (this.txtTenNV.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập tên nhân viên");
                return;
            }
            else
            {
                if (rdcNam.Checked == true) phai = "Nam"; else phai = "Nu";
                cmd = new OleDbCommand("Insert into T_NHAN_VIEN values('" + txtMaNV.Text + "','" + txtTenNV.Text + "','" + phai + "','" + txtDienthoai.Text + "','" + cmbChucvu.SelectedValue.ToString() + "','"+ txtMatkhau_NV.Text+  "')", conn);
                if (Kiem_tra_khoa_chinh())
                {
                    MessageBox.Show("Đã có mã nhân viên này");
                    return;
                }
                else
                {    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadTable();
                }
            }
        }
        public void sua()
        {
            if (this.txtTenNV.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập thông tin nhân viên");
                return;
            }
            else
            {
                if (rdcNam.Checked == true) phai = "Nam"; else phai = "Nu";
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Update T_NHAN_VIEN set TENNV='" + txtTenNV.Text + "', EMAILNV ='" + txtEmail.Text + "', PHAI='" + phai + "', DIENTHOAINV='" + txtDienthoai.Text + "', MANHOM='" + cmbChucvu.SelectedValue.ToString() + "',MATKHAU='"+txtMatkhau_NV.Text+"' where MANV='" + txtMaNV.Text + "'", conn);
                cmd.ExecuteNonQuery();
                loadTable();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }

        }

        private void btnLuu_NV_Click(object sender, EventArgs e)
        {
            if (luu == 1)
            {
                them();
                dgvNV.Enabled = true;
            }
            else if (luu == 2)
            {
                sua();
                dgvNV.Enabled = true;
            }
        }

        private void btnSua_NV_Click(object sender, EventArgs e)
        {
            luu = 2;
            groupBox1.Enabled = true;
            txtTenNV.Focus();
            btnThem_NV.Enabled = false;
            btnXoa_NV.Enabled = false;
            btnSua_NV.Enabled = false;
            btnLuu_NV.Enabled = true;
            dgvNV.Enabled = false;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
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

                cmd = new OleDbCommand("select TENNHOM from T_NHOM_TAI_KHOAN where MANHOM='" + row.Cells[5].Value.ToString() + "'", conn);
                string tenloai = (string)cmd.ExecuteScalar();

                txtMaNV.Text = row.Cells[0].Value.ToString();
                txtTenNV.Text = row.Cells[1].Value.ToString();
                txtEmail.Text = row.Cells[3].Value.ToString();
                cmbChucvu.Text = tenloai;
                txtDienthoai.Text = row.Cells[4].Value.ToString();
                txtMatkhau_NV.Text = row.Cells[5].Value.ToString();
                conn.Close();

            }
            catch
            {
                conn.Close();
            }
        }

        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            dgvNV.CurrentRow.Selected = false;
            DataGridViewRow rowchon;
            adapter = new OleDbDataAdapter("select * from T_NHAN_VIEN", conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            Boolean kq = false;
            dgvNV.ClearSelection();

            if (e.KeyCode == Keys.Enter)
            {

                for (int i = 0; i < dgvNV.Rows.Count; i++)
                {
                    if (dgvNV.Rows[i].Cells[1].Value.ToString().ToLower() == txttimkiem.Text.ToLower())
                    {
                        dgvNV.FirstDisplayedScrollingRowIndex = i;
                        kq = true;
                        dgvNV.Rows[i].Selected = true;
                        rowchon = new DataGridViewRow();
                        rowchon = dgvNV.Rows[i];
                        loadThongtinkhichon(rowchon);
                        break;
                    }
                }


                if (kq == false)
                    MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            SaveFileDialog s = new SaveFileDialog();
            s.Title = "Chọn đường dẫn lưu tệp excel";
            s.InitialDirectory = @"c:\";
            s.FileName = "ds_nhanvien.xlsx";
            s.Filter = "Excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            s.FilterIndex = 2;
            s.RestoreDirectory = true;
            if (s.ShowDialog() == DialogResult.OK)
            {
                xuatExcel(dgvNV, s.FileName);
                MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAsc_Click(object sender, EventArgs e)
        {
            dgvNV.Sort(dgvNV.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void btnDes_Click(object sender, EventArgs e)
        {
            dgvNV.Sort(dgvNV.Columns[0], System.ComponentModel.ListSortDirection.Descending);
        }
    }
}
