using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELibrary.Migrations
{
    public partial class CreateInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    id_admin = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_admin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin", x => x.id_admin);
                });

            migrationBuilder.CreateTable(
                name: "baigiang",
                columns: table => new
                {
                    id_bg = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_bg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description_bg = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_baigiang", x => x.id_bg);
                });

            migrationBuilder.CreateTable(
                name: "data_file",
                columns: table => new
                {
                    id_file = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_file = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Extension_file = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_data_file", x => x.id_file);
                });

            migrationBuilder.CreateTable(
                name: "dethikiemtra",
                columns: table => new
                {
                    id_dtkt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_dtkt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description_dtks = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dethikiemtra", x => x.id_dtkt);
                });

            migrationBuilder.CreateTable(
                name: "dsmongiangday",
                columns: table => new
                {
                    id_dsmgd = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_dsmgd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description_dsmh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dsmongiangday", x => x.id_dsmgd);
                });

            migrationBuilder.CreateTable(
                name: "help",
                columns: table => new
                {
                    id_help = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_help = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description_help = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_help", x => x.id_help);
                });

            migrationBuilder.CreateTable(
                name: "nganhangdethi",
                columns: table => new
                {
                    id_nhdt = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_nhdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description_nhdt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nganhangdethi", x => x.id_nhdt);
                });

            migrationBuilder.CreateTable(
                name: "tailieumonhoc",
                columns: table => new
                {
                    id_tlmh = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_tlmh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tailieumonhoc", x => x.id_tlmh);
                });

            migrationBuilder.CreateTable(
                name: "tainguyen",
                columns: table => new
                {
                    id_tn = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_tn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description_tn = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tainguyen", x => x.id_tn);
                });

            migrationBuilder.CreateTable(
                name: "teacher",
                columns: table => new
                {
                    id_teacher = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_teacher = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teacher", x => x.id_teacher);
                });

            migrationBuilder.CreateTable(
                name: "thongbao",
                columns: table => new
                {
                    id_tb = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_tb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description_tb = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_thongbao", x => x.id_tb);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin");

            migrationBuilder.DropTable(
                name: "baigiang");

            migrationBuilder.DropTable(
                name: "data_file");

            migrationBuilder.DropTable(
                name: "dethikiemtra");

            migrationBuilder.DropTable(
                name: "dsmongiangday");

            migrationBuilder.DropTable(
                name: "help");

            migrationBuilder.DropTable(
                name: "nganhangdethi");

            migrationBuilder.DropTable(
                name: "tailieumonhoc");

            migrationBuilder.DropTable(
                name: "tainguyen");

            migrationBuilder.DropTable(
                name: "teacher");

            migrationBuilder.DropTable(
                name: "thongbao");
        }
    }
}
