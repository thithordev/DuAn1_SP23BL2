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
            if (hoaDonViewModel.TrangThai != 1)
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
            e.Graphics.DrawString("Hóa đơn",new Font("Arial",20,FontStyle.Bold), Brushes.Black, new Point(10,10));
        }

        private void pcb_in_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }
    }
}
