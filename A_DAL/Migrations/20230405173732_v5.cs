using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_DAL.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SoGiuong",
                table: "LoaiPhong",
                newName: "OToiDa");

            migrationBuilder.AddColumn<int>(
                name: "Tang",
                table: "Phong",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tang",
                table: "Phong");

            migrationBuilder.RenameColumn(
                name: "OToiDa",
                table: "LoaiPhong",
                newName: "SoGiuong");
        }
    }
}
