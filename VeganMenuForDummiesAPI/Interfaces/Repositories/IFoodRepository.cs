using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IFoodRepository : IRepository<Food>
    {
        IQueryable<Food> GetFood();
    }
}
