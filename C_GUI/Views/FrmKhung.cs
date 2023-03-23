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
    public partial class FrmKhung : MetroFramework.Forms.MetroForm
    {
        private Color _blueColorDefaul = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
        private Color _whiteColorFontDefaul = Color.White;
        private Button _buttonSlideBarOldClicked;
        public FrmKhung()
        {
            InitializeComponent();
            _buttonSlideBarOldClicked = new Button();

            // Thêm sự kiện click Tab btnTrangChu
            this.btnTrangChu.Click += new System.EventHandler(this.btnTrangChu_Click);

            // Khi load form, button Trang Chủ sẽ được nhấn
            object button1obj = btnTrangChu as object;
            button1_Click(button1obj, EventArgs.Empty);
            btnTrangChu_Click(button1obj, EventArgs.Empty);

            // Đồng hồ thời gian thực khởi chạy
            timer1.Start();

            // is notworking
            //this.BackColor= _blueColorDefaul;
        }

        private void btnTrangChu_Click(object? sender, EventArgs e)
        {
            pnlNoiDungTab.Controls.Clear();
            FrmTrangChu frmTrangChu = new FrmTrangChu();
            frmTrangChu.TopLevel = false;
            pnlNoiDungTab.Controls.Add(frmTrangChu);
            frmTrangChu.BringToFront();
            frmTrangChu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _buttonSlideBarOldClicked.BackColor = _blueColorDefaul;
            _buttonSlideBarOldClicked.ForeColor = _whiteColorFontDefaul;
            var button = sender as Button;
            _buttonSlideBarOldClicked = button;
            button.BackColor = _whiteColorFontDefaul;
            button.ForeColor = Form.DefaultForeColor;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.label8.Text = String.Format("{0:dddd, MM/d/yyyy}", now);
            this.label7.Text = String.Format("{0:hh:mm:ss tt}", now);
        }
    }
}
