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
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;

namespace QL_VatLieuXayDung
{
    public partial class frmThongKeSanPham : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        OleDbCommand cmd;
        DataTable dt;
        int kieuthongke = 0;
        public frmThongKeSanPham()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

      
        public void load_SanPham()
        {
            string st = "select MASP,TENSP from T_SAN_PHAM order by MASP ASC";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvSanPham.DataSource = dt;
            var source = new AutoCompleteStringCollection();
            foreach (DataRow i in dt.Rows)
                source.Add(i.Field<string>(1));
            txttimkiem.AutoCompleteCustomSource = source;
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

            load_SanPham();
            cbNam.Text = "" + nam;
            cbThang.Text = "" + thang;
            groupBoxNgay.Enabled = true;
            groupBoxThang.Enabled = false;
            groupBoxThoigian.Enabled = false;
            kieuthongke = 1;
            chart1.Series.Clear();
        }
        //
        decimal laytongnhap_theongay(string masp)
        {
            decimal tong = 0;
            adapter = new OleDbDataAdapter("select SOLUONG from T_CT_PHIEU_NHAP,T_PHIEU_NHAP where T_CT_PHIEU_NHAP.MAPN=T_PHIEU_NHAP.MAPN AND NGAYLAP=TO_DATE('" + dtpNgay.Text + "','DD-MM-RR') AND MASP='" + masp + "'", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow i in dt.Rows)
                tong += i.Field<decimal>(0);
           
            return tong;
        }
        decimal laytongban_theongay(string masp)
        {
            decimal tong = 0;
            adapter = new OleDbDataAdapter("select SOLUONGBAN from T_CT_HOA_DON, T_HOA_DON where T_CT_HOA_DON.MAHD=T_HOA_DON.MAHD AND NGAYHD=TO_DATE('" + dtpNgay.Text + "','DD-MM-RR') AND MASP='" + masp + "'", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow i in dt.Rows)
            {
                tong += i.Field<decimal>(0);
            }         
            return tong;
        }
        //
        decimal laytongban_theoThang(string masp)
        {
            decimal tong = 0;
            adapter = new OleDbDataAdapter("SELECT SOLUONGBAN from T_CT_HOA_DON, T_HOA_DON WHERE T_CT_HOA_DON.MAHD=T_HOA_DON.MAHD and EXTRACT(MONTH FROM NGAYHD)="+ cbThang.Text +" AND EXTRACT(YEAR FROM NGAYHD)="+cbNam.Text+"  AND MASP='"+masp+"'", conn);
            dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow i in dt.Rows)
                tong += i.Field<decimal>(0);
            return tong;
        }

        decimal laytongnhap_theoThang(string masp)
        {
            decimal tong = 0;
            adapter = new OleDbDataAdapter("select SOLUONG from T_CT_PHIEU_NHAP,T_PHIEU_NHAP where T_CT_PHIEU_NHAP.MAPN=T_PHIEU_NHAP.MAPN AND EXTRACT(MONTH FROM NGAYLAP)=" + cbThang.Text + " AND EXTRACT(YEAR FROM NGAYLAP)=" + cbNam.Text + "  AND MASP='" + masp + "'", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow i in dt.Rows)
                tong += i.Field<decimal>(0);
            return tong;
        }
        //
        decimal laytongban_theokhoangthoigian(string masp)
        {
            decimal tong = 0;
            adapter = new OleDbDataAdapter("select SOLUONGBAN from T_CT_HOA_DON, T_HOA_DON where T_CT_HOA_DON.MAHD=T_HOA_DON.MAHD AND NGAYHD Between TO_DATE('"+ dtpTG1.Text +"','DD-MM-RR') and TO_DATE('"+ dtpTG2.Text +"','DD-MM-RR') AND MASP='"+ masp +"'", conn);
            dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow i in dt.Rows)
                tong += i.Field<decimal>(0);
            return tong;
        }

        decimal laytongnhap_theokhoangthoigian(string masp)
        {
            decimal tong = 0;
            adapter = new OleDbDataAdapter("select SOLUONG from T_CT_PHIEU_NHAP,T_PHIEU_NHAP where T_CT_PHIEU_NHAP.MAPN=T_PHIEU_NHAP.MAPN AND NGAYLAP Between TO_DATE('" + dtpTG1.Text + "','DD-MM-RR') and TO_DATE('" + dtpTG2.Text + "','DD-MM-RR') AND MASP='" + masp + "'", conn);
            dt = new DataTable();
            adapter.Fill(dt);
            foreach (DataRow i in dt.Rows)
                tong += i.Field<decimal>(0);
            return tong;
        }
        private void frmThongKeSanPham_Load(object sender, EventArgs e)
        {
            conn.Open();
            loadlai();
            conn.Close();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            if (kieuthongke == 1)
            {
                txtnhap.Text = laytongnhap_theongay(dgvSanPham.CurrentRow.Cells[0].Value.ToString()) + "";
                txtban.Text = laytongban_theongay(dgvSanPham.CurrentRow.Cells[0].Value.ToString()) + "";
                if (txtnhap.Text == "0" && txtban.Text == "0")
                {
                    chart1.Series.Clear();
                    MessageBox.Show("Không có kết quả nhập / xuất nào thuộc sản phẩm trong thời gian này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int max = int.Parse(txtnhap.Text);
                    if (max < int.Parse(txtban.Text))
                        max = int.Parse(txtban.Text);

                    chart1.ChartAreas[0].AxisY.Maximum = max;
                    string[] Mangtencot = { "Nhập", "Bán" };
                    int[] MangTien = { int.Parse(txtnhap.Text), int.Parse(txtban.Text) };
                    chart1.Series.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        // Add series.
                        Series series = this.chart1.Series.Add(Mangtencot[i]);

                        // Add point.
                        series.Points.Add(MangTien[i]);
                    }
                }
                
 
            }
            else if (kieuthongke == 2)
            {
                txtnhap.Text = laytongnhap_theoThang(dgvSanPham.CurrentRow.Cells[0].Value.ToString()) + "";
                txtban.Text = laytongban_theoThang(dgvSanPham.CurrentRow.Cells[0].Value.ToString()) + "";
                if (txtnhap.Text == "0" && txtban.Text == "0")
                {
                    chart1.Series.Clear();
                    MessageBox.Show("Không có kết quả nhập / xuất nào thuộc sản phẩm trong thời gian này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int max = int.Parse(txtnhap.Text);
                    if (max < int.Parse(txtban.Text))
                        max = int.Parse(txtban.Text);

                    chart1.ChartAreas[0].AxisY.Maximum = max;
                    string[] Mangtencot = { "Nhập", "Bán" };
                    int[] MangTien = { int.Parse(txtnhap.Text), int.Parse(txtban.Text) };
                    chart1.Series.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        // Add series.
                        Series series = this.chart1.Series.Add(Mangtencot[i]);

                        // Add point.
                        series.Points.Add(MangTien[i]);
                    }
                }

            }
            else if (kieuthongke == 3)
            {
                txtban.Text = laytongban_theokhoangthoigian(dgvSanPham.CurrentRow.Cells[0].Value.ToString()) + "";
                txtnhap.Text = laytongnhap_theokhoangthoigian(dgvSanPham.CurrentRow.Cells[0].Value.ToString()) + "";
                if (txtnhap.Text == "0" && txtban.Text == "0")
                {
                    chart1.Series.Clear();
                    MessageBox.Show("Không có kết quả nhập / xuất nào thuộc sản phẩm trong thời gian này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int max = int.Parse(txtnhap.Text);
                    if (max < int.Parse(txtban.Text))
                        max = int.Parse(txtban.Text);

                    chart1.ChartAreas[0].AxisY.Maximum = max;
                    string[] Mangtencot = { "Nhập", "Bán" };
                    int[] MangTien = { int.Parse(txtnhap.Text), int.Parse(txtban.Text) };
                    chart1.Series.Clear();
                    for (int i = 0; i < 2; i++)
                    {
                        // Add series.
                        Series series = this.chart1.Series.Add(Mangtencot[i]);

                        // Add point.
                        series.Points.Add(MangTien[i]);
                    }
                }
             
            }
        }

        private void dgvSanPham_Click(object sender, EventArgs e)
        {
            btnThongke.Enabled = true;
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

        private void bntLammoi_Click(object sender, EventArgs e)
        {
            conn.Open();
            loadlai();
            conn.Close();
        }

        private void txttimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            dgvSanPham.CurrentRow.Selected = false;
            adapter = new OleDbDataAdapter("select * from T_SAN_PHAM", conn);
            dt = new System.Data.DataTable();
            adapter.Fill(dt);
            Boolean kq = false;
            dgvSanPham.ClearSelection();

            if (e.KeyCode == Keys.Enter)
            {

                for (int i = 0; i < dgvSanPham.Rows.Count; i++)
                {
                    if (dgvSanPham.Rows[i].Cells[1].Value.ToString().ToLower() == txttimkiem.Text.ToLower())
                    {
                        dgvSanPham.FirstDisplayedScrollingRowIndex = i;
                        kq = true;
                        dgvSanPham.Rows[i].Selected = true;
                        break;
                    }
                }

                if (kq == false)
                    MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvSanPham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewCellStyle style1 = new DataGridViewCellStyle();
            //style1.ForeColor = Color.Gray;
            style1.BackColor = Color.LightBlue;
            for (int i = dgvSanPham.RowCount - 1; i >= 0; i--)
            {
                if (i % 2 == 0) dgvSanPham.Rows[i].DefaultCellStyle = style1;
            }
        }
    }
}
