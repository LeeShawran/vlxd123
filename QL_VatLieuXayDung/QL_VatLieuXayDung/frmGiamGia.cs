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
        OleDbConnection conn;
        public frmGiamGia()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void Refresh_GG()
        {
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_GIAM_GIA", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvGG.DataSource = dt;
            conn.Close();
        }

        private void frmGiamGia_Load(object sender, EventArgs e)
        {
            Refresh_GG();
            btnLuu_GG.Enabled = false;
            dtpBatdau_GG.Format = DateTimePickerFormat.Custom;
            dtpBatdau_GG.CustomFormat = "dd/MM/yyyy";
            dtpKetthuc_GG.Format = DateTimePickerFormat.Custom;
            dtpKetthuc_GG.CustomFormat = "dd/MM/yyyy";
        }

        private bool Kiem_tra_khoa_chinh()
        {
            bool tatkt = false;
            string MaGG = txtMaGG_GG.Text;
            OleDbCommand cmd = new OleDbCommand("select * from T_GIAM_GIA", conn);
            OleDbDataReader PK = cmd.ExecuteReader();
            while (PK.Read())
            {
                if (MaGG == PK.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            return tatkt;
        }
        
        private void btnThem_GG_Click(object sender, EventArgs e)
        {
            
            
            if (this.txtMaGG_GG.TextLength == 0 || this.txtChietkhau_GG.TextLength == 0)
            {
                this.lblStatus_GG.ForeColor = Color.Red;
                this.lblStatus_GG.Text = "Bạn chưa nhập thông tin giảm giá !";
            }
            else
            {         
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Insert into T_GIAM_GIA values('" + txtMaGG_GG.Text + "','" + txtChietkhau_GG.Text + "', TO_DATE('" + dtpBatdau_GG.Text + "','DD-MM-RR') , TO_DATE('" + dtpKetthuc_GG.Text + "','DD-MM-RR'))", conn);
                if (Kiem_tra_khoa_chinh())
                {
                    this.lblStatus_GG.ForeColor = Color.Red;
                    this.lblStatus_GG.Text = "Đã có mã giảm giá này !";
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Refresh_GG();
                    txtMaGG_GG.Clear();
                    txtChietkhau_GG.Clear();
                    dtpBatdau_GG.Value = DateTime.Today;
                    dtpKetthuc_GG.Value = DateTime.Today;
                }
            }
        }

        private void dgvGG_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvGG.Rows[e.RowIndex];
                txtMaGG_GG.Text = row.Cells[0].Value.ToString();
                txtChietkhau_GG.Text = row.Cells[1].Value.ToString();
                dtpBatdau_GG.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                dtpKetthuc_GG.Value = DateTime.Parse(row.Cells[3].Value.ToString());
            }
            catch (Exception)
            {
            }
        }

        private void btnXoa_GG_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Delete from T_GIAM_GIA where MAGG='" + txtMaGG_GG.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Refresh_GG();
            txtMaGG_GG.Clear();
            txtChietkhau_GG.Clear();
            dtpBatdau_GG.Value = DateTime.Today;
            dtpKetthuc_GG.Value = DateTime.Today;
        }

        private void btnSua_GG_Click(object sender, EventArgs e)
        {
            txtMaGG_GG.ReadOnly = true;
            btnThem_GG.Enabled = false;
            btnXoa_GG.Enabled = false;
            btnSua_GG.Enabled = false;
            btnLuu_GG.Enabled = true;
        }

        private void btnLuu_GG_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Update T_GIAM_GIA set CHIETKHAU='" + txtChietkhau_GG.Text + "', NGAYBD=TO_DATE('" + dtpBatdau_GG.Text + "','DD-MM-RR'), NGAYKT=TO_DATE('" + dtpKetthuc_GG.Text + "','DD-MM-RR') where MAGG='" + txtMaGG_GG.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Refresh_GG();
            txtMaGG_GG.Clear();
            txtChietkhau_GG.Clear();
            dtpBatdau_GG.Value = DateTime.Today;
            dtpKetthuc_GG.Value = DateTime.Today;
            txtMaGG_GG.ReadOnly = false;
            btnThem_GG.Enabled = true;
            btnXoa_GG.Enabled = true;
            btnSua_GG.Enabled = true;
            btnLuu_GG.Enabled = false;
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
    }
}
