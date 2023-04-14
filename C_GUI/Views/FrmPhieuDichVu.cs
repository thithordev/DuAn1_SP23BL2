using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using C_GUI.VMProviders;
using System.Text;
using System.Text.RegularExpressions;

namespace C_GUI.Views
{
    public partial class FrmPhieuDichVu : Form
    {
        IPhieuDichVuService _phieuDichVu;
        INhanVienService _nhanVien;
        IChiTietPhieuDichVuService _chiTietPhieuDichVu;
        IDichVuService _dichVu;
        string _id,_idNV, _phieuDatPhongId, _ngayTao, _trangThai,_hoTenNV;

        private void btnXoa_Click(object sender, EventArgs e)
        {
            _phieuDichVu.Delete(Guid.Parse(_id));
            MessageBox.Show("xóa thành công");
            load();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var ds = from x in _phieuDichVu.GetAll()
                     join y in _nhanVien.GetAll() on x.NhanVienId equals y.Id
                     where LoaiDau(y.Ten).ToLower().Contains(LoaiDau(textBox1.Text).ToLower())
                     select new
                     {
                         Id = x.Id,
                         nhanVien = $"{y.TenDem} {y.Ten}",
                         IdNV = y.Id,
                         NgayTao = x.NgayTao,
                         TrangThai = x.TrangThai,
                     };
            dgvPhieuDV.DataSource = ds.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (FrmAddorEditPhieuDichVu form = new FrmAddorEditPhieuDichVu(null,
                null))
            {
                if (!VMPPhieuDatPhong.Ins.PhieuDatPhongsDangThue.Any())
                {
                    RJMessageBox.Show("Không có phòng nào hiện được thuê để thêm phiếu dịch vụ !.");
                    return;
                }
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RJMessageBox.Show("Phiếu dịch vụ đã được thêm !.");
                }
                else
                {
                    RJMessageBox.Show("Phiếu dịch vụ đã không được thêm !.");
                }
            }
            //RJMessageBox.Show("Phiếu dịch vụ đã được thêm !.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var pDV = _phieuDichVu.GetByID(Guid.Parse(_id));
            using (FrmAddorEditPhieuDichVu form = new FrmAddorEditPhieuDichVu(pDV,
                null))
            {
                //if (!VMPPhieuDatPhong.Ins.PhieuDatPhongsDangThue.Any())
                //{
                //    RJMessageBox.Show("Không có phòng nào hiện được thuê để thêm phiếu dịch vụ !.");
                //    return;
                //}
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RJMessageBox.Show("Phiếu dịch vụ đã được thêm !.");
                }
                else
                {
                    RJMessageBox.Show("Phiếu dịch vụ đã không được thêm !.");
                }
            }
            load();
        }

        public FrmPhieuDichVu()
        {
            InitializeComponent();
            _phieuDichVu = new PhieuDichVuService();
            _nhanVien = new NhanVienService();
            _chiTietPhieuDichVu = new ChiTietPhieuDichVuService();
            load();
            _dichVu = new DichVuService();
        }
        void load()
        {
            var ds = from x in _phieuDichVu.GetAll()
                     join y in _nhanVien.GetAll() on x.NhanVienId equals y.Id
                     select new
                     {
                         Id = x.Id,
                         nhanVien = $"{y.TenDem} {y.Ten}",
                         IdNV = y.Id,
                         NgayTao = x.NgayTao,
                        TrangThai = x.TrangThai,
                     };
            dgvPhieuDV.DataSource = ds.ToList();
            lbHoTenNV.Text = "0";
            lbNgayTao.Text = "0";
            lbTrangThai.Text = "0";

        }

        private void dgvPhieuDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex < 0) return;
            _id = dgvPhieuDV.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            _idNV = dgvPhieuDV.Rows[e.RowIndex].Cells["IdNV"].Value.ToString();
            _phieuDatPhongId = null;
            _ngayTao = dgvPhieuDV.Rows[e.RowIndex].Cells["NgayTao"].Value.ToString();
            _hoTenNV = dgvPhieuDV.Rows[e.RowIndex].Cells["TenNV"].Value.ToString();
            _trangThai = dgvPhieuDV.Rows[e.RowIndex].Cells["TrangThai"].Value.ToString();
            lbHoTenNV.Text = _hoTenNV;
            lbNgayTao.Text = _ngayTao;
            lbTrangThai.Text = _trangThai;
            var dsctdv = _chiTietPhieuDichVu.GetAll().Where(p => p.PhieuDichVuID == Guid.Parse(_id));

            var ds = from x in dsctdv.ToList()
                     join y in _dichVu.GetAll() on x.DichVuID equals y.Id
                     select new
                     {
                         TenDV = y.Ten,
                         SoLuong = x.SoLuong,
                         Gia = x.DonGia,       
                     };
            dgvDSDV.DataSource = ds.ToList();
            dgvDSDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public string LoaiDau(string str)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = str.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty)
                        .Replace('đ', 'd').Replace('Đ', 'D').Replace(" ", "");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
