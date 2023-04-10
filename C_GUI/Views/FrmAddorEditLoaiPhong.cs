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
    public partial class FrmAddorEditLoaiPhong : MetroFramework.Forms.MetroForm
    {
        ILoaiPhongService _loaiPhongService;
        bool IsNew;
        public FrmAddorEditLoaiPhong(LoaiPhongViewModel obj)
        {
            InitializeComponent();
            _loaiPhongService = VMPLoaiPhong.Ins.service;
            if (obj == null)
            {
                bindingSource1.DataSource = new LoaiPhongViewModel();
                IsNew = true;
            }
            else
            {
                bindingSource1.DataSource = obj;
                IsNew = false;
            }
        }

        private void FrmAddorEditLoaiPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                //Validate
                if (string.IsNullOrEmpty(tbTen.Text))
                {
                    MessageBox.Show("Chưa nhập tên!");
                    tbTen.Focus();
                    e.Cancel = true;
                    return;
                }

                var obj = bindingSource1.Current as LoaiPhongViewModel;
                if (obj != null)
                {
                    if (IsNew)
                    {

                        _loaiPhongService.Add(obj);

                    }
                    else
                    {

                        _loaiPhongService.Update(obj);

                    }
                }
            }
        }

        private void tbGiaGio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbGiaNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tbSoGiuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

    }
}
