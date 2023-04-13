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
        public FrmAddorEditKhachHang(KhachHangViewModel obj)
        {
            InitializeComponent();
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
                if (string.IsNullOrEmpty(tbTen.Text))
                {
                    MessageBox.Show("Chưa nhập tên!");
                    tbTen.Focus();
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
    }
}
