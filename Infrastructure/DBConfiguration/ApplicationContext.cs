using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DBConfiguration
{
    public interface IAppDbContext { }
    public class ApplicationContext : DbContext
    {
        public DbSet<Food> Dishes { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) 
            : base(options) { }
        public ApplicationContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>().HasData(new Food
            {
                Id = Guid.NewGuid(),
                Name = "Spaghetti aglio y oleo",
                Ingredients = "Spaghetti, olive oil, garlic",
                Day = Domain.Enum.EDayOfTheWeek.MONDAY,
            });

            modelBuilder.Entity<Food>().HasData(new Food
            {
                Id = Guid.NewGuid(),
                Name = "Spaghetti with lentils",
                Ingredients = "Spaghetti, olive oil, garlic, lentils",
                Day = Domain.Enum.EDayOfTheWeek.TUESDAY,
            });

            modelBuilder.Entity<Food>().HasData(new Food
            {
                Id = Guid.NewGuid(),
                Name = "Spaghetti with cauliflower sauce and chickpeas",
                Ingredients = "Spaghetti, olive oil, garlic, cauliflower, chickpeas",
                Day = Domain.Enum.EDayOfTheWeek.WEDNESDAY,
            });

            modelBuilder.Entity<Food>().HasData(new Food
            {
                Id = Guid.NewGuid(),
                Name = "Risotto",
                Ingredients = "Rice, lentils, potato, peas,carrpts",
                Day = Domain.Enum.EDayOfTheWeek.THURSDAY,
            });

            modelBuilder.Entity<Food>().HasData(new Food
            {
                Id = Guid.NewGuid(),
                Name = "Pizza",
                Ingredients = "Margherita or mussarela",
                Day = Domain.Enum.EDayOfTheWeek.FRIDAY,
            });

            modelBuilder.Entity<Food>().HasData(new Food
            {
                Id = Guid.NewGuid(),
                Name = "Donburi",
                Ingredients = "gohan, tofu, mushrooms,soy sauce, spring onion, fried eggplant, courgette ",
                Day = Domain.Enum.EDayOfTheWeek.SATURDAY,
            });

            modelBuilder.Entity<Food>().HasData(new Food
            {
                Id = Guid.NewGuid(),
                Name = "Hamburger",
                Ingredients = "hamburger of chickpeas, lentils, beans, soy",
                Day = Domain.Enum.EDayOfTheWeek.SUNDAY,
            });

            base.OnModelCreating(modelBuilder);
            
        }
    }
}
