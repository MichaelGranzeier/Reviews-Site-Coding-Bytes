using Microsoft.EntityFrameworkCore;
using template_csharp_reviews_site.Models;

namespace template_csharp_reviews_site
{
    public class SupplyContext : DbContext
    {
        public DbSet<SchoolSupply> SchoolSupplies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server = (localdb)\\mssqllocaldb;Database=SupplyDB_Summer2022; Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);



        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SchoolSupply>().HasData(
                new SchoolSupply() { Id = 1, Name = "Ticonderoga Pencil", Description = "Triangular and fun!", AgeGroup = AgeGroup.Pre_K, Price = 2.99, SupplyType = SupplyType.Writing },
                new SchoolSupply() { Id = 2, Name = "Bic Pen", Description = "Filled with ink!", AgeGroup = AgeGroup.ElemSchool, Price = 1.99, SupplyType = SupplyType.Writing },
                new SchoolSupply() { Id = 3, Name = "5 star", Description = "durable and indestructible", AgeGroup = AgeGroup.MiddleSchool, Price = 10.00, SupplyType = SupplyType.Binders },
                new SchoolSupply() { Id = 4, Name = "Texas Insturment", Description = "Calculator", AgeGroup = AgeGroup.HighSchool, Price = 200.00, SupplyType = SupplyType.Calculator },
                new SchoolSupply() { Id = 5, Name = "LL Bean", Description = "Durable and strong", AgeGroup = AgeGroup.College, Price = 50, SupplyType = SupplyType.Backpacks }
                );
            
        }

    }
}
