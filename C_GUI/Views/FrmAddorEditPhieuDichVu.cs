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
    public partial class FrmAddorEditPhieuDichVu : MetroFramework.Forms.MetroForm
    {
        IPhieuDichVuService _Service;
        bool IsNew;
        public FrmAddorEditPhieuDichVu(PhieuDichVuViewModel obj)
        {
            InitializeComponent();
            _Service = VMPPhieuDichVu.Ins.service;
            if (obj == null)
            {
                bindingSource1.DataSource = new PhieuDichVuViewModel();
                IsNew = true;
            }
            else
            {
                bindingSource1.DataSource = obj;
                IsNew = false;
            }
        }

        private void FrmAddorEditPhieuDichVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                //Validate
                //if (string.IsNullOrEmpty(tbTen.Text))
                //{
                //    MessageBox.Show("Chưa nhập tên!");
                //    tbTen.Focus();
                //    e.Cancel = true;
                //    return;
                //}

                var obj = bindingSource1.Current as PhieuDichVuViewModel;
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
