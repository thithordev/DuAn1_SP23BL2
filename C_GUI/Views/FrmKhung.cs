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
        private Button  _buttonSlideBarOldClicked;
        public FrmKhung()
        {
            InitializeComponent();
            _buttonSlideBarOldClicked = new Button();

            // Khi load form, button Trang Chủ sẽ được nhấn
            object button1obj = button1 as object;
            button1_Click(button1obj, EventArgs.Empty);

            // is notworking
            //this.BackColor= _blueColorDefaul;
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
    }
}
