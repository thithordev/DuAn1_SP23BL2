using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_GUI.Views
{
    public partial class FrmThemDV : MetroFramework.Forms.MetroForm
    {
        IDichVuService _dichVu;
        string Id, Ten, Gia, TrangThai;
        public FrmThemDV(string id = null, string ten = null, string gia = null, string trangThai = null)
        {
            InitializeComponent();
            _dichVu = new DichVuService();
            Id = id;
            Ten = ten;
            Gia = gia;
            TrangThai = trangThai;
            load();
        }
        void load()
        {
            if (Id== null)
            {
                btnSua.Visible = false;
                comboBox1.Text = "Cung Cấp";
            }
            else
            {
                txtTen.Text = Ten;
                txtGia.Text = Gia;
                comboBox1.Text = TrangThai;
                btnThem.Visible = false;
            }

        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtGia.Text, @"^[0-9]{1,}$") == true && Regex.IsMatch(txtTen.Text, @"\S+") == true)
            {
                _dichVu.Update(DuLieu1());
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("chưa hợp lệ");
            }
        }

        bool abc;

        private void txtTen_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtTen.Text, @"\S+") == true)
            {

            }
            else
            {
                txtTen.Text = "";
            }
        }

        private void txtGia_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtGia.Text, @"^[0-9]{1,}$") == true)
            {

            }
            else
            {
                txtGia.Text = "";
            }
        }

        DichVuViewModel DuLieu()
        {
            if (comboBox1.Text == "Ngưng Cung Cấp")
            {
                abc = false;
            }
            else
            {
                abc = true;
            }
            DichVuViewModel dichVuViewModel = new DichVuViewModel()
            {
                Id = Guid.NewGuid(),
                Ten = txtTen.Text,
                Gia = decimal.Parse(txtGia.Text),
                TrangThai = abc,
            };
            return dichVuViewModel;
        }
        DichVuViewModel DuLieu1()
        {
            if (comboBox1.Text == "Ngưng Cung Cấp")
            {
                abc = false;
            }
            else
            {
                abc = true;
            }
            DichVuViewModel dichVuViewModel = new DichVuViewModel()
            {
                Id = Guid.Parse(Id),
                Ten = txtTen.Text,
                Gia = decimal.Parse(txtGia.Text),
                TrangThai = abc,
            };
            return dichVuViewModel;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtGia.Text, @"^[0-9]{1,}$") == true && Regex.IsMatch(txtTen.Text, @"\S+") == true)
            {
                _dichVu.Add(DuLieu());
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("chưa hợp lệ");
            }
        }
    }
}
