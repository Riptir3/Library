using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.DatabaseConfig
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("ConnectionString");
        }
    }
}
