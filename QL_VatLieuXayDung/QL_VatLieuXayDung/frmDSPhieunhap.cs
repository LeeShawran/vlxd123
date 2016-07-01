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
    public partial class frmDSPhieunhap : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        System.Data.DataTable dt;
        bool chon = false;
        public frmDSPhieunhap()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void load_PhieuNhap()
        {
            string st = "select * from T_PHIEU_NHAP";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvPhieunhap.DataSource = dt;
        }

        public void loadCT_Phieunhap(string maphieunhap)
        {
            string st = "select MASP,DONGIANHAP,SOLUONG from T_CT_PHIEU_NHAP where MAPN='" + maphieunhap + "' order by MASP asc";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvCT_NhapHang.DataSource = dt;
        }

        public void loadLai()
        {
            load_PhieuNhap();
            ///xoa chi tiet hoa don
            string st = "select MASP,DONGIANHAP,SOLUONG from T_CT_PHIEU_NHAP where MAPN='aaa' order by MASP asc";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvCT_NhapHang.DataSource = dt;
        }

        private void frmDSPhieunhap_Load(object sender, EventArgs e)
        {
            conn.Open();
            dgvPhieunhap.Columns["ngaylapcol"].DefaultCellStyle.Format = @"dd/MM/yyyy";
            loadLai();
            conn.Close();
        }

        private void dgvPhieunhap_Click(object sender, EventArgs e)
        {
            loadCT_Phieunhap(dgvPhieunhap.CurrentRow.Cells[0].Value.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox ck = sender as System.Windows.Forms.CheckBox;
            if (ck != null)
            {
                if (ck.Checked)
                {
                    groupBox1.Enabled = true;
                    btnLoc.Enabled = true;
                    chon = true;
                }
                else
                {
                    groupBox1.Enabled = false;
                    btnLoc.Enabled = false;
                    chon = false;
                    conn.Open();
                    loadLai();
                    conn.Close();
                }
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            string st = "select T_PHIEU_NHAP.* from T_PHIEU_NHAP,T_CT_PHIEU_NHAP where T_CT_PHIEU_NHAP.MAPN=T_PHIEU_NHAP.MAPN AND NGAYLAP Between TO_DATE('" + dtpTG1.Text + "','DD-MM-RR') and TO_DATE('" + dtpTG2.Text + "','DD-MM-RR') order by T_PHIEU_NHAP.MAPN asc ";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvPhieunhap.DataSource = dt;
            if (dgvPhieunhap.Rows.Count <= 0)
            {
                MessageBox.Show("Không có phiếu nhập trong khoảng thời gian được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //
            ///xoa chi tiet hoa don
            string xoa = "select MASP,DONGIANHAP,SOLUONG from T_CT_PHIEU_NHAP where MAPN='aaa' order by MASP asc";
            adapter = new OleDbDataAdapter(xoa, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvCT_NhapHang.DataSource = dt;
        }

        private void bntLammoi_Click(object sender, EventArgs e)
        {
            conn.Open();
            loadLai();
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

        private void btnExcelPN_Click(object sender, EventArgs e)
        {
            if (dgvPhieunhap.Rows.Count <= 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Title = "Chọn đường dẫn lưu tệp excel";
                s.InitialDirectory = @"c:\";
                s.FileName = "Danh_sach_phieu_nhap.xlsx";
                s.Filter = "Excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                s.FilterIndex = 2;
                s.RestoreDirectory = true;
                if (s.ShowDialog() == DialogResult.OK)
                {
                    xuatExcel(dgvPhieunhap, s.FileName);
                    MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExcelCT_PN_Click(object sender, EventArgs e)
        {
            if (dgvCT_NhapHang.Rows.Count <= 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Title = "Chọn đường dẫn lưu tệp excel";
                s.InitialDirectory = @"c:\";
                s.FileName = "Danh_sach_chi_tiet_phieu_nhap.xlsx";
                s.Filter = "Excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                s.FilterIndex = 2;
                s.RestoreDirectory = true;
                if (s.ShowDialog() == DialogResult.OK)
                {
                    xuatExcel(dgvCT_NhapHang, s.FileName);
                    MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        


    }
}
