using Domain.Entities.Core;
using Domain.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Entities
{
    public class Food: Entity, IEntityTypeConfiguration<Food>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public EDayOfTheWeek Day { get; set; }

        public Food()
        {
        }

        public Food(Guid id, string name, string ingredients, EDayOfTheWeek day)
        {
            Id = id;
            Name = name;
            Ingredients = ingredients;
            Day = day;
        }

        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Id).IsRequired();
            builder.Property(f => f.Name).IsRequired();
            builder.Property(f => f.Ingredients).IsRequired();
            builder.Property(f => f.Day);
        }
    }
}
