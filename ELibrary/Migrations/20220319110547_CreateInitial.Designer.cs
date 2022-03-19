﻿// <auto-generated />
using ELibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ELibrary.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220319110547_CreateInitial")]
    partial class CreateInitial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ELibrary.Models.Admin", b =>
                {
                    b.Property<int>("ID_Admin")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Admin"), 1L, 1);

                    b.Property<string>("NAME_Admin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Admin");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("ELibrary.Models.BaiGiang", b =>
                {
                    b.Property<int>("ID_BaiGiang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_BaiGiang"), 1L, 1);

                    b.Property<string>("DESCRIPTION_BaiGiang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAME_BaiGiang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_BaiGiang");

                    b.ToTable("BaiGiang");
                });

            modelBuilder.Entity("ELibrary.Models.DanhSachMonGiangDay", b =>
                {
                    b.Property<int>("ID_DSMGiangDay")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_DSMGiangDay"), 1L, 1);

                    b.Property<string>("DESCRIPTION_DSMGiangDay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAME_DSMGiangDay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_DSMGiangDay");

                    b.ToTable("DanhSachMonGiangDay");
                });

            modelBuilder.Entity("ELibrary.Models.DeThiKiemTra", b =>
                {
                    b.Property<int>("ID_DeThiKiemTra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_DeThiKiemTra"), 1L, 1);

                    b.Property<string>("DESCRIPTION_DeThiKiemTra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAME_DeThiKiemTra")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_DeThiKiemTra");

                    b.ToTable("DeThiKiemTra");
                });

            modelBuilder.Entity("ELibrary.Models.DFile", b =>
                {
                    b.Property<int>("ID_File")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_File"), 1L, 1);

                    b.Property<string>("Extension_File")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MimeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAME_File")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_File");

                    b.ToTable("DFile");
                });

            modelBuilder.Entity("ELibrary.Models.Help", b =>
                {
                    b.Property<int>("ID_Help")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Help"), 1L, 1);

                    b.Property<string>("DESCRIPTION_Help")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAME_Help")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Help");

                    b.ToTable("Help");
                });

            modelBuilder.Entity("ELibrary.Models.NganHangDeThi", b =>
                {
                    b.Property<int>("ID_NganHangDeThi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_NganHangDeThi"), 1L, 1);

                    b.Property<string>("DESCRIPTION_NganHangDeThi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAME_NganHangDeThi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_NganHangDeThi");

                    b.ToTable("NganHangDeThi");
                });

            modelBuilder.Entity("ELibrary.Models.TaiLieuMonHoc", b =>
                {
                    b.Property<int>("ID_TaiLieuMonHoc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_TaiLieuMonHoc"), 1L, 1);

                    b.Property<string>("DESCRIPTION_TaiLieuMonHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAME_TaiLieuMonHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_TaiLieuMonHoc");

                    b.ToTable("TaiLieuMonHoc");
                });

            modelBuilder.Entity("ELibrary.Models.TaiNguyen", b =>
                {
                    b.Property<int>("ID_TaiNguyen")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_TaiNguyen"), 1L, 1);

                    b.Property<string>("DESCRIPTION_TaiNguyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAME_TaiNguyen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_TaiNguyen");

                    b.ToTable("TaiNguyen");
                });

            modelBuilder.Entity("ELibrary.Models.Teacher", b =>
                {
                    b.Property<int>("ID_Teacher")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Teacher"), 1L, 1);

                    b.Property<string>("NAME_Teacher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Teacher");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("ELibrary.Models.ThongBao", b =>
                {
                    b.Property<int>("ID_ThongBao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_ThongBao"), 1L, 1);

                    b.Property<string>("DESCRIPTION_ThongBao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NAME_ThongBao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_ThongBao");

                    b.ToTable("ThongBao");
                });
#pragma warning restore 612, 618
        }
    }
}