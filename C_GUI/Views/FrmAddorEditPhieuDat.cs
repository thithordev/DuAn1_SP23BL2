using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using C_GUI.VMProviders;
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
        public FrmAddorEditPhieuDat(PhieuDatPhongViewModel obj)
        {
            InitializeComponent();
            _phongVM = new PhongViewModel();
            _Service = VMPPhieuDatPhong.Ins.service;
            if (obj == null)
            {
                _ViewModel = new PhieuDatPhongViewModel();
                bindingSource1.DataSource = _ViewModel;


                dtpNgayDat.MinDate = DateTime.Today;

                _ViewModel.NgayDat = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 0, 0, 0);
                dtpNgayDat.Value = _ViewModel.NgayDat ?? DateTime.Today;
                _ViewModel.NgayDatTra = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day + 1, 0, 0, 0);
                dtpNgayDatTra.Value = _ViewModel.NgayDatTra ?? DateTime.Today;

                IsNew = true;
            }
            else
            {
                if (obj.KieuDat == null || obj.KieuDat == 0) radioButton1.Checked = true;
                else if (obj.KieuDat == 1) radioButton2.Checked = true;
                else radioButton3.Checked = true;
                _ViewModel = obj;
                _phongVM = _ViewModel.PhongVM ?? new PhongViewModel();
                //bindingSource1.DataSource = _ViewModel;
                IsNew = false;
            }

            //lbPhiPhong.DataBindings.Add("Text", _ViewModel, "StrPhiPhong");

            cbbGioDat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbGioDatTra.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbPhong.DropDownStyle = ComboBoxStyle.DropDownList;

            radioButton1_CheckedChanged(null, null);

            if (_phongVM.Id != Guid.Empty)
            {
                cbbPhong.DataSource = new List<PhongViewModel> { _phongVM };
                cbbPhong.SelectedIndex = 0;
            }

            if (!IsNew)
            {
                dtpNgayDat.Value = _ViewModel.NgayDat ?? DateTime.Today;
                dtpNgayDatTra.MinDate = dtpNgayDat.Value;
                dtpNgayDatTra.Value = _ViewModel.NgayDatTra ?? DateTime.Today;
                //bindingSource1.DataSource = _ViewModel;
            }


        }

        private void FrmAddorEditLoaiPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                //if (string.IsNullOrEmpty(tbTen.Text))
                //{
                //    MessageBox.Show("Chưa nhập tên!");
                //    tbTen.Focus();
                //    e.Cancel = true;
                //    return;
                //}

                var obj = bindingSource1.Current as PhieuDatPhongViewModel;
                if (obj != null)
                {
                    if (IsNew)
                    {

                        _Service.Add(obj);

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

                cbbGioDat.Items.Clear();
                cbbGioDatTra.Items.Clear();
                cbbGioDat.Items.Add("21:00");
                cbbGioDatTra.Items.Add("10:00");
                cbbGioDat.SelectedIndex = 0;
                cbbGioDatTra.SelectedIndex = 0;

                dtpNgayDatTra.MinDate = dtpNgayDat.Value.AddDays(1);
                dtpNgayDatTra.Value = dtpNgayDat.Value.AddDays(1);

                var obj = bindingSource1.Current as PhieuDatPhongViewModel;
                if (obj != null) { obj.KieuDat = 2; }
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked)
            {
                dtpNgayDatTra.Enabled = true;

                cbbGioDat.Items.Clear();
                cbbGioDatTra.Items.Clear();
                cbbGioDat.Items.Add("14:00");
                cbbGioDatTra.Items.Add("12:00");
                cbbGioDat.SelectedIndex = 0;
                cbbGioDatTra.SelectedIndex = 0;

                dtpNgayDatTra.MinDate = dtpNgayDat.Value.AddDays(1);
                dtpNgayDatTra.Value = dtpNgayDat.Value.AddDays(1);

                var obj = bindingSource1.Current as PhieuDatPhongViewModel;
                if (obj != null) { obj.KieuDat = 1; }
            }

        }

        private void radioButton1_CheckedChanged(object? sender, EventArgs? e)
        {

            if (radioButton1.Checked)
            {
                dtpNgayDatTra.Enabled = false;

                //if (IsNew)
                //{
                //    if (dtpNgayDat.Value == DateTime.Today)
                //    {
                //        cbbGioDat.Items.Clear();
                //        cbbGioDatTra.Items.Clear();
                //        var hourss = Enumerable.Range(DateTime.Now.Hour, 24 - DateTime.Now.Hour)
                //.Select(i => new DateTime(2000, 1, 1, i, 0, 0).ToString("HH:mm"));
                //        cbbGioDat.Items.AddRange(hourss.ToArray());
                //        cbbGioDatTra.Items.AddRange(hourss.ToArray());
                //        cbbGioDat.SelectedIndex = 0;
                //        cbbGioDatTra.SelectedIndex = 0;
                //    }
                //    else
                //    {
                //        cbbGioDat.Items.Clear();
                //        cbbGioDatTra.Items.Clear();
                //        var hours = Enumerable.Range(00, 24)
                //.Select(i => new DateTime(2000, 1, 1, i, 0, 0).ToString("HH:mm"));
                //        cbbGioDat.Items.AddRange(hours.ToArray());
                //        //hours.RemoveFirst();
                //        cbbGioDatTra.Items.AddRange(hours.ToArray());
                //        cbbGioDat.SelectedIndex = 0;
                //        cbbGioDatTra.SelectedIndex = 0;
                //    }
                //}
                //else
                //{
                cbbGioDat.Items.Clear();
                cbbGioDatTra.Items.Clear();
                var hours = Enumerable.Range(00, 24)
        .Select(i => new DateTime(2000, 1, 1, i, 0, 0).ToString("HH:mm"));
                cbbGioDat.Items.AddRange(hours.ToArray());
                //hours.RemoveFirst();
                cbbGioDatTra.Items.AddRange(hours.ToArray());
                cbbGioDat.SelectedIndex = 0;
                cbbGioDatTra.SelectedIndex = 0;
                //}

                dtpNgayDatTra.MinDate = dtpNgayDat.Value;
                dtpNgayDatTra.Value = dtpNgayDat.Value;

                var obj = bindingSource1.Current as PhieuDatPhongViewModel;
                if (obj != null) { obj.KieuDat = 0; }
            }

        }

        private void addHours(int start)
        {

        }

        private void cbbGioDat_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeNgayDat();
            //cbbPhong.DataSource = null;
            //_ViewModel.PhongVM = null;
            //lbPhiPhong.Text = "0 đ";
        }
        private void cbbGioDatTra_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeNgayDatTra();
            //cbbPhong.DataSource = null;
            //_ViewModel.PhongVM = null;
            //lbPhiPhong.Text = "0 đ";
        }
        private void dtpNgayDat_ValueChanged(object sender, EventArgs e)
        {
            changeNgayDat();
            //cbbPhong.DataSource = null;
            //_ViewModel.PhongVM = null;
            //lbPhiPhong.Text = "0 đ";
        }

        private void dtpNgayDatTra_ValueChanged(object sender, EventArgs e)
        {
            changeNgayDatTra();
            //cbbPhong.DataSource = null;
            //_ViewModel.PhongVM = null;
            //lbPhiPhong.Text = "0 đ";
        }

        private void changeNgayDat()
        {
            string strtime = cbbGioDat.Text + ":00";


            try
            {
                var time = TimeSpan.Parse(strtime);

                //if (_ViewModel.NgayDat.HasValue)
                //{
                //    _ViewModel.NgayDat = new DateTime(dtpNgayDat.Value.Year, dtpNgayDat.Value.Month, dtpNgayDat.Value.Day, time.Hours, time.Minutes, 0);
                //}

                if (_ViewModel.KieuDat == 1)
                {
                    dtpNgayDatTra.MinDate = dtpNgayDat.Value;
                    dtpNgayDatTra.Value = dtpNgayDat.Value;
                }

                if (_ViewModel.KieuDat == 2)
                {
                    dtpNgayDatTra.MinDate = dtpNgayDat.Value.AddDays(1);
                    if (dtpNgayDat.Value > dtpNgayDatTra.Value)
                        dtpNgayDatTra.Value = dtpNgayDat.Value.AddDays(1);
                }

                if (_ViewModel.KieuDat == 3)
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
                //if (_ViewModel.NgayDat.HasValue)
                //{
                //    _ViewModel.NgayDatTra = new DateTime(dtpNgayDatTra.Value.Year, dtpNgayDatTra.Value.Month, dtpNgayDatTra.Value.Day, time.Hours, time.Minutes, 0);
                //}
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

        private void cbbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbTenDem.Focus();
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
            }
            else
            {
                _ViewModel.PhongVM = null;
                lbPhiPhong.Text = "0 đ";
            }
        }
    }
}
