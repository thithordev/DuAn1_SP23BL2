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
        PhieuDichVuViewModel _phieuDV;

        IPhieuDichVuService _Service;
        IChiTietPhieuDichVuService _ctDVsevice;
        bool IsNew;
        public FrmAddorEditPhieuDichVu(PhieuDichVuViewModel? obj, PhieuDatPhongViewModel? objPhieuDat)
        {
            InitializeComponent();

            // Khởi Tạo.
            _phieuDV = new PhieuDichVuViewModel();

            _Service = VMPPhieuDichVu.Ins.service;
            _ctDVsevice = VMPChiTietPhieuDichVu.Ins.service;

            //var lstctDV = _ctDVsevice.GetAll()??new List<ChiTietPhieuDichVuViewModel>();
            //bindingSource2.DataSource = lstctDV.Where(x => x.TrangThai == true).OrderBy(x => x.Ten);

            cbbPhieuDat.DataSource = VMPPhieuDatPhong.Ins.PhieuDatPhongsDangThue;
            cbbPhieuDat.DisplayMember = "status";
            cbbPhieuDat.DropDownStyle = ComboBoxStyle.DropDownList;

            if (obj == null)
            {
                _phieuDV = new PhieuDichVuViewModel()
                {
                    Id = Guid.NewGuid(),
                    NhanVienId = VMPNhanVien.Ins.NhanVienLogin.Id,
                    NhanVienVM = VMPNhanVien.Ins.NhanVienLogin,
                    NgayTao = DateTime.Now,
                    TrangThai = 1,
                    GhiChu = string.Empty,
                };
                if(objPhieuDat!= null) {
                    _phieuDV.PhieuDatPhongId = objPhieuDat.Id;
                    _phieuDV.PhieuDatPhongVM = objPhieuDat; 
                    cbbPhieuDat.Enabled = false; }
                bindingSource1.DataSource = _phieuDV;
                VMPChiTietPhieuDichVu.Ins.GetbasectPhieuDichVu(_phieuDV);
                bindingSource2.DataSource = VMPChiTietPhieuDichVu.Ins.BasectPhieuDichVu;
                IsNew = true;
            }
            else
            {
                bindingSource1.DataSource = obj;
                VMPChiTietPhieuDichVu.Ins.GetbasectPhieuDichVu(obj);
                VMPChiTietPhieuDichVu.Ins.AddbasectPhieuDichVu(obj);
                bindingSource2.DataSource = VMPChiTietPhieuDichVu.Ins.BasectPhieuDichVu;
                cbbPhieuDat.Enabled = false;
                IsNew = false;
            }

            lbTongTien.Text = strTinhTongTien();

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
                        VMPChiTietPhieuDichVu.Ins.UpdatebasePhieuDichVu();
                    }
                    else
                    {
                        _Service.Update(obj);
                        VMPChiTietPhieuDichVu.Ins.UpdatebasePhieuDichVu();
                    }
                }
            }
        }

        private void dgvCTPhieuDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (e.ColumnIndex == AddSL.Index)
                {
                    //var cell = senderGrid.CurrentRow.Cells[SL.Index].Value.ToString();
                    //MessageBox.Show(cell);
                    var obj = bindingSource2.Current as ChiTietPhieuDichVuViewModel;
                    if (obj != null)
                    {
                        obj.SoLuong++;
                        senderGrid.CurrentRow.Cells[SL.Index].Value = obj.SoLuong;
                    }
                    lbTongTien.Text = strTinhTongTien();
                }

                if (e.ColumnIndex == RemoveSL.Index)
                {
                    var obj = bindingSource2.Current as ChiTietPhieuDichVuViewModel;
                    if (obj != null)
                    {
                        if (obj.SoLuong > 0) { obj.SoLuong--; }
                        senderGrid.CurrentRow.Cells[SL.Index].Value = obj.SoLuong;
                    }
                    lbTongTien.Text = strTinhTongTien();
                }
            }
        }

        private string strTinhTongTien()
        {
            decimal tong = 0;
            int count = VMPChiTietPhieuDichVu.Ins.BasectPhieuDichVu.Count;
            if(count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    int sl = VMPChiTietPhieuDichVu.Ins.BasectPhieuDichVu[i].SoLuong ?? 0;
                    decimal dongia = VMPChiTietPhieuDichVu.Ins.BasectPhieuDichVu[i].DonGia ?? 0;
                    tong += (sl * dongia);
                }
            }
            return string.Format("{0:C0}", tong);
        }
    }
}
