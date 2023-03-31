using A_DAL.Models;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.ViewModels;

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
            dgvDVChon.ColumnCount = 4;
            dgvDVChon.Columns[0].Name = "STT";
            dgvDVChon.Columns[0].Width = 50;
            dgvDVChon.Columns[1].Name = "Tên";
            dgvDVChon.Columns[1].Width = 150;
            //dgvDV.Columns[2].Name = "Số lượng";
            dgvDVChon.Columns[2].Name = "số lượng";
            dgvDVChon.Columns[2].Width = 50;
            dgvDVChon.Columns[3].Name = "đơn giá";
            dgvDVChon.Columns[3].Width = 100;
            dgvDVChon.Rows.Clear();
            dgvDVChon.Columns.Insert(4, btnXoa);
            //dgv.Columns[3].Width = 80;
        }

        private void dgvDVChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public class Dulieu
        {
            private Guid id;
            private string name;
            private int soLuong;
            private decimal donGia;

            public Guid Id { get => id; set => id = value; }
            public string Name { get => name; set => name = value; }
            public int SoLuong { get => soLuong; set => soLuong = value; }
            public decimal DonGia { get => donGia; set => donGia = value; }

            public Dulieu()
            {

            }

            public Dulieu(Guid id, string name, int soLuong, decimal donGia)
            {
                this.id = id;
                this.name = name;
                this.soLuong = soLuong;
                this.donGia = donGia;
            }
        }
        private void dgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Guid.Parse(dgvDV.Rows[e.RowIndex].Cells[3].Value.ToString());
            if (e.ColumnIndex == 4)
            {
                List<Dulieu> dulieus = new List<Dulieu>();
                dulieus.Add(new Dulieu(id, dgvDV.Rows[e.RowIndex].Cells[1].Value.ToString(),1, decimal.Parse(dgvDV.Rows[e.RowIndex].Cells[2].Value.ToString())));
                foreach (var x in dulieus)
                {
                    dgvDVChon.Rows.Add(dgvDVChon.RowCount, x.Name, x.SoLuong, x.DonGia);
                }
            };
        }
    }
}
