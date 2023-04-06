using C_GUI.Views;
using C_GUI.VMProviders;
using System.Collections.ObjectModel;
namespace C_GUI.UserControls
{
    public partial class uc_PhongTrong : UserControl
    {
        int _index = 0;
        bool isChecked = false;

        public uc_PhongTrong(int index)
        {
            _index = index;
            InitializeComponent();

            this.DataBindings.Add("BackColor", VMPPhong.Ins.Phongs[_index], "ucBackColor");
            panel1.DataBindings.Add("BackColor", VMPPhong.Ins.Phongs[_index], "pnlBackColor");
            textBox1.DataBindings.Add("Text", VMPPhong.Ins.Phongs[_index], "TrangThai");
            lbTen.DataBindings.Add("Text", VMPPhong.Ins.Phongs[_index], "Ten");
            lbLoaiPhong.DataBindings.Add("Text", VMPPhong.Ins.Phongs[_index].LoaiPhongViewModel, "Ten");
            lbTang.DataBindings.Add("Text", VMPPhong.Ins.Phongs[_index], "Tang");

            lbTrangThai.DataBindings.Add("Text", VMPPhong.Ins.Phongs[_index], "status");



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
            }
            isChecked = !isChecked;
        }
    }
}
