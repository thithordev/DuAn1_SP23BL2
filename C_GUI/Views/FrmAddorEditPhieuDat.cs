using B_BUS.DataProviders;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using C_GUI.VMProviders;
using Catel.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_GUI.Views
{
    public partial class FrmAddorEditPhieuDat : MetroFramework.Forms.MetroForm
    {
        IPhieuDatPhongService _Service;
        bool IsNew;
        PhieuDatPhongViewModel _ViewModel;
        PhongViewModel _phongVM;
        KhachHangViewModel _khachHangVM;
        public FrmAddorEditPhieuDat(PhieuDatPhongViewModel obj)
        {
            InitializeComponent();

            _ViewModel = new PhieuDatPhongViewModel();
            _phongVM = new PhongViewModel();
            _khachHangVM = new KhachHangViewModel();


            _Service = VMPPhieuDatPhong.Ins.service;
            if (obj == null)
            {
                _ViewModel = new PhieuDatPhongViewModel()
                {
                    Id = Guid.NewGuid(),
                    NhanVienId = VMPNhanVien.Ins.NhanVienLogin.Id,


                    NgayTao = DateTime.Now,
                    NgayDat = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0),
                    NgayDatTra = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day + 1, 0, 0, 0),
                    KieuDat = 1,
                    TrangThai = 1,
                    PhiPhong = 0,
                    NhanVienVM = VMPNhanVien.Ins.NhanVienLogin,

                };
                _ViewModel.KhachHangVM = new KhachHangViewModel() { Id = Guid.NewGuid(), GioiTinh = true, };
                bindingSource2.DataSource = _ViewModel.KhachHangVM;
                bindingSource1.DataSource = _ViewModel;
                IsNew = true;
            }
            else
            {
                _ViewModel = new PhieuDatPhongViewModel()
                {
                    Id = obj.Id,
                    KhachHangId = obj.KhachHangId,
                    NhanVienId = obj.NhanVienId,
                    HoaDonId = obj.HoaDonId,
                    PhongId = obj.PhongId,
                    NgayTao = obj.NgayTao,
                    NgayDat = obj.NgayDat,
                    NgayDatTra = obj.NgayDatTra,
                    NgayNhan = obj.NgayNhan,
                    NgayTra = obj.NgayTra,
                    KieuDat = obj.KieuDat,
                    TrangThai = obj.TrangThai,
                    PhiPhong = obj.PhiPhong,
                    GhiChu = obj.GhiChu,

                    PhongVM = obj.PhongVM,
                    NhanVienVM = obj.NhanVienVM,
                    KhachHangVM = obj.KhachHangVM,
                    HoaDonVM = obj.HoaDonVM,
                    PhieuDichVusVM = obj.PhieuDichVusVM,
                };
                if(_ViewModel.KhachHangVM == null) _ViewModel.KhachHangVM = new KhachHangViewModel();
                bindingSource2.DataSource = _ViewModel.KhachHangVM;
                bindingSource1.DataSource = _ViewModel;
                IsNew = false;
            }

            // Settting

            cbbGioDat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbGioDatTra.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbPhong.DropDownStyle = ComboBoxStyle.DropDownList;


            // Nạp data
            _phongVM = _ViewModel.PhongVM ?? new PhongViewModel();


            if (_ViewModel.KieuDat == 0) radioButton1.Checked = true;
            else if (_ViewModel.KieuDat == 1) radioButton2.Checked = true;
            else radioButton3.Checked = true;


            if (!IsNew)
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                dtpNgayDat.Enabled = false;
                dtpNgayDatTra.Enabled = false;
                cbbGioDat.Enabled = false;
                cbbGioDatTra.Enabled = false;
                groupBox1.Enabled = false;
            }

            dtpNgayDat.Value = _ViewModel.NgayDat;
            dtpNgayDatTra.Value = _ViewModel.NgayDatTra;

            cbbGioDat.SelectedItem = _ViewModel.strGioDat;
            cbbGioDatTra.SelectedItem = _ViewModel.strGioDatTra;

            // Khi thay doi date thì _viewmodel thay doi

            if (_ViewModel.PhongVM != null)
            {
                //cbbPhong.DataSource = bindingSource2.DataSource;
                cbbPhong.DataSource = new List<PhongViewModel>() { _ViewModel.PhongVM };
                cbbPhong.DisplayMember = "strshowCBB";
                cbbPhong.SelectedIndex = 0;
                cbbPhong_SelectedIndexChanged(null, null);
            }


            //lbPhiPhong.DataBindings.Add("Text", _ViewModel, "StrPhiPhong");



            //if (_phongVM.Id != Guid.Empty)
            //{
            //    cbbPhong.DataSource = new List<PhongViewModel> { _phongVM };
            //    cbbPhong.SelectedIndex = 0;
            //}

            this.cbbGioDat.SelectedIndexChanged += cbbGioDat_SelectedIndexChanged;
            this.cbbGioDatTra.SelectedIndexChanged += cbbGioDatTra_SelectedIndexChanged;
            this.dtpNgayDat.ValueChanged += dtpNgayDat_ValueChanged;
            this.dtpNgayDatTra.ValueChanged += dtpNgayDatTra_ValueChanged;
            //this.dtpNgayDatTra.


        }

        private void FrmAddorEditLoaiPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(tbTenDem.Text))
                {
                    MessageBox.Show("Chưa nhập tên đệm!");
                    tbTenDem.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(tbTen.Text))
                {
                    MessageBox.Show("Chưa nhập tên!");
                    tbTen.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(tbCCCD.Text))
                {
                    MessageBox.Show("Chưa nhập CCCD/CMTND!");
                    tbCCCD.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(tbCCCD.Text))
                {
                    MessageBox.Show("Chưa nhập CCCD/CMTND!");
                    tbCCCD.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(tbSDT.Text))
                {
                    MessageBox.Show("Chưa nhập CCCD/CMTND!");
                    tbSDT.Focus();
                    e.Cancel = true;
                    return;
                }
                if (string.IsNullOrEmpty(tbDiaChi.Text))
                {
                    MessageBox.Show("Chưa nhập CCCD/CMTND!");
                    tbDiaChi.Focus();
                    e.Cancel = true;
                    return;
                }

                var obj = bindingSource1.Current as PhieuDatPhongViewModel;
                var objKH = bindingSource2.Current as KhachHangViewModel;
                if (obj != null && objKH != null)
                {
                    if (IsNew)
                    {
                        var isKHdb = KhachHangDataProvider.Ins.repository.GetAll().Where(x => x.CCCD == objKH.CCCD).FirstOrDefault();
                        if(isKHdb == null)
                        {
                            var kq1 = KhachHangDataProvider.Ins.service.Add(objKH);
                            MessageBox.Show(kq1.ToString());
                            obj.KhachHangId = objKH.Id;
                        }
                        else
                        {
                            obj.KhachHangId = isKHdb.Id;
                        }
                        var kq = _Service.Add(obj);
                        MessageBox.Show(kq.ToString());
                    }
                    else
                    {

                        _Service.Update(obj);

                    }
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton3.Checked)
            {
                dtpNgayDatTra.Enabled = false;
                _ViewModel.KieuDat = 2;

                cbbGioDat.Items.Clear();
                cbbGioDatTra.Items.Clear();
                cbbGioDat.Items.Add("21:00");
                cbbGioDatTra.Items.Add("10:00");
                cbbGioDat.SelectedIndex = 0;
                cbbGioDatTra.SelectedIndex = 0;

                //if(IsNew)
                //{
                //    dtpNgayDatTra.MinDate = dtpNgayDat.Value.AddDays(1);
                //    dtpNgayDatTra.Value = dtpNgayDat.Value.AddDays(1);

                //}

            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked)
            {
                dtpNgayDatTra.Enabled = true;
                _ViewModel.KieuDat = 1;

                cbbGioDat.Items.Clear();
                cbbGioDatTra.Items.Clear();
                cbbGioDat.Items.Add("14:00");
                cbbGioDatTra.Items.Add("12:00");
                cbbGioDat.SelectedIndex = 0;
                cbbGioDatTra.SelectedIndex = 0;

                //if (IsNew)
                //{
                //    dtpNgayDatTra.MinDate = dtpNgayDat.Value.AddDays(1);
                //    dtpNgayDatTra.Value = dtpNgayDat.Value.AddDays(1);
                //}


            }

        }

        private void radioButton1_CheckedChanged(object? sender, EventArgs? e)
        {

            if (radioButton1.Checked)
            {
                dtpNgayDatTra.Enabled = true;
                _ViewModel.KieuDat = 0;

                cbbGioDat.Items.Clear();
                cbbGioDatTra.Items.Clear();
                var hours = Enumerable.Range(00, 24)
        .Select(i => new DateTime(2000, 1, 1, i, 0, 0).ToString("HH:mm"));
                cbbGioDat.Items.AddRange(hours.ToArray());
                //hours.RemoveFirst();
                cbbGioDatTra.Items.AddRange(hours.ToArray());
                cbbGioDat.SelectedIndex = 0;
                cbbGioDatTra.SelectedIndex = 0;

                //if (IsNew)
                //{
                //    dtpNgayDatTra.MinDate = dtpNgayDat.Value;
                //    dtpNgayDatTra.Value = dtpNgayDat.Value;

                //}

            }

        }

        private void cbbGioDat_SelectedIndexChanged(object? sender, EventArgs? e)
        {
            changeNgayDat();
            cbbPhong.DataSource = null;
            _ViewModel.PhongVM = null;
            lbPhiPhong.Text = "0 đ";
        }
        private void cbbGioDatTra_SelectedIndexChanged(object? sender, EventArgs? e)
        {
            changeNgayDatTra();
            cbbPhong.DataSource = null;
            _ViewModel.PhongVM = null;
            lbPhiPhong.Text = "0 đ";
        }
        private void dtpNgayDat_ValueChanged(object? sender, EventArgs? e)
        {
            changeNgayDat();
            cbbPhong.DataSource = null;
            _ViewModel.PhongVM = null;
            lbPhiPhong.Text = "0 đ";
        }

        private void dtpNgayDatTra_ValueChanged(object? sender, EventArgs? e)
        {
            changeNgayDatTra();
            cbbPhong.DataSource = null;
            _ViewModel.PhongVM = null;
            lbPhiPhong.Text = "0 đ";
        }

        private void changeNgayDat()
        {
            string strtime = cbbGioDat.Text + ":00";


            try
            {
                var time = TimeSpan.Parse(strtime);


                //_ViewModel.NgayDat = new DateTime(dtpNgayDat.Value.Year, dtpNgayDat.Value.Month, dtpNgayDat.Value.Day, time.Hours, time.Minutes, 0);

                if (IsNew)
                {
                    dtpNgayDat.MinDate = DateTime.Today;
                }

                if (_ViewModel.KieuDat == 0)
                {
                    dtpNgayDatTra.MinDate = dtpNgayDat.Value;
                    dtpNgayDatTra.Value = dtpNgayDat.Value;
                }

                if (_ViewModel.KieuDat == 1)
                {
                    dtpNgayDatTra.MinDate = dtpNgayDat.Value.AddDays(1);
                    if (dtpNgayDat.Value > dtpNgayDatTra.Value)
                        dtpNgayDatTra.Value = dtpNgayDat.Value.AddDays(1);
                }

                if (_ViewModel.KieuDat == 2)
                {
                    dtpNgayDatTra.MinDate = dtpNgayDat.Value.AddDays(1);
                    dtpNgayDatTra.Value = dtpNgayDat.Value.AddDays(1);
                }

            }
            catch (Exception)
            {

                return;
            }

        }

        private void changeNgayDatTra()
        {
            string strtime = cbbGioDatTra.Text + ":00";

            try
            {
                var time = TimeSpan.Parse(strtime);


                //_ViewModel.NgayDatTra = new DateTime(dtpNgayDatTra.Value.Year, dtpNgayDatTra.Value.Month, dtpNgayDatTra.Value.Day, time.Hours, time.Minutes, 0);

            }
            catch (Exception)
            {

                return;
            }

        }

        private void lstPhongTrongKhoang()
        {
            List<PhongViewModel> lst = new List<PhongViewModel>();
            var lstPhong = VMPPhong.Ins.service.GetAll();
            List<PhieuDatPhongViewModel> lstPDphong = _Service.GetAll() ?? new List<PhieuDatPhongViewModel>();
            if (lst != null)
            {
                lst = (from p in lstPhong
                       where !lstPDphong.Any(x => x.PhongId == p.Id && x.NgayDatTra >= _ViewModel.NgayDat && x.NgayDat <= _ViewModel.NgayDatTra)
                       select p
                           ).ToList();
            }
            cbbPhong.DataSource = lst;
            cbbPhong.DisplayMember = "strshowCBB";
        }

        private void cbbPhong_SelectedIndexChanged(object? sender, EventArgs? e)
        {
            tbTenDem.Focus();
            //_ViewModel.PhongVM = sender as PhongViewModel;

            if (_ViewModel.PhongVM != null)
            {
                var ngaydattra = _ViewModel.NgayDatTra;
                var ngaytra = _ViewModel.NgayDat;

                var loaiphong = _ViewModel.PhongVM.loaiPhongViewModel;
                if (loaiphong != null)
                {
                    if (_ViewModel.KieuDat == null || _ViewModel.KieuDat == 0)
                    {
                        int timesp = ngaydattra.Hour - ngaytra.Hour;
                        _ViewModel.PhiPhong = timesp * loaiphong.GiaGio;
                    }
                    else if (_ViewModel.KieuDat == 1)
                    {
                        int timesp = ngaydattra.Day - ngaytra.Day;
                        _ViewModel.PhiPhong = timesp * loaiphong.GiaNgay;
                    }
                    else
                    {
                        int timesp = ngaydattra.Day - ngaytra.Day;
                        _ViewModel.PhiPhong = timesp * loaiphong.GiaDem;
                    }
                }

                _ViewModel.PhongId = _ViewModel.PhongVM?.Id;

            }
        }

        private void button1_Click(object? sender, EventArgs? e)
        {
            var a = _ViewModel.PhongVM;
            if (a != null)
            {
                MessageBox.Show(a.Ten + _ViewModel.PhiPhong + " " + _ViewModel.KieuDat);
            }
        }

        private void btnTimPhong_Click(object sender, EventArgs e)
        {


            if (_ViewModel.NgayDat < _ViewModel.NgayDatTra)
            {
                lstPhongTrongKhoang();
                _ViewModel.PhongVM = cbbPhong.SelectedItem as PhongViewModel;
                cbbPhong_SelectedIndexChanged(null,null);
            }
            else
            {
                _ViewModel.PhongVM = null;
                lbPhiPhong.Text = "0 đ";
            }
        }
    }
}
