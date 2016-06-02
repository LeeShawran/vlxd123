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

namespace QL_VatLieuXayDung
{
    public partial class frmNhaCungCap : Form
    {
        OleDbConnection conn;
        public frmNhaCungCap()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void Refresh_Nha_CC()
        {
            conn.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter("select * from T_NHA_CUNG_CAP", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvNCC.DataSource = dt;
            conn.Close();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            Refresh_Nha_CC();
            btnLuu_NCC.Enabled = false;
        }

        private bool Kiem_tra_khoa_chinh()
        {
            bool tatkt = false;
            string MaNCC = txtMaNCC_NCC.Text;
            OleDbCommand cmd = new OleDbCommand("select * from T_NHA_CUNG_CAP", conn);
            OleDbDataReader PK = cmd.ExecuteReader();
            while (PK.Read())
            {
                if (MaNCC == PK.GetString(0))
                {
                    tatkt = true;
                    break;
                }
            }
            return tatkt;
        }

        private void btnThem_NCC_Click(object sender, EventArgs e)
        {
            if (this.txtMaNCC_NCC.TextLength == 0 || this.txtTenNCC_NCC.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập thông tin nhà cung cấp !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("Insert into T_NHA_SAN_XUAT values('" + txtMaNCC_NCC.Text + "','" + txtTenNCC_NCC.Text + "','" + txtDiachi_NCC.Text + "','" + txtDienthoai_NCC.Text + "','" + txtGhiChu_NCC.Text + "')", conn);
                if (Kiem_tra_khoa_chinh())
                {
                    MessageBox.Show("Đã có mã nhả cung cấp này !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    Refresh_Nha_CC();
                    txtMaNCC_NCC.Clear();
                    txtTenNCC_NCC.Clear();
                    txtDiachi_NCC.Clear();
                    txtDienthoai_NCC.Clear();
                    txtGhiChu_NCC.Clear();   
                }
            }
        }

        private void dgvNCC_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvNCC.Rows[e.RowIndex];
                txtMaNCC_NCC.Text = row.Cells[0].Value.ToString();
                txtTenNCC_NCC.Text = row.Cells[1].Value.ToString();
                txtDiachi_NCC.Text = row.Cells[2].Value.ToString();
                txtDienthoai_NCC.Text = row.Cells[3].Value.ToString();
                txtGhiChu_NCC.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnXoa_NCC_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Delete from T_CUNG_CAP where MANCC='" + txtMaNCC_NCC.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Refresh_Nha_CC();
            txtMaNCC_NCC.Clear();
            txtTenNCC_NCC.Clear();
            txtDiachi_NCC.Clear();
            txtDienthoai_NCC.Clear();
            txtGhiChu_NCC.Clear();   
        }

        private void btnSua_NCC_Click(object sender, EventArgs e)
        {
            txtMaNCC_NCC.ReadOnly = true;
            btnThem_NCC.Enabled = false;
            btnXoa_NCC.Enabled = false;
            btnSua_NCC.Enabled = false;
            btnLuu_NCC.Enabled = true;
        }

        private void btnLuu_NCC_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("Update T_NHA_CUNG_CAP set TENNCC='" + txtTenNCC_NCC.Text + "', DCHINCC='" + txtDiachi_NCC.Text + "', DTHOAINCC='" + txtDienthoai_NCC.Text + "', GCHUNCC='" + txtGhiChu_NCC.Text + "' where MANCC='" + txtMaNCC_NCC.Text + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Refresh_Nha_CC();
            txtMaNCC_NCC.Clear();
            txtTenNCC_NCC.Clear();
            txtDiachi_NCC.Clear();
            txtDienthoai_NCC.Clear();
            txtGhiChu_NCC.Clear();
            txtMaNCC_NCC.ReadOnly = false;
            btnThem_NCC.Enabled = true;
            btnXoa_NCC.Enabled = true;
            btnSua_NCC.Enabled = true;
            btnLuu_NCC.Enabled = false;
        }

        private void btnAsc_NCC_Click(object sender, EventArgs e)
        {
            dgvNCC.Sort(dgvNCC.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void btnDes_NCC_Click(object sender, EventArgs e)
        {
            dgvNCC.Sort(dgvNCC.Columns[0], System.ComponentModel.ListSortDirection.Descending);
        }
    }
}
