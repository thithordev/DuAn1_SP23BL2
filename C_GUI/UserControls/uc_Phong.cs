using C_GUI.Views;
using C_GUI.VMProviders;
using System.Collections.ObjectModel;
namespace C_GUI.UserControls
{
    public partial class uc_Phong : UserControl
    {
        int _index = 0;
        bool isChecked = false;

        public uc_Phong(int index)
        {
            _index = index;
            InitializeComponent();

            this.DataBindings.Add("BackColor", VMPPhong.Ins.Phongs[_index], "ucBackColor");
            panel1.DataBindings.Add("BackColor", VMPPhong.Ins.Phongs[_index], "pnlBackColor");
            lbTen.DataBindings.Add("Text", VMPPhong.Ins.Phongs[_index], "Ten");
            lbLoaiPhong.DataBindings.Add("Text", VMPPhong.Ins.Phongs[_index], "TenLoaiPhong");
            lbTang.DataBindings.Add("Text", VMPPhong.Ins.Phongs[_index], "Tang");
            lbHienTrang.DataBindings.Add("Text", VMPPhong.Ins.Phongs[_index], "strHienTrang");
            lbTrangThai.DataBindings.Add("Text", VMPPhong.Ins.Phongs[_index], "strTrangThai");
            lbStatus.DataBindings.Add("Text", VMPPhong.Ins.Phongs[_index], "status");



        }

        private void btnChecked_Click(object sender, EventArgs e)
        {
            if(isChecked)
            {
                btnChecked.BackgroundImage = null;

                VMPPhong.Ins.phongsChecked.Remove(VMPPhong.Ins.Phongs[_index]);
            }
            else
            {
                btnChecked.BackgroundImage = Properties.Resources.check__1_;

                VMPPhong.Ins.phongsChecked.Add(VMPPhong.Ins.Phongs[_index]);

                VMPPhong.Ins.indexChecked = _index;
            }
            isChecked = !isChecked;
        }
    }
}
