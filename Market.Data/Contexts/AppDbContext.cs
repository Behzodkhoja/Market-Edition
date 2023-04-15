using Market.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Market.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = "Server=(localdb)\\MSSQLLocalDB; Database=BankDb; Trusted_Connection=true";
            optionsBuilder.UseSqlServer(path);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
