using B_BUS.ViewModels;
using C_GUI.UserControls;
using C_GUI.VMProviders;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;


namespace C_GUI.Views
{
    public partial class FrmPhong : Form
    {
        private DateTime _realtime = DateTime.Now;
        bool isLoc = false;
        public FrmPhong()
        {
            InitializeComponent();

            var lst = VMPPhong.Ins.service.GetAll() ?? new List<PhongViewModel>();
            VMPPhong.Ins.Phongs = lst.OrderBy(x => x.Tang).ToList();

            var count = VMPPhong.Ins.Phongs.Count;
            for (int i = 0; i < count; i++)
            {
                var uc = new uc_Phong(i);
                VMPPhong.Ins.ucPhongs.Add(uc);
            }

            flowLayoutPanel1.Controls.AddRange(VMPPhong.Ins.ucPhongs.ToArray());

            VMPPhong.Ins.phongsChecked.CollectionChanged += btnOrderChange;
            VMPPhong.Ins.phongsChecked.CollectionChanged += btnDonPhongChange;
            VMPPhong.Ins.phongsChecked.CollectionChanged += btnCheckinChange;
            VMPPhong.Ins.phongsChecked.CollectionChanged += btnCheckoutChange;
            VMPPhong.Ins.phongsChecked.CollectionChanged += indexChange;


            timer1.Start();
        }

        private void indexChange(object? sender, EventArgs e)
        {
            var phongselected = VMPPhong.Ins.Phongs[VMPPhong.Ins.indexChecked];
            lbTen.Text = phongselected.Ten;
            lbTinhTrang1.Text = phongselected.TenLoaiPhong;
            lbTinhTrang2.Text = phongselected.strHienTrang;
            lbTinhTrang3.Text = phongselected.strTrangThai;
            var phieudat = phongselected.phieuDatPhongViewModel;
            if (phieudat != null)
            {
                lbChitietPhieuD.Text = phieudat.status;
            }
            else
            {
                lbChitietPhieuD.Text = string.Empty;
            }
            VMPChiTietPhieuDichVu.Ins.BasectPhieuDichVu = new List<ChiTietPhieuDichVuViewModel>();
            var lstphieuDV = phongselected.phieuDatPhongViewModel?.PhieuDichVusVM;
            if (lstphieuDV != null)
            {
                VMPChiTietPhieuDichVu.Ins.AddlstbasectPhieuDichVu(lstphieuDV);
                BindingSource1.DataSource = VMPChiTietPhieuDichVu.Ins.BasectPhieuDichVu;
            }
            else
            {
                BindingSource1.DataSource = null;
            }
        }

        private void btnOrderChange(object? sender, EventArgs e)
        {
            if (VMPPhong.Ins.phongsChecked.Count == 1)
            {
                if (VMPPhong.Ins.phongsChecked[0].intHienTrang == 1) btnOrder.Enabled = true;
                else btnOrder.Enabled = false;
            }
            else btnOrder.Enabled = false;
        }

        private void btnDonPhongChange(object? sender, EventArgs e)
        {
            if (VMPPhong.Ins.phongsChecked.Count == 1) btnDonPhong.Enabled = true; else btnDonPhong.Enabled = false;
        }

        private void btnCheckinChange(object? sender, EventArgs e)
        {

            bool result = VMPPhong.Ins.phongsChecked.Any(x => x.intHienTrang != 2);
            if (result) btnCheckin.Enabled = false;
            else
            {
                if (VMPPhong.Ins.phongsChecked.Count == 0) btnCheckin.Enabled = false;
                else btnCheckin.Enabled = true;
            }
        }

        private void btnCheckoutChange(object? sender, EventArgs e)
        {

            bool result = VMPPhong.Ins.phongsChecked.Any(x => x.intHienTrang != 1);
            if (result) btnCheckout.Enabled = false;
            else
            {
                if (VMPPhong.Ins.phongsChecked.Count == 0) btnCheckout.Enabled = false;
                else btnCheckout.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _realtime = DateTime.Now;

            int count = VMPPhong.Ins.Phongs.Count;
            for (int i = 0; i < count; i++)
            {
                VMPPhong.Ins.Phongs[i].realTime = _realtime;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            var lst = VMPPhong.Ins.service.GetAll() ?? new List<PhongViewModel>();
            VMPPhong.Ins.Phongs = lst.OrderBy(x => x.Tang).ToList();

            var count = VMPPhong.Ins.Phongs.Count;
            VMPPhong.Ins.ucPhongs.Clear();
            for (int i = 0; i < count; i++)
            {
                var uc = new uc_Phong(i);
                VMPPhong.Ins.ucPhongs.Add(uc);
            }
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(VMPPhong.Ins.ucPhongs.ToArray());

            VMPPhong.Ins.phongsChecked.Clear();
            timer1.Start();
            textBox1.Text = string.Empty;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            using (FrmAddorEditPhieuDichVu form = new FrmAddorEditPhieuDichVu(null, VMPPhong.Ins.phongsChecked[0].phieuDatPhongViewModel))
            {
                form.ShowDialog();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            int count = VMPPhong.Ins.phongsChecked.Count;
            for (int i = 0; i < count; i++)
            {
                var phieu = VMPPhong.Ins.phongsChecked[i].phieuDatPhongViewModel;
                if (phieu == null) continue;
                phieu.NgayTra = DateTime.Now;
                VMPPhieuDatPhong.Ins.service.Update(phieu);
            }

            btnLoad_Click(sender, e);
        }

        private void btnCheckin_Click(object sender, EventArgs e)
        {
            int count = VMPPhong.Ins.phongsChecked.Count;
            for (int i = 0; i < count; i++)
            {
                var phieu = VMPPhong.Ins.phongsChecked[i].phieuDatPhongViewModel;
                if (phieu == null) continue;
                phieu.NgayNhan = DateTime.Now;
                VMPPhieuDatPhong.Ins.service.Update(phieu);
            }

            btnLoad_Click(sender, e);
        }

        private void btnDonPhong_Click(object sender, EventArgs e)
        {
            int count = VMPPhong.Ins.phongsChecked.Count;
            for (int i = 0; i < count; i++)
            {
                var phong = VMPPhong.Ins.phongsChecked[i];
                if (phong.TrangThai == null || phong.TrangThai == 0)
                    phong.TrangThai = 1;
                else phong.TrangThai = 0;
                VMPPhong.Ins.service.Update(phong);
            }

            btnLoad_Click(sender, e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                timer1.Stop();
                var lst = VMPPhong.Ins.service.GetAll() ?? new List<PhongViewModel>();
                lst = lst.Where(x => x.Ten == null ? false : x.Ten.Contains(textBox1.Text)).ToList();
                VMPPhong.Ins.Phongs = lst.OrderBy(x => x.Tang).ToList();

                var count = VMPPhong.Ins.Phongs.Count;
                VMPPhong.Ins.ucPhongs.Clear();
                for (int i = 0; i < count; i++)
                {
                    var uc = new uc_Phong(i);
                    VMPPhong.Ins.ucPhongs.Add(uc);
                }
                flowLayoutPanel1.Controls.Clear();
                flowLayoutPanel1.Controls.AddRange(VMPPhong.Ins.ucPhongs.ToArray());

                VMPPhong.Ins.phongsChecked.Clear();
                timer1.Start();
            }
        }
    }
}
