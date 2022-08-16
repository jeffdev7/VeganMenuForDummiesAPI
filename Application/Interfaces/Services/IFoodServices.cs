using Application.ViewModel;
using Domain.Entities;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface IFoodServices : IDisposable
    {
        IEnumerable<FoodViewModel> GetAll();
        FoodViewModel GetById(Guid id);
        IEnumerable<FoodViewModel> GetAllBy(Func<Food, bool> exp);
        //Task<FoodViewModel> Update(FoodViewModel vm);
        //Task<FoodViewModel> Add(FoodViewModel vm);
        //Task<bool> Remove(Guid id);

        ValidationResult Add(FoodViewModel vm);
        ValidationResult Update(FoodViewModel vm);
        ValidationResult Remove(Guid id);
        IEnumerable<FoodViewModel> GetDishes();
    }
}
