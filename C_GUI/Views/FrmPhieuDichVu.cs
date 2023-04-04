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
        IDichVuService _ichVuService;
        public FrmPhieuDichVu()
        {
            InitializeComponent();
            _ichVuService = new DichVuService();
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
            if (e.ColumnIndex == 5)
            {
                dgvDVChon.Rows.RemoveAt(e.RowIndex);
                for (int i = e.RowIndex; i < dgvDVChon.RowCount; i++)
                {
                    dgvDVChon.Rows[i].Cells[0].Value = i;
                }

            }
        }

        private void dgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Guid.Parse(dgvDV.Rows[e.RowIndex].Cells[3].Value.ToString());
            int index = 1;
            if (e.ColumnIndex == 4)
            {

                var ds = from x in _ichVuService.GetAll()
                         where x.Id == id
                         select x;
                if (dgvDVChon.RowCount == 0)
                {
                    foreach (var x in ds.ToList())
                    {
                        dgvDVChon.Rows.Add(dgvDVChon.RowCount, x.Ten, index, x.Gia, x.Id);
                    }
                }
                else
                {
                    for (int i = 0; i < dgvDVChon.RowCount; i++)
                    {
                        if (ds.FirstOrDefault().Id == Guid.Parse(dgvDVChon.Rows[i].Cells[4].Value.ToString()))
                        {
                            dgvDVChon.Rows[i].Cells[2].Value = int.Parse(dgvDVChon.Rows[i].Cells[2].Value.ToString()) + 1;
                            return;
                        }
                    }
                    foreach (var x in ds.ToList())
                    {
                        dgvDVChon.Rows.Add(dgvDVChon.RowCount, x.Ten, index, x.Gia, x.Id);
                    }
                }

            }

        }

        private void btnthoat_click(object sender, EventArgs e)
        {

        }

        private void btnluu_click(object sender, EventArgs e)
        {

        }

        private void txttimkiem_enter_1(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void txttimkiem_textchanged(object sender, EventArgs e)
        {
            var ds = from x in _ichVuService.GetAll()
                     where LoaiDau(x.Ten).ToLower().Contains(LoaiDau(txtTimKiem.Text).ToLower())
                     select x;
        }
    }
}

