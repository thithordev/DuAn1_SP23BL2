using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NgayGioTaoPhieu",
                table: "PhieuDatPhong",
                newName: "NgayTao");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "ThongKeDoanhThu",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "PhieuDichVu",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PhieuDatPhongId",
                table: "PhieuDichVu",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayTao",
                table: "HoaDon",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PhieuDichVu_PhieuDatPhongId",
                table: "PhieuDichVu",
                column: "PhieuDatPhongId");

            migrationBuilder.AddForeignKey(
                name: "FK_PhieuDichVu_PhieuDatPhong_PhieuDatPhongId",
                table: "PhieuDichVu",
                column: "PhieuDatPhongId",
                principalTable: "PhieuDatPhong",
                principalColumn: "IdPhieuDatPhong");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PhieuDichVu_PhieuDatPhong_PhieuDatPhongId",
                table: "PhieuDichVu");

            migrationBuilder.DropIndex(
                name: "IX_PhieuDichVu_PhieuDatPhongId",
                table: "PhieuDichVu");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "ThongKeDoanhThu");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "PhieuDichVu");

            migrationBuilder.DropColumn(
                name: "PhieuDatPhongId",
                table: "PhieuDichVu");

            migrationBuilder.DropColumn(
                name: "NgayTao",
                table: "HoaDon");

            migrationBuilder.RenameColumn(
                name: "NgayTao",
                table: "PhieuDatPhong",
                newName: "NgayGioTaoPhieu");
        }
    }
}
