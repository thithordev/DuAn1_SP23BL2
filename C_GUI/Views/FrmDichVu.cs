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
        public FrmDichVu()
        {
            InitializeComponent();
            _dichVu = new DichVuService();
            loadDV(_dichVu.GetAll());
        }
        void loadDV(List<DichVuViewModel> ds)
        {
            //txtTimKiem.Text = "Tìm kiếm theo tên";
            //txtTimKiem.Font = 
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
            dgvDichVu.Columns[1].Name = "Tên sản phẩm";
            dgvDichVu.Columns[1].Width = 220;
            dgvDichVu.Columns[2].Name = "Giá";
            dgvDichVu.Columns[2].Width = 200;
            dgvDichVu.Columns[3].Name = "ID";
            dgvDichVu.Columns[3].Visible = false;
            dgvDichVu.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDichVu.Rows.Clear();
            dgvDichVu.Columns.Insert(4, btnSua);
            dgvDichVu.Columns.Insert(5, btnXoa);
            foreach (var x in  ds)
            {
                dgvDichVu.Rows.Add(index++, x.Ten, x.Gia,x.IdDichVu);
            }
            //dgvDichVu.Rows[_dichVu.GetAll().Count()].Visible = false;
        }
        //string iddv, ten, gia;
        private void dgvDichVu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var iddv = dgvDichVu.Rows[e.RowIndex].Cells[3].Value.ToString();
            var ten = dgvDichVu.Rows[e.RowIndex].Cells[1].Value.ToString();
            var gia = dgvDichVu.Rows[e.RowIndex].Cells[2].Value.ToString();
            var dt = _dichVu.GetByID(Guid.Parse(iddv));
            switch (e.ColumnIndex)
            {
                case 4:

                    dt.Ten = ten;
                    dt.Gia = decimal.Parse(gia);
                    MessageBox.Show(_dichVu.Update(dt));
                    break;
               case 5:
                    //dgvDichVu.Rows[e.RowIndex].Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }

        public string LoaiDau(string str)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = str.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty)
                        .Replace('đ', 'd').Replace('Đ', 'D').Replace(" ","");
        }


        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
                var ds = from x in _dichVu.GetAll()
                         where LoaiDau(x.Ten).ToLower().Contains(LoaiDau(txtTimKiem.Text).ToLower())
                         select x;
                loadDV(ds.ToList()); 
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            FrmThemDV frm = new FrmThemDV();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadDV(_dichVu.GetAll());
        }
    }
}
