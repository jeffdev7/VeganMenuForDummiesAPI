using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.DBConfiguration;

namespace Infrastructure.Repositories
{
    public class FoodRepository : Repository<Food>, IFoodRepository
    {
        public FoodRepository(ApplicationContext context) : base(context)
        {
        }

        public IQueryable<Food> GetDish()
        {
            return Db.Dishes;
        }
    }
}
