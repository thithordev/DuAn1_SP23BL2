using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhiCuoc",
                table: "PhieuDatPhong");

            migrationBuilder.AddColumn<int>(
                name: "KieuDat",
                table: "PhieuDatPhong",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KieuDat",
                table: "PhieuDatPhong");

            migrationBuilder.AddColumn<decimal>(
                name: "PhiCuoc",
                table: "PhieuDatPhong",
                type: "money",
                nullable: true);
        }
    }
}
