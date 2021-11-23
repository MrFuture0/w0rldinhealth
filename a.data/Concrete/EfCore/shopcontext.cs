using Microsoft.EntityFrameworkCore;
using a.entity;

namespace a.data.Concrete.EfCore
{
    public class shopcontext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Date Source=shopDb");
        }
    }
}