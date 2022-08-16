using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DBConfiguration
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Food> Dishes { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) 
            : base(options) { }
        public ApplicationContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //TODO
        }
    }
}
