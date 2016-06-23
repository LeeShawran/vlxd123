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
    public partial class frmDatHangKH : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        OleDbCommand cmd;
        DataTable dt;
        int luu = 0;
        float tong = 0;
        public frmDatHangKH()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void loadKH()
        {
            string st = "select * from T_KHACH_HANG";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            cbKH.DataSource = dt;
            cbKH.DisplayMember = "TENKH";
            cbKH.ValueMember = "MAKH";
        }

        public void loadSP()
        {
            string st = "select T_SAN_PHAM.MASP,TENSP,SOLUONG,DONGIABAN from T_SAN_PHAM, T_GIA_BAN where T_SAN_PHAM.MASP=T_GIA_BAN.MASP AND T_GIA_BAN.NGAYHIEULUC =(SELECT MAX(T_GIA_BAN.NGAYHIEULUC) FROM  T_GIA_BAN WHERE  T_GIA_BAN.NGAYHIEULUC <=TO_DATE ('"+ dtpNgaydat.Text +"', 'DD/MM/YYYY'))";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvSanPHam.DataSource = dt;

        }

        public void load_ct_dathang(string madondat)
        {
            string s = "select MASP,SOLUONG,DONGIABAN from T_CT_DAT_HANG_KH where MADDH='" + madondat + "'";
            adapter = new OleDbDataAdapter(s, conn);
            DataTable dt2 = new DataTable();
            adapter.Fill(dt2);
            dgvCT_DonDatHang.DataSource = dt2;
        }
        public void loadLai()
        {
            txtMaNV.Text = Program.mainForm.ma;
            loadKH();
            loadSP();
            dgvDonDatHang.Columns["ngaydat"].DefaultCellStyle.Format = @"dd/MM/yyyy";
            adapter = new OleDbDataAdapter("select * from T_DON_DAT_HANG_KH", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvDonDatHang.DataSource = dt;
            groupBoxsanpham.Enabled = false;
            luu = 0;
            groupBoxThongTinDH.Enabled = false;

            btnThemDH.Enabled = true;
            btnLuuDH.Enabled = false;
            btnXoaDH.Enabled = false;
            btnXoaCT.Enabled = false;
            btnThanhToan.Enabled = false;

            dgvDonDatHang.Enabled = true;

            txtMaDH.Clear();
            txtSoluongmua.Clear();
            txtTongtien.Clear();
            txtTTGiao.Clear();
            txtTTThanhToan.Clear();
            

            cbKH.DisplayMember = cbKH.Items[0].ToString();

            //
            dtpNgaydat.Format = DateTimePickerFormat.Custom;
            dtpNgaydat.CustomFormat = "dd/MM/yyyy";
            //


            dgvCT_DonDatHang.DataSource = null;
           
        }

        private void frmDatHangKH_Load(object sender, EventArgs e)
        {
            dtpNgaydat.Format = DateTimePickerFormat.Custom;
            dtpNgaydat.CustomFormat = "dd/MM/yyyy";
            conn.Open();
            loadLai();
            conn.Close();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            frmXuatHang f = new frmXuatHang(txtMaDH.Text);
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show();
           
        }

        private void btnThemDH_Click(object sender, EventArgs e)
        {
            luu = 1;
            conn.Open();
            /// MA TU DONG
            string lenh = "select MADDH from T_DON_DAT_HANG_KH order by MADDH desc";
            OleDbCommand cmd = new OleDbCommand(lenh, conn);
            string macuoi = (string)cmd.ExecuteScalar();
          
            if (macuoi == null)
            {
                txtMaDH.Text = "DHKH0001";
            }
            else
            {
                int somacuoi = int.Parse(macuoi.Replace("DHKH", ""));
                if (somacuoi < 10)
                    txtMaDH.Text = "DHKH000" + (somacuoi + 1);
                else if (somacuoi >= 10 && somacuoi < 100)
                    txtMaDH.Text = "DHKH00" + (somacuoi + 1);
                else if (somacuoi >= 100 && somacuoi < 1000)
                    txtMaDH.Text = "DHKH0" + (somacuoi + 1);
                else
                    txtMaDH.Text = "DHKH" + (somacuoi + 1);
            }
            
            ////
            conn.Close();

            txtTongtien.Text = "" + 0;
            txtTTGiao.Text = "Chua";
            txtTTThanhToan.Text = "Chua";
            cbKieuTra.Text = cbKieuTra.Items[0].ToString();
            cbTongLanGiao.Text = cbTongLanGiao.Items[0].ToString();
            txtConLai.Text = "1";

            groupBoxThongTinDH.Enabled = true;
            btnThemDH.Enabled = false;
            btnXoaDH.Enabled = false;

            btnLuuDH.Enabled = true;
            dgvDonDatHang.Enabled = false;
            cbKH.Enabled = true;
            cbKieuTra.Enabled = true;
        }

        public void them()
        {
            if (this.txtMaDH.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập thông tin ");
                return;
            }
            else
            {

                cmd = new OleDbCommand("Insert into T_DON_DAT_HANG_KH values('" + txtMaDH.Text + "',TO_DATE('" + dtpNgaydat.Text + "','DD-MM-RR'),'" + cbKH.SelectedValue.ToString() + "','" + txtMaNV.Text + "'," + 0 + ",'Chua','" + cbKieuTra.Text + "','Chua',"+ cbTongLanGiao.Text +", "+ txtConLai.Text +")", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                loadLai();


            }
        }

        private void btnLuuDH_Click(object sender, EventArgs e)
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
                //sua();
                //dgvDonDatHang.Enabled = true;
            }

            conn.Close();
        }

        private void dgvDonDatHang_Click(object sender, EventArgs e)
        {
            conn.Open();
            btnXoaDH.Enabled = true;


            DataGridViewRow row = new DataGridViewRow();
            row = dgvDonDatHang.CurrentRow;

            //lay ten NCC tu ma NCC de hien thi len comboboc
            cmd = new OleDbCommand("select TENKH from T_KHACH_HANG where MAKH='" + row.Cells["kh"].Value.ToString() + "'", conn);
            string tenKH = (string)cmd.ExecuteScalar();

            //bam dong hien thi len dgv dat hang
            txtMaDH.Text = row.Cells["ma"].Value.ToString();
            dtpNgaydat.Value = DateTime.Parse(row.Cells["ngaydat"].Value.ToString());

            cbKH.Text = tenKH;
            txtMaNV.Text = row.Cells["nv"].Value.ToString();
            txtTongtien.Text = row.Cells["tongtien"].Value.ToString();
            tong = float.Parse(txtTongtien.Text);
            txtTTThanhToan.Text = row.Cells["tttt"].Value.ToString();
            cbKieuTra.Text = row.Cells["kieutt"].Value.ToString();
            txtTTGiao.Text = row.Cells["ttgiao"].Value.ToString();
            //kt tinhtrang thanh toan de hien thi nut nhap hang và khong cho them,xoa, sua san pham
            if (row.Cells["tttt"].Value.ToString() == "Chua")
            {
                btnThanhToan.Enabled = true;
                groupBoxsanpham.Enabled = true;
            }
            else
            {
                btnThanhToan.Enabled = false;
                groupBoxsanpham.Enabled = false;
            }
            load_ct_dathang(row.Cells[0].Value.ToString());

            conn.Close();
        }

        int ktma()
        {
            conn.Close();
            conn.Open();
            string s = "select count(*) from T_CT_DAT_HANG_KH where MADDH=('" + txtMaDH.Text + "') and MASP='" + dgvSanPHam.CurrentRow.Cells["masp"].Value.ToString() + "'";
            OleDbCommand cmd = new OleDbCommand(s, conn);
            string o = cmd.ExecuteScalar().ToString();
            MessageBox.Show(o);
            int a = int.Parse(o);
            return a;
            conn.Close();

        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            //int slkho=int.Parse(dgvSanPham.CurrentRow.Cells["soluongkho"].Value.ToString());
            if (this.txtSoluongmua.TextLength == 0)
            {
                MessageBox.Show("Chưa nhập thông tin số lượng đặt");
                return;
            }

            else
            {

                float sldat = float.Parse(txtSoluongmua.Text);
                float giaban = float.Parse(dgvSanPHam.CurrentRow.Cells["giaban"].Value.ToString());
                tong = tong + sldat * giaban;

                if (txtSoluongmua.Text == "")
                {
                    MessageBox.Show("Chưa nhập số lượng đặt");
                    return;
                }
                else if (int.Parse(txtSoluongmua.Text) <= 0)
                {
                    MessageBox.Show("So luong dat phai > 0");
                    return;
                }
                else if (ktma() >= 1)
                {
                    MessageBox.Show("san pham nay da duoc dat");
                    return;
                }
                else
                {

                    cmd = new OleDbCommand("Insert into T_CT_DAT_HANG_KH values('" + txtMaDH.Text + "','" + dgvSanPHam.CurrentRow.Cells["masp"].Value.ToString() + "'," + int.Parse(txtSoluongmua.Text) + "," + float.Parse(dgvSanPHam.CurrentRow.Cells["giaban"].Value.ToString()) + ")", conn);
                    cmd.ExecuteNonQuery();

                    cmd = new OleDbCommand("Update T_DON_DAT_HANG_KH set TONGTIEN=" + tong + " where MADDH='"+ txtMaDH.Text +"'", conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Thêm thành công");

                    //load lai ct don dat
                    load_ct_dathang(dgvDonDatHang.CurrentRow.Cells[0].Value.ToString());
                    //

                    txtSoluongmua.Clear();

                    conn.Close();
                }

            }
        }

        private void btnLammoiHD_Click(object sender, EventArgs e)
        {
            conn.Open();
            loadLai();
            conn.Close();
        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            DialogResult dir;
            dir = MessageBox.Show("Bạn có muốn xóa không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dir == DialogResult.Yes)
            {
                conn.Close();
                conn.Open();
                cmd = new OleDbCommand("Delete from T_CT_DAT_HANG_KH where MASP='" + dgvCT_DonDatHang.CurrentRow.Cells[0].Value.ToString() + "' and MADDH='" + txtMaDH.Text + "'", conn);
                cmd.ExecuteNonQuery();

                float sldat = float.Parse(dgvCT_DonDatHang.CurrentRow.Cells[1].Value.ToString());
                float giaban = float.Parse(dgvCT_DonDatHang.CurrentRow.Cells[2].Value.ToString());
                tong = tong - sldat * giaban;

                cmd = new OleDbCommand("Update T_DON_DAT_HANG_KH set TONGTIEN=" + tong + " where MADDH='" + txtMaDH.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");

                //load lai ct don dat
                load_ct_dathang(dgvDonDatHang.CurrentRow.Cells[0].Value.ToString());
                //

                txtSoluongmua.Clear();
                conn.Close();
            }
        }

        private void txtSoluongmua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true; 
        }

        private void dgvCT_DonDatHang_Click(object sender, EventArgs e)
        {
            btnXoaCT.Enabled = true;

            txtSoluongmua.Text = dgvCT_DonDatHang.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnXoaDH_Click(object sender, EventArgs e)
        {
            if (dgvDonDatHang.CurrentRow.Cells["tttt"].Value.ToString() == "Co")
            {
                MessageBox.Show("Đơn đặt hàng đã thanh toán, không thể xóa");
                return;
            }
            else
            {
                DialogResult dir;
                dir = MessageBox.Show("Bạn có muốn xóa không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dir == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new OleDbCommand("Delete from T_DON_DAT_HANG_KH where MADDH='" + txtMaDH.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    loadLai();
                    conn.Close();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGiaoHang f = new frmGiaoHang(txtMaDH.Text);
            f.StartPosition = FormStartPosition.CenterParent;
            f.Show();
            button1.Enabled = false;
            btnThemDH.Enabled = false;
            btnXoaDH.Enabled = false;
          
            btnLuuDH.Enabled = false;
        }
    }
}
