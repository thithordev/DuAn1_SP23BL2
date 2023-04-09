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


            timer1.Start();
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
            if (result) btnCheckin.Enabled = false; else btnCheckin.Enabled = true;
        }

        private void btnCheckoutChange(object? sender, EventArgs e)
        {
            bool result = VMPPhong.Ins.phongsChecked.Any(x => x.intHienTrang != 1);
            if (result) btnCheckout.Enabled = false; else btnCheckout.Enabled = true;
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
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            using (FrmAddorEditPhieuDichVu form = new FrmAddorEditPhieuDichVu(null))
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
                phong.TrangThai = 1;
                VMPPhong.Ins.service.Update(phong);
            }

            btnLoad_Click(sender, e);
        }
    }
}
