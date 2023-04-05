using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuDichVu_DichVu_DichVuID",
                table: "ChiTietPhieuDichVu");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuDichVu_PhieuDichVu_PhieuDichVuID",
                table: "ChiTietPhieuDichVu");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuDichVu_HoaDon_HoaDonIdHoaDon",
                table: "PhieuDichVu");

            migrationBuilder.RenameColumn(
                name: "IdYeuCau",
                table: "YeuCau",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IDThongKeDoanhThu",
                table: "ThongKeDoanhThu",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdPhong",
                table: "Phong",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "HoaDonIdHoaDon",
                table: "PhieuDichVu",
                newName: "HoaDonId");

            migrationBuilder.RenameColumn(
                name: "IdPhieuDichVu",
                table: "PhieuDichVu",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_PhieuDichVu_HoaDonIdHoaDon",
                table: "PhieuDichVu",
                newName: "IX_PhieuDichVu_HoaDonId");

            migrationBuilder.RenameColumn(
                name: "IdPhieuDatPhong",
                table: "PhieuDatPhong",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdNhanVien",
                table: "NhanVien",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IDLoaiDoanhThu",
                table: "LoaiDoanhThu",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdKhachHang",
                table: "KhachHang",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdHoaDon",
                table: "HoaDon",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IdDichVu",
                table: "DichVu",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IDChucVu",
                table: "ChucVu",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IDChiTietPhieuDichVu",
                table: "ChiTietPhieuDichVu",
                newName: "Id");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "YeuCau",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ThongKeDoanhThu",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Phong",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PhieuDichVu",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PhieuDatPhong",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "NhanVien",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "LoaiDoanhThu",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "KhachHang",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "HoaDon",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "DichVu",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TrangThai",
                table: "DichVu",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ChucVu",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ChiTietPhieuDichVu",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuDichVu_DichVu_PhieuDichVuID",
                table: "ChiTietPhieuDichVu",
                column: "PhieuDichVuID",
                principalTable: "DichVu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuDichVu_PhieuDichVu_DichVuID",
                table: "ChiTietPhieuDichVu",
                column: "DichVuID",
                principalTable: "PhieuDichVu",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuDichVu_HoaDon_HoaDonId",
                table: "PhieuDichVu",
                column: "HoaDonId",
                principalTable: "HoaDon",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuDichVu_DichVu_PhieuDichVuID",
                table: "ChiTietPhieuDichVu");

            migrationBuilder.DropForeignKey(
                name: "FK_ChiTietPhieuDichVu_PhieuDichVu_DichVuID",
                table: "ChiTietPhieuDichVu");

            migrationBuilder.DropForeignKey(
                name: "FK_PhieuDichVu_HoaDon_HoaDonId",
                table: "PhieuDichVu");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "YeuCau");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ThongKeDoanhThu");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Phong");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PhieuDichVu");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PhieuDatPhong");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "NhanVien");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "LoaiDoanhThu");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "KhachHang");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "DichVu");

            migrationBuilder.DropColumn(
                name: "TrangThai",
                table: "DichVu");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ChucVu");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ChiTietPhieuDichVu");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "YeuCau",
                newName: "IdYeuCau");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ThongKeDoanhThu",
                newName: "IDThongKeDoanhThu");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Phong",
                newName: "IdPhong");

            migrationBuilder.RenameColumn(
                name: "HoaDonId",
                table: "PhieuDichVu",
                newName: "HoaDonIdHoaDon");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PhieuDichVu",
                newName: "IdPhieuDichVu");

            migrationBuilder.RenameIndex(
                name: "IX_PhieuDichVu_HoaDonId",
                table: "PhieuDichVu",
                newName: "IX_PhieuDichVu_HoaDonIdHoaDon");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PhieuDatPhong",
                newName: "IdPhieuDatPhong");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "NhanVien",
                newName: "IdNhanVien");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LoaiDoanhThu",
                newName: "IDLoaiDoanhThu");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "KhachHang",
                newName: "IdKhachHang");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "HoaDon",
                newName: "IdHoaDon");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DichVu",
                newName: "IdDichVu");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ChucVu",
                newName: "IDChucVu");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ChiTietPhieuDichVu",
                newName: "IDChiTietPhieuDichVu");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuDichVu_DichVu_DichVuID",
                table: "ChiTietPhieuDichVu",
                column: "DichVuID",
                principalTable: "DichVu",
                principalColumn: "IdDichVu");

            migrationBuilder.AddForeignKey(
                name: "FK_ChiTietPhieuDichVu_PhieuDichVu_PhieuDichVuID",
                table: "ChiTietPhieuDichVu",
                column: "PhieuDichVuID",
                principalTable: "PhieuDichVu",
                principalColumn: "IdPhieuDichVu");

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuDichVu_HoaDon_HoaDonIdHoaDon",
                table: "PhieuDichVu",
                column: "HoaDonIdHoaDon",
                principalTable: "HoaDon",
                principalColumn: "IdHoaDon");
        }
    }
}
