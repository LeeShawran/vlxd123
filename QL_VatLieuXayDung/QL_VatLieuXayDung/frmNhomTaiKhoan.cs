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
    public partial class frmNhomTaiKhoan : Form
    {
        OleDbConnection conn;
        public frmNhomTaiKhoan()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void Refresh_NTK()
        {
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_NHOM_TAI_KHOAN", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvNTK.DataSource = dt;
            conn.Close();
        }

        private void frmNhomTaiKhoan_Load(object sender, EventArgs e)
        {
            btnLuu_NTK.Enabled = false;
            Refresh_NTK();
        }

        private bool Kiem_tra_khoa_chinh()
        {
            bool tatkt = false;
            string MaNTK = txtMaNTK_NTK.Text;
            OleDbCommand cmd = new OleDbCommand("select * from T_NHOM_TAI_KHOAN", conn);
            OleDbDataReader PK = cmd.ExecuteReader();
            while (PK.Read())
            {
                if (MaNTK == PK.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            return tatkt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_MAN_HINH", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            Int32 b = 0;
            conn.Open();
            //OleDbCommand cm = new OleDbCommand("insert into T_NHOM_TAI_KHOAN(MANHOM,TENNHOM) values ('" + txtmanhom.Text + "','" + txttennhom.Text + "')", conn);

            OleDbCommand cm2 = new OleDbCommand("insert into T_NHOM_TAI_KHOAN(MANHOM,TENNHOM) values ('" + txtMaNTK_NTK.Text + "','" + txtTenNTK_NTK.Text + "')", conn);
            cm2.ExecuteNonQuery();

            //MessageBox.Show(""+b);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //MessageBox.Show("" + dt.Rows[i].Field<string>(0));
                OleDbCommand cm8 = new OleDbCommand("insert into T_PHAN_QUYEN(MANHOM,MAMH,COQUYEN) values ('" + txtMaNTK_NTK.Text + "','" + dt.Rows[i].Field<string>(0) + "'," + 0 + ")", conn);

                cm8.ExecuteNonQuery();
            }
            //OleDbCommand cm2 = new OleDbCommand("insert into T_PHAN_QUYEN(MANHOM,TENNHOM) values ('" + txtmanhom.Text 
            //cm.ExecuteNonQuery();
            conn.Close();
            Refresh_NTK();

           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_MAN_HINH", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            Int32 b = 0;
            conn.Open();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MessageBox.Show("" + dt.Rows[i].Field<string>(0));
                OleDbCommand cm8 = new OleDbCommand("delete from T_PHAN_QUYEN where MANHOM='" + txtMaNTK_NTK.Text + "'", conn);
                cm8.ExecuteNonQuery();
            }

            OleDbCommand cm2 = new OleDbCommand("delete from T_NHOM_TAI_KHOAN where MANHOM='" + txtMaNTK_NTK.Text + "'", conn);
            cm2.ExecuteNonQuery();
            conn.Close();
            Refresh_NTK();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvNhomTK_Click(object sender, EventArgs e)
        {
            txtMaNTK_NTK.Text = dgvNTK.CurrentRow.Cells[0].Value.ToString();
            txtTenNTK_NTK.Text = dgvNTK.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
          
            conn.Open();
            OleDbCommand cm2 = new OleDbCommand("update T_NHOM_TAI_KHOAN set TENNHOM=N'" + txtTenNTK_NTK.Text + "' where MANHOM='"+txtMaNTK_NTK.Text+"'", conn);
            cm2.ExecuteNonQuery();
            conn.Close();
            Refresh_NTK();
        }
    }
}
