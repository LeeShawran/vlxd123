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
    public partial class frmDonDatHangNCC : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        OleDbCommand cmd;
        DataTable dt;
        int luu = 0;
        float tong = 0;
        bool dadatsanpham = false;
        int sttdong = -1;
        public frmDonDatHangNCC()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void loadNCC()
        {
            string st = "select * from T_NHA_CUNG_CAP order by MANCC ASC";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            cbNCC.DataSource = dt;
            cbNCC.DisplayMember = "TENNCC";
            cbNCC.ValueMember = "MANCC";
        }
        public void load_DatHang()
        {
            adapter = new OleDbDataAdapter("select * from T_DON_DAT_HANG_NCC order by MADATNCC ASC", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvDonDatHang.DataSource = dt;
        }
        public void loadCT_DonDatHang(string madondat)
        {
            string st = "select MASP,SOLUONG from T_CT_DAT_HANG_NCC where MADATNCC='" + madondat + "' order by MASP ASC";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvCTDonDatHang.DataSource = dt;
        }
       
        public void loadLai()
        {
            txtMaNV.Text = Program.mainForm.ma;
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            dgvDonDatHang.Columns["Column4"].DefaultCellStyle.Format = @"dd/MM/yyyy";
           
            groupBoxSanPham.Enabled = false;
           
            luu = 0;
            groupBoxThongTinDH.Enabled = false;
        
            loadNCC();
            load_DatHang();
            
            btnThemDDH.Enabled = true;
            btnLuuDDH.Enabled = false;
            btnXoaDDH.Enabled = false;
            btnXoaCT.Enabled = false;
            btnPhieuNhap.Enabled = false;

            dgvDonDatHang.Enabled = true;

            txtMaPhieu.Clear();
            txtTinhTrangNhap.Clear();
            cbNCC.DisplayMember = cbNCC.Items[0].ToString();
            
            //xoa chi tiet don dat hang
            string s = "select MASP,SOLUONG from T_CT_DAT_HANG_NCC where MADATNCC='aaaa'";
            adapter = new OleDbDataAdapter(s, conn);
            DataTable dt2 = new DataTable();
            adapter.Fill(dt2);
            dgvCTDonDatHang.DataSource = dt2;
            //xoa datagridview san pham
            string st = "select MASP,TENSP from T_SAN_PHAM where MASP='aa'";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvSanPHam.DataSource = dt;
            //
            //dgvSanPHam.Rows[0].Selected = false;
            dgvDonDatHang.Rows[0].Selected = false;

        }

        private void frmDatHangNCC_Load(object sender, EventArgs e)
        {
            conn.Open();
            loadLai();
            conn.Close();
        }

        private void btnThemDDH_Click(object sender, EventArgs e)
        {
            luu = 1;
            conn.Open();
            /// MA TU DONG
            string lenh = "select MADATNCC from T_DON_DAT_HANG_NCC order by MADATNCC desc";
            cmd = new OleDbCommand(lenh, conn);
            string macuoi = (string)cmd.ExecuteScalar();

            if (macuoi == null)
            {
                txtMaPhieu.Text = "DHNCC0001";
            }
            else
            {
                int somacuoi = int.Parse(macuoi.Replace("DHNCC", ""));
                if (somacuoi < 9)
                    txtMaPhieu.Text = "DHNCC000" + (somacuoi + 1);
                else if (somacuoi >= 9 && somacuoi < 99)
                    txtMaPhieu.Text = "DHNCC00" + (somacuoi + 1);
                else if (somacuoi >= 99 && somacuoi < 999)
                    txtMaPhieu.Text = "DHNCC0" + (somacuoi + 1);
                else
                    txtMaPhieu.Text = "DHNCC" + (somacuoi + 1);
            }
          
            groupBoxThongTinDH.Enabled = true;
            btnThemDDH.Enabled = false;
            btnXoaDDH.Enabled = false;
            btnLuuDDH.Enabled = true;
            dgvDonDatHang.Enabled = false;
            cbNCC.Enabled = true;
           
            txtTinhTrangNhap.Text = "Chua nhap";
            //bam dong hien thi len datagirdview sanpham
            string st = "select MASP,TENSP from T_SAN_PHAM where MANCC='" + cbNCC.SelectedValue.ToString() + "'";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvSanPHam.DataSource = dt;
            conn.Close();
        }

     
        private void btnLuuDDH_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            if (luu == 1)
            {
                them();
                
            }
            else if (luu == 2)
            {
               
            }
            conn.Close();
        }

        public void them()
        {
            if (dgvSanPHam.Rows.Count<=0 )
            {
                MessageBox.Show("Không có bất kì sản phẩm nào thuộc nhà cung cấp này, vui lòng chọn nhà cung cấp khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
               
            }
            else
            {
                cmd = new OleDbCommand("Insert into T_DON_DAT_HANG_NCC values('" + txtMaPhieu.Text + "',TO_DATE('" + dtpNgayLap.Text + "','DD-MM-RR'),'" + cbNCC.SelectedValue.ToString() + "','" + txtMaNV.Text + "','Chua nhap')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadLai();
                dgvDonDatHang.Enabled = true;
            }
        }
        
        private void btnXoaDDH_Click(object sender, EventArgs e)
        {       
            if (dgvDonDatHang.CurrentRow.Cells["ttnhap"].Value.ToString() == "Da nhap")
            {
                MessageBox.Show("Đơn đặt hàng đã nhập, không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else 
            {
                DialogResult dir;
                dir = MessageBox.Show("Bạn có muốn xóa không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dir == DialogResult.Yes)
                {
                    conn.Close();
                    conn.Open();
                    cmd = new OleDbCommand("Delete from T_DON_DAT_HANG_NCC where MADATNCC='" + txtMaPhieu.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadLai();
                    conn.Close();
                }
            }      
        }

        private void dgvSanPHam_Click(object sender, EventArgs e)
        {
           
        }

        private void cbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string st = "select MASP,TENSP from T_SAN_PHAM where MANCC='" + cbNCC.SelectedValue.ToString() + "' order by MASP ASC";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvSanPHam.DataSource = dt;
            conn.Close();
        }

        private void txtSLDat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true; 
        }

        private void txtDonGiaDat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true; 
        }

        int ktma()
        {
            conn.Close();
            conn.Open();
            string s = "select count(*) from T_CT_DAT_HANG_NCC where MADATNCC=('" + txtMaPhieu.Text + "') and MASP='" + dgvSanPHam.CurrentRow.Cells["masp"].Value.ToString() + "'";
            OleDbCommand cmd = new OleDbCommand(s, conn);
            string o = cmd.ExecuteScalar().ToString();
            int a = int.Parse(o);
            return a;
            conn.Close();
        }

        private void dgvDonDatHang_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            btnXoaDDH.Enabled = true;
            sttdong = -1;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvDonDatHang.CurrentRow;

            //lay ten NCC tu ma NCC de hien thi len comboboc
            cmd = new OleDbCommand("select TENNCC from T_NHA_CUNG_CAP where MANCC='" + row.Cells[2].Value.ToString() + "'", conn);
            string tenNCC = (string)cmd.ExecuteScalar();

            //bam dong hien thi len dgv dat hang
            txtMaPhieu.Text = row.Cells[0].Value.ToString();
            dtpNgayLap.Value = DateTime.Parse(row.Cells[1].Value.ToString());
            cbNCC.Text = tenNCC;
            txtMaNV.Text = row.Cells[3].Value.ToString();
            txtTinhTrangNhap.Text = row.Cells[4].Value.ToString();
            //kt tinhtrang thanh toan de hien thi nut nhap hang và khong cho them,xoa, sua san pham
            if (row.Cells[4].Value.ToString() == "Chua nhap")
            {
                btnPhieuNhap.Enabled = true;
                groupBoxSanPham.Enabled = true;
            }
            else 
            {
                btnPhieuNhap.Enabled = false;
                groupBoxSanPham.Enabled = false;
            }
          
            loadCT_DonDatHang(row.Cells["madondat"].Value.ToString());

            //bam dong hien thi len datagirdview sanpham
            string st = "select MASP,TENSP from T_SAN_PHAM where MANCC='" + row.Cells[2].Value.ToString() + "'";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvSanPHam.DataSource = dt;
            ////bam dong hien thi len datagirdview chi tiet dat hang
            if (dgvCTDonDatHang.Rows.Count <= 0)
            {
                dadatsanpham = false;
            }
            else
            {
                dgvCTDonDatHang.Rows[0].Selected = false;
                dadatsanpham = true;
            }
            conn.Close();
        }

    
        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dadatsanpham == true)
            {
                fmPhieuNhapNCC f = new fmPhieuNhapNCC(txtMaPhieu.Text);
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
                btnPhieuNhap.Enabled = false;
                btnThemDDH.Enabled = false;
                btnXoaDDH.Enabled = false;
                btnLuuDDH.Enabled = false;
                btnLamMoi.Enabled = true;
            }
            else MessageBox.Show("Chưa đặt sản phẩm nào cho đơn đặt hàng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);  
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            conn.Open();
            loadLai();
            conn.Close();
        }

        private void btnThemCT_Click_1(object sender, EventArgs e)
        {
            if (sttdong == -1)
            {
                sttdong = dgvDonDatHang.CurrentRow.Index;
            }
            if (this.txtSLDat.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập số lượng đặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (int.Parse(txtSLDat.Text) <= 0)
            {
                MessageBox.Show("Số lượng đặt phải > 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (ktma() >= 1)
            {
                MessageBox.Show("Sản phẩm này đã đặt rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                conn.Close();
                conn.Open();
                cmd = new OleDbCommand("Insert into T_CT_DAT_HANG_NCC values('" + txtMaPhieu.Text + "','" + dgvSanPHam.CurrentRow.Cells[0].Value.ToString() + "'," + int.Parse(txtSLDat.Text) + ")", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //load lai ct don dat

                load_DatHang();
                dgvDonDatHang.Rows[0].Selected = false;
                dgvDonDatHang.FirstDisplayedScrollingRowIndex = sttdong;
                dgvDonDatHang.Rows[sttdong].Selected = true;
                loadCT_DonDatHang(dgvDonDatHang.Rows[sttdong].Cells[0].Value.ToString());
                //
                txtSLDat.Clear();
                groupBoxSanPham.Enabled = true;
                if (dgvCTDonDatHang.Rows.Count <= 0)
                {
                    dadatsanpham = false;
                }
                else
                {
                    dgvCTDonDatHang.Rows[0].Selected = false;
                    dadatsanpham = true;
                }
                conn.Close();
            }

        }

        private void btnSuaCT_Click_1(object sender, EventArgs e)
        {

        }
        private void dgvCTDonDatHang_Click(object sender, EventArgs e)
        {
            btnXoaCT.Enabled = true;
            //txtSLDat.Text = dgvCTDonDatHang.CurrentRow.Cells[1].Value.ToString();
            
        }
        private void btnXoaCT_Click_1(object sender, EventArgs e)
        {
            DialogResult dir;
            dir = MessageBox.Show("Bạn có muốn xóa không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dir == DialogResult.Yes)
            {
                conn.Close();
                conn.Open();
                if (sttdong == -1)
                {
                    sttdong = dgvDonDatHang.CurrentRow.Index;
                }
              
                cmd = new OleDbCommand("Delete from T_CT_DAT_HANG_NCC where MASP='" + dgvCTDonDatHang.CurrentRow.Cells[0].Value.ToString() + "' and MADATNCC='" + txtMaPhieu.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //load lai ct don dat

                load_DatHang();
                dgvDonDatHang.Rows[0].Selected = false;
                dgvDonDatHang.FirstDisplayedScrollingRowIndex = sttdong;
                dgvDonDatHang.Rows[sttdong].Selected = true;
                loadCT_DonDatHang(dgvDonDatHang.Rows[sttdong].Cells[0].Value.ToString());
                //
                txtSLDat.Clear();
                groupBoxSanPham.Enabled = true;
                if (dgvCTDonDatHang.Rows.Count <= 0)
                {
                    dadatsanpham = false;
                }
                else
                {
                    dgvCTDonDatHang.Rows[0].Selected = false;
                    dadatsanpham = true;
                }
                btnXoaCT.Enabled = false;
                conn.Close();
            }
           
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

       
    }
}
