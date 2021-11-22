using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAcessLayer.Migrations
{
    public partial class BTv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TAIKHOAN_NHANVIEN_MaNhanVien",
                table: "TAIKHOAN");

            migrationBuilder.DropIndex(
                name: "IX_TAIKHOAN_MaNhanVien",
                table: "TAIKHOAN");

            migrationBuilder.DropColumn(
                name: "MaNhanVien",
                table: "TAIKHOAN");

            migrationBuilder.AddColumn<int>(
                name: "NhanVien",
                table: "TAIKHOAN",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Anh",
                table: "MOTASANPHAM",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NhanVien",
                table: "TAIKHOAN");

            migrationBuilder.AddColumn<int>(
                name: "MaNhanVien",
                table: "TAIKHOAN",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Anh",
                table: "MOTASANPHAM",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TAIKHOAN_MaNhanVien",
                table: "TAIKHOAN",
                column: "MaNhanVien");

            migrationBuilder.AddForeignKey(
                name: "FK_TAIKHOAN_NHANVIEN_MaNhanVien",
                table: "TAIKHOAN",
                column: "MaNhanVien",
                principalTable: "NHANVIEN",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
