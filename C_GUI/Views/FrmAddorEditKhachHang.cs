using B_BUS.DataProviders;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_GUI.Views
{
    public partial class FrmAddorEditKhachHang : MetroFramework.Forms.MetroForm
    {
        IKhachHangService _khachHangService;
        bool IsNew;
        List<KhachHangViewModel> KhachHangList;
        public FrmAddorEditKhachHang(KhachHangViewModel obj)
        {
            InitializeComponent();
            KhachHangList = KhachHangDataProvider.Ins.service.GetAll() ?? new List<KhachHangViewModel>();
            _khachHangService = VMPKhachHang.Ins.service;
            if (obj == null)
            {
                khachHangViewModelBindingSource.DataSource = new KhachHangViewModel();
                IsNew = true;
            }
            else
            {
                khachHangViewModelBindingSource.DataSource = obj;
                IsNew = false;
            }
        }

        private void FrmAddorEditKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(tbTen1.Text))
                {
                    MessageBox.Show("Chưa nhập tên!");
                    tbTen1.Focus();
                    e.Cancel = true;
                    return;
                }

                if (string.IsNullOrEmpty(tbTenDem.Text))
                {
                    MessageBox.Show("Chưa nhập tên đệm!");
                    tbTenDem.Focus();
                    e.Cancel = true;
                    return;
                }

                if (KhachHangList.Any(x => (x.CCCD ?? string.Empty).Equals(tbCCCD.Text)))
                {
                    MessageBox.Show("Chứng minh hoặc căn cước đã có trong danh sách");
                    tbCCCD.Focus();
                    e.Cancel = true;
                    return;
                }

                if (string.IsNullOrEmpty(tbCCCD.Text))
                {
                    MessageBox.Show("Chưa nhập căn cước hoặc chứng minh thư!");
                    tbCCCD.Focus();
                    e.Cancel = true;
                    return;
                }

                if (string.IsNullOrEmpty(tbSDT.Text))
                {
                    MessageBox.Show("Chưa nhập số diện thoại!");
                    tbCCCD.Focus();
                    e.Cancel = true;
                    return;
                }
                if ((DateTime.Today.Year - dtpkNgaySinh.Value.Year) < 18 )
                {
                    MessageBox.Show("Tuổi phải lớn hơn hoặc bằng 18 tuổi!");
                    tbGhiChu.Focus();
                    e.Cancel = true;
                    return;
                }

                var obj = khachHangViewModelBindingSource.Current as KhachHangViewModel;
                if (obj != null)
                {
                    if (IsNew)
                    {

                        _khachHangService.Add(obj);

                    }
                    else
                    {

                        _khachHangService.Update(obj);

                    }
                }
            }
        }

        private void tbGiaNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbGiaGio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
