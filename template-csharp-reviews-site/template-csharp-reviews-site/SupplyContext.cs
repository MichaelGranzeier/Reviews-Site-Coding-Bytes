using Microsoft.EntityFrameworkCore;

namespace template_csharp_reviews_site
{
    public class SupplyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server(localdb)\\mssqllocaldb;Database=SupplyDB_Summer2022; Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();
            base.OnConfiguring(optionsBuilder);



        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
