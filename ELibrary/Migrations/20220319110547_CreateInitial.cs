using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELibrary.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    ID_Admin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME_Admin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.ID_Admin);
                });

            migrationBuilder.CreateTable(
                name: "BaiGiang",
                columns: table => new
                {
                    ID_BaiGiang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME_BaiGiang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIPTION_BaiGiang = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaiGiang", x => x.ID_BaiGiang);
                });

            migrationBuilder.CreateTable(
                name: "DanhSachMonGiangDay",
                columns: table => new
                {
                    ID_DSMGiangDay = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME_DSMGiangDay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIPTION_DSMGiangDay = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhSachMonGiangDay", x => x.ID_DSMGiangDay);
                });

            migrationBuilder.CreateTable(
                name: "DeThiKiemTra",
                columns: table => new
                {
                    ID_DeThiKiemTra = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME_DeThiKiemTra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIPTION_DeThiKiemTra = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeThiKiemTra", x => x.ID_DeThiKiemTra);
                });

            migrationBuilder.CreateTable(
                name: "DFile",
                columns: table => new
                {
                    ID_File = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME_File = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Extension_File = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DFile", x => x.ID_File);
                });

            migrationBuilder.CreateTable(
                name: "Help",
                columns: table => new
                {
                    ID_Help = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME_Help = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIPTION_Help = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Help", x => x.ID_Help);
                });

            migrationBuilder.CreateTable(
                name: "NganHangDeThi",
                columns: table => new
                {
                    ID_NganHangDeThi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME_NganHangDeThi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIPTION_NganHangDeThi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NganHangDeThi", x => x.ID_NganHangDeThi);
                });

            migrationBuilder.CreateTable(
                name: "TaiLieuMonHoc",
                columns: table => new
                {
                    ID_TaiLieuMonHoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME_TaiLieuMonHoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIPTION_TaiLieuMonHoc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiLieuMonHoc", x => x.ID_TaiLieuMonHoc);
                });

            migrationBuilder.CreateTable(
                name: "TaiNguyen",
                columns: table => new
                {
                    ID_TaiNguyen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME_TaiNguyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIPTION_TaiNguyen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiNguyen", x => x.ID_TaiNguyen);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    ID_Teacher = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME_Teacher = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.ID_Teacher);
                });

            migrationBuilder.CreateTable(
                name: "ThongBao",
                columns: table => new
                {
                    ID_ThongBao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME_ThongBao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIPTION_ThongBao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongBao", x => x.ID_ThongBao);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "BaiGiang");

            migrationBuilder.DropTable(
                name: "DanhSachMonGiangDay");

            migrationBuilder.DropTable(
                name: "DeThiKiemTra");

            migrationBuilder.DropTable(
                name: "DFile");

            migrationBuilder.DropTable(
                name: "Help");

            migrationBuilder.DropTable(
                name: "NganHangDeThi");

            migrationBuilder.DropTable(
                name: "TaiLieuMonHoc");

            migrationBuilder.DropTable(
                name: "TaiNguyen");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropTable(
                name: "ThongBao");
        }
    }
}
