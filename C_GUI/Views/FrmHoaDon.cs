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
    public partial class FrmHoaDon : Form
    {
        IHoaDonService Ihd;
        List<HoaDonViewModel> _lstHoadon;
        int _index = 0;

        public FrmHoaDon()
        {
            InitializeComponent();
            Ihd = new HoaDonService();
            _lstHoadon = new List<HoaDonViewModel>();
            GetHoaDonFromData();
        }

        private void GetHoaDonFromData()
        {
            //_lstHoadon = Ihd.GetAll();
            _lstHoadon = new List<HoaDonViewModel>()
            {
                new HoaDonViewModel(){Hoadon = Guid.NewGuid(),Khachhang = "Dương Đức Hiếu",sdt = 12312312, DateTime = DateTime.Now,phuongthucthanhtoan = 1,Tongsotien = 100,trangthai = 1},
                new HoaDonViewModel(){Hoadon = Guid.NewGuid(),Khachhang = "Dương Đức Hiếu",sdt = 12312312, DateTime = DateTime.Now,phuongthucthanhtoan = 0,Tongsotien = 100,trangthai = 0}
            };

            dgv_hoadon.Rows.Clear();
            _index = 0;
            foreach (var x in _lstHoadon)
            {
                _index++;
                dgv_hoadon.Rows.Add(_index, x.Hoadon, x.Khachhang, x.sdt, x.DateTime, x.phuongthucthanhtoan == 1 ? "Chuyển khoản" : "Tiền mặt", x.Tongsotien, x.trangthai == 1 ? "Đã thanh toán" : "Hủy thanh toán");
            }

        }

        private void GetTrangThai()
        {


        }

        private void dgv_hoadon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
