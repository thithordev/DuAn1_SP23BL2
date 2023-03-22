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
    public partial class FrmTrangChu : Form
    {
        private Color _blueColorDefaul = Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
        private Color _whiteColorFontDefaul = Color.AntiqueWhite;
        private Button  _buttonSlideBarOldClicked;
        public FrmTrangChu()
        {
            InitializeComponent();
            _buttonSlideBarOldClicked = new Button();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _buttonSlideBarOldClicked.BackColor = _blueColorDefaul;
            _buttonSlideBarOldClicked.ForeColor = _whiteColorFontDefaul;
            var button = sender as Button;
            _buttonSlideBarOldClicked = button;
            button.BackColor = Form.DefaultBackColor;
            button.ForeColor = Form.DefaultForeColor;

        }
    }
}
