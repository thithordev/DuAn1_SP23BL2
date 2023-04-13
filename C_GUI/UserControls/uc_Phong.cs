using C_GUI.Views;
using C_GUI.VMProviders;
using System.Collections.ObjectModel;
namespace C_GUI.UserControls
{
    public partial class uc_Phong : UserControl
    {
        int _index = 0;
        public bool isChecked = false;

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


            //VMPPhong.Ins.phongsChecked.CollectionChanged += indexChange;
        }

        private void indexChange(object? sender, EventArgs? e)
        {
            btnChecked_Click(null, null);
        }

        public void btnChecked_Click(object? sender, EventArgs? e)
        {
            //int count = VMPPhong.Ins.ucPhongs.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    if (VMPPhong.Ins.ucPhongs[i].isChecked == true)
            //    {
            //        VMPPhong.Ins.ucPhongs[i].btnChecked_Click(null, null);
            //    }
            //}

            if (VMPPhong.Ins.indexChecked == _index) return;

            if(isChecked)
            {
                btnChecked.BackgroundImage = null;

                isChecked = !isChecked;

                //VMPPhong.Ins.indexChecked = _index;

                VMPPhong.Ins.phongsChecked.Remove(VMPPhong.Ins.Phongs[_index]);
            }
            else
            {
                btnChecked.BackgroundImage = Properties.Resources.check__1_;

                isChecked = !isChecked;

                VMPPhong.Ins.indexChecked = _index;

                VMPPhong.Ins.phongsChecked.Add(VMPPhong.Ins.Phongs[_index]);

            }
            
        }

    }
}
