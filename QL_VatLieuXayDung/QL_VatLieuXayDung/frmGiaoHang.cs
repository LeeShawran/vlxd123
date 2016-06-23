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
    public partial class frmGiaoHang : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        OleDbCommand cmd;
        DataTable dt;
        float tong = 0;
        bool q = false;
        string mahd;
        public frmGiaoHang()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }
        public frmGiaoHang(string madat)
        {
            InitializeComponent();
            conn = Connect.getConnect();
            txtMaDonDat.Text = madat;
        }

        public void loadCT_HoaDon()
        {
          
            string lenh = "select MAHD from T_HOA_DON, T_DON_DAT_HANG_KH where T_DON_DAT_HANG_KH.MADDH=T_HOA_DON.MADDH and T_DON_DAT_HANG_KH.MADDH='" + txtMaDonDat.Text + "'";
            cmd = new OleDbCommand(lenh, conn);
            mahd = cmd.ExecuteScalar().ToString();
           

            string lenh2 = "select MASP,SOLUONG_CONGIAO from T_CT_HOA_DON where MAHD='" + mahd + "'";
            adapter = new OleDbDataAdapter(lenh2, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvCT_HOADON.DataSource = dt;
        }


        public void load_PhieuGiao()
        {
            string st = "select * from T_PHIEU_GIAO";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvPhieu_Giao.DataSource = dt;
        }

        public void loadCT_PHIEUGIAO(string maphieugiao)
        {
            string st = "select MASP,SOLUONG_CONGIAO,SOLUONGGIAO from T_CT_PHIEU_GIAO where MAPHIEUGIAO='" + maphieugiao + "'";
            adapter = new OleDbDataAdapter(st, conn);
            dt = new DataTable();
            adapter.Fill(dt);
            dgvCT_PhieuGiao.DataSource = dt;
        }
        public void loadLai()
        {
          

            btnThem.Enabled = true;
          
            load_PhieuGiao();

        }
        private void frmGiaoHang_Load(object sender, EventArgs e)
        {
            conn.Open();
            dgvPhieu_Giao.Columns["ngaygiao"].DefaultCellStyle.Format = @"dd/MM/yyyy";

            txtNhanVien.Text = Program.mainForm.ma;
            
            /// MA TU DONG
            string lenh = "select MAPHIEUGIAO from T_PHIEU_GIAO order by MAPHIEUGIAO desc";
            cmd = new OleDbCommand(lenh, conn);
            string macuoi = (string)cmd.ExecuteScalar();


            if (macuoi == null)
            {
                txtPhieuGiao.Text = "PGH0001";
            }
            else
            {
                int somacuoi = int.Parse(macuoi.Replace("PGH", ""));
                if (somacuoi < 10)
                    txtPhieuGiao.Text = "PGH000" + (somacuoi + 1);
                else if (somacuoi >= 10 && somacuoi < 100)
                    txtPhieuGiao.Text = "PGH00" + (somacuoi + 1);
                else if (somacuoi >= 100 && somacuoi < 1000)
                    txtPhieuGiao.Text = "PGH0" + (somacuoi + 1);
                else
                    txtPhieuGiao.Text = "PGH" + (somacuoi + 1);
            }

            ////

            loadLai();
            loadCT_HoaDon();
            txtNgayGiao.Format = DateTimePickerFormat.Custom;
            txtNgayGiao.CustomFormat = "dd/MM/yyyy";
            conn.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvCT_HOADON.Rows.Count; i++)
            {
                float slgiao = float.Parse(dgvCT_HOADON.Rows[i].Cells["soluonggiao"].Value.ToString());
                float slmua = float.Parse(dgvCT_HOADON.Rows[i].Cells["soluongmua"].Value.ToString());


                if (slgiao > slmua)// sl ban > sl trong kho 
                {
                    MessageBox.Show("san pham " + dgvCT_HOADON.Rows[i].Cells["masp"].Value.ToString() + "giao qua so luong mua hang");
                    q = false;
                    return;
                }
                else { q = true; }
            }
            if (q == true)
            {
                bool dagiaotatca=false;
                float tongslgiao = 0; float tongslmua = 0;
                for (int i = 0; i < dgvCT_HOADON.Rows.Count; i++)
                {
                    tongslgiao = tongslgiao + float.Parse(dgvCT_HOADON.Rows[i].Cells["soluonggiao"].Value.ToString());
                    tongslmua = tongslmua + float.Parse(dgvCT_HOADON.Rows[i].Cells["soluongmua"].Value.ToString());
                }
                if (tongslgiao == tongslmua)
                {
                    dagiaotatca = true;
                }



               conn.Open();
                //


                    // them vao hoa don
                    cmd = new OleDbCommand("Insert into T_PHIEU_GIAO values('" + txtPhieuGiao.Text + "','" + txtMaDonDat.Text + "',TO_DATE('" + txtNgayGiao.Text + "','DD-MM-RR'),'" + txtNhanVien.Text + "')", conn);
                    cmd.ExecuteNonQuery();

                    adapter = new OleDbDataAdapter("select * from T_CT_HOA_DON where MAHD='" + mahd + "'", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        int a = 0; int b = 0; int c = 0;
                        //them vao chi tiet phieu nhap
                        cmd = new OleDbCommand("insert into T_CT_PHIEU_GIAO values ('" + txtPhieuGiao.Text + "','" + dt.Rows[i].Field<string>(1) + "'," + int.Parse(dgvCT_HOADON.Rows[i].Cells["soluongmua"].Value.ToString()) + "," + int.Parse(dgvCT_HOADON.Rows[i].Cells["soluonggiao"].Value.ToString()) + ")", conn);
                        cmd.ExecuteNonQuery();
                        //lay sl tu bang sp gan vao a
                        string lenh1 = "select SOLUONG_CONGIAO from T_CT_HOA_DON where MASP='" + dt.Rows[i].Field<string>(1) + "' and MAHD='"+ mahd +"'";
                        //lay sldat tu chi tiet dat gan vao b
                        string lenh2 = "select SOLUONGGIAO from T_CT_PHIEU_GIAO where MASP='" + dt.Rows[i].Field<string>(1) + "' and MAPHIEUGIAO='" + txtPhieuGiao.Text + "'";

                        OleDbCommand cmd1 = new OleDbCommand(lenh1, conn);
                        a = Convert.ToInt32(cmd1.ExecuteScalar().ToString());

                        OleDbCommand cmd2 = new OleDbCommand(lenh2, conn);
                        b = Convert.ToInt32(cmd2.ExecuteScalar().ToString()); ;

                        c = a - b;

                        // update sl trong ban sp
                        string lenh3 = "update T_CT_HOA_DON set SOLUONG_CONGIAO=" + c + " where MASP='" + dt.Rows[i].Field<string>(1) + "' and MAHD='" + mahd + "'";
                        OleDbCommand cmd3 = new OleDbCommand(lenh3, conn);
                        cmd3.ExecuteNonQuery();

                    }
                    //update tinh trang nhap
                    string lenh6 = "select CONLAI from T_DON_DAT_HANG_KH where MADDH='" + txtMaDonDat.Text + "'";
                    OleDbCommand cmd6 = new OleDbCommand(lenh6, conn);
                    int x = Convert.ToInt32(cmd6.ExecuteScalar().ToString());
                    x = x - 1;
    

                    if (x == 0)
                    {
                        string lenh5 = "update T_DON_DAT_HANG_KH set CONLAI=" + x + ", TINHTRANGGIAO='Co' where MADDH='" + txtMaDonDat.Text + "'";
                        OleDbCommand cmd5 = new OleDbCommand(lenh5, conn);
                        cmd5.ExecuteNonQuery();
                    }
                    else
                    {
                        if (dagiaotatca == true)
                        {

                            string lenh8 = "update T_DON_DAT_HANG_KH set CONLAI=" + x + ", TINHTRANGGIAO='Co' where MADDH='" + txtMaDonDat.Text + "'";
                            OleDbCommand cmd8 = new OleDbCommand(lenh8, conn);
                            cmd8.ExecuteNonQuery();
                        }
                        else
                        {
                            string lenh5 = "update T_DON_DAT_HANG_KH set CONLAI=" + x + " where MADDH='" + txtMaDonDat.Text + "'";
                            OleDbCommand cmd5 = new OleDbCommand(lenh5, conn);
                            cmd5.ExecuteNonQuery();
                        }
                        
                    }
                    MessageBox.Show("Giao thành công");
                    loadLai();
                    conn.Close();
                    btnThem.Enabled = false;

            }
        }

        private void dgvPhieu_Giao_Click(object sender, EventArgs e)
        {

            loadCT_PHIEUGIAO(txtPhieuGiao.Text);
        }
    }
}
