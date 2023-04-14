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
    public partial class FrmAddorEditThuChiKhac : MetroFramework.Forms.MetroForm
    {
        IThuChiKhacService _thuChiKhacService;
        bool IsNew;
        ThuChiKhacViewModel _thuChiKhacViewModel;
        public FrmAddorEditThuChiKhac(ThuChiKhacViewModel obj)
        {
            InitializeComponent();
            _thuChiKhacService = VMPThuChiKhac.Ins.service;
            _thuChiKhacViewModel = new ThuChiKhacViewModel();
            if (obj == null)
            {                
                _thuChiKhacViewModel = new ThuChiKhacViewModel() {NgayTao = DateTime.Now};
                bindingSource1.DataSource = _thuChiKhacViewModel;
                IsNew = true;
            }
            else
            {
                _thuChiKhacViewModel = obj;
                bindingSource1.DataSource = _thuChiKhacViewModel;            
                IsNew = false;
            }          
        }

        private void FrmAddorEditLoaiPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                //Validate
                if (string.IsNullOrEmpty(tbSoTien.Text))
                {
                    MessageBox.Show("Chưa nhập số tiền!");
                    tbSoTien.Focus();
                    e.Cancel = true;
                    return;
                }

                var obj = bindingSource1.Current as ThuChiKhacViewModel;
                if (obj != null)
                {
                    if (IsNew)
                    {

                        _thuChiKhacService.Add(obj);

                    }
                    else
                    {

                        _thuChiKhacService.Update(obj);

                    }
                }
            }
        }

        private void tbSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
