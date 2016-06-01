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

        public void lamMoi()
        {
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_NHOM_TAI_KHOAN", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvNhomTK.DataSource = dt;
            conn.Close();
        }

        private void frmNhomTaiKhoan_Load(object sender, EventArgs e)
        {
            lamMoi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //btnThem.Enabled = false;
            //groupBox1.Enabled = true;
            //btnLuu.Enabled = true;
            //btnSua.Enabled = false;
            //btnXoa.Enabled = false;
            //txttennhom.Enabled = true;

            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_MAN_HINH", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            Int32 b = 0;
            conn.Open();
            //OleDbCommand cm = new OleDbCommand("insert into T_NHOM_TAI_KHOAN(MANHOM,TENNHOM) values ('" + txtmanhom.Text + "','" + txttennhom.Text + "')", conn);

            OleDbCommand cm2 = new OleDbCommand("insert into T_NHOM_TAI_KHOAN(MANHOM,TENNHOM) values ('" + txtmanhom.Text + "','" + txttennhom.Text + "')", conn);
            cm2.ExecuteNonQuery();

            //MessageBox.Show(""+b);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MessageBox.Show("" + dt.Rows[i].Field<string>(0));
                OleDbCommand cm8 = new OleDbCommand("insert into T_PHAN_QUYEN(MANHOM,MAMH,COQUYEN) values ('" + txtmanhom.Text + "','" + dt.Rows[i].Field<string>(0) + "'," + 0 + ")", conn);

                cm8.ExecuteNonQuery();
            }
            //OleDbCommand cm2 = new OleDbCommand("insert into T_PHAN_QUYEN(MANHOM,TENNHOM) values ('" + txtmanhom.Text 
            //cm.ExecuteNonQuery();
            conn.Close();
            lamMoi();

           
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
                OleDbCommand cm8 = new OleDbCommand("delete from T_PHAN_QUYEN where MANHOM='" + txtmanhom.Text + "'", conn);
                cm8.ExecuteNonQuery();
            }

            OleDbCommand cm2 = new OleDbCommand("delete from T_NHOM_TAI_KHOAN where MANHOM='" + txtmanhom.Text + "'", conn);
            cm2.ExecuteNonQuery();
            conn.Close();
            lamMoi();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvNhomTK_Click(object sender, EventArgs e)
        {
            txtmanhom.Text = dgvNhomTK.CurrentRow.Cells[0].Value.ToString();
            txttennhom.Text = dgvNhomTK.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
          
            conn.Open();
            OleDbCommand cm2 = new OleDbCommand("update T_NHOM_TAI_KHOAN set TENNHOM=N'" + txttennhom.Text + "' where MANHOM='"+txtmanhom.Text+"'", conn);
            cm2.ExecuteNonQuery();
            conn.Close();
            lamMoi();
        }

        private void bntLammoi_Click(object sender, EventArgs e)
        {
            lamMoi();
        }
    }
}
