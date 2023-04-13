using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using System.Text;
using System.Text.RegularExpressions;

namespace C_GUI.Views
{
    public partial class FrmDichVu : Form
    {
        IDichVuService _dichVu;
        string _id,_ten,_gia,_trangThai, _trangThai1;
        public FrmDichVu()
        {
            InitializeComponent();
            _dichVu = new DichVuService();
            loadDGV();
        }
        void loadDGV()
        {
            dgvSanPham.DataSource = _dichVu.GetAll();
            dgvSanPham.Columns["STT"].Width = 100;
            lbTen.Text = "0";
            lbGia.Text = "0";
            lbTrangThai.Text = "0";
            _id = dgvSanPham.Rows[0].Cells["Id"].Value.ToString();
            _ten = dgvSanPham.Rows[0].Cells["Ten"].Value.ToString();
            _gia = dgvSanPham.Rows[0].Cells["Gia"].Value.ToString();
            if (dgvSanPham.Rows[0].Cells["TrangThai"].Value.ToString() == "True")
            {
                _trangThai = "Cung cấp";
            }
            else
            {
                _trangThai = "Ngưng Cung cấp";
            }
            lbTen.Text = _ten;
            lbGia.Text = _gia;
            lbTrangThai.Text = _trangThai;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            loadDGV();
        }

        private void dgvSanPham_CellClick(object? sender, DataGridViewCellEventArgs? e)
        {
            if (e.RowIndex == -1) return;
            _ten = dgvSanPham.Rows[e.RowIndex].Cells["Ten"].Value.ToString();           
            _gia = dgvSanPham.Rows[e.RowIndex].Cells["Gia"].Value.ToString();
            if (dgvSanPham.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString() == "True")
            {
                _trangThai = "Cung cấp";
            }
            else
            {
                _trangThai = "Ngưng Cung cấp";
            }
            lbTen.Text = _ten;
            lbGia.Text = _gia;
            lbTrangThai.Text = _trangThai;
            _id = dgvSanPham.Rows[e.RowIndex].Cells["Id"].Value.ToString();
        }
        public string LoaiDau(string str)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = str.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty)
                        .Replace('đ', 'd').Replace('Đ', 'D').Replace(" ", "");
        }

        private void FrmDichVu_Load(object sender, EventArgs e)
        {

        }

        private void dgvSanPham_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            for (int i = 0; i < _dichVu.GetAll().Count; i++)
            {
                dgvSanPham.Rows[i].Cells["STT"].Value = (i+1).ToString();
                if (dgvSanPham.Rows[i].Cells["TrangThai"].Value.ToString() == "True")
                {
                    dgvSanPham.Rows[i].Cells["Column1"].Value = "Cung cấp";
                }
                else
                {
                    dgvSanPham.Rows[i].Cells["Column1"].Value = "Ngưng Cung cấp";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var ds = from x in _dichVu.GetAll()
                     where LoaiDau(x.Ten).ToLower().Contains(LoaiDau(textBox1.Text).ToLower())
                     select x;
            dgvSanPham.DataSource = ds.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemDV frmThemDV = new FrmThemDV();
            frmThemDV.ShowDialog();
            loadDGV();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            _dichVu.Delete(Guid.Parse(_id));
            MessageBox.Show("Xóa thành công");
            loadDGV();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrmThemDV frmThemDV = new FrmThemDV(_id,_ten,_gia,_trangThai);
            frmThemDV.ShowDialog();
            loadDGV();
            //_id = dgvSanPham.Rows[0].Cells["Id"].Value.ToString();
        }
    }
}
