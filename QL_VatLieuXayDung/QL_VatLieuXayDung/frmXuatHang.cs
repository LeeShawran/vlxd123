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
    public partial class frmXuatHang : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        OleDbCommand cmd;
        DataTable dt;
        float tong = 0;
        bool q = false;
        private frmDatHangKH frmdathang;
        public frmXuatHang()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }
        public frmXuatHang(frmDatHangKH frmdathang)
        {
            InitializeComponent();
            conn = Connect.getConnect();
            this.frmdathang = frmdathang;
        }
        public frmXuatHang(string madat)
        {
            InitializeComponent();
            conn = Connect.getConnect();
            txtMaDonDat.Text = madat;
        }

        public void loadCT_DonDatHang()
        {
            string st = "select T_CT_DAT_HANG_KH.MASP,T_CT_DAT_HANG_KH.SOLUONG,T_CT_DAT_HANG_KH.DONGIABAN,T_SAN_PHAM.SOLUONG from T_CT_DAT_HANG_KH, T_SAN_PHAM where T_CT_DAT_HANG_KH.MASP=T_SAN_PHAM.MASP AND MADDH='" + txtMaDonDat.Text + "' order by T_CT_DAT_HANG_KH.MASP asc";
            adapter = new OleDbDataAdapter(st, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvCT_DatHang.DataSource = dt;
        }


        public void load_HoaDon()
        {
            string st = "select * from T_HOA_DON where MADDH='" + txtMaDonDat.Text + "'";
            adapter = new OleDbDataAdapter(st, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvHoaDon.DataSource = dt;
        }

        public void loadCT_HoaDon(string mahoadon)
        {
            string st = "select MASP,SOLUONGBAN,DONGIABAN from T_CT_HOA_DON where MAHD='" + mahoadon + "' order by MASP asc";
            adapter = new OleDbDataAdapter(st, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvCT_HD.DataSource = dt;

        }
        public void loadLai()
        {
            //adapter = new OleDbDataAdapter("select * from T_HOA_DON", conn);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //dgvHoaDon.DataSource = dt;
            txtNhanVien.Text = Program.mainForm.ma;
            btnThem.Enabled = true;
            load_HoaDon();

        }
        private void frmXuatHang_Load(object sender, EventArgs e)
        {
            conn.Open();
            dgvHoaDon.Columns["ngaylap"].DefaultCellStyle.Format = @"dd/MM/yyyy";
            txtNgayLap.Format = DateTimePickerFormat.Custom;
            txtNgayLap.CustomFormat = "dd/MM/yyyy";
            loadLai();
            /// MA TU DONG
            string lenh = "select MAHD from T_HOA_DON order by MAHD desc";
            cmd = new OleDbCommand(lenh, conn);
            string macuoi = (string)cmd.ExecuteScalar();

            if (macuoi == null)
            {
                txtMaHD.Text = "HD0001";
            }
            else
            {
                int somacuoi = int.Parse(macuoi.Replace("HD", ""));
                if (somacuoi < 9)
                    txtMaHD.Text = "HD000" + (somacuoi + 1);
                else if (somacuoi >= 9 && somacuoi < 99)
                    txtMaHD.Text = "HD00" + (somacuoi + 1);
                else if (somacuoi >= 99 && somacuoi < 999)
                    txtMaHD.Text = "HD0" + (somacuoi + 1);
                else
                    txtMaHD.Text = "HD" + (somacuoi + 1);
            }
            ////
            loadCT_DonDatHang();

            for (int i = 0; i < dgvCT_DatHang.Rows.Count; i++)
            {
                float slban = float.Parse(dgvCT_DatHang.Rows[i].Cells["soluong"].Value.ToString());
                float dongia = float.Parse(dgvCT_DatHang.Rows[i].Cells["dongiaban"].Value.ToString());
                tong = tong + slban * dongia;
            }
            string st = "select KIEUTHANHTOAN from T_DON_DAT_HANG_KH where MADDH='" + txtMaDonDat.Text + "'";
            cmd = new OleDbCommand(st, conn);
            string k = cmd.ExecuteScalar().ToString();

            if (k == "Tra truoc")
            {
                txtTongtien.Text = "" + tong;
            }
            else
            {
                tong = tong - (tong * 30 / 100);
                txtTongtien.Text = "" + tong;
            }

            conn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvCT_DatHang.Rows.Count; i++)
            {
                float slban = float.Parse(dgvCT_DatHang.Rows[i].Cells["soluong"].Value.ToString());
                float slkho = float.Parse(dgvCT_DatHang.Rows[i].Cells["soluongkho"].Value.ToString());

                if (slban > slkho)// sl ban > sl trong kho 
                {
                    MessageBox.Show("Sản phẩm " + dgvCT_DatHang.Rows[i].Cells["masp"].Value.ToString() + "không đủ số lượng để bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    q = false;
                    return;
                }
                else { q = true; }
            }
            if (q == true)
            {
                if (txtTienKhachTra.Text == "")
                {
                    MessageBox.Show("Chưa nhập tiền trả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if ((int.Parse(txtTienKhachTra.Text)) < (int.Parse(txtTongtien.Text)))
                {
                    MessageBox.Show("Tiền trả không đủ để thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    conn.Open();
                    // them vao hoa don
                    cmd = new OleDbCommand("Insert into T_HOA_DON values('" + txtMaHD.Text + "',TO_DATE('" + txtNgayLap.Text + "','DD-MM-RR'),'" + txtMaDonDat.Text + "','" + txtNhanVien.Text + "'," + tong + ")", conn);
                    cmd.ExecuteNonQuery();

                    adapter = new OleDbDataAdapter("select * from T_CT_DAT_HANG_KH where MADDH='" + txtMaDonDat.Text + "'", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int a = 0; int b = 0; int c = 0;
                        //them vao chi tiet phieu nhap
                        cmd = new OleDbCommand("insert into T_CT_HOA_DON values ('" + txtMaHD.Text + "','" + dt.Rows[i].Field<string>(1) + "'," + int.Parse(dgvCT_DatHang.Rows[i].Cells["soluong"].Value.ToString()) + "," + float.Parse(dgvCT_DatHang.Rows[i].Cells["dongiaban"].Value.ToString()) + "," + int.Parse(dgvCT_DatHang.Rows[i].Cells["soluong"].Value.ToString()) + ")", conn);
                        cmd.ExecuteNonQuery();
                        //lay so luong tu bang san pham gan vao a
                        string lenh1 = "select SOLUONG from T_SAN_PHAM where MASP='" + dt.Rows[i].Field<string>(1) + "'";
                        //lay so luong dat tu chi tiet dat gan vao b
                        string lenh2 = "select SOLUONG from T_CT_DAT_HANG_KH where MASP='" + dt.Rows[i].Field<string>(1) + "' and MADDH='" + txtMaDonDat.Text + "'";

                        OleDbCommand cmd1 = new OleDbCommand(lenh1, conn);
                        a = Convert.ToInt32(cmd1.ExecuteScalar().ToString());
                        OleDbCommand cmd2 = new OleDbCommand(lenh2, conn);
                        b = Convert.ToInt32(cmd2.ExecuteScalar().ToString()); ;

                        c = a - b;
                        // update số lượng kho sản phẩm
                        string lenh3 = "update T_SAN_PHAM set SOLUONG=" + c + " where MASP='" + dt.Rows[i].Field<string>(1) + "'";
                        OleDbCommand cmd3 = new OleDbCommand(lenh3, conn);
                        cmd3.ExecuteNonQuery();

                    }
                    //update tinh trang thanh toán
                    //kt kieu giao hang
                    OleDbCommand cmd9 = new OleDbCommand("select KIEUTHANHTOAN from T_DON_DAT_HANG_KH where MADDH='" + txtMaDonDat.Text + "'", conn);
                    string kieutt = cmd9.ExecuteScalar().ToString();
                    if (kieutt == "Tra truoc")
                    {
                        string lenh5 = "update T_DON_DAT_HANG_KH set TINHTRANG_THANHTOAN='Da thanh toan' where MADDH='" + txtMaDonDat.Text + "'";
                        OleDbCommand cmd5 = new OleDbCommand(lenh5, conn);
                        cmd5.ExecuteNonQuery();
                    }
                    else
                    {
                        string lenh10 = "update T_DON_DAT_HANG_KH set TINHTRANG_THANHTOAN='Da thanh toan', TINHTRANGGIAO='Da giao' where MADDH='" + txtMaDonDat.Text + "'";
                        OleDbCommand cmd10 = new OleDbCommand(lenh10, conn);
                        cmd10.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thanh toán thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadLai();
                    load_HoaDon();
                    loadCT_HoaDon(dgvHoaDon.Rows[0].Cells[0].Value.ToString());
                    
                    conn.Close();
                    btnThem.Enabled = false;
                }

            }


        }

        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                loadCT_HoaDon(dgvHoaDon.CurrentRow.Cells[0].Value.ToString());
            }
            catch { }
           
        }

        private void txtTienKhachTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTienKhachTra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int x = (int.Parse(txtTienKhachTra.Text)) - (int.Parse(txtTongtien.Text));
                txtTienthoi.Text = "" + x;
            }
            catch
            { }
        }
    }
}
