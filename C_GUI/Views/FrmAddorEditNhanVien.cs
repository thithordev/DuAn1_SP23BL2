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
    public partial class FrmAddorEditNhanVien : MetroFramework.Forms.MetroForm
    {
        INhanVienService _nhanVienService;
        bool IsNew;
        public FrmAddorEditNhanVien(NhanVienViewModel obj)
        {
            InitializeComponent();
            _nhanVienService = VMPNhanVien.Ins.service;
            if (obj == null)
            {
                nhanVienViewModelBindingSource.DataSource = new NhanVienViewModel();
                IsNew = true;
            }
            else
            {
                nhanVienViewModelBindingSource.DataSource = obj;
                IsNew = false;
            }
        }

        private void FrmAddorEditNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {

                var obj = nhanVienViewModelBindingSource.Current as NhanVienViewModel;
                if (obj != null)
                {
                    if (IsNew)
                    {

                        _nhanVienService.Add(obj);

                    }
                    else
                    {

                        _nhanVienService.Update(obj);

                    }
                }
            }
        }
    }
}

