using E_Com.Models;
using Microsoft.EntityFrameworkCore;

namespace E_Com.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Phone", Description = "All kinds of phone here", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Laptop", Description = "All kinds of Laptop here", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Gadgets", Description = "All kinds of Gadgets here", DisplayOrder = 3 }
                );
        }

    }
}
