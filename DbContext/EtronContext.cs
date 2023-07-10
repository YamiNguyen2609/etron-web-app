using Microsoft.EntityFrameworkCore;
using AppWebCore.Models;

namespace AppWebCore
{
    public class EtronContext : DbContext
    {
        public string DbPath { get; }
        public EtronContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Etron.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Recruit> Recruitments { get; set; }
    }
}