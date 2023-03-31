using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;

namespace C_GUI.Views
{
    public partial class FrmLoaiPhong : Form
    {
        ILoaiPhongService _loaiPhongService;
        public FrmLoaiPhong()
        {
            InitializeComponent();
            _loaiPhongService = new LoaiPhongService();
            Load(_loaiPhongService.GetAll());
        }
        void Load(List<LoaiPhongViewModel> list)
        {
            DataGridViewButtonColumn btnSua = new DataGridViewButtonColumn();
            btnSua.UseColumnTextForButtonValue = true;
            btnSua.Text = "Sửa";
            btnSua.CellTemplate.Style.BackColor = Color.Green;
            btnSua.Name = "Sửa";
            DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
            btnXoa.UseColumnTextForButtonValue = true;
            btnXoa.Text = "Xóa";
            btnXoa.Name = "Xóa";
            btnXoa.CellTemplate.Style.BackColor = Color.Red;
            int i = 1;
            dgvLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiPhong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLoaiPhong.AllowUserToAddRows = false;
            dgvLoaiPhong.ColumnCount = 7;
            dgvLoaiPhong.Columns[0].Name = "STT";
            dgvLoaiPhong.Columns[1].Name = "Tên";
            dgvLoaiPhong.Columns[2].Name = "Mô tả";
            dgvLoaiPhong.Columns[3].Name = "Số giường";
            dgvLoaiPhong.Columns[4].Name = "Giá ngày";
            dgvLoaiPhong.Columns[5].Name = "Giá giờ";
            dgvLoaiPhong.Columns[6].Name = "ID";
            dgvLoaiPhong.Columns[6].Visible = false;
            dgvLoaiPhong.Columns.Insert(7, btnSua);
            dgvLoaiPhong.Columns.Insert(8, btnXoa);
            dgvLoaiPhong.Rows.Clear();
            foreach (var x in list)
            {
                dgvLoaiPhong.Rows.Add(i++, x.Ten, x.Mota, x.SoGiuong, x.GiaNgay, x.GiaGio,x.IdLoaiPhong);
            }
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var idLP = dgvLoaiPhong.Rows[e.RowIndex].Cells[6].Value.ToString();
            var ten = dgvLoaiPhong.Rows[e.RowIndex].Cells[1].Value.ToString();
            var mota = dgvLoaiPhong.Rows[e.RowIndex].Cells[2].Value.ToString();
            var sogiuong = dgvLoaiPhong.Rows[e.RowIndex].Cells[3].Value.ToString();
            var giangay = dgvLoaiPhong.Rows[e.RowIndex].Cells[4].Value.ToString();
            var giagio = dgvLoaiPhong.Rows[e.RowIndex].Cells[5].Value.ToString();
            var bang = _loaiPhongService.GetByID(Guid.Parse(idLP));
            switch (e.ColumnIndex)
            {
                case 7:
                    bang.Ten = ten;
                    bang.Mota = mota;
                    bang.SoGiuong = int.Parse(sogiuong);
                    bang.GiaNgay = decimal.Parse(giangay);
                    bang.GiaGio = decimal.Parse(giagio);
                    MessageBox.Show(_loaiPhongService.Update(bang));
                    break;
                case 8:
                    MessageBox.Show(_loaiPhongService.Delete(bang));
                    break;
                default:
                    break;
            }
        }
    }
}
