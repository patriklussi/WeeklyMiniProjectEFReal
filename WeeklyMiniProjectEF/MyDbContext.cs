using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;

namespace WeeklyMiniProjectEF
{
    internal class MyDbContext:DbContext
    {
        string connectionString = "Server=PATRIK;Database=WMPAssetTracking;Trusted_Connection=True;Encrypt=false";
        public DbSet<Office> Offices { get; set; }
        public   DbSet<Assets> Assets { get; set; }
      
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //We tell the app to use connection string
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {
            ModelBuilder.Entity<Assets>().HasData(new Assets { Id = 1, AssetType = "Phone", Name = "Samsung", Model = "S20", PurchasePrice = 214551, PurchaseDate = new DateTime(2022, 02, 13), OfficeId = 1 });
            ModelBuilder.Entity<Assets>().HasData(new Assets { Id = 2, AssetType = "Laptop", Name = "Lenovo", Model = "LG5", PurchasePrice = 25144151, PurchaseDate = new DateTime(2021, 06, 12), OfficeId = 2 });
            ModelBuilder.Entity<Assets>().HasData(new Assets { Id = 3, AssetType = "Computer", Name = "Taurus", Model = "D0nkey", PurchasePrice = 1546, PurchaseDate = new DateTime(2015, 10, 5), OfficeId = 3 });
            ModelBuilder.Entity<Assets>().HasData(new Assets { Id = 4, AssetType = "Computer", Name = "Cooler master", Model = "Monkey", PurchasePrice = 51951959, PurchaseDate = new DateTime(2022, 10, 5), OfficeId = 3 });

            ModelBuilder.Entity<Office>().HasData(new Office { Id = 1, OfficeName = "Sweden", CurrencyType = "SEK" });
            ModelBuilder.Entity<Office>().HasData(new Office { Id = 2, OfficeName = "USA", CurrencyType = "USD" });
            ModelBuilder.Entity<Office>().HasData(new Office { Id = 3, OfficeName = "Germany", CurrencyType = "EUR" });
        }
    }
}


