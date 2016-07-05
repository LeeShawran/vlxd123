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
        bool dadatsanpham = false;
        int sttdong = -1;
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
            txtGiam.Text = "" + 0;
            string st = "select T_SAN_PHAM.MASP,TENSP,SOLUONG,DONGIABAN from T_SAN_PHAM, T_GIA_BAN where T_SAN_PHAM.MASP=T_GIA_BAN.MASP AND T_GIA_BAN.NGAYHIEULUC =(SELECT MAX(T_GIA_BAN.NGAYHIEULUC) FROM  T_GIA_BAN WHERE T_GIA_BAN.NGAYHIEULUC <=TO_DATE ('" + dtpNgaydat.Text + "', 'DD/MM/YYYY') and T_SAN_PHAM.MASP=T_GIA_BAN.MASP) order by T_SAN_PHAM.MASP ASC";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvSanPHam.DataSource = dt;
            //dgvSanPHam.Columns.Add("Column55", "Test");


            //string lenh = "select MASP, GIAM from T_GIAM_GIA,T_CT_GIAM_GIA where T_CT_GIAM_GIA.MAGG=T_GIAM_GIA.MAGG and NGAYBATDAU<=(SYSDATE)and NGAYKETTHUC >= (SYSDATE)";
            //OleDbDataAdapter adapter2 = new OleDbDataAdapter(lenh, conn);
            //DataTable dt2 = new DataTable();
            //adapter2.Fill(dt2);
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dt2.Rows.Count; j++)
            //    {
            //        //MessageBox.Show("san pham-" + dt.Rows[i].Field<string>(0)); MessageBox.Show("gg-" + dt2.Rows[j].Field<string>(0));
            //        if (dt.Rows[i].Field<string>(0) == dt2.Rows[j].Field<string>(0))
            //        {

            //            txtGiam.Text = dt2.Rows[j].Field<decimal>(1)+"";

            //        }
            //        else
            //        {
            //            txtGiam.Text = "0";
            //        }
            //    }

            //}

        }
        public void load_DatHang()
        {
            adapter = new OleDbDataAdapter("select * from T_DON_DAT_HANG_KH order by MADDH ASC", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvDonDatHang.DataSource = dt;
        }
        public void load_ct_dathang(string madondat)
        {
            string s = "select MASP,SOLUONG,DONGIABAN,GIAMGIA from T_CT_DAT_HANG_KH where MADDH='" + madondat + "' order by MASP ASC";
            adapter = new OleDbDataAdapter(s, conn);
            DataTable dt2 = new DataTable();
            adapter.Fill(dt2);
            dgvCT_DonDatHang.DataSource = dt2;
        }
        public void load_giam_gia(string masp)
        {
            string lenh = "select MASP, GIAM from T_GIAM_GIA,T_CT_GIAM_GIA where T_CT_GIAM_GIA.MAGG=T_GIAM_GIA.MAGG and NGAYBATDAU<=(SYSDATE)and NGAYKETTHUC >= (SYSDATE)";
            OleDbDataAdapter adapter2 = new OleDbDataAdapter(lenh, conn);
            DataTable dt2 = new DataTable();
            adapter2.Fill(dt2);

            for (int j = 0; j < dt2.Rows.Count; j++)
            {
                //MessageBox.Show("san pham-" + dgvSanPHam.CurrentRow.Cells["masp"].Value.ToString()); MessageBox.Show("gg-" + dt2.Rows[j].Field<string>(0));
                if (masp == dt2.Rows[j].Field<string>(0))
                {
                    //MessageBox.Show("bang");
                    txtGiam.Text = dt2.Rows[j].Field<decimal>(1) + "";
                    break;
                }
                else
                {
                    txtGiam.Text = "0";

                }
            }
        }
        public void loadLai()
        {
            dadatsanpham = false;
            luu = 0;

            loadKH();
            loadSP();
            load_DatHang();
            load_giam_gia(dgvSanPHam.Rows[0].Cells[0].Value.ToString());
            groupBoxsanpham.Enabled = false;
            groupBoxThongTinDH.Enabled = false;
            btnThemDH.Enabled = true;
            btnLuuDH.Enabled = false;
            btnXoaDH.Enabled = false;
            btnXoaCT.Enabled = false;
            btnThanhToan.Enabled = false;
            btnGiaoHang.Enabled = false;

            dgvDonDatHang.Enabled = true;

            txtMaDH.Clear();
            txtSoluongmua.Clear();
            txtTongtien.Clear();
            txtTTGiao.Clear();
            txtTTThanhToan.Clear();
            txtConLai.Clear();
            cbTongLanGiao.Text = cbTongLanGiao.Items[0].ToString();

            cbKH.DisplayMember = cbKH.Items[0].ToString();

            //
            dtpNgaydat.Format = DateTimePickerFormat.Custom;
            dtpNgaydat.CustomFormat = "dd/MM/yyyy";
            //xoa chi tiet don dat hang
            string s = "select MASP,SOLUONG,DONGIABAN from T_CT_DAT_HANG_KH where MADDH='aaaa'";
            adapter = new OleDbDataAdapter(s, conn);
            DataTable dt2 = new DataTable();
            adapter.Fill(dt2);
            dgvCT_DonDatHang.DataSource = dt2;
            //
            //dgvSanPHam.Rows[0].Selected = false;
            dgvDonDatHang.Rows[0].Selected = false;

        }
        private void frmDatHangKH_Load(object sender, EventArgs e)
        {
            dgvDonDatHang.Columns["ngaydat"].DefaultCellStyle.Format = @"dd/MM/yyyy";
            txtMaNV.Text = Program.mainForm.ma;
            dtpNgaydat.Format = DateTimePickerFormat.Custom;
            dtpNgaydat.CustomFormat = "dd/MM/yyyy";
            conn.Open();
            loadLai();
            dgvDonDatHang.CurrentCell = null;
            conn.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dadatsanpham == true)
            {
                frmXuatHang f = new frmXuatHang(txtMaDH.Text);
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
                btnThanhToan.Enabled = false;
                btnThemDH.Enabled = false;
                btnXoaDH.Enabled = false;
                btnGiaoHang.Enabled = false;
                btnLammoiHD.Enabled = true;
            }
            else MessageBox.Show("Chưa đặt sản phẩm nào cho đơn đặt hàng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void btnThemDH_Click(object sender, EventArgs e)
        {
            luu = 1;
            conn.Close();
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
                if (somacuoi < 9)
                    txtMaDH.Text = "DHKH000" + (somacuoi + 1);
                else if (somacuoi >= 9 && somacuoi < 99)
                    txtMaDH.Text = "DHKH00" + (somacuoi + 1);
                else if (somacuoi >= 99 && somacuoi < 999)
                    txtMaDH.Text = "DHKH0" + (somacuoi + 1);
                else
                    txtMaDH.Text = "DHKH" + (somacuoi + 1);
            }

            ////
            conn.Close();

            txtTongtien.Text = "" + 0;
            txtTTGiao.Text = "Chua giao";
            txtTTThanhToan.Text = "Chua thanh toan";
            //cbKieuTra.Text = cbKieuTra.Items[0].ToString();
            cbTongLanGiao.Text = cbTongLanGiao.Items[0].ToString();
            txtConLai.Text = "1";

            groupBoxThongTinDH.Enabled = true;
            btnThemDH.Enabled = false;
            btnXoaDH.Enabled = false;

            btnLuuDH.Enabled = true;
            dgvDonDatHang.Enabled = false;
            cbKH.Enabled = true;
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
                string kieu;
                if (radtratruoc.Checked == true)
                    kieu = "Tra truoc";
                else kieu = "Tra sau";
                cmd = new OleDbCommand("Insert into T_DON_DAT_HANG_KH values('" + txtMaDH.Text + "',TO_DATE('" + dtpNgaydat.Text + "','DD-MM-RR'),'" + cbKH.SelectedValue.ToString() + "','" + txtMaNV.Text + "'," + 0 + ",'Chua thanh toan','" + kieu + "','Chua giao'," + int.Parse(cbTongLanGiao.Text) + ", " + int.Parse(txtConLai.Text) + ")", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            conn.Close();
            conn.Open();
            btnXoaDH.Enabled = true;
            sttdong = -1;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvDonDatHang.CurrentRow;

            //lay ten Khach hang tu ma NCC de hien thi len comboboc
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
            if (row.Cells["kieutt"].Value.ToString() == "Tra truoc")
                radtratruoc.Checked = true;
            else radtrasau.Checked = true;

            if (row.Cells["kieutt"].Value.ToString() == "Tra truoc" && row.Cells["tttt"].Value.ToString() == "Chua thanh toan")
            {
                btnThanhToan.Enabled = true;
                groupBoxsanpham.Enabled = true;
                btnGiaoHang.Enabled = false;
            }
            else if (row.Cells["kieutt"].Value.ToString() == "Tra truoc" && row.Cells["tttt"].Value.ToString() == "Da thanh toan" && (row.Cells["ttgiao"].Value.ToString() == "Chua giao" || row.Cells["ttgiao"].Value.ToString() == "Dang giao"))
            {
                btnThanhToan.Enabled = false;
                groupBoxsanpham.Enabled = false;
                btnGiaoHang.Enabled = true;
            }
            else if (row.Cells["kieutt"].Value.ToString() == "Tra truoc" && row.Cells["tttt"].Value.ToString() == "Da thanh toan" && row.Cells["ttgiao"].Value.ToString() == "Da giao")
            {
                btnThanhToan.Enabled = false;
                groupBoxsanpham.Enabled = false;
                btnGiaoHang.Enabled = false;
            }
            else if (row.Cells["kieutt"].Value.ToString() == "Tra sau" && row.Cells["ttgiao"].Value.ToString() == "Chua giao")
            {
                btnGiaoHang.Enabled = true;
                groupBoxsanpham.Enabled = true;
                btnThanhToan.Enabled = false;
            }
            else if (row.Cells["kieutt"].Value.ToString() == "Tra sau" && (row.Cells["ttgiao"].Value.ToString() == "Dang giao" || row.Cells["ttgiao"].Value.ToString() == "Da giao") && row.Cells["tttt"].Value.ToString() == "Chua thanh toan")
            {
                btnGiaoHang.Enabled = false;
                groupBoxsanpham.Enabled = false;
                btnThanhToan.Enabled = true;
            }
            else if (row.Cells["kieutt"].Value.ToString() == "Tra sau" && (row.Cells["ttgiao"].Value.ToString() == "Dang giao" || row.Cells["ttgiao"].Value.ToString() == "Da giao") && row.Cells["tttt"].Value.ToString() == "Da thanh toan")
            {
                btnGiaoHang.Enabled = false;
                groupBoxsanpham.Enabled = false;
                btnThanhToan.Enabled = false;
            }
            txtTTGiao.Text = row.Cells["ttgiao"].Value.ToString();
            cbTongLanGiao.Text = row.Cells["tonglangiao"].Value.ToString();
            txtConLai.Text = row.Cells["conlai"].Value.ToString();
            //kt tinhtrang thanh toan de hien thi nut nhap hang và khong cho them,xoa, sua san pham
            //if (row.Cells["tttt"].Value.ToString() == "Chua thanh toan")
            //{

            //}
            //else
            //{

            //}
            //if (row.Cells["ttgiao"].Value.ToString() == "Chua giao")
            //{
            //    btnGiaoHang.Enabled = true;
            //    groupBoxsanpham.Enabled = true;
            //}
            //else
            //{
            //    btnGiaoHang.Enabled = false;
            //    groupBoxsanpham.Enabled = false;
            //}
            load_ct_dathang(row.Cells[0].Value.ToString());
            if (dgvCT_DonDatHang.DataSource == null || dgvCT_DonDatHang.Rows.Count <= 0)
            {
                dadatsanpham = false;
            }
            else
            {
                dgvCT_DonDatHang.Rows[0].Selected = false;
                dadatsanpham = true;
            }
            conn.Close();
        }

        int ktma()
        {
            conn.Close();
            conn.Open();
            string s = "select count(*) from T_CT_DAT_HANG_KH where MADDH=('" + txtMaDH.Text + "') and MASP='" + dgvSanPHam.CurrentRow.Cells["masp"].Value.ToString() + "'";
            OleDbCommand cmd = new OleDbCommand(s, conn);
            string o = cmd.ExecuteScalar().ToString();
            int a = int.Parse(o);
            return a;
            conn.Close();

        }
        
        private void btnThemCT_Click(object sender, EventArgs e)
        {

            if (sttdong == -1)
            {
                sttdong = dgvDonDatHang.CurrentRow.Index;
            }
            //int slkho=int.Parse(dgvSanPham.CurrentRow.Cells["soluongkho"].Value.ToString());
            if (txtSoluongmua.Text == "")
            {
                MessageBox.Show("Chưa nhập số lượng đặt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (int.Parse(txtSoluongmua.Text) <= 0)
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
                float sldat = float.Parse(txtSoluongmua.Text);
                float giaban = float.Parse(dgvSanPHam.CurrentRow.Cells["giaban"].Value.ToString());
                float giam_gia = float.Parse(txtGiam.Text);
                tong = tong + ((sldat * giaban) - (sldat * giaban * giam_gia / 100));

                cmd = new OleDbCommand("Insert into T_CT_DAT_HANG_KH values('" + txtMaDH.Text + "','" + dgvSanPHam.CurrentRow.Cells["masp"].Value.ToString() + "'," + int.Parse(txtSoluongmua.Text) + "," + float.Parse(dgvSanPHam.CurrentRow.Cells["giaban"].Value.ToString()) + "," + int.Parse(txtGiam.Text) + ")", conn);
                cmd.ExecuteNonQuery();

                cmd = new OleDbCommand("Update T_DON_DAT_HANG_KH set TONGTIEN=" + tong + " where MADDH='" + txtMaDH.Text + "'", conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //load lai ct don dat

                load_DatHang();
                dgvDonDatHang.Rows[0].Selected = false;
                dgvDonDatHang.FirstDisplayedScrollingRowIndex = sttdong;
                dgvDonDatHang.Rows[sttdong].Selected = true;
                load_ct_dathang(dgvDonDatHang.Rows[sttdong].Cells[0].Value.ToString());
                //
                txtSoluongmua.Clear();
                groupBoxsanpham.Enabled = true;
                if (dgvCT_DonDatHang.Rows.Count <= 0)
                {
                    dadatsanpham = false;
                }
                else
                {
                    dgvCT_DonDatHang.Rows[0].Selected = false;
                    dadatsanpham = true;
                }
                conn.Close();
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
                if (sttdong == -1)
                {
                    sttdong = dgvDonDatHang.CurrentRow.Index;
                }
                cmd = new OleDbCommand("Delete from T_CT_DAT_HANG_KH where MASP='" + dgvCT_DonDatHang.CurrentRow.Cells[0].Value.ToString() + "' and MADDH='" + txtMaDH.Text + "'", conn);
                cmd.ExecuteNonQuery();

                float sldat = float.Parse(dgvCT_DonDatHang.CurrentRow.Cells[1].Value.ToString());
                float giaban = float.Parse(dgvCT_DonDatHang.CurrentRow.Cells[2].Value.ToString());
                float giam_gia = float.Parse(dgvCT_DonDatHang.CurrentRow.Cells[3].Value.ToString());
                tong = tong - ((sldat * giaban) - (sldat * giaban * giam_gia / 100));
                //tong = tong - sldat * giaban;

                cmd = new OleDbCommand("Update T_DON_DAT_HANG_KH set TONGTIEN=" + tong + " where MADDH='" + txtMaDH.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //load lai ct don dat

                load_DatHang();
                dgvDonDatHang.Rows[0].Selected = false;
                dgvDonDatHang.FirstDisplayedScrollingRowIndex = sttdong;
                dgvDonDatHang.Rows[sttdong].Selected = true;
                load_ct_dathang(dgvDonDatHang.Rows[sttdong].Cells[0].Value.ToString());
                //
                txtSoluongmua.Clear();
                groupBoxsanpham.Enabled = true;
                if (dgvCT_DonDatHang.Rows.Count <= 0)
                {
                    dadatsanpham = false;
                }
                else
                {
                    dgvCT_DonDatHang.Rows[0].Selected = false;
                    dadatsanpham = true;
                }
                conn.Close();
                btnXoaCT.Enabled = false;
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

            //txtSoluongmua.Text = dgvCT_DonDatHang.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnXoaDH_Click(object sender, EventArgs e)
        {
            if (dgvDonDatHang.CurrentRow.Cells["tttt"].Value.ToString() == "Da thanh toan")
            {
                MessageBox.Show("Đơn hàng đã thanh toán, không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadLai();
                    conn.Close();
                }

            }
        }

        private void radtratruoc_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    cbTongLanGiao.Enabled = true;
                    cbTongLanGiao.Text = cbTongLanGiao.Items[0].ToString();
                    txtConLai.Text = "1";
                }
            }
        }

        private void radtrasau_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    cbTongLanGiao.Enabled = false;
                    cbTongLanGiao.Text = cbTongLanGiao.Items[0].ToString();
                    txtConLai.Text = "1";
                }
            }
        }

        private void cbTongLanGiao_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTongLanGiao.Text == "1")
            {
                txtConLai.Text = "1";
            }
            if (cbTongLanGiao.Text == "2")
            {
                txtConLai.Text = "2";
            }
            if (cbTongLanGiao.Text == "3")
            {
                txtConLai.Text = "3";
            }
        }

        private void btnGiaoHang_Click(object sender, EventArgs e)
        {
            if (dadatsanpham == true)
            {
               
                if (radtratruoc.Checked == true)
                {
                    
                    frmGiaoHang f = new frmGiaoHang(txtMaDH.Text);
                    f.StartPosition = FormStartPosition.CenterParent;
                    f.Show();
                    btnThanhToan.Enabled = false;
                    btnThemDH.Enabled = false;
                    btnXoaDH.Enabled = false;
                    btnGiaoHang.Enabled = false;
                    btnLammoiHD.Enabled = true;
                }
                else
                {
                    
                    frmGiaoHangTraSau f = new frmGiaoHangTraSau(txtMaDH.Text);
                    f.StartPosition = FormStartPosition.CenterParent;
                    f.Show();
                    btnThanhToan.Enabled = false;
                    btnThemDH.Enabled = false;
                    btnXoaDH.Enabled = false;
                    btnGiaoHang.Enabled = false;
                    btnLammoiHD.Enabled = true;
     
                }
            }
            else MessageBox.Show("Chưa đặt sản phẩm nào cho đơn hàng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvDonDatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDonDatHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.ForeColor = Color.Gray;
            style1.BackColor = Color.LightBlue;
            for (int i = dgvDonDatHang.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) dgvDonDatHang.Rows[i].DefaultCellStyle = style1;
            }
        }

        private void dgvSanPHam_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.ForeColor = Color.Gray;
            style1.BackColor = Color.LightBlue;
            for (int i = dgvSanPHam.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) dgvSanPHam.Rows[i].DefaultCellStyle = style1;
            }
        }

        private void dgvCT_DonDatHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.ForeColor = Color.Gray;
            style1.BackColor = Color.LightBlue;
            for (int i = dgvCT_DonDatHang.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) dgvCT_DonDatHang.Rows[i].DefaultCellStyle = style1;
            }
        }

        private void dgvSanPHam_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            load_giam_gia(dgvSanPHam.CurrentRow.Cells["masp"].Value.ToString());
            conn.Close();
        }
    }
}
