using Application.ViewModel;
using Domain.Entities;
using FluentValidation.Results;

namespace Application.Interfaces.Services
{
    public interface IFoodServices : IDisposable
    {
        IEnumerable<FoodViewModel> GetAll();
        FoodViewModel GetById(Guid id);
        IEnumerable<FoodViewModel> GetAllBy(Func<Food, bool> exp);
        ValidationResult Add(FoodViewModel vm);
        ValidationResult Update(FoodViewModel vm);
        ValidationResult Remove(Guid id);
        IEnumerable<FoodViewModel> GetDishes();
    }
}
