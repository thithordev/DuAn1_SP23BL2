using A_DAL.Models;
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
        List<HoaDonViewModel> _lst_hoaDon;
        public FrmHoaDon()
        {
            InitializeComponent();
            _lst_hoaDon = new List<HoaDonViewModel>();

        }
        private void dgv_hoadon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            _lst_hoaDon = LstHoaDon();
            BindingSource1.DataSource = _lst_hoaDon;
        }

        private List<HoaDonViewModel> LstHoaDon()
        {
            return  new List<HoaDonViewModel>()
            {
                new HoaDonViewModel()
                {
                    Id = Guid.NewGuid(),
                    NgayTao = DateTime.Now,
                    TongTien = 1000,
                    TrangThai = 0,
                    GhiChu = "HAHA",
                    KhachHang = new A_DAL.Models.KhachHang()
                    {
                      Id = Guid.NewGuid(),
                      Ten = "DucHieu0",
                     SDT = "01123123",
                    },
                    NhanVien = new NhanVien()
                    {
                            Ten = "Hieu0",

                    },
                },

                new HoaDonViewModel()
                {
                    Id = Guid.NewGuid(),
                    NgayTao = DateTime.Now,
                    TongTien = 1000,
                    TrangThai = 2,
                    GhiChu = "HAHA",
                    KhachHang = new A_DAL.Models.KhachHang()
                    {
                      Id = Guid.NewGuid(),
                      Ten = "DucHieu1",
                     SDT = "01123123",
                    },
                    NhanVien = new NhanVien()
                    {
                            Ten = "Hieu1",
                    },
                },

                new HoaDonViewModel()
                {
                    Id = Guid.NewGuid(),
                    NgayTao = DateTime.Now,
                    TongTien = 1000,
                    TrangThai = 2,
                    GhiChu = "HAHA",
                    KhachHang = new A_DAL.Models.KhachHang()
                    {
                      Id = Guid.NewGuid(),
                      Ten = "DucHieu2",
                     SDT = "01123123",
                    },
                    NhanVien = new NhanVien()
                    {
                            Ten = "Hieu2",
                    },
                },
                
            };
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var id = dataGridView2.SelectedCells[1].OwningRow.Cells[1].Value.ToString();
            var ob = Guid.Parse(id);

            FrmSuaHoaDon frmSuaHoaDon = new FrmSuaHoaDon(_lst_hoaDon.FirstOrDefault(c=>c.Id == ob));
            frmSuaHoaDon.Show();
        }
    }
}
