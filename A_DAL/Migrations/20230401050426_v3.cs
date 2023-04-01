using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GiaPhong",
                table: "LoaiPhong",
                newName: "GiaGio");

            migrationBuilder.RenameColumn(
                name: "IdLoaiPhong",
                table: "LoaiPhong",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayDatTra",
                table: "PhieuDatPhong",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayNhan",
                table: "PhieuDatPhong",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "LoaiPhong",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NgayDatTra",
                table: "PhieuDatPhong");

            migrationBuilder.DropColumn(
                name: "NgayNhan",
                table: "PhieuDatPhong");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "LoaiPhong");

            migrationBuilder.RenameColumn(
                name: "GiaGio",
                table: "LoaiPhong",
                newName: "GiaPhong");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LoaiPhong",
                newName: "IdLoaiPhong");
        }
    }
}
