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
        private DateTime _fromTime = DateTime.Now;
        private DateTime _toTime = DateTime.MaxValue;
        bool isLoc = false;
        public FrmPhong()
        {
            InitializeComponent();

            var lst = VMPPhong.Ins.service.CheckPhongRealTime() ?? new List<PhongViewModel>();
            VMPPhong.Ins.Phongs = lst.OrderBy(x => x.Tang).ToList();

            timer1.Start();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var count = VMPPhong.Ins.Phongs.Count;
            if (count == 0) return;
            for (int i = 0; i < count; i++)
            {
                var uc = new uc_PhongTrong(i);
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rd = random.Next(-1, 3);
            int indexrd = random.Next(0, 4);
            VMPPhong.Ins.Phongs[indexrd].TrangThai = rd;

            isLoc = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _fromTime = DateTime.Now;
            _toTime = DateTime.MaxValue;

            int count = VMPPhong.Ins.Phongs.Count;
            for (int i = 0; i < count; i++)
            {
                VMPPhong.Ins.Phongs[i].fromTime= _fromTime;
                VMPPhong.Ins.Phongs[i].toTime= _toTime;
            }
        }
    }
}
