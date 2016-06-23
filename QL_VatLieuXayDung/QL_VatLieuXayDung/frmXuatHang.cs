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

        public frmXuatHang()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }
        public frmXuatHang(string madat)
        {
            InitializeComponent();
            conn = Connect.getConnect();
            txtMaDonDat.Text = madat;
        }

        public void loadCT_DonDatHang()
        {
            string st = "select T_CT_DAT_HANG_KH.MASP,T_CT_DAT_HANG_KH.SOLUONG,T_CT_DAT_HANG_KH.DONGIABAN,T_SAN_PHAM.SOLUONG from T_CT_DAT_HANG_KH, T_SAN_PHAM where T_CT_DAT_HANG_KH.MASP=T_SAN_PHAM.MASP AND MADDH='" + txtMaDonDat.Text + "'";
            adapter = new OleDbDataAdapter(st, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvCT_DatHang.DataSource = dt;
        }


        public void load_HoaDon()
        {
            string st = "select * from T_HOA_DON";
            adapter = new OleDbDataAdapter(st, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvHoaDon.DataSource = dt;
        }

        public void loadCT_HoaDon(string mahoadon)
        {
            string st = "select MASP,SOLUONGBAN,DONGIABAN from T_CT_HOA_DON where MAHD='" + mahoadon + "'";
            adapter = new OleDbDataAdapter(st, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvCT_HD.DataSource = dt;



        }
        public void loadLai()
        {
            dgvHoaDon.Columns["ngaylap"].DefaultCellStyle.Format = @"dd/MM/yyyy";
            adapter = new OleDbDataAdapter("select * from T_HOA_DON", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvHoaDon.DataSource = dt;
            txtNhanVien.Text = Program.mainForm.ma;
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
                if (somacuoi < 10)
                    txtMaHD.Text = "HD000" + (somacuoi + 1);
                else if (somacuoi >= 10 && somacuoi < 100)
                    txtMaHD.Text = "HD00" + (somacuoi + 1);
                else if (somacuoi >= 100 && somacuoi < 1000)
                    txtMaHD.Text = "HD0" + (somacuoi + 1);
                else
                    txtMaHD.Text = "HD" + (somacuoi + 1);
            }
           
            ////

            btnThem.Enabled = true;
            load_HoaDon();

        }
        private void frmXuatHang_Load(object sender, EventArgs e)
        {
            conn.Open();
            loadLai();
            loadCT_DonDatHang();
            txtNgayLap.Format = DateTimePickerFormat.Custom;
            txtNgayLap.CustomFormat = "dd/MM/yyyy";
            for (int i = 0; i < dgvCT_DatHang.Rows.Count; i++)
            {
                float slban = float.Parse(dgvCT_DatHang.Rows[i].Cells["soluong"].Value.ToString());
                float dongia = float.Parse(dgvCT_DatHang.Rows[i].Cells["dongiaban"].Value.ToString());
                tong = tong + slban * dongia;

            }
            string st = "select KIEUTHANHTOAN from T_DON_DAT_HANG_KH where MADDH='" + txtMaDonDat.Text + "'";
            cmd = new OleDbCommand(st, conn);
            int k = Convert.ToInt32(cmd.ExecuteScalar().ToString().Replace("%",""));

            if (k == 100)
            {
                txtTongtien.Text = "" + tong;
            }
            else
            {
                tong = tong - (tong * 40 / 100);
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
                    MessageBox.Show("san pham " + dgvCT_DatHang.Rows[i].Cells["masp"].Value.ToString() + "khong du so luong ban");
                    q = false;
                    return;
                }
                else { q = true; }
            }
            if (q == true)
            {
                if (txtTienKhachTra.Text == "")
                {
                    MessageBox.Show("Chưa nhập tiền trả");
                    return;
                }
                else if ((int.Parse(txtTienKhachTra.Text)) < (int.Parse(txtTongtien.Text)))
                {
                    MessageBox.Show("tiền trả không đủ để thanh toán");
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
                        //lay sl tu bang sp gan vao a
                        string lenh1 = "select SOLUONG from T_SAN_PHAM where MASP='" + dt.Rows[i].Field<string>(1) + "'";
                        //lay sldat tu chi tiet dat gan vao b
                        string lenh2 = "select SOLUONG from T_CT_DAT_HANG_KH where MASP='" + dt.Rows[i].Field<string>(1) + "' and MADDH='" + txtMaDonDat.Text + "'";

                        OleDbCommand cmd1 = new OleDbCommand(lenh1, conn);
                        a = Convert.ToInt32(cmd1.ExecuteScalar().ToString());

                        OleDbCommand cmd2 = new OleDbCommand(lenh2, conn);
                        b = Convert.ToInt32(cmd2.ExecuteScalar().ToString()); ;

                        c = a - b;

                        // update sl trong ban sp
                        string lenh3 = "update T_SAN_PHAM set SOLUONG=" + c + " where MASP='" + dt.Rows[i].Field<string>(1) + "'";
                        OleDbCommand cmd3 = new OleDbCommand(lenh3, conn);
                        cmd3.ExecuteNonQuery();

                    }
                    //update tinh trang nhap
                    string lenh5 = "update T_DON_DAT_HANG_KH set TINHTRANG_THANHTOAN='Co' where MADDH='" + txtMaDonDat.Text + "'";
                    OleDbCommand cmd5 = new OleDbCommand(lenh5, conn);
                    cmd5.ExecuteNonQuery();

                    MessageBox.Show("Thanh toán thành công");
                    loadLai();
                    conn.Close();
                    btnThem.Enabled = false;
                }

            }

        }

        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            loadCT_HoaDon(dgvHoaDon.CurrentRow.Cells[0].Value.ToString());
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
