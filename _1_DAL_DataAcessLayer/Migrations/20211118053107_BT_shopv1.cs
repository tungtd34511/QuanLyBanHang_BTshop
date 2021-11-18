using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _1_DAL_DataAcessLayer.Migrations
{
    public partial class BT_shopv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BANGGIA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiaNhap = table.Column<int>(type: "int", nullable: false),
                    GiaBan = table.Column<int>(type: "int", nullable: false),
                    GiamGia = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BANGGIA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CHUCVU",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenChucVu = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CHUCVU", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KHACHHANG",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TinhTrang = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KHACHHANG", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MOTASANPHAM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DungTich = table.Column<int>(type: "int", nullable: false),
                    PhienBan = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Anh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MOTASANPHAM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "THONGTINCANHAN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GioiTinh = table.Column<bool>(type: "bit", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    SDT = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Anh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_THONGTINCANHAN", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "XUATXU",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ThuongHieu = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    NoiSanXuat = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    NamPhatHanh = table.Column<int>(type: "int", nullable: false),
                    NgayNhap = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_XUATXU", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HOADON",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKhachHang = table.Column<int>(type: "int", nullable: true),
                    TheLoai = table.Column<bool>(type: "bit", nullable: false),
                    GiamGia = table.Column<int>(type: "int", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TinhTrangThanhToan = table.Column<bool>(type: "bit", nullable: false),
                    TinhTrang = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HOADON", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HOADON_KHACHHANG_MaKhachHang",
                        column: x => x.MaKhachHang,
                        principalTable: "KHACHHANG",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NHANVIEN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    MaChucVu = table.Column<int>(type: "int", nullable: true),
                    TinhTrang = table.Column<bool>(type: "bit", nullable: false),
                    MaMoTa = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NHANVIEN", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NHANVIEN_CHUCVU_MaChucVu",
                        column: x => x.MaChucVu,
                        principalTable: "CHUCVU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NHANVIEN_THONGTINCANHAN_MaMoTa",
                        column: x => x.MaMoTa,
                        principalTable: "THONGTINCANHAN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SANPHAM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    TinhTrang = table.Column<bool>(type: "bit", nullable: false),
                    MaQR = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    MaBangGia = table.Column<int>(type: "int", nullable: true),
                    MaXuatXu = table.Column<int>(type: "int", nullable: true),
                    MaMoTa = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SANPHAM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SANPHAM_BANGGIA_MaBangGia",
                        column: x => x.MaBangGia,
                        principalTable: "BANGGIA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SANPHAM_MOTASANPHAM_MaMoTa",
                        column: x => x.MaMoTa,
                        principalTable: "MOTASANPHAM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SANPHAM_XUATXU_MaXuatXu",
                        column: x => x.MaXuatXu,
                        principalTable: "XUATXU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TAIKHOAN",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaNhanVien = table.Column<int>(type: "int", nullable: true),
                    Acc = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Pass = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    TinhTrang = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAIKHOAN", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TAIKHOAN_NHANVIEN_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NHANVIEN",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DONHANG",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHoaDon = table.Column<int>(type: "int", nullable: true),
                    MaSanPham = table.Column<int>(type: "int", nullable: true),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    TinhTrang = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DONHANG", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DONHANG_HOADON_MaHoaDon",
                        column: x => x.MaHoaDon,
                        principalTable: "HOADON",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DONHANG_SANPHAM_MaSanPham",
                        column: x => x.MaSanPham,
                        principalTable: "SANPHAM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DONHANG_MaHoaDon",
                table: "DONHANG",
                column: "MaHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_DONHANG_MaSanPham",
                table: "DONHANG",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_HOADON_MaKhachHang",
                table: "HOADON",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_NHANVIEN_MaChucVu",
                table: "NHANVIEN",
                column: "MaChucVu");

            migrationBuilder.CreateIndex(
                name: "IX_NHANVIEN_MaMoTa",
                table: "NHANVIEN",
                column: "MaMoTa");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_MaBangGia",
                table: "SANPHAM",
                column: "MaBangGia");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_MaMoTa",
                table: "SANPHAM",
                column: "MaMoTa");

            migrationBuilder.CreateIndex(
                name: "IX_SANPHAM_MaXuatXu",
                table: "SANPHAM",
                column: "MaXuatXu");

            migrationBuilder.CreateIndex(
                name: "IX_TAIKHOAN_MaNhanVien",
                table: "TAIKHOAN",
                column: "MaNhanVien");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DONHANG");

            migrationBuilder.DropTable(
                name: "TAIKHOAN");

            migrationBuilder.DropTable(
                name: "HOADON");

            migrationBuilder.DropTable(
                name: "SANPHAM");

            migrationBuilder.DropTable(
                name: "NHANVIEN");

            migrationBuilder.DropTable(
                name: "KHACHHANG");

            migrationBuilder.DropTable(
                name: "BANGGIA");

            migrationBuilder.DropTable(
                name: "MOTASANPHAM");

            migrationBuilder.DropTable(
                name: "XUATXU");

            migrationBuilder.DropTable(
                name: "CHUCVU");

            migrationBuilder.DropTable(
                name: "THONGTINCANHAN");
        }
    }
}
