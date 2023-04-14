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
    public partial class FrmAddorEditNhanVien : MetroFramework.Forms.MetroForm
    {
        List<NhanVienViewModel> NhanVienList;
        List<ChucVuViewModel> chucVuViewModelList;
        INhanVienService _nhanVienService;
        bool IsNew;
        public FrmAddorEditNhanVien(NhanVienViewModel obj)
        {
            InitializeComponent();
            chucVuViewModelList = ChucVuDataProvider.Ins.service.GetAll() ?? new List<ChucVuViewModel>();
            NhanVienList = NhanVienDataProvider.Ins.service.GetAll() ?? new List<NhanVienViewModel> ();
            cbbChucVu.DataSource = chucVuViewModelList;
            cbbChucVu.DisplayMember= "Ten";
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
                if (string.IsNullOrEmpty(tbTen.Text))
                {
                    MessageBox.Show("Chưa nhập tên!");
                    tbTen.Focus();
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
                if(IsNew)
                {
                if (NhanVienList.Any(x => (x.CCCD ?? string.Empty).Equals(tbCCCD.Text)))
                {
                    MessageBox.Show("Chứng minh hoặc căn cước đã có trong danh sách");
                    tbCCCD.Focus();
                    e.Cancel = true;
                    return;
                }
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
                if ((DateTime.Today.Year - dtpkNgaySinh.Value.Year) < 18)
                {
                    MessageBox.Show("Tuổi phải lớn hơn hoặc bằng 18 tuổi!");
                    tbMoTa.Focus();
                    e.Cancel = true;
                    return;
                }

                if (string.IsNullOrEmpty(tbLuong.Text))
                {
                    MessageBox.Show("Chưa nhập số diện thoại!");
                    tbCCCD.Focus();
                    e.Cancel = true;
                    return;
                }


                var obj = nhanVienViewModelBindingSource.Current as NhanVienViewModel;
                if (obj != null)
                {
                    if (IsNew)
                    {
                        if(string.IsNullOrEmpty(tbTaiKhoan.Text) || string.IsNullOrEmpty(tbMatKhau.Text)) 
                            {
                            obj.TenTaiKhoan = null;
                            obj.MatKhau= null;
                        }
                        _nhanVienService.Add(obj);

                    }
                    else
                    {

                        _nhanVienService.Update(obj);

                    }
                }
            }
        }

        private void tbCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

