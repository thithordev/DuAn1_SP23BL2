using A_DAL.Models;
using B_BUS.DataProviders;
using B_BUS.ViewModels;
using C_GUI.UserControls;
using C_GUI.VMProviders;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;


namespace C_GUI.Views
{
    public partial class FrmPhong : Form
    {
        private DateTime _realtime = DateTime.Now;
        public FrmPhong()
        {
            InitializeComponent();

            // Khởi Tạo

            VMPPhong.Ins.Method_PhongsFULL();
            VMPPhong.Ins.Method_ucPhongs();

            //VMPPhong.Ins.phongsChecked.CollectionChanged += btnOrderChange;
            //VMPPhong.Ins.phongsChecked.CollectionChanged += btnDonPhongChange;
            //VMPPhong.Ins.phongsChecked.CollectionChanged += btnCheckinChange;
            //VMPPhong.Ins.phongsChecked.CollectionChanged += btnCheckoutChange;
            //VMPPhong.Ins.phongsChecked.CollectionChanged += indexChange;
            flowLayoutPanel1.Controls.AddRange(VMPPhong.Ins.ucPhongs.ToArray());

            indexChange(null, null);

            VMPPhong.Ins.PropertyChanged += indexChange;
            VMPPhong.Ins.PropertyChanged += btnOrderChange;
            VMPPhong.Ins.PropertyChanged += btnCheckinChange;
            VMPPhong.Ins.PropertyChanged += btnCheckoutChange;
            //VMPPhong.Ins.PropertyChanged += btnDonPhongChange;
            timer1.Start();

            timer2.Interval = 1000;
            timer2.Start();

        }


        public void LoadDataForm()
        {
            timer1.Stop();

            VMPPhong.Ins.Method_PhongsFULL();
            VMPPhong.Ins.Method_ucPhongs();

            VMPPhong.Ins.PropertyChanged -= indexChange;
            VMPPhong.Ins.PropertyChanged -= btnOrderChange;
            VMPPhong.Ins.PropertyChanged -= btnCheckinChange;
            VMPPhong.Ins.PropertyChanged -= btnCheckoutChange;

            VMPPhong.Ins.indexChecked = 0;
            VMPPhong.Ins.indexChecked = 1;
            indexChange(null, null);


            VMPPhong.Ins.PropertyChanged += indexChange;
            VMPPhong.Ins.PropertyChanged += btnOrderChange;
            VMPPhong.Ins.PropertyChanged += btnCheckinChange;
            VMPPhong.Ins.PropertyChanged += btnCheckoutChange;


            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(VMPPhong.Ins.ucPhongs.ToArray());



            textBox1.Text = string.Empty;
            timer1.Start();

            timer2.Interval = 3000;
            timer2.Start();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadDataForm();

            #region NHAP
            //timer1.Stop();

            //VMPPhong.Ins.Method_PhongsFULL();
            //VMPPhong.Ins.Method_ucPhongs();

            ////var lst = VMPPhong.Ins.service.GetAll() ?? new List<PhongViewModel>();
            ////VMPPhong.Ins.Phongs = lst.OrderBy(x => x.Tang).ToList();

            ////var count = VMPPhong.Ins.Phongs.Count;
            ////VMPPhong.Ins.ucPhongs.Clear();
            ////for (int i = 0; i < count; i++)
            ////{
            ////    var uc = new uc_Phong(i);
            ////    VMPPhong.Ins.ucPhongs.Add(uc);
            ////}
            //flowLayoutPanel1.Controls.Clear();
            //flowLayoutPanel1.Controls.AddRange(VMPPhong.Ins.ucPhongs.ToArray());

            ////VMPPhong.Ins.phongsChecked.Clear();

            //timer1.Start();
            //textBox1.Text = string.Empty;
            #endregion
        }

        private void indexChange(object? sender, EventArgs? e)
        {
            VMPPhong.Ins.Method_ucPhongsClick();

            VMPPhong.Ins.Method_VM();
            lbTen.Text = VMPPhong.Ins.VM.Ten;
            lbTinhTrang1.Text = VMPPhong.Ins.VM.TenLoaiPhong;
            lbTinhTrang2.Text = VMPPhong.Ins.VM.strHienTrang;
            lbTinhTrang3.Text = VMPPhong.Ins.VM.strTrangThai;

            PhieuDatPhongViewModel? phieuDatPhongViewModel = VMPPhong.Ins.VM.phieuDatPhongViewModel;

            if (phieuDatPhongViewModel != null)
            {
                phieuDatPhongViewModel.KhachHangVM = KhachHangDataProvider.Ins.service
                    .GetByID(phieuDatPhongViewModel.KhachHangId ?? Guid.Empty);
                phieuDatPhongViewModel.PhongVM = VMPPhong.Ins.VM;

                lbChitietPhieuD.Text = phieuDatPhongViewModel.status;

                VMPChiTietPhieuDichVu.Ins.BasectPhieuDichVu = new List<ChiTietPhieuDichVuViewModel>();

                List<PhieuDichVuViewModel> lstphieuDVVM = PhieuDichVuDataProvider.Ins.repository
                    .GetAll().Where(x => x.PhieuDatPhongId == phieuDatPhongViewModel.Id)
                    .ToList().ConvertAll(x => PhieuDichVuDataProvider.Ins.convertToVM(x));

                if (lstphieuDVVM.Any())
                {
                    VMPChiTietPhieuDichVu.Ins.AddlstbasectPhieuDichVu(lstphieuDVVM);
                    BindingSource1.DataSource = VMPChiTietPhieuDichVu.Ins.BasectPhieuDichVu;
                }
                else
                {
                    BindingSource1.DataSource = null;
                }
            }
            else
            {
                lbChitietPhieuD.Text = string.Empty;
                BindingSource1.DataSource = null;
            }
        }

        private void btnOrderChange(object? sender, EventArgs e)
        {
            if (VMPPhong.Ins.VM.intHienTrang == 1) btnOrder.Enabled = true;
            else { btnOrder.Enabled = false; }

            //if (VMPPhong.Ins.phongsChecked.Count == 1)
            //{
            //    if (VMPPhong.Ins.phongsChecked[0].intHienTrang == 1) btnOrder.Enabled = true;
            //    else btnOrder.Enabled = false;
            //}
            //else btnOrder.Enabled = false;
        }

        //private void btnDonPhongChange(object? sender, EventArgs e)
        //{

        //}

        private void btnCheckinChange(object? sender, EventArgs e)
        {
            if (VMPPhong.Ins.VM.intHienTrang == 2) btnCheckin.Enabled = true;
            else { btnCheckin.Enabled = false; }
            //if (VMPPhong.Ins.phongsChecked.Count != 1) btnCheckin.Enabled = false;
            //bool result = VMPPhong.Ins.phongsChecked.Any(x => x.intHienTrang != 2);
            //if (result) btnCheckin.Enabled = false;
            //else
            //{
            //    if (VMPPhong.Ins.phongsChecked.Count == 0) btnCheckin.Enabled = false;
            //    else btnCheckin.Enabled = true;
            //}
        }

        private void btnCheckoutChange(object? sender, EventArgs e)
        {
            if (VMPPhong.Ins.VM.intHienTrang == 1) btnCheckout.Enabled = true;
            else { btnCheckout.Enabled = false; }
            //if (VMPPhong.Ins.phongsChecked.Count != 1) btnCheckout.Enabled = false;
            //bool result = VMPPhong.Ins.phongsChecked.Any(x => x.intHienTrang != 1);
            //if (result) btnCheckout.Enabled = false;
            //else
            //{
            //    if (VMPPhong.Ins.phongsChecked.Count == 0) btnCheckout.Enabled = false;
            //    else btnCheckout.Enabled = true;
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _realtime = DateTime.Now;

            int count = VMPPhong.Ins.Phongs.Count;
            for (int i = 0; i < count; i++)
            {
                VMPPhong.Ins.Phongs[i].realTime = _realtime;
            }
        }



        private void btnOrder_Click(object sender, EventArgs e)
        {
            using (FrmAddorEditPhieuDichVu form = new FrmAddorEditPhieuDichVu(null, 
                VMPPhong.Ins.VM.phieuDatPhongViewModel))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RJMessageBox.Show("Phiếu dịch vụ đã được thêm !.");
                }
                else
                {
                    RJMessageBox.Show("Phiếu dịch vụ đã không được thêm !.");
                }
            }

            btnCheckinChange(null, null);
            btnCheckoutChange(null, null);
            btnOrderChange(null, null);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            var result = RJMessageBox.Show("Xác nhận \"Trả Phòng\":  Chọn  YES  để \"Đồng Ý\"  ,  NO  để \"Hủy Bỏ\".",
    "Yes-No Button",
    MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
            {
                return;
            }


            PhongViewModel.newHoaDon = new HoaDonViewModel()
            {
                Id = Guid.NewGuid(),
                NhanVienId = VMPNhanVien.Ins.NhanVienLogin.Id,
                NgayTao = DateTime.Now,
                TrangThai = 1,
                TongTien = 0,
            };

            //int count = VMPPhong.Ins.phongsChecked.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    var phieu = VMPPhong.Ins.phongsChecked[i].phieuDatPhongViewModel;
            //    if (phieu != null)
            //    {
            //        phieu.NgayTra = DateTime.Now;
            //        VMPPhieuDatPhong.Ins.service.Update(phieu);
            //    }
            //}

            PhieuDatPhongViewModel? phieuDatPhongViewModel = VMPPhong.Ins.VM.phieuDatPhongViewModel;
            if (phieuDatPhongViewModel != null)
            {
                phieuDatPhongViewModel.NgayTra = DateTime.Now;
                var kq =PhieuDatPhongDataProvider.Ins.service.Update(phieuDatPhongViewModel);
                if(kq) RJMessageBox.Show("Phòng đã được trả và xuất hóa đơn chờ thành toán!.");
            }

            btnCheckinChange(null, null);
            btnCheckoutChange(null, null);
            btnOrderChange(null, null);

            //PhongViewModel.newHoaDon = new HoaDonViewModel();
            //btnLoad_Click(sender, e);
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            //int count = VMPPhong.Ins.phongsChecked.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    var phieu = VMPPhong.Ins.phongsChecked[i].phieuDatPhongViewModel;
            //    if (phieu != null)
            //    {
            //        phieu.NgayNhan = DateTime.Now;
            //        VMPPhieuDatPhong.Ins.service.Update(phieu);
            //    }
            //}

            //if(MetroFramework.MetroMessageBox.
            //    Show(this, 
            //    "Yes/No", "Đây là cảnh báo check in", MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Question)
            //    == DialogResult.Yes)
            //{

            //}

            var result = RJMessageBox.Show("Xác nhận \"Nhận Phòng\":  Chọn  YES  để \"Đồng Ý\"  ,  NO  để \"Hủy Bỏ\".",
                "Yes-No Button",
                MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
            {
                return;
            }


            PhieuDatPhongViewModel? phieuDatPhongViewModel = VMPPhong.Ins.VM.phieuDatPhongViewModel;
            if (phieuDatPhongViewModel != null)
            {
                phieuDatPhongViewModel.NgayNhan = DateTime.Now;
                var kq = PhieuDatPhongDataProvider.Ins.service.Update(phieuDatPhongViewModel);
                if (kq) RJMessageBox.Show("Phòng đã được nhận và từ giờ có thể gọi dịch vụ!.");
            }

            btnCheckinChange(null, null);
            btnCheckoutChange(null, null);
            btnOrderChange(null, null);

            //btnLoad_Click(sender, e);
        }

        private void btnDonPhong_Click(object sender, EventArgs e)
        {
            var result = RJMessageBox.Show("Xác nhận \"Đổi trạng Dọn Phòng\":  Chọn  YES  để \"Đồng Ý\"  ,  NO  để \"Hủy Bỏ\".",
    "Yes-No Button",
    MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
            {
                return;
            }
            //int count = VMPPhong.Ins.phongsChecked.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    var phong = VMPPhong.Ins.phongsChecked[i];
            //    if (phong.TrangThai == null || phong.TrangThai == 0)
            //        phong.TrangThai = 1;
            //    else phong.TrangThai = 0;
            //    VMPPhong.Ins.service.Update(phong);
            //}

            if (VMPPhong.Ins.VM.TrangThai == 0) VMPPhong.Ins.VM.TrangThai = 1;
            else VMPPhong.Ins.VM.TrangThai = 0;

            PhongDataProvider.Ins.service.Update(VMPPhong.Ins.VM);
            if (VMPPhong.Ins.VM.TrangThai == 0) RJMessageBox.Show("Phòng đã được đổi sang chờ dọn dẹp!.");
            else RJMessageBox.Show("Phòng đã được đổi sang đã dọn dẹp!.");
            //btnLoad_Click(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                timer1.Stop();

                VMPPhong.Ins.Method_PhongsFULL();
                VMPPhong.Ins.Phongs = VMPPhong.Ins.Phongs.Where(x => x.Ten.Contains(textBox1.Text)).ToList();
                VMPPhong.Ins.Method_ucPhongs();


                VMPPhong.Ins.PropertyChanged -= indexChange;
                VMPPhong.Ins.PropertyChanged -= btnOrderChange;
                VMPPhong.Ins.PropertyChanged -= btnCheckinChange;
                VMPPhong.Ins.PropertyChanged -= btnCheckoutChange;

                VMPPhong.Ins.indexChecked = 0;
                VMPPhong.Ins.indexChecked = 1;
                indexChange(null, null);

                VMPPhong.Ins.PropertyChanged += indexChange;
                VMPPhong.Ins.PropertyChanged += btnOrderChange;
                VMPPhong.Ins.PropertyChanged += btnCheckinChange;
                VMPPhong.Ins.PropertyChanged += btnCheckoutChange;
                //var lst = VMPPhong.Ins.service.GetAll() ?? new List<PhongViewModel>();
                //lst = lst.Where(x => x.Ten == null ? false : x.Ten.Contains(textBox1.Text)).ToList();
                //VMPPhong.Ins.Phongs = lst.OrderBy(x => x.Tang).ToList();

                //var count = VMPPhong.Ins.Phongs.Count;
                //VMPPhong.Ins.ucPhongs.Clear();
                //for (int i = 0; i < count; i++)
                //{
                //    var uc = new uc_Phong(i);
                //    VMPPhong.Ins.ucPhongs.Add(uc);
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Controls.AddRange(VMPPhong.Ins.ucPhongs.ToArray());
                timer1.Start();
            }

            //VMPPhong.Ins.phongsChecked.Clear();


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            btnCheckinChange(null, null);
            btnCheckoutChange(null, null);
            btnOrderChange(null, null);
            timer2.Stop();
        }
    }
}
