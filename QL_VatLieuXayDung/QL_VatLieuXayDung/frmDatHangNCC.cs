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
        public frmDonDatHangNCC()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }
        public void loadLai()
        {
            dgvDonDatHang.Columns["Column4"].DefaultCellStyle.Format = @"dd/MM/yyyy";
            adapter = new OleDbDataAdapter("select * from T_DON_DAT_HANG_NCC", conn);
            dt= new DataTable();
            adapter.Fill(dt);
            dgvDonDatHang.DataSource = dt;
            groupBoxSanPham.Enabled = false;
           

            luu = 0;
            groupBoxThongTinDH.Enabled = false;
        

            loadNCC();

            btnThemDDH.Enabled = true;
            btnLuuDDH.Enabled = false;
            btnSuaDDH.Enabled = false;
            btnXoaDDH.Enabled = false;
            btnPhieuNhap.Enabled = false;

            dgvDonDatHang.Enabled = true;

            txtMaPhieu.Clear();
            txtTongTien.Clear();
            cbTinhTRrang.DisplayMember = cbTinhTRrang.Items[0].ToString();
            cbNCC.DisplayMember = cbNCC.Items[0].ToString();

            //
            dtpNgayLap.Format = DateTimePickerFormat.Custom;
            dtpNgayLap.CustomFormat = "dd/MM/yyyy";

        }

        public void loadNCC()
        {
            string st = "select * from T_NHA_CUNG_CAP";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            cbNCC.DataSource = dt;
            cbNCC.DisplayMember = "TENNCC";
            cbNCC.ValueMember = "MANCC";
        }
        public void loadCT_DonDatHang()
        {
            string st = "select MASP,SOLUONG,DONGIANHAP from T_CT_DAT_HANG_NCC";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvCTDonDatHang.DataSource = dt;
        }

        private void frmDatHangNCC_Load(object sender, EventArgs e)
        {
            conn.Open();
            loadLai();
            conn.Close();
        }

        private bool Kiem_tra_khoa_chinh()
        {
            bool a = false;
            string MaPD = txtMaPhieu.Text;
            cmd = new OleDbCommand("select * from T_DON_DAT_HANG_NCC", conn);
            OleDbDataReader PK = cmd.ExecuteReader();
            while (PK.Read())
            {
                if (MaPD == PK.GetString(0))
                {
                    a = true;
                    break;
                }
            }
            return a;
        }


        private void btnThemDDH_Click(object sender, EventArgs e)
        {
            luu = 1;
            conn.Open();
            adapter = new OleDbDataAdapter("select * from T_DON_DAT_HANG_NCC", conn);
            dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count < 100)
                txtMaPhieu.Text = "DHNCC000" + (dt.Rows.Count + 1);
            else if (dt.Rows.Count < 10)
                txtMaPhieu.Text = "DHNCC00" + (dt.Rows.Count + 1);
            else txtMaPhieu.Text = "DHNCC0" + (dt.Rows.Count + 1);
            conn.Close();

            groupBoxThongTinDH.Enabled = true;
            btnThemDDH.Enabled = false;
            btnXoaDDH.Enabled = false;
            btnSuaDDH.Enabled = false;
            btnLuuDDH.Enabled = true;
            dgvDonDatHang.Enabled = false;
            cbNCC.Enabled = true;

            txtTongTien.Text = "0";
        }

        private void btnSuaDDH_Click(object sender, EventArgs e)
        {
            luu = 2;
            groupBoxThongTinDH.Enabled = true;
            btnThemDDH.Enabled = false;
            btnXoaDDH.Enabled = false;
            btnSuaDDH.Enabled = false;
            btnLuuDDH.Enabled = true;
            dgvDonDatHang.Enabled = false;
            cbNCC.Enabled = false;
        }

        private void btnLuuDDH_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            if (luu == 1)
            {
                them();
                dgvDonDatHang.Enabled = true;
            }
            else if (luu == 2)
            {
                sua();
                dgvDonDatHang.Enabled = true;
            }


            conn.Close();
        }
        public void them()
        {
            if (this.txtMaPhieu.TextLength == 0 )
            {
                MessageBox.Show("Chưa nhập thông tin ");
                return;
            }
            else
            {
           
                cmd = new OleDbCommand("Insert into T_DON_DAT_HANG_NCC values('" + txtMaPhieu.Text + "',TO_DATE('" + dtpNgayLap.Text + "','DD-MM-RR'),'" + cbNCC.SelectedValue.ToString() + "','" + txtMaNV.Text + "'," + float.Parse(txtTongTien.Text) + ",'"+ cbTinhTRrang.Text +"')", conn);
            
                    cmd.ExecuteNonQuery();
                    loadLai();

               
            }
        }
        public void sua()
        {
            if (this.txtMaPhieu.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập thông tin");
                return;
            }
            else
            {
                OleDbCommand cmd = new OleDbCommand("Update T_DON_DAT_HANG_NCC set NGAYDATNCC=TO_DATE('" + dtpNgayLap.Text + "','DD-MM-RR'), MANCC ='" + cbNCC.SelectedValue.ToString() + "', MANV='" + txtMaNV.Text + "', TONGTIEN='" + float.Parse(txtTongTien.Text) + "', TINHTRANG='" + cbTinhTRrang.Text + "' where MADATNCC='" + txtMaPhieu.Text + "'", conn);
                cmd.ExecuteNonQuery();
                loadLai();
            }

        }

        private void btnXoaDDH_Click(object sender, EventArgs e)
        {
           
            if (dgvDonDatHang.CurrentRow.Cells[5].Value.ToString() == "Yes")
            {
                MessageBox.Show("Đơn đặt hàng đã thanh toán, không thể xóa");
                return;
            }
            else 
            {
                conn.Open();
                cmd = new OleDbCommand("Delete from T_DON_DAT_HANG_NCC where MADATNCC='" + txtMaPhieu.Text + "'", conn);
                cmd.ExecuteNonQuery();
                loadLai();
                conn.Close();
            }
            
          
        }

        private void dgvSanPHam_Click(object sender, EventArgs e)
        {
           
        }

        private void cbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            string st = "select MASP,TENSP,SOLUONG from T_SAN_PHAM where MANCC='" + cbNCC.SelectedValue.ToString() + "'";

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

        private bool Kiem_tra_ma_sanpham(string masp)
        {
         
            bool a = false;
            cmd = new OleDbCommand("select * from T_CT_DAT_HANG_NCC", conn);
            OleDbDataReader PK = cmd.ExecuteReader();
            while (PK.Read())
            {
                if (masp == PK.GetString(0))
                {
                    a = true;
                    break;
                }
            }
            return a;
            conn.Close();
        }

     

        private void dgvDonDatHang_Click(object sender, EventArgs e)
        {
            conn.Open();
            btnXoaDDH.Enabled = true;
            btnSuaDDH.Enabled = true;
           

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
            txtTongTien.Text = row.Cells[4].Value.ToString();
            cbTinhTRrang.Text = row.Cells[5].Value.ToString();
            //kt tinhtrang thanh toan de hien thi nut nhap hang và khong cho them,xoa, sua san pham
            if (row.Cells[5].Value.ToString() == "Yes")
            {
                btnPhieuNhap.Enabled = true;
                groupBoxSanPham.Enabled = false;
            }
            else 
            {
                btnPhieuNhap.Enabled = false;
                groupBoxSanPham.Enabled = true;
            }
                
   
           
            loadCT_DonDatHang();

            ////bam dong hien thi len datagirdview sanpham
            string st = "select MASP,TENSP,SOLUONG from T_SAN_PHAM where MANCC='" + row.Cells[2].Value.ToString() + "'";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvSanPHam.DataSource = dt;
            ////bam dong hien thi len datagirdview chi tiet dat hang

            string s = "select MASP,SOLUONG,DONGIANHAP from T_CT_DAT_HANG_NCC where MADATNCC='" + row.Cells[0].Value.ToString() + "'";
            OleDbDataAdapter adapter2 = new OleDbDataAdapter(s, conn);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);
            dgvCTDonDatHang.DataSource = dt2;
            conn.Close();
        }

     
        private void btnSuaCT_Click(object sender, EventArgs e)
        {

        }
      
        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
           
                fmPhieuNhapNCC f = new fmPhieuNhapNCC(txtMaPhieu.Text);
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            conn.Open();
            loadLai();
            conn.Close();
        }

        private void btnThemCT_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            DataGridViewRow row = new DataGridViewRow();
            row = dgvSanPHam.CurrentRow;
            if (this.txtDonGiaDat.TextLength == 0 || this.txtSLDat.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập thông tin đơn giá, số lượng");
                return;
            }
            else if (Kiem_tra_ma_sanpham(row.Cells[0].Value.ToString()))
            {
                MessageBox.Show("Đã có mã sản phẩm này");
                return;
            }
            else
            {
                cmd = new OleDbCommand("Insert into T_CT_DAT_HANG_NCC values('" + txtMaPhieu.Text + "','" + row.Cells[0].Value.ToString() + "'," + int.Parse(txtSLDat.Text) + "," + float.Parse(txtDonGiaDat.Text) + ")", conn);
                cmd.ExecuteNonQuery();
                tong = tong + (float.Parse(txtSLDat.Text) * float.Parse(txtDonGiaDat.Text));
                //update tong tien
                string lenh= "update T_DON_DAT_HANG_NCC set TONGTIEN=" + tong + " where MADATNCC='" + txtMaPhieu.Text + "'";
                OleDbCommand cmd3 = new OleDbCommand(lenh, conn);
                cmd3.ExecuteNonQuery();
                loadLai();

                

            }
            conn.Close();
        }

        private void btnSuaCT_Click_1(object sender, EventArgs e)
        {

        }

        private void btnXoaCT_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            DataGridViewRow row = new DataGridViewRow();
            row = dgvSanPHam.CurrentRow;

            cmd = new OleDbCommand("Delete from T_CT_DAT_HANG_NCC where MASP='" + row.Cells[0].Value.ToString() + "'", conn);
            cmd.ExecuteNonQuery();

            tong = tong - (float.Parse(txtSLDat.Text) * float.Parse(txtDonGiaDat.Text));
            string lenh = "update T_DON_DAT_HANG_NCC set TONGTIEN=" + tong + " where MADATNCC='" + txtMaPhieu.Text + "'";
            OleDbCommand cmd3 = new OleDbCommand(lenh, conn);
            cmd3.ExecuteNonQuery();

            loadLai();
           
            conn.Close();
        }
    }
}
