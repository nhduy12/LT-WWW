using NHD.EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHD.EntityFramework.DataContext
{
    public class QLSachDbContext : DbContext
    {
        public QLSachDbContext() : base("QLSach")
        {
            Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Sach> Saches { get; set; }
        public DbSet<LoaiSach> LoaiSaches { get; set; }
        public DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public DbSet<Sach_LoaiSach> Sach_LoaiSaches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
