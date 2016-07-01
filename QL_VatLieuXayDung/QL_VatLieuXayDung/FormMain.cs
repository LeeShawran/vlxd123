using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QL_VatLieuXayDung
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        static public Label lbTen;
      
        public FormMain()
        {
            InitializeComponent();
           
        }
        
      
       

        private Form KT_TonTai(Type frm_type)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == frm_type)
                {
                    return frm;
                }
            }
            return null;
        }

        private void btnPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmPhanQuyen));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmPhanQuyen f = new frmPhanQuyen();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void btnNhomTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmNhomTaiKhoan));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmNhomTaiKhoan f = new frmNhomTaiKhoan();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void btnThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmLienHe));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmLienHe f = new frmLienHe();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void btnSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmSanPham));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmSanPham f = new frmSanPham();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void btnKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmKhachHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmKhachHang f = new frmKhachHang();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void btnLoaiSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmLoaiSanPham));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmLoaiSanPham f = new frmLoaiSanPham();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void btnNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmNhaCungCap));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmNhaCungCap f = new frmNhaCungCap();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void btnNhaSanXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmNhaSanXuat));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmNhaSanXuat f = new frmNhaSanXuat();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmNhanVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void btnThongTinNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmThongTinNguoiDung));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmThongTinNguoiDung f = new frmThongTinNguoiDung();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnGiamGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmGiamGia));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmGiamGia f = new frmGiamGia();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void btnDatNCC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmDonDatHangNCC));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDonDatHangNCC f = new frmDonDatHangNCC();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmDinhGia));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDinhGia f = new frmDinhGia();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        public string ma;
        public bool MH01 = true, MH02 = true, MH03 = true, MH04 = true;
        private void FormMain_Load(object sender, EventArgs e)
        {
            //lbTen = labelTen;
         
            if (MH01 == false)
            {
                ribbonPageLienHe.Enabled = false;
            }
            if (MH02 == false)
            {
                ribbonPageNhomtk.Enabled = false;
            }
            if (MH03 == false)
            {
                ribbonPagePhanQuyen.Enabled = false;
            }
            if (MH04 == false)
            {
                ribbonPageNhanVien.Enabled = false;
            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dong)
                Application.Exit();
        }

        bool dong = true;

        private void barButtonItem20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn đăng xuất không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
            {
                frmDangNhap dn = new frmDangNhap();
                dn.Show();
                dong = false;
                this.Close();
            }
        }

        private void barButtonItem30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmDatHangKH));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDatHangKH f = new frmDatHangKH();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void btnThongkeSP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmThongKeSanPham));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmThongKeSanPham f = new frmThongKeSanPham();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void btnThongKeTonKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmThongKeTonKho));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmThongKeTonKho f = new frmThongKeTonKho();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void btnThongKeXuatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmThongKeXuatHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmThongKeXuatHang f = new frmThongKeXuatHang();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void btnThongkeNhapHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmThongKeNhapHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmThongKeNhapHang f = new frmThongKeNhapHang();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmDoiMatKhau));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDoiMatKhau f = new frmDoiMatKhau();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void btnDSHoadon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmDSHoadon));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDSHoadon f = new frmDSHoadon();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void btnDSPhieunhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmDSPhieunhap));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDSPhieunhap f = new frmDSPhieunhap();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }

        private void btnDSPhieugiao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.KT_TonTai(typeof(frmDSPhieugiao));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDSPhieugiao f = new frmDSPhieugiao();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterParent;
                f.Show();
            }
        }
    }
}
