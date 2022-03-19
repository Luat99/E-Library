using ELibrary.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ELibrary.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Admin> Admin { get; set; } = null!;
        public DbSet<Teacher> Teacher { get; set; } = null!;
        public DbSet<BaiGiang> BaiGiang { get; set; } = null!;
        public DbSet<DeThiKiemTra> DeThiKiemTra { get; set; } = null!;
        public DbSet<DanhSachMonGiangDay> DanhSachMonGiangDay { get; set; } = null!;
        public DbSet<Help> Help { get; set; } = null!;
        public DbSet<DFile> DFile { get; set; } = null!;
        public DbSet<NganHangDeThi> NganHangDeThi { get; set; } = null!;
        public DbSet<TaiLieuMonHoc> TaiLieuMonHoc { get; set; } = null!;
        public DbSet<TaiNguyen> TaiNguyen { get; set; } = null!;
        public DbSet<ThongBao> ThongBao { get; set; } = null!;
    }
}
