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
using System.IO;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Text.RegularExpressions;



namespace QL_VatLieuXayDung
{
    public partial class frmNhanVien : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        System.Data.DataTable dt;
        OleDbCommand cmd;
        String phai = null;
        Boolean bamchon = false;
        int luu = 0; 
        string tenhinh;
        string match = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"; 
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
            bamchon = false;
            adapter = new OleDbDataAdapter("select * from T_NHAN_VIEN", conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvNV.DataSource = dt;
            var source = new AutoCompleteStringCollection();
            foreach (DataRow i in dt.Rows)
                source.Add(i.Field<string>(1));
            txttimkiem.AutoCompleteCustomSource = source;

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
            txtMatkhau_NV.Clear();
            string duongdan2 = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\hinhnhanvien\\avatar.jpg";
            Stream s = File.Open(duongdan2, FileMode.Open);
            Image hinh = Image.FromStream(s);
            s.Close();
            pictureBox1.Image = hinh;  
            cmbChucvu.DisplayMember = cmbChucvu.Items[0].ToString();
        }
        

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            conn.Open();
            loadTable();
          
            conn.Close();
        }
        public void loadThongtinkhichon(DataGridViewRow row)
        {
                 conn.Open();
                cmd = new OleDbCommand("select TENNHOM from T_NHOM_TAI_KHOAN where MANHOM='" + row.Cells["nhom"].Value.ToString() + "'", conn);
                string tenloai = (string)cmd.ExecuteScalar();

                txtMaNV.Text = row.Cells["manv"].Value.ToString();
                txtTenNV.Text = row.Cells["hoten"].Value.ToString();
                if (row.Cells["gioitinh"].Value.ToString() == "Nam")
                    rdcNam.Checked = true;
                else rdcNu.Checked = true;
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtDienthoai.Text = row.Cells["dienthoai"].Value.ToString();
                cmbChucvu.Text = tenloai;
                txtMatkhau_NV.Text = row.Cells["matkhau"].Value.ToString();
                try
                {
                    string duongdan = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\hinhnhanvien\\" + txtMaNV.Text + ".jpg";
                    Stream s = File.Open(duongdan, FileMode.Open);
                    Image hinh = Image.FromStream(s);
                    s.Close();
                    pictureBox1.Image = hinh;
                }
                catch
                {
                    string duongdan2 = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\hinhnhanvien\\avatar.jpg";
                    Stream s = File.Open(duongdan2, FileMode.Open);
                    Image hinh = Image.FromStream(s);
                    s.Close();
                    pictureBox1.Image = hinh;             
       
                }          
                conn.Close();
        }
        private void dgvNV_Click(object sender, EventArgs e)
        {
            btnXoa_NV.Enabled = true;
            btnSua_NV.Enabled = true;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvNV.CurrentRow;
            loadThongtinkhichon(row);
        }

        private void btnThem_NV_Click(object sender, EventArgs e)
        {
            luu = 1;
            conn.Open();
         
            /// MA TU DONG
            string lenh = "select MANV from T_NHAN_VIEN order by MANV desc";
            cmd = new OleDbCommand(lenh, conn);
            string macuoi = (string)cmd.ExecuteScalar();

            if (macuoi == null)
            {
                txtMaNV.Text = "NV0001";
            }
            else
            {
                int somacuoi = int.Parse(macuoi.Replace("NV", ""));
                if (somacuoi < 9)
                    txtMaNV.Text = "NV000" + (somacuoi + 1);
                else if (somacuoi >= 9 && somacuoi < 99)
                    txtMaNV.Text = "NV00" + (somacuoi + 1);
                else if (somacuoi >= 99 && somacuoi < 999)
                    txtMaNV.Text = "NV0" + (somacuoi + 1);
                else
                    txtMaNV.Text = "NV" + (somacuoi + 1);
            }
            ////   
            conn.Close();
            groupBox1.Enabled = true;
            btnThem_NV.Enabled = false;
            btnXoa_NV.Enabled = false;
            btnSua_NV.Enabled = false;
            btnLuu_NV.Enabled = true;
            dgvNV.Enabled = false;
          
            txtTenNV.Clear();
            txtEmail.Clear();
            txtDienthoai.Clear();
            txtMatkhau_NV.Clear();
            
            cmbChucvu.DisplayMember = cmbChucvu.Items[0].ToString();

            string duongdan2 = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\hinhnhanvien\\avatar.jpg";
            Stream s = File.Open(duongdan2, FileMode.Open);
            Image hinh = Image.FromStream(s);
            s.Close();
            pictureBox1.Image = hinh;  
        }

        private void btnXoa_NV_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                cmd = new OleDbCommand("Delete from T_NHAN_VIEN where MANV='" + txtMaNV.Text + "'", conn);
                cmd.ExecuteNonQuery();
                string duongdan = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\hinhnhanvien\\" + txtMaNV.Text + ".jpg";
                if (System.IO.File.Exists(duongdan))
                {
                    System.IO.File.Delete(duongdan);
                }
               
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadTable();
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Không thể xóa nhân viên này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            
        }

        public void them()
        {
            bool ktmail=false;
            Regex reg = new Regex(match);
            if (reg.IsMatch(this.txtEmail.Text))
                ktmail=true;
            else ktmail=false;
            if (this.txtTenNV.TextLength == 0 || txtMatkhau_NV.Text=="" )
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if(ktmail==false)
            {
                MessageBox.Show("Định dạng mail không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if ( txtDienthoai.TextLength < 10)
            {
                MessageBox.Show("Số điện thoại không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                conn.Open();
                if (rdcNam.Checked == true) phai = "Nam"; else phai = "Nu";
                cmd = new OleDbCommand("Insert into T_NHAN_VIEN values('" + txtMaNV.Text + "','" + txtTenNV.Text + "','" + phai + "','"+txtEmail.Text +"','" + txtDienthoai.Text + "','" + cmbChucvu.SelectedValue.ToString() + "','"+ txtMatkhau_NV.Text+  "')", conn);
                cmd.ExecuteNonQuery();
                if (bamchon == true)
                {
                    string duongdan = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\hinhnhanvien\\" + txtMaNV.Text + ".jpg";
                  
                    if (System.IO.File.Exists(duongdan))
                    {
                        System.IO.File.Delete(duongdan);
                    }
                    File.Copy(tenhinh, duongdan);
                }        
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadTable();
                    conn.Close();
            }
        }
        public void sua()
        {
            if (this.txtTenNV.TextLength == 0 || txtMatkhau_NV.Text == "")
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (rdcNam.Checked == true) phai = "Nam"; else phai = "Nu";
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Update T_NHAN_VIEN set TENNV='" + txtTenNV.Text + "', EMAILNV ='" + txtEmail.Text + "', PHAI='" + phai + "', DIENTHOAINV='" + txtDienthoai.Text + "', MANHOM='" + cmbChucvu.SelectedValue.ToString() + "',MATKHAU='"+txtMatkhau_NV.Text+"' where MANV='" + txtMaNV.Text + "'", conn);
                cmd.ExecuteNonQuery();
             
                if (bamchon == true)
                {
                    string duongdan = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\hinhnhanvien\\" + txtMaNV.Text + ".jpg";
                    if (System.IO.File.Exists(duongdan))
                    {
                        System.IO.File.Delete(duongdan);
                    }
                    File.Copy(tenhinh, duongdan);
                }
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bamchon = false;
                loadTable();
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

        private void bthinh_Click(object sender, EventArgs e)
        {        
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = "C:\\";
            open.Filter = "Hình (*.JPG,*.PNG)|*.JPG;*.PNG;|" + "All files (*.*)|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                tenhinh = open.FileName;
                bamchon = true;
            }
        }

        private void txtDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true; 
        }

        private void dgvNV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNV.Columns[e.ColumnIndex].Name == "matkhau" && e.Value != null)
            {
                dgvNV.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void txttimkiem_KeyDown_1(object sender, KeyEventArgs e)
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
                    MessageBox.Show("Không tìm thấy nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
