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
    public partial class frmDSHoadon : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        System.Data.DataTable dt;
        bool chon=false;
        public frmDSHoadon()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void load_HoaDon()
        {
            string st = "select * from T_HOA_DON";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvHoaDon.DataSource = dt;
        }

        public void loadCT_HoaDon(string mahoadon)
        {
            string st = "select MASP,SOLUONGBAN,DONGIABAN from T_CT_HOA_DON where MAHD='" + mahoadon + "' order by MASP asc";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvCT_HD.DataSource = dt;

        }
        public void loadLai()
        {
            
            load_HoaDon();
            ///xoa chi tiet hoa don
            string st = "select MASP,SOLUONGBAN,DONGIABAN from T_CT_HOA_DON where MAHD='aaa' order by MASP asc";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvCT_HD.DataSource = dt;

        }
        private void frmDSHoadon_Load(object sender, EventArgs e)
        {
            conn.Open();
            dgvHoaDon.Columns["ngaylap"].DefaultCellStyle.Format = @"dd/MM/yyyy";
            loadLai();
            conn.Close();
        }

        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            loadCT_HoaDon(dgvHoaDon.CurrentRow.Cells[0].Value.ToString());
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
            string st = "select T_HOA_DON.* from T_HOA_DON,T_CT_HOA_DON where T_CT_HOA_DON.MAHD=T_HOA_DON.MAHD AND NGAYHD Between TO_DATE('" + dtpTG1.Text + "','DD-MM-RR') and TO_DATE('" + dtpTG2.Text + "','DD-MM-RR') order by T_HOA_DON.MAHD asc ";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvHoaDon.DataSource = dt;
            if (dgvHoaDon.Rows.Count <= 0)
            {
                MessageBox.Show("Không có hóa đơn trong khoảng thời gian được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //
            ///xoa chi tiet hoa don
            string xoa = "select MASP,SOLUONGBAN,DONGIABAN from T_CT_HOA_DON where MAHD='aaa' order by MASP asc";
            adapter = new OleDbDataAdapter(xoa, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvCT_HD.DataSource = dt;
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
        private void btnExcelHD_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.Rows.Count <= 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Title = "Chọn đường dẫn lưu tệp excel";
                s.InitialDirectory = @"c:\";
                s.FileName = "DanhSachHoaDon.xlsx";
                s.Filter = "Excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                s.FilterIndex = 2;
                s.RestoreDirectory = true;
                if (s.ShowDialog() == DialogResult.OK)
                {
                    xuatExcel(dgvHoaDon, s.FileName);
                    MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void btnExcelCT_HD_Click(object sender, EventArgs e)
        {
            if (dgvCT_HD.Rows.Count <= 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Title = "Chọn đường dẫn lưu tệp excel";
                s.InitialDirectory = @"c:\";
                s.FileName = "DanhSachChiTiet_HoaDon.xlsx";
                s.Filter = "Excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                s.FilterIndex = 2;
                s.RestoreDirectory = true;
                if (s.ShowDialog() == DialogResult.OK)
                {
                    xuatExcel(dgvCT_HD, s.FileName);
                    MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
