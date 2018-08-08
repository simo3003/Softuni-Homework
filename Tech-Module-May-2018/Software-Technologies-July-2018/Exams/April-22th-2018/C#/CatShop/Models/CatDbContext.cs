namespace CatShop.Models
{
    using Microsoft.EntityFrameworkCore;

    public class CatDbContext : DbContext
    {
        public DbSet<Cat> Cats { get; set; }

        public CatDbContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=catshop_csharp;user=root;");
        }
    }
}
