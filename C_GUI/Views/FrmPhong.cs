<<<<<<< HEAD
﻿using A_DAL.Models;
using C_GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
=======
﻿using C_GUI.UserControls;
>>>>>>> 945e166614b55b3314202b8e3bdd791ee0b34c98

namespace C_GUI.Views
{
    public partial class FrmPhong : Form
    {
        public FrmPhong()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int rd = random.Next(0, 4);
            var uc_1 = new uc_PhongTrong();
            var uc_2 = new uc_PhongDat();
            var uc_3 = new uc_PhongDangThue();
            var uc_4 = new uc_PhongDisable();
            List<UserControl> ucs = new List<UserControl> { uc_1, uc_2, uc_3, uc_4 };
            flowLayoutPanel1.Controls.Add(ucs[rd]);
        }

    

        
    }
}
