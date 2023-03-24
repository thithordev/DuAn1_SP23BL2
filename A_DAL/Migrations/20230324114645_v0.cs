using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class v0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    IDChucVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuyenTruyCap = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.IDChucVu);
                });

            migrationBuilder.CreateTable(
                name: "DichVu",
                columns: table => new
                {
                    IdDichVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gia = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVu", x => x.IdDichVu);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    IdKhachHang = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenDem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true),
                    GhiChu = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.IdKhachHang);
                });

            migrationBuilder.CreateTable(
                name: "LoaiDoanhThu",
                columns: table => new
                {
                    IDLoaiDoanhThu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kieu = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiDoanhThu", x => x.IDLoaiDoanhThu);
                });

            migrationBuilder.CreateTable(
                name: "LoaiPhong",
                columns: table => new
                {
                    IdLoaiPhong = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mota = table.Column<string>(type: "ntext", nullable: true),
                    SoGiuong = table.Column<int>(type: "int", nullable: true),
                    GiaNgay = table.Column<decimal>(type: "money", nullable: true),
                    GiaPhong = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiPhong", x => x.IdLoaiPhong);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    IdNhanVien = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChucVuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TenDem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CCCD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true),
                    Luong = table.Column<decimal>(type: "money", nullable: true),
                    TenTaiKhoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.IdNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_ChucVuId",
                        column: x => x.ChucVuId,
                        principalTable: "ChucVu",
                        principalColumn: "IDChucVu");
                });

            migrationBuilder.CreateTable(
                name: "ThongKeDoanhThu",
                columns: table => new
                {
                    IDThongKeDoanhThu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoaiDoanhThuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NoiDung = table.Column<string>(type: "ntext", nullable: true),
                    SoTien = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongKeDoanhThu", x => x.IDThongKeDoanhThu);
                    table.ForeignKey(
                        name: "FK_ThongKeDoanhThu_LoaiDoanhThu_LoaiDoanhThuId",
                        column: x => x.LoaiDoanhThuId,
                        principalTable: "LoaiDoanhThu",
                        principalColumn: "IDLoaiDoanhThu");
                });

            migrationBuilder.CreateTable(
                name: "Phong",
                columns: table => new
                {
                    IdPhong = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoaiPhongId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true),
                    GhiChu = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phong", x => x.IdPhong);
                    table.ForeignKey(
                        name: "FK_Phong_LoaiPhong_LoaiPhongId",
                        column: x => x.LoaiPhongId,
                        principalTable: "LoaiPhong",
                        principalColumn: "IdLoaiPhong");
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhachHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NhanVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TongTien = table.Column<decimal>(type: "money", nullable: true),
                    PhuongThucThanhToan = table.Column<int>(type: "int", nullable: true),
                    GhiChu = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.IdHoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHang",
                        principalColumn: "IdKhachHang");
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanVien",
                        principalColumn: "IdNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "YeuCau",
                columns: table => new
                {
                    IdYeuCau = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NhanVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Noidung = table.Column<string>(type: "ntext", nullable: true),
                    ChiPhi = table.Column<decimal>(type: "money", nullable: true),
                    GhiChu = table.Column<string>(type: "ntext", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YeuCau", x => x.IdYeuCau);
                    table.ForeignKey(
                        name: "FK_YeuCau_NhanVien_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanVien",
                        principalColumn: "IdNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "PhieuDatPhong",
                columns: table => new
                {
                    IdPhieuDatPhong = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhachHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HoaDonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NhanVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PhongId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NgayGioTaoPhieu = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayDat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayTra = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhiCuoc = table.Column<decimal>(type: "money", nullable: true),
                    PhiPhong = table.Column<decimal>(type: "money", nullable: true),
                    GhiChu = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuDatPhong", x => x.IdPhieuDatPhong);
                    table.ForeignKey(
                        name: "FK_PhieuDatPhong_HoaDon_HoaDonId",
                        column: x => x.HoaDonId,
                        principalTable: "HoaDon",
                        principalColumn: "IdHoaDon");
                    table.ForeignKey(
                        name: "FK_PhieuDatPhong_KhachHang_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHang",
                        principalColumn: "IdKhachHang");
                    table.ForeignKey(
                        name: "FK_PhieuDatPhong_NhanVien_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanVien",
                        principalColumn: "IdNhanVien");
                    table.ForeignKey(
                        name: "FK_PhieuDatPhong_Phong_PhongId",
                        column: x => x.PhongId,
                        principalTable: "Phong",
                        principalColumn: "IdPhong");
                });

            migrationBuilder.CreateTable(
                name: "PhieuDichVu",
                columns: table => new
                {
                    IdPhieuDichVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    KhachHangId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NhanVienId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true),
                    GhiChu = table.Column<string>(type: "ntext", nullable: true),
                    HoaDonIdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuDichVu", x => x.IdPhieuDichVu);
                    table.ForeignKey(
                        name: "FK_PhieuDichVu_HoaDon_HoaDonIdHoaDon",
                        column: x => x.HoaDonIdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "IdHoaDon");
                    table.ForeignKey(
                        name: "FK_PhieuDichVu_KhachHang_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "KhachHang",
                        principalColumn: "IdKhachHang");
                    table.ForeignKey(
                        name: "FK_PhieuDichVu_NhanVien_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "NhanVien",
                        principalColumn: "IdNhanVien");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietPhieuDichVu",
                columns: table => new
                {
                    IDChiTietPhieuDichVu = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhieuDichVuID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DichVuID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: true),
                    DonGia = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietPhieuDichVu", x => x.IDChiTietPhieuDichVu);
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuDichVu_DichVu_DichVuID",
                        column: x => x.DichVuID,
                        principalTable: "DichVu",
                        principalColumn: "IdDichVu");
                    table.ForeignKey(
                        name: "FK_ChiTietPhieuDichVu_PhieuDichVu_PhieuDichVuID",
                        column: x => x.PhieuDichVuID,
                        principalTable: "PhieuDichVu",
                        principalColumn: "IdPhieuDichVu");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuDichVu_DichVuID",
                table: "ChiTietPhieuDichVu",
                column: "DichVuID");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietPhieuDichVu_PhieuDichVuID",
                table: "ChiTietPhieuDichVu",
                column: "PhieuDichVuID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_KhachHangId",
                table: "HoaDon",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_NhanVienId",
                table: "HoaDon",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_ChucVuId",
                table: "NhanVien",
                column: "ChucVuId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatPhong_HoaDonId",
                table: "PhieuDatPhong",
                column: "HoaDonId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatPhong_KhachHangId",
                table: "PhieuDatPhong",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatPhong_NhanVienId",
                table: "PhieuDatPhong",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDatPhong_PhongId",
                table: "PhieuDatPhong",
                column: "PhongId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDichVu_HoaDonIdHoaDon",
                table: "PhieuDichVu",
                column: "HoaDonIdHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDichVu_KhachHangId",
                table: "PhieuDichVu",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDichVu_NhanVienId",
                table: "PhieuDichVu",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_Phong_LoaiPhongId",
                table: "Phong",
                column: "LoaiPhongId");

            migrationBuilder.CreateIndex(
                name: "IX_ThongKeDoanhThu_LoaiDoanhThuId",
                table: "ThongKeDoanhThu",
                column: "LoaiDoanhThuId");

            migrationBuilder.CreateIndex(
                name: "IX_YeuCau_NhanVienId",
                table: "YeuCau",
                column: "NhanVienId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietPhieuDichVu");

            migrationBuilder.DropTable(
                name: "PhieuDatPhong");

            migrationBuilder.DropTable(
                name: "ThongKeDoanhThu");

            migrationBuilder.DropTable(
                name: "YeuCau");

            migrationBuilder.DropTable(
                name: "DichVu");

            migrationBuilder.DropTable(
                name: "PhieuDichVu");

            migrationBuilder.DropTable(
                name: "Phong");

            migrationBuilder.DropTable(
                name: "LoaiDoanhThu");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "LoaiPhong");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "ChucVu");
        }
    }
}
