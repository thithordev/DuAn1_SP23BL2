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
        public FrmPhieuDichVu()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
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
=======

        private void dgvDVChon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
>>>>>>> c300b5782afe591b751f97fb7b941f70e4f4f34e

        }
        private void dgvDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
<<<<<<< HEAD
            var id = Guid.Parse(dgvDV.Rows[e.RowIndex].Cells[3].Value.ToString());
            int index = 1;
            if (e.ColumnIndex == 4)
            {

                var ds = from x in _ichVuService.GetAll()
                         where x.IdDichVu == id
                         select x;
                if (dgvDVChon.RowCount ==0)
                {
                    foreach (var x in ds.ToList())
                    {
                        dgvDVChon.Rows.Add(dgvDVChon.RowCount, x.Ten, index, x.Gia, x.IdDichVu);
                    }
                }
                else
                {
                    for (int i = 0; i < dgvDVChon.RowCount; i++)
                    {
                        if (ds.FirstOrDefault().IdDichVu == Guid.Parse(dgvDVChon.Rows[i].Cells[4].Value.ToString()))
                        {
                            dgvDVChon.Rows[i].Cells[2].Value = int.Parse(dgvDVChon.Rows[i].Cells[2].Value.ToString()) + 1;
                            return;
                        }
                    }
                    foreach (var x in ds.ToList())
                    {
                        dgvDVChon.Rows.Add(dgvDVChon.RowCount, x.Ten, index, x.Gia, x.IdDichVu);
                    }
                }

            };
=======

>>>>>>> c300b5782afe591b751f97fb7b941f70e4f4f34e
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
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
