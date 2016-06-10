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
    public partial class frmBanHangKH : Form
    {
        OleDbConnection conn;
        OleDbDataAdapter adapter;
        OleDbCommand cmd;
        DataTable dt;
        int luu = 0;
        float tong = 0;
        public frmBanHangKH()
        {
            InitializeComponent();
            conn = Connect.getConnect();
        }

        public void loadLai()
        {
           

           
        }
    }
}
