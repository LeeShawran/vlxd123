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
    public partial class frmThongKeTonKho : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        OleDbCommand cmd;
        System.Data.DataTable dt;
        public frmThongKeTonKho()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void loadlai()
        {
            string st = "select * from T_SAN_PHAM  order by MASP asc";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            var source = new AutoCompleteStringCollection();
            foreach (DataRow i in dt.Rows)
                source.Add(i.Field<string>(1));
            txttimkiem.AutoCompleteCustomSource = source;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Clear(); ;
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int nhap = 0; int ban = 0; int lai = 0; int tongtien = 0; int dangcho_xuatkho = 0; int dangcho_nhapkho = 0;
                string lenh1 = "select MASP from T_SAN_PHAM where MASP='" + dt.Rows[i].Field<string>(0) + "'";
                OleDbCommand cmd1 = new OleDbCommand(lenh1, conn);
                string ma = cmd1.ExecuteScalar().ToString();

                string lenh2 = "select TENSP from T_SAN_PHAM where MASP='" + dt.Rows[i].Field<string>(0) + "'";
                OleDbCommand cmd2 = new OleDbCommand(lenh2, conn);
                string ten = cmd2.ExecuteScalar().ToString();

                string lenh3 = "select SOLUONG from T_SAN_PHAM where MASP='" + dt.Rows[i].Field<string>(0) + "'";
                OleDbCommand cmd3 = new OleDbCommand(lenh3, conn);
                int soluong = Convert.ToInt32(cmd3.ExecuteScalar().ToString());

                try
                {
                    string lenh4 = "select DONGIANHAP from T_GIA_NHAP where MASP='" + dt.Rows[i].Field<string>(0) + "' ORDER BY NGAYAPDUNG desc";
                    OleDbCommand cmd4 = new OleDbCommand(lenh4, conn);
                    nhap = Convert.ToInt32(cmd4.ExecuteScalar().ToString());
                }
                catch
                {
                    nhap = 0;
                }

                try
                {
                    string lenh5 = "select DONGIABAN from T_GIA_BAN where MASP='" + dt.Rows[i].Field<string>(0) + "' ORDER BY NGAYHIEULUC desc";
                    OleDbCommand cmd5 = new OleDbCommand(lenh5, conn);
                    ban = Convert.ToInt32(cmd5.ExecuteScalar().ToString());
                }
                catch
                {
                    ban = 0;
                }

                if (ban - nhap > 0)
                    lai = ban - nhap;
                else lai = 0;

                tongtien = nhap * soluong;
                try
                {
                    string lenh6 = "select SUM(SOLUONG) from T_DON_DAT_HANG_NCC,T_CT_DAT_HANG_NCC where T_DON_DAT_HANG_NCC.MADATNCC=T_CT_DAT_HANG_NCC.MADATNCC AND MASP='" + dt.Rows[i].Field<string>(0) + "' AND TINHTRANGNHAP='Chua nhap'";
                    OleDbCommand cmd6 = new OleDbCommand(lenh6, conn);
                    dangcho_nhapkho = Convert.ToInt32(cmd6.ExecuteScalar().ToString());
                }
                catch
                {
                    dangcho_nhapkho = 0;
                }

                try
                {
                    string lenh7 = "select SUM(SOLUONG) from T_DON_DAT_HANG_KH,T_CT_DAT_HANG_KH where T_DON_DAT_HANG_KH.MADDH=T_CT_DAT_HANG_KH.MADDH AND MASP='" + dt.Rows[i].Field<string>(0) + "' AND(T_DON_DAT_HANG_KH.TINHTRANG_THANHTOAN='Chua thanh toan' OR (T_DON_DAT_HANG_KH.TINHTRANGGIAO='Chua giao' AND T_DON_DAT_HANG_KH.TINHTRANG_THANHTOAN='Chua thanh toan'))";
                    OleDbCommand cmd7 = new OleDbCommand(lenh7, conn);
                    dangcho_xuatkho = Convert.ToInt32(cmd7.ExecuteScalar().ToString());
                }
                catch
                {
                    dangcho_xuatkho = 0;
                }

                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["masp"].Value = ma;
                dataGridView1.Rows[i].Cells["tensp"].Value = ten;
                dataGridView1.Rows[i].Cells["soluong"].Value = soluong;
                dataGridView1.Rows[i].Cells["choxuat"].Value = dangcho_xuatkho;
                dataGridView1.Rows[i].Cells["chonhap"].Value = dangcho_nhapkho;
                dataGridView1.Rows[i].Cells["gianhap"].Value = nhap;
                dataGridView1.Rows[i].Cells["giaban"].Value = ban;
                dataGridView1.Rows[i].Cells["loi"].Value = lai;
                dataGridView1.Rows[i].Cells["tongton"].Value = tongtien;

            }

            //dataGridView1.DataSource=dt;
            // for (int i = 0; i< dt.Rows.Count; i++)
            // {
            //     int gianhap = 0; int giaban = 0; int loi = 0; int tongtiennhap = 0;
            //     try
            //     {
            //         //MessageBox.Show(dataGridView1.Rows[i].Cells["masp"].Value.ToString());
            //         string lenh1 = "select DONGIANHAP from T_GIA_NHAP where MASP='" + dataGridView1.Rows[i].Cells["masp"].Value.ToString() + "' ORDER BY NGAYAPDUNG desc";
            //         OleDbCommand cmd1 = new OleDbCommand(lenh1, conn);
            //         gianhap = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
            //         //MessageBox.Show("" + gianhap);
            //     }
            //     catch
            //     {
            //         gianhap = 0;
            //         //MessageBox.Show("loi");
            //     }

            //     try
            //     {
            //         string lenh2 = "select DONGIABAN from T_GIA_BAN where MASP='" + dataGridView1.Rows[i].Cells["masp"].Value.ToString() + "' ORDER BY NGAYHIEULUC desc";
            //         OleDbCommand cmd2 = new OleDbCommand(lenh2, conn);
            //         giaban = Convert.ToInt32(cmd2.ExecuteScalar().ToString());
            //     }
            //     catch
            //     {
            //         giaban = 0;
            //     }
            //     if (giaban - gianhap > 0)
            //         loi = giaban - gianhap;
            //     else loi = 0;

            //     tongtiennhap = gianhap * int.Parse(dataGridView1.Rows[i].Cells["soluong"].Value.ToString());

            //         dataGridView1.Rows[i].Cells["gianhap"].Value = 1;
            //         dataGridView1.Rows[i].Cells["giaban"].Value = 2;
            //         dataGridView1.Rows[i].Cells["loi"].Value = loi;
            //         dataGridView1.Rows[i].Cells["tongton"].Value = tongtiennhap;
            // }

            // //ListViewItem lst = lvsanpham.SelectedItems[0];
            // //lst.SubItems[0].Text = "00";
            // //lst.SubItems[1].Text = "11";
            // //lst.SubItems[2].Text = "2";
            // //lst.SubItems[3].Text = "3";
            // //lst.SubItems[4].Text = "4";

            // //lvsanpham.Items.Add(lst);
        }
        private void frmThongKeTonKho_Load(object sender, EventArgs e)
        {
           conn.Open();
           loadlai();
           conn.Close();
        }

        
        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = false;
            adapter = new OleDbDataAdapter("select * from T_SAN_PHAM", conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            Boolean kq = false;
            dataGridView1.ClearSelection();

            if (e.KeyCode == Keys.Enter)
            {

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString().ToLower() == txttimkiem.Text.ToLower())
                    {
                        dataGridView1.FirstDisplayedScrollingRowIndex = i;
                        kq = true;
                        dataGridView1.Rows[i].Selected = true;
                        break;
                    }
                }

                if (kq == false)
                    MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            if (dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SaveFileDialog s = new SaveFileDialog();
                s.Title = "Chọn đường dẫn lưu tệp excel";
                s.InitialDirectory = @"c:\";
                s.FileName = "BaoCaoTonKho.xlsx";
                s.Filter = "Excel file (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                s.FilterIndex = 2;
                s.RestoreDirectory = true;
                if (s.ShowDialog() == DialogResult.OK)
                {
                    xuatExcel(dataGridView1, s.FileName);
                    MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void bntLammoi_Click(object sender, EventArgs e)
        {
            conn.Open();
            loadlai();
            conn.Close();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.ForeColor = Color.Gray;
            style1.BackColor = Color.LightBlue;
            for (int i = dataGridView1.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) dataGridView1.Rows[i].DefaultCellStyle = style1;
            }
        }
    }
}
