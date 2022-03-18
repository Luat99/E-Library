using Microsoft.EntityFrameworkCore;
using ELibrary.Models.admin;
using ELibrary.Models.feature;
using ELibrary.Models.teacher;

namespace ELibrary.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
       
        public DbSet<admin> admin { get; set; }
        public DbSet<teacher> teacher { get; set; }
        public DbSet<baigiang> baigiang { get; set; }
        public DbSet<dethikiemtra> dethikiemtra { get; set; }
        public DbSet<dsmongiangday> dsmongiangday { get; set; }
        public DbSet<help> help { get; set; }
        public DbSet<data_file> data_file { get; set; }
        public DbSet<nganhangdethi> nganhangdethi { get; set; }
        public DbSet<tailieumonhoc> tailieumonhoc { get; set; }
        public DbSet<tainguyen> tainguyen { get; set; }
        public DbSet<thongbao> thongbao { get; set; }




    }





}

