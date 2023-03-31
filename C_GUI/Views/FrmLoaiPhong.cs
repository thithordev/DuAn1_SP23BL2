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
                dgvLoaiPhong.Rows.Add(i++, x.Ten, x.Mota, x.SoGiuong, x.GiaNgay, x.GiaGio);
            }
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var IdLP = dgvLoaiPhong.Rows[e.RowIndex].Cells[6].Value.ToString();
            var temp = _loaiPhongService.GetByID(Guid.Parse(IdLP));
        }
    }
}
