using B_BUS.DataProviders;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using C_GUI.VMProviders;
using Catel.Collections;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_GUI.Views
{
    public partial class FrmHoaDonChiTiet : Form
    {
        List<ChiTietPhieuDichVuViewModel> _lst_chiTietdv;

        public FrmHoaDonChiTiet(HoaDonViewModel hoaDonViewModel)
        {
            InitializeComponent();
            Cbb_all();
            cbb_pttt.SelectedIndex = 0;
            if (hoaDonViewModel.TrangThai != 0)
            {
                if (hoaDonViewModel.PhuongThucThanhToan == 0 || hoaDonViewModel.PhuongThucThanhToan == null)
                {
                    cbb_pttt.SelectedIndex = 0;
                }
                else
                {
                    cbb_pttt.SelectedIndex = 1;
                }
                hoaDonViewModelBindingSource.DataSource = hoaDonViewModel;
                cbb_pttt.Enabled = false;
                cbb_Trangthai.Enabled = false;
                btn_luu.Enabled = false;
            }
            else
            {
                hoaDonViewModelBindingSource.DataSource = hoaDonViewModel;
                cbb_pttt.Enabled = true;
                btn_luu.Enabled = true;
            }
            _lst_chiTietdv = new List<ChiTietPhieuDichVuViewModel>();
            hoaDonViewModelBindingSource.DataSource = hoaDonViewModel;
            DSChiTietPhieuDichVu();
        }

        private void DSChiTietPhieuDichVu()
        {
            double o = 0;
            var hdMV = hoaDonViewModelBindingSource.Current as HoaDonViewModel;
            if (hdMV == null) return;
            if (hdMV.phieuDatPhongViewModels.Count == 0) return;

            decimal _PhiDichVu = new decimal(o);
            var obj = hdMV.phieuDatPhongViewModels[0];
            if (obj == null) { return; }

            if (obj.PhieuDichVusVM == null)
            {
                obj.PhieuDichVusVM = PhieuDichVuDataProvider.Ins.repository.GetAll()
                        .Where(x => x.PhieuDatPhongId == obj.Id).ToList().ConvertAll(x =>
                        PhieuDichVuDataProvider.Ins.convertToVM(x));
            }

            if (obj.PhieuDichVusVM.Any())
            {
                int count = obj.PhieuDichVusVM.Count;
                for (int i = 0; i < count; i++)
                {
                     var ctdv = ChiTietPhieuDichVuDataProvider.Ins.repository.GetAll().Where(x => x.PhieuDichVuID == obj.PhieuDichVusVM[i].Id)
                         .ToList().ConvertAll(c=>ChiTietPhieuDichVuDataProvider.Ins.convertToVM(c));
                    ctdv.ForEach(c => c.DichVuVM = DichVuDataProvider.Ins.service.GetByID(c.DichVuID ?? Guid.Empty));
                    ctdv.ForEach(x => _PhiDichVu += (x.SoLuong * x.DonGia));
                    _lst_chiTietdv.AddRange(ctdv);
                }
            }
            lb_tongtien.Text = string.Format(
        System.Globalization.CultureInfo.GetCultureInfo("vi-VN"), "{0:C0}", (_PhiDichVu + obj.PhiPhong));
            chiTietPhieuDichVuViewModelBindingSource.DataSource = _lst_chiTietdv;
        }

        private void Cbb_all()
        {
            cbb_Trangthai.Items.Clear();
            cbb_Trangthai.Items.Add("Đã thanh toán");
            cbb_Trangthai.Items.Add("Chờ thanh toán");
            cbb_Trangthai.Items.Add("Hủy");

            cbb_pttt.Items.Clear();
            cbb_pttt.Items.Add("Tiền mặt");
            cbb_pttt.Items.Add("Chuyển khoản");

        }

        private void SuaHoaDon()
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thanh toán không ?", "Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                var obj = hoaDonViewModelBindingSource.Current as HoaDonViewModel;
                if (obj == null) return;
                //obj.TrangThai = cbb_Trangthai.Text == "Đã thanh toán" ? 2 : 0;
                obj.TrangThai = 2;
                obj.PhuongThucThanhToan = cbb_pttt.Text == "Tiền mặt" ? 0 : 1;
                HoaDonDataProvider.Ins.service.Update(obj);
            }

        }

        private void TinhGioAndTongTienPhong()
        {
            if (lb_ngaytt.Text == "" || lb_ngaynhan.Text == "")
            {
                lb_songay.Text = "0";
                return;
            }
            TimeSpan span = DateTime.Parse(lb_ngaytra.Text) - DateTime.Parse(lb_ngaynhan.Text);
            lb_songay.Text = span.Days.ToString() + " Ngày" + " - " + span.Hours.ToString() + " Giờ" + " - " + span.Minutes.ToString() + " Phút";
        }

        private void FrmHoaDonChiTiet_Load(object sender, EventArgs e)
        {
            TinhGioAndTongTienPhong();

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            SuaHoaDon();
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var obj = hoaDonViewModelBindingSource.Current as HoaDonViewModel;
            if (obj == null)
            {
                return;
            }
            //trái
            e.Graphics.DrawString("Hóa đơn", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, new Point(350, 10));

            e.Graphics.DrawString(obj.TenDayDu_KH, new Font("Arial", 22, FontStyle.Bold), Brushes.Black, new Point(130, 97));
            e.Graphics.DrawString("Tên KH :", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(10, 100));

            e.Graphics.DrawString(obj.TenDayDu_NV, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(600, 100));
            e.Graphics.DrawString("Tên NV :", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(490, 100));

            e.Graphics.DrawString(obj.ngayNhan, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(160, 160));
            e.Graphics.DrawString("Ngày nhận :", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(10, 160));

            e.Graphics.DrawString(obj.NgayThanhToan.ToString(), new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(160, 200));
            e.Graphics.DrawString("Ngày TT :", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(10, 200));

            e.Graphics.DrawString(obj.ngayDat.ToString(), new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(160, 240));
            e.Graphics.DrawString("Ngày đặt :", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(10, 240));

            e.Graphics.DrawString(obj.ngayTra.ToString(), new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(160, 280));
            e.Graphics.DrawString("Ngày trả :", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(10, 280));


            //phải
            // e.Graphics.DrawString("123-321-123", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(700, 15));
            // e.Graphics.DrawString("Mã HD :", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(550, 15));

            e.Graphics.DrawString(lb_songay.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(590, 160));
            e.Graphics.DrawString("Số giờ :", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(490, 160));

            e.Graphics.DrawString(lb_maphong.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(580, 200));
            e.Graphics.DrawString(lb_loaiphong.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(680, 200));
            e.Graphics.DrawString("Phòng :", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(490, 200));

            e.Graphics.DrawString(lb_tienphong.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(490, 240));

            e.Graphics.DrawString(lb_pp.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(490, 280));

            //dich vu
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(0, 340));
            e.Graphics.DrawString("Tên dịch vụ", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(10, 380));
            e.Graphics.DrawString("Số lượng", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(250, 380));
            e.Graphics.DrawString("Đơn giá", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(450, 380));
            e.Graphics.DrawString("Thành tiền", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(680, 380));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(0, 420));

            int y = 420;

            foreach (var x in _lst_chiTietdv)
            {
                y += 40;
                e.Graphics.DrawString(x.Ten_DichVuVM, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(10, y));
                e.Graphics.DrawString(x.SoLuong.ToString(), new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(250, y));
                e.Graphics.DrawString(x.DonGia.ToString(), new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(450, y));
                e.Graphics.DrawString(x.strThanhTien, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(680, y));
            }
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(0, y + 40));

            e.Graphics.DrawString(lb_tongtien.Text, new Font("Arial", 30, FontStyle.Bold), Brushes.Red, new Point(600, y+90));
            e.Graphics.DrawString("Tổng tiền :", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(400, y+100));

        }

        private void pcb_in_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
