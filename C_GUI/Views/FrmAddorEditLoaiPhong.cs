using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
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
    public partial class FrmAddorEditLoaiPhong : Form
    {
        ILoaiPhongService _loaiPhongService;
        bool IsNew;
        public FrmAddorEditLoaiPhong(LoaiPhongViewModel obj)
        {
            InitializeComponent();
            _loaiPhongService = new LoaiPhongService();
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
    }
}
