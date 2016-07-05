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
    public partial class frmGiamGia : Form
    {

        int sttdong = -1;
        OleDbCommand cmd;
        OleDbConnection conn;
        public frmGiamGia()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void load_dot_giam_gia()
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_GIAM_GIA", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvGG.DataSource = dt;
        }
        public void load_ct_giamgia(string madotgiam)
        {
            string s = "select MASP,GIAM from T_CT_GIAM_GIA where MAGG='" + madotgiam + "' order by MASP ASC";
            OleDbDataAdapter adapter = new OleDbDataAdapter(s, conn);
            DataTable dt2 = new DataTable();
            adapter.Fill(dt2);
            dgvCT_DonDatHang.DataSource = dt2;
        }

        public void loadSP()
        {
            string st = "select T_SAN_PHAM.MASP,TENSP,DONGIABAN from T_SAN_PHAM, T_GIA_BAN where T_SAN_PHAM.MASP=T_GIA_BAN.MASP AND T_GIA_BAN.NGAYHIEULUC =(SELECT MAX(T_GIA_BAN.NGAYHIEULUC) FROM  T_GIA_BAN WHERE T_GIA_BAN.NGAYHIEULUC <=(SYSDATE) and T_SAN_PHAM.MASP=T_GIA_BAN.MASP) order by T_SAN_PHAM.MASP ASC";
            OleDbDataAdapter adapter = new OleDbDataAdapter(st, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvSanPHam.DataSource = dt;

        }
        public void Refresh_GG()
        {
            conn.Close();
            conn.Open();
            txtMaNV.Text = Program.mainForm.ma;
            load_dot_giam_gia();
            loadSP();
            groupBoxThongtinGG.Enabled = false;
            btnThem_GG.Enabled = true;
            btnLuu_GG.Enabled = false;
            btnXoa_GG.Enabled = false;
            btnXoaCT.Enabled = false;
            dgvGG.Enabled = true;

            txtMaGG_GG.Clear();
            txtGiam.Clear();


            //xoa chi tiet giam gia
            string s = "select MASP,GIAM from T_CT_GIAM_GIA where MAGG='aaaa'";
            OleDbDataAdapter adapter = new OleDbDataAdapter(s, conn);
            DataTable dt2 = new DataTable();
            adapter.Fill(dt2);
            dgvCT_DonDatHang.DataSource = dt2;
            //
            //dgvSanPHam.Rows[0].Selected = false;
            dgvGG.Rows[0].Selected = false;
            conn.Close();
        }

        private void frmGiamGia_Load(object sender, EventArgs e)
        {
            Refresh_GG();
            dgvGG.Columns["ngaybd"].DefaultCellStyle.Format = @"dd/MM/yyyy";
            dgvGG.Columns["ngaykt"].DefaultCellStyle.Format = @"dd/MM/yyyy";
            ;
            dtpBatdau_GG.Format = DateTimePickerFormat.Custom;
            dtpBatdau_GG.CustomFormat = "dd/MM/yyyy";
            dtpKetthuc_GG.Format = DateTimePickerFormat.Custom;
            dtpKetthuc_GG.CustomFormat = "dd/MM/yyyy";
        }

        private int ktmasptrongdot()
        {
            conn.Close();
            conn.Open();
            string s = "select count(*) from T_CT_GIAM_GIA where MAGG=('" + txtMaGG_GG.Text + "') and MASP='" + dgvSanPHam.CurrentRow.Cells["masp"].Value.ToString() + "'";
            OleDbCommand cmd = new OleDbCommand(s, conn);
            string o = cmd.ExecuteScalar().ToString();
            int a = int.Parse(o);
            return a;
            conn.Close();
        }

        private int ktmasp_cotrongdotkhac()
        {
            conn.Close();
            conn.Open();
            int kq = 0;
            string s = "select count(*) from T_CT_GIAM_GIA where MASP='" + dgvSanPHam.CurrentRow.Cells["masp"].Value.ToString() + "'";
            OleDbCommand cmd = new OleDbCommand(s, conn);
            string o = cmd.ExecuteScalar().ToString();
            int a = int.Parse(o);
            if (a >= 1)
            {
                string lenh = "select MASP from T_GIAM_GIA,T_CT_GIAM_GIA where T_CT_GIAM_GIA.MAGG=T_GIAM_GIA.MAGG and ((NGAYBATDAU<=(SYSDATE)and NGAYKETTHUC >= (SYSDATE)) or (NGAYBATDAU>(SYSDATE)and NGAYKETTHUC >= (SYSDATE)))";
                OleDbDataAdapter adapter = new OleDbDataAdapter(lenh, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i].Field<string>(0) == dgvSanPHam.CurrentRow.Cells["masp"].Value.ToString())
                    {
                        kq = 1;
                        break;
                    }
                }
            }
            else { kq = 0; }
            return kq;
            conn.Close();
        }

        private void btnThem_GG_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            /// MA TU DONG
            string lenh = "select MAGG from T_GIAM_GIA order by MAGG desc";
            OleDbCommand cmd = new OleDbCommand(lenh, conn);
            string macuoi = (string)cmd.ExecuteScalar();

            if (macuoi == null)
            {
                txtMaGG_GG.Text = "GG0001";
            }
            else
            {
                int somacuoi = int.Parse(macuoi.Replace("GG", ""));
                if (somacuoi < 9)
                    txtMaGG_GG.Text = "GG000" + (somacuoi + 1);
                else if (somacuoi >= 9 && somacuoi < 99)
                    txtMaGG_GG.Text = "GG00" + (somacuoi + 1);
                else if (somacuoi >= 99 && somacuoi < 999)
                    txtMaGG_GG.Text = "GG0" + (somacuoi + 1);
                else
                    txtMaGG_GG.Text = "GG" + (somacuoi + 1);
            }
            dtpBatdau_GG.Value = DateTime.Today;
            dtpKetthuc_GG.Value = DateTime.Today;
            ////
            conn.Close();


            //cbKieuTra.Text = cbKieuTra.Items[0].ToString();

            groupBoxThongtinGG.Enabled = true;
            btnThem_GG.Enabled = false;
            btnXoa_GG.Enabled = false;
            btnLuu_GG.Enabled = true;
            dgvGG.Enabled = false;
        }
        public void them()
        {
            if (dtpBatdau_GG.Value > dtpKetthuc_GG.Value)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Insert into T_GIAM_GIA values('" + txtMaGG_GG.Text + "', TO_DATE('" + dtpBatdau_GG.Text + "','DD-MM-RR') , TO_DATE('" + dtpKetthuc_GG.Text + "','DD-MM-RR'),'" + txtMaNV.Text + "')", conn);

                cmd.ExecuteNonQuery();
                Refresh_GG();
                conn.Close();

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaGG_GG.Clear();
                dtpBatdau_GG.Value = DateTime.Today;
                dtpKetthuc_GG.Value = DateTime.Today;
            }
        }

        private void btnXoa_GG_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dir;
                dir = MessageBox.Show("Bạn có muốn xóa không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dir == DialogResult.Yes)
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("Delete from T_GIAM_GIA where MAGG='" + txtMaGG_GG.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Refresh_GG();
                    conn.Close();
                    txtMaGG_GG.Clear();
                    dtpBatdau_GG.Value = DateTime.Today;
                    dtpKetthuc_GG.Value = DateTime.Today;
                }
            }
            catch { MessageBox.Show("Không thê xóa"); conn.Close(); }
        }

        private void btnLuu_GG_Click(object sender, EventArgs e)
        {
            them();   
        }

        private void dtpKetthuc_GG_ValueChanged(object sender, EventArgs e)
        {
            if (dtpBatdau_GG.Value > dtpKetthuc_GG.Value)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpBatdau_GG.Value = DateTime.Today;
                dtpKetthuc_GG.Value = DateTime.Today;
            }
        }

        private void btnThemCT_Click(object sender, EventArgs e)
        {
            if (sttdong == -1)
            {
                sttdong = dgvGG.CurrentRow.Index;
            }
            if (txtGiam.Text == "")
            {
                MessageBox.Show("Chưa nhập mức giảm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (int.Parse(txtGiam.Text) <= 0)
            {
                MessageBox.Show("Mức giảm phải > 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (ktmasp_cotrongdotkhac() == 1)
            {
                MessageBox.Show("Sản phẩm này hiện có trong đợt giảm giá khác, và đợt giảm giá đó chưa hết hiệu lực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (ktmasptrongdot() >= 1)
            {
                MessageBox.Show("Sản phẩm này đã giảm rồi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                cmd = new OleDbCommand("Insert into T_CT_GIAM_GIA values('" + txtMaGG_GG.Text + "','" + dgvSanPHam.CurrentRow.Cells["masp"].Value.ToString() + "'," + int.Parse(txtGiam.Text) + ")", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //load lai ct giam gia

                load_dot_giam_gia();
                dgvGG.Rows[0].Selected = false;
                dgvGG.FirstDisplayedScrollingRowIndex = sttdong;
                dgvGG.Rows[sttdong].Selected = true;
                load_ct_giamgia(dgvGG.Rows[sttdong].Cells[0].Value.ToString());
                //
                txtGiam.Clear();
                groupBoxsanpham.Enabled = true;
                conn.Close();
            }
        }

        private void dgvGG_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            btnXoa_GG.Enabled = true;
            sttdong = -1;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvGG.CurrentRow;

            txtMaGG_GG.Text = row.Cells["ma"].Value.ToString();
            dtpBatdau_GG.Value = DateTime.Parse(row.Cells["ngaybd"].Value.ToString());
            dtpKetthuc_GG.Value = DateTime.Parse(row.Cells["ngaykt"].Value.ToString());
            txtMaNV.Text = row.Cells["manv"].Value.ToString();
            load_ct_giamgia(row.Cells[0].Value.ToString());
            //
            conn.Close();
        }

        private void dgvCT_DonDatHang_Click(object sender, EventArgs e)
        {
            btnXoaCT.Enabled = true;
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
                    sttdong = dgvGG.CurrentRow.Index;
                }
                cmd = new OleDbCommand("Delete from T_CT_GIAM_GIA where MASP='" + dgvCT_DonDatHang.CurrentRow.Cells[0].Value.ToString() + "' and MAGG='" + txtMaGG_GG.Text + "'", conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                load_dot_giam_gia();
                dgvGG.Rows[0].Selected = false;
                dgvGG.FirstDisplayedScrollingRowIndex = sttdong;
                dgvGG.Rows[sttdong].Selected = true;
                load_ct_giamgia(dgvGG.Rows[sttdong].Cells[0].Value.ToString());
                //
                txtGiam.Clear();
                groupBoxsanpham.Enabled = true;
                conn.Close();
                btnXoaCT.Enabled = false;
            }
        }

        private void btnLammoiHD_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            Refresh_GG();
            conn.Close();
        }

        private void dgvGG_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.ForeColor = Color.Gray;
            style1.BackColor = Color.LightBlue;
            for (int i = dgvGG.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) dgvGG.Rows[i].DefaultCellStyle = style1;
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

        private void txtGiam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true; 
        }
    }
}
