﻿using System;
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
    public partial class frmThongKeXuatHang : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        OleDbCommand cmd;
        System.Data.DataTable dt;
        int kieuthongke = 0;
        public frmThongKeXuatHang()
        {
            InitializeComponent();
            conn = Connect.getConnect();
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
            string st = "select T_CT_HOA_DON.MASP,T_CT_HOA_DON.MAHD,T_HOA_DON.NGAYHD,T_CT_HOA_DON.SOLUONGBAN,T_CT_HOA_DON.DONGIABAN from T_HOA_DON,T_CT_HOA_DON where T_CT_HOA_DON.MAHD=T_HOA_DON.MAHD AND NGAYHD=TO_DATE('01/01/1870','DD-MM-RR') order by T_CT_HOA_DON.MAHD asc ";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            dgvXuatHang.DataSource = dt;
        }
        private void frmThongKeXuatHang_Load(object sender, EventArgs e)
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
                dgvXuatHang.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    cmd = new OleDbCommand("select TENSP from T_SAN_PHAM where MASP='" + dt.Rows[i].Field<string>(0) + "'", conn);
                    string ten = (string)cmd.ExecuteScalar();
                    dgvXuatHang.Rows[i].Cells["tensp"].Value = ten;
                    float a = float.Parse(dgvXuatHang.Rows[i].Cells["soluong"].Value.ToString());
                    float b = float.Parse(dgvXuatHang.Rows[i].Cells["dongia"].Value.ToString());
                    float tien = a * b;
                    dgvXuatHang.Rows[i].Cells["thanhtien"].Value = tien;
                    x_tongsl = x_tongsl + a;
                    x_tongtien = x_tongtien + tien;
                }
                lbTongsl.Text = "" + x_tongsl;
                lbTongtien.Text = "" + x_tongtien;
            }
                  
        }
        private void btnThongke_Click(object sender, EventArgs e)
        {
            conn.Close();
            conn.Open();
            if (kieuthongke == 1)
            {       
                string st = "select T_CT_HOA_DON.MASP,T_CT_HOA_DON.MAHD,T_HOA_DON.NGAYHD,T_CT_HOA_DON.SOLUONGBAN,T_CT_HOA_DON.DONGIABAN from T_HOA_DON,T_CT_HOA_DON where T_CT_HOA_DON.MAHD=T_HOA_DON.MAHD AND NGAYHD=TO_DATE('" + dtpNgay.Text + "','DD-MM-RR') order by T_CT_HOA_DON.MAHD asc ";
                hamThongKe(st);
            }
            else if (kieuthongke == 2)
            {
                string st = "select T_CT_HOA_DON.MASP,T_CT_HOA_DON.MAHD,T_HOA_DON.NGAYHD,T_CT_HOA_DON.SOLUONGBAN,T_CT_HOA_DON.DONGIABAN from T_HOA_DON,T_CT_HOA_DON where T_CT_HOA_DON.MAHD=T_HOA_DON.MAHD AND EXTRACT(MONTH FROM NGAYHD)=" + cbThang.Text + " AND EXTRACT(YEAR FROM NGAYHD)=" + cbNam.Text + " order by T_CT_HOA_DON.MAHD asc ";
                hamThongKe(st);
            }
            else if (kieuthongke == 3)
            {
                string st = "select T_CT_HOA_DON.MASP,T_CT_HOA_DON.MAHD,T_HOA_DON.NGAYHD,T_CT_HOA_DON.SOLUONGBAN,T_CT_HOA_DON.DONGIABAN from T_HOA_DON,T_CT_HOA_DON where T_CT_HOA_DON.MAHD=T_HOA_DON.MAHD AND NGAYHD Between TO_DATE('" + dtpTG1.Text + "','DD-MM-RR') and TO_DATE('" + dtpTG2.Text + "','DD-MM-RR') order by T_CT_HOA_DON.MAHD asc ";
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
            if (dgvXuatHang.Rows.Count <= 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Title = "Chọn đường dẫn lưu tệp excel";
                s.InitialDirectory = @"c:\";
                s.FileName = "ThongKeXuatHang.xlsx";
                s.Filter = "Excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                s.FilterIndex = 2;
                s.RestoreDirectory = true;
                if (s.ShowDialog() == DialogResult.OK)
                {
                    xuatExcel(dgvXuatHang, s.FileName);
                    MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void dgvXuatHang_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.ForeColor = Color.Gray;
            style1.BackColor = Color.LightBlue;
            for (int i = dgvXuatHang.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) dgvXuatHang.Rows[i].DefaultCellStyle = style1;
            }
        }
    }
}
