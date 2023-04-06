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
    public partial class FrmAddorEditPhieuDat : MetroFramework.Forms.MetroForm
    {
        IPhieuDatPhongService _Service;
        bool IsNew;
        public FrmAddorEditPhieuDat(PhieuDatPhongViewModel obj)
        {
            InitializeComponent();
            _Service = VMPPhieuDatPhong.Ins.service;
            if (obj == null)
            {
                bindingSource1.DataSource = new PhieuDatPhongViewModel();
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
                if (string.IsNullOrEmpty(tbTen.Text))
                {
                    MessageBox.Show("Chưa nhập tên!");
                    tbTen.Focus();
                    e.Cancel = true;
                    return;
                }

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
    }
}
