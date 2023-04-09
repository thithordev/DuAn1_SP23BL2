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
    public partial class FrmAddorEditQLPhong : MetroFramework.Forms.MetroForm
    {
        IPhongService _phongService;
        bool IsNew;
        public FrmAddorEditQLPhong(PhongViewModel obj)
        {
            InitializeComponent();
            _phongService = VMPPhong.Ins.service;
            if (obj == null)
            {
                bindingSource1.DataSource = new PhongViewModel();
                IsNew = true;
            }
            else
            {
                bindingSource1.DataSource = obj;
                IsNew = false;
            }
            cbbLoaiPhong.DataSource = VMPLoaiPhong.Ins.service.GetAll();
            cbbLoaiPhong.DisplayMember = "Ten";
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

                var obj = bindingSource1.Current as PhongViewModel;
                if (obj != null)
                {
                    if (IsNew)
                    {

                        _phongService.Add(obj);

                    }
                    else
                    {

                        _phongService.Update(obj);

                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }
    }
}
