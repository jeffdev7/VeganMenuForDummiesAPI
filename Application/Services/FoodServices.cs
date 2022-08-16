using Application.Interfaces.Services;
using Application.ViewModel;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Validator;
using FluentValidation.Results;
using Infrastructure.DBConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Application.Services
{
    public class FoodServices : IFoodServices
    {
        private readonly IMapper _mapper;
        private readonly IFoodRepository _foodRepository;
        private readonly ApplicationContext _context;

        public FoodServices(IMapper mapper, IFoodRepository foodRepository,
            ApplicationContext context)
        {
            _mapper = mapper;
            _foodRepository = foodRepository;
            _context = context;
        }

        //public async Task<FoodViewModel> Add(FoodViewModel vm)
        //{
        //    Food food = _mapper.Map<Food>(vm);
        //    _context.Dishes.Add(food);
        //    await _context.SaveChangesAsync();
        //    return _mapper.Map<FoodViewModel>(food);
        //}
        public ValidationResult Add(FoodViewModel vm)
        {
            var entity = _mapper.Map<Food>(vm);
            var validationResult = new FoodValidator().Validate(entity);
            if(validationResult.IsValid)
                _foodRepository.Add(entity);
            return validationResult;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<FoodViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<FoodViewModel>>(_foodRepository.GetAll());
        }

        public IEnumerable<FoodViewModel> GetAllBy(Func<Food, bool> exp)
        {
            return _mapper.Map<IEnumerable<FoodViewModel>>(_foodRepository.GetAllBy(exp)); ;
        }

        public FoodViewModel GetById(Guid id)
        {
            return _mapper.Map<FoodViewModel>(_foodRepository.GetById(id));
        }

        public IEnumerable<FoodViewModel> GetDishes()
        {
            return _mapper.Map<IEnumerable<FoodViewModel>>(_foodRepository.GetDish());
        }

        //public async Task<bool> Remove(Guid id)
        //{
        //    Food food = await _context.Dishes.Where(p => p.Id == id)
        //            .FirstOrDefaultAsync();
        //    if (food == null) return false;
        //    _context.Dishes.Remove(food);
        //    await _context.SaveChangesAsync();
        //    return true;
        //}

        public ValidationResult Remove(Guid id)
        {
            var entity = _foodRepository.GetById(id);
            var validationResult = new FoodRemoveValidator().Validate(entity);
            if (validationResult.IsValid)
                _foodRepository.Remove(id);
            return validationResult;

        }

        //public async Task<FoodViewModel> Update(FoodViewModel vm)
        //{
        //    Food food = _mapper.Map<Food>(vm);
        //    _context.Dishes.Update(food);
        //    await _context.SaveChangesAsync();
        //    return _mapper.Map<FoodViewModel>(food);
        //}
        public ValidationResult Update(FoodViewModel vm)
        {
           var entity = _mapper.Map<Food>(vm);
            var validationResult = new FoodUpdateValidator().Validate(entity);
            if(validationResult.IsValid)
                _foodRepository.Update(entity);
            return validationResult;
        }
    }
}
