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
    public partial class frmThongKeNhapHang : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        OleDbCommand cmd;
        System.Data.DataTable dt;
        int kieuthongke = 0;
        public frmThongKeNhapHang()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }
        public void loadlai()
        {
            //lay thang he thong
            string thanghethong = "select EXTRACT(MONTH FROM sysdate) from dual";
            cmd = new OleDbCommand(thanghethong, conn);
            string o = cmd.ExecuteScalar().ToString();
            int thang = int.Parse(o);
            //lay nam he thong
            string namhethong = "select EXTRACT(YEAR FROM sysdate) from dual";
            cmd = new OleDbCommand(namhethong, conn);
            string u = cmd.ExecuteScalar().ToString();
            int nam = int.Parse(u);
            cbNam.Text = "" + nam;
            cbThang.Text = "" + thang;
            groupBoxThang.Enabled = false;
            groupBoxThoigian.Enabled = false;
            kieuthongke = 1;
            lbTongsl.Text = "" + 0;
            lbTongtien.Text = "" + 0;
            //xoa datadgridview
            string st = "select T_CT_PHIEU_NHAP.MASP,T_CT_PHIEU_NHAP.MAPN,T_PHIEU_NHAP.NGAYLAP,SOLUONG,T_CT_PHIEU_NHAP.DONGIANHAP from T_PHIEU_NHAP,T_CT_PHIEU_NHAP where T_PHIEU_NHAP.MAPN=T_CT_PHIEU_NHAP.MAPN AND NGAYLAP=TO_DATE('01/01/1870','DD-MM-RR') order by T_CT_PHIEU_NHAP.MAPN asc";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvNhapHang.DataSource = dt;
        }
        private void frmThongKeNhapHang_Load(object sender, EventArgs e)
        {
            conn.Open();
            loadlai();
            conn.Close();
        }

        public void hamThongKe(string lenhSQL)
        {
            float x_tongsl = 0; float x_tongtien = 0;
            adapter = new OleDbDataAdapter(lenhSQL, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm nào bán ra trong thời gian này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadlai();
            }
            else
            {
                dgvNhapHang.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmd = new OleDbCommand("select TENSP from T_SAN_PHAM where MASP='" + dt.Rows[i].Field<string>(0) + "'", conn);
                    string ten = (string)cmd.ExecuteScalar();
                    dgvNhapHang.Rows[i].Cells["tensp"].Value = ten;
                    float a = float.Parse(dgvNhapHang.Rows[i].Cells["soluong"].Value.ToString());
                    float b = float.Parse(dgvNhapHang.Rows[i].Cells["dongia"].Value.ToString());
                    float tien = a * b;
                    dgvNhapHang.Rows[i].Cells["thanhtien"].Value = tien;
                    x_tongsl = x_tongsl + a;
                    x_tongtien = x_tongtien + tien;
                }
                lbTongsl.Text = "" + x_tongsl;
                lbTongtien.Text = "" + x_tongtien;
            }

        }
        private void radNgay_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    groupBoxNgay.Enabled = true;
                    groupBoxThang.Enabled = false;
                    groupBoxThoigian.Enabled = false;
                    kieuthongke = 1;
                }
            }
        }

        private void radThang_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    groupBoxNgay.Enabled = false;
                    groupBoxThang.Enabled = true;
                    groupBoxThoigian.Enabled = false;
                    kieuthongke = 2;
                }
            }
        }

        private void radThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                if (rb.Checked)
                {
                    groupBoxNgay.Enabled = false;
                    groupBoxThang.Enabled = false;
                    groupBoxThoigian.Enabled = true;
                    kieuthongke = 3;
                }
            }
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            if (kieuthongke == 1)
            {

                string st = "select T_CT_PHIEU_NHAP.MASP,T_CT_PHIEU_NHAP.MAPN,T_PHIEU_NHAP.NGAYLAP,SOLUONG,T_CT_PHIEU_NHAP.DONGIANHAP from T_PHIEU_NHAP,T_CT_PHIEU_NHAP where T_PHIEU_NHAP.MAPN=T_CT_PHIEU_NHAP.MAPN AND NGAYLAP=TO_DATE('" + dtpNgay.Text + "','DD-MM-RR') order by T_CT_PHIEU_NHAP.MAPN asc";
                hamThongKe(st);
            }
            else if (kieuthongke == 2)
            {
                string st = "select T_CT_PHIEU_NHAP.MASP,T_CT_PHIEU_NHAP.MAPN,T_PHIEU_NHAP.NGAYLAP,SOLUONG,T_CT_PHIEU_NHAP.DONGIANHAP from T_PHIEU_NHAP,T_CT_PHIEU_NHAP where T_PHIEU_NHAP.MAPN=T_CT_PHIEU_NHAP.MAPN AND EXTRACT(MONTH FROM NGAYLAP)=" + cbThang.Text + " AND EXTRACT(YEAR FROM NGAYLAP)=" + cbNam.Text + " order by T_CT_PHIEU_NHAP.MAPN asc";
                hamThongKe(st);
            }
            else if (kieuthongke == 3)
            {
                string st = "select T_CT_PHIEU_NHAP.MASP,T_CT_PHIEU_NHAP.MAPN,T_PHIEU_NHAP.NGAYLAP,SOLUONG,T_CT_PHIEU_NHAP.DONGIANHAP from T_PHIEU_NHAP,T_CT_PHIEU_NHAP where T_PHIEU_NHAP.MAPN=T_CT_PHIEU_NHAP.MAPN AND NGAYLAP Between TO_DATE('" + dtpTG1.Text + "','DD-MM-RR') and TO_DATE('" + dtpTG2.Text + "','DD-MM-RR') order by T_CT_PHIEU_NHAP.MAPN asc";
                hamThongKe(st);
            }
            conn.Close();
        }

        private void bntLammoi_Click(object sender, EventArgs e)
        {
            conn.Open();
            loadlai();
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
            if (dgvNhapHang.Rows.Count <= 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Title = "Chọn đường dẫn lưu tệp excel";
                s.InitialDirectory = @"c:\";
                s.FileName = "ThongKeNhapHang.xlsx";
                s.Filter = "Excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                s.FilterIndex = 2;
                s.RestoreDirectory = true;
                if (s.ShowDialog() == DialogResult.OK)
                {
                    xuatExcel(dgvNhapHang, s.FileName);
                    MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
