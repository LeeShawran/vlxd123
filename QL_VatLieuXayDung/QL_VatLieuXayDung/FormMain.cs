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
    }
}
