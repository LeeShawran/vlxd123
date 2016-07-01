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
    public partial class frmDSPhieugiao : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        System.Data.DataTable dt;
        bool chon = false;
        public frmDSPhieugiao()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void load_PhieuGiao()
        {
            string st = "select * from T_PHIEU_GIAO";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvPhieu_Giao.DataSource = dt;
        }

        public void loadCT_PhieuGiao(string maphieugiao)
        {
            string st = "select MASP,SOLUONG_CONGIAO,SOLUONGGIAO from T_CT_PHIEU_GIAO where MAPHIEUGIAO='" + maphieugiao + "' order by MASP asc";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvCT_PhieuGiao.DataSource = dt;

        }

        public void loadLai()
        {
            load_PhieuGiao();
            ///xoa chi tiet hoa don
            string st = "select select MASP,SOLUONG_CONGIAO,SOLUONGGIAO from T_CT_PHIEU_GIAO where MAPHIEUGIAO='aaa' order by MASP asc";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvCT_PhieuGiao.DataSource = dt;
        }

        private void fmDSPhieugiao_Load(object sender, EventArgs e)
        {
            conn.Open();
            dgvPhieu_Giao.Columns["ngaygiao"].DefaultCellStyle.Format = @"dd/MM/yyyy";
            loadLai();
            conn.Close();
        }

        private void dgvPhieu_Giao_Click(object sender, EventArgs e)
        {
            loadCT_PhieuGiao(dgvPhieu_Giao.CurrentRow.Cells[0].Value.ToString());
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
            string st = "select T_PHIEU_GIAO.* from T_PHIEU_GIAO,T_CT_PHIEU_GIAO where T_CT_PHIEU_GIAO.MAPHIEUGIAO=T_PHIEU_GIAO.MAPHIEUGIAO AND NGAYGIAO Between TO_DATE('" + dtpTG1.Text + "','DD-MM-RR') and TO_DATE('" + dtpTG2.Text + "','DD-MM-RR') order by T_HOA_DON.MAHD asc ";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvPhieu_Giao.DataSource = dt;
            if (dgvPhieu_Giao.Rows.Count <= 0)
            {
                MessageBox.Show("Không có phiếu giao trong khoảng thời gian được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //
            ///xoa chi tiet hoa don
            string xoa = "select MASP,SOLUONG_CONGIAO,SOLUONGGIAO from T_CT_PHIEU_GIAO where MAPHIEUGIAO='aaa' order by MASP asc";
            adapter = new OleDbDataAdapter(xoa, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvCT_PhieuGiao.DataSource = dt;
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

        private void btnExcelPG_Click(object sender, EventArgs e)
        {
            if (dgvPhieu_Giao.Rows.Count <= 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Title = "Chọn đường dẫn lưu tệp excel";
                s.InitialDirectory = @"c:\";
                s.FileName = "Danh_sach_phieu_giao.xlsx";
                s.Filter = "Excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                s.FilterIndex = 2;
                s.RestoreDirectory = true;
                if (s.ShowDialog() == DialogResult.OK)
                {
                    xuatExcel(dgvPhieu_Giao, s.FileName);
                    MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnExcelCT_PG_Click(object sender, EventArgs e)
        {
            if (dgvCT_PhieuGiao.Rows.Count <= 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Title = "Chọn đường dẫn lưu tệp excel";
                s.InitialDirectory = @"c:\";
                s.FileName = "Danh_sach_chi_tiet_phieu_giao.xlsx";
                s.Filter = "Excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                s.FilterIndex = 2;
                s.RestoreDirectory = true;
                if (s.ShowDialog() == DialogResult.OK)
                {
                    xuatExcel(dgvCT_PhieuGiao, s.FileName);
                    MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
