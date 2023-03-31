using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;

namespace C_GUI.Views
{
    public partial class FrmDichVu : Form
    {
        DichVu doiTuong;
        IDichVuService _dichVu;
        public FrmDichVu()
        {
            InitializeComponent();
            _dichVu = new DichVuService();
            doiTuong = new DichVu();
            loadDV();
        }
        void loadDV()
        {
            DataGridViewButtonColumn btnSua = new DataGridViewButtonColumn();
            btnSua.UseColumnTextForButtonValue = true;
            btnSua.Text = "Sửa";
            btnSua.CellTemplate.Style.BackColor = Color.Green;
            DataGridViewButtonColumn btnXoa = new DataGridViewButtonColumn();
            btnXoa.UseColumnTextForButtonValue = true;
            btnXoa.Text = "Xóa";
            btnXoa.CellTemplate.Style.BackColor = Color.Red;
            int index = 1;
            dgvDichVu.ColumnCount = 4;
            dgvDichVu.Columns[0].Name = "STT";
            dgvDichVu.Columns[1].Name = "Tên san phẩm";
            dgvDichVu.Columns[1].Width = 220;
            dgvDichVu.Columns[2].Name = "Gía";
            dgvDichVu.Columns[2].Width = 200;
            dgvDichVu.Columns[3].Name = "ID";
            dgvDichVu.Columns[3].Visible = false;
            dgvDichVu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDichVu.Rows.Clear();
            dgvDichVu.Columns.Insert(4, btnSua);
            dgvDichVu.Columns.Insert(5, btnXoa);
            foreach (var x in  _dichVu.GetAll())
            {
                dgvDichVu.Rows.Add(index++, x.Ten, x.Gia,x.IdDichVu);
            }
        }
        //string iddv, ten, gia;

        private void dgvDichVu_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvDichVu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                var iddv = dgvDichVu.Rows[e.RowIndex].Cells[3].Value.ToString();
                var ten = dgvDichVu.Rows[e.RowIndex].Cells[1].Value.ToString();
                var gia = dgvDichVu.Rows[e.RowIndex].Cells[2].Value.ToString();
                var dt = _dichVu.GetByID(Guid.Parse(iddv));
                dt.Ten = ten;
                dt.Gia = decimal.Parse(gia);
                MessageBox.Show(_dichVu.Update(dt));
                txtTimKiem.Text = dt.Ten.ToString();
            }
        }


    }
}
