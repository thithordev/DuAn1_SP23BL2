using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;
using System.Text;
using System.Text.RegularExpressions;

namespace C_GUI.Views
{
    public partial class FrmPhieuDichVu : Form
    {
        IChiTietPhieuDichVuService _chiTietPhieuDichVuService;
        IDichVuService _ichVuService;
        public FrmPhieuDichVu()
        {
            InitializeComponent();
            _chiTietPhieuDichVuService = new ChiTietPhieuDichVuService();
            _ichVuService = new DichVuService();
            loaddgv(_ichVuService.GetAll());
            loaddgvdc();
        }
        public void loaddgv(dynamic dt )
        {
            int index = 1;
            DataGridViewButtonColumn btnThem = new DataGridViewButtonColumn();
            btnThem.UseColumnTextForButtonValue = true;
            btnThem.Text = "Thêm";
            btnThem.CellTemplate.Style.BackColor = Color.Green;
            dgvDV.ColumnCount = 4;
            dgvDV.Columns[0].Name = "STT";
            dgvDV.Columns[0].Width = 50;
            dgvDV.Columns[1].Name = "Tên";
            dgvDV.Columns[1].Width = 200;
            //dgvDV.Columns[2].Name = "Số lượng";
            dgvDV.Columns[2].Name = "Đơn giá";
            dgvDV.Columns[3].Name = "ID";
            dgvDV.Columns[3].Visible = false;
            dgvDV.Rows.Clear();
            dgvDV.Columns.Insert(4, btnThem);
            dgvDV.Columns[4].Width = 100;
            foreach (var x in dt)
            {
                dgvDV.Rows.Add(index++, x.Ten, x.Gia,x.IdDichVu);
                //dgvDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;   
            }
        }
        public void loaddgvdc()
        {
            int index = 1;
            DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
            btnXoa.UseColumnTextForButtonValue = true;
            btnXoa.Text = "Xóa";
            btnXoa.CellTemplate.Style.BackColor = Color.Red;
            dgvDVChon.ColumnCount = 5;
            dgvDVChon.Columns[0].Name = "STT";
            dgvDVChon.Columns[0].Width = 50;
            dgvDVChon.Columns[1].Name = "Tên";
            dgvDVChon.Columns[1].Width = 150;
            //dgvDV.Columns[2].Name = "Số lượng";
            dgvDVChon.Columns[2].Name = "số lượng";
            dgvDVChon.Columns[2].Width = 50;
            dgvDVChon.Columns[3].Name = "đơn giá";
            dgvDVChon.Columns[3].Width = 100;
            dgvDVChon.Columns[4].Name = "ID";
            dgvDVChon.Columns[4].Visible = false;
            dgvDVChon.Rows.Clear();
            dgvDVChon.Columns.Insert(5, btnXoa);
            //dgv.Columns[3].Width = 80;
        }

        public string LoaiDau(string str)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = str.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty)
                        .Replace('đ', 'd').Replace('Đ', 'D').Replace(" ", "");
        }

        private void dgvDVChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==5)
            {
                dgvDVChon.Rows.RemoveAt(e.RowIndex);
            }
        }
        private void dgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Guid.Parse(dgvDV.Rows[e.RowIndex].Cells[3].Value.ToString());
            int index = 1;
            if (e.ColumnIndex == 4)
            {

                var ds = from x in _ichVuService.GetAll()
                         where x.IdDichVu == id
                         select x;
                    foreach (var x in ds.ToList())
                    {
                        dgvDVChon.Rows.Add(dgvDVChon.RowCount, x.Ten, index, x.Gia, x.IdDichVu);
                    } 
            };
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var idPhieudv = Guid.NewGuid();
            ChiTietPhieuDichVuViewModel chiTietPhieuDichVu = new ChiTietPhieuDichVuViewModel()
            {
                phieuDichVu = new PhieuDichVu()
                {
                    IdPhieuDichVu = idPhieudv,
                    NgayTao = DateTime.Today,
                }
            };
            MessageBox.Show(_chiTietPhieuDichVuService.Add(chiTietPhieuDichVu));
            for (int i = 0; i < dgvDVChon.RowCount; i++)
            {
                var ten = dgvDVChon.Rows[i].Cells[1].Value.ToString();
                var soLuong =int.Parse(dgvDVChon.Rows[i].Cells[2].Value.ToString());
                var doiGia = decimal.Parse(dgvDVChon.Rows[i].Cells[3].Value.ToString())* soLuong;
                var id = Guid.Parse(dgvDVChon.Rows[i].Cells[4].Value.ToString());
                chiTietPhieuDichVu.ChiTietPhieuDichVu = new ChiTietPhieuDichVu()
                {
                    IDChiTietPhieuDichVu = Guid.NewGuid(),
                    DichVuID = id,
                    PhieuDichVuID = idPhieudv,
                    SoLuong = soLuong,
                    DonGia = doiGia,
                };
                _chiTietPhieuDichVuService.Add1(chiTietPhieuDichVu);
            }

        }

        private void txtTimKiem_Enter_1(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            var ds = from x in _ichVuService.GetAll()
                     where LoaiDau(x.Ten).ToLower().Contains(LoaiDau(txtTimKiem.Text).ToLower())
                     select x;
            loaddgv(ds.ToList());
        }
    }
}
