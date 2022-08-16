using Domain.Enum;
using System.ComponentModel.DataAnnotations;

namespace Application.ViewModel
{
    public class FoodViewModel
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public EDayOfTheWeek Day { get; set; }

    }
}
