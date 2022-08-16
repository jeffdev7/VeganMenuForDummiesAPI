using Application.ViewModel;
using AutoMapper;
using Domain.Entities;

namespace Application.AutoMapper
{
    public class DomainViewModelMapping : Profile
    {
        public DomainViewModelMapping()
        {
            CreateMap<Food, FoodViewModel>();
        }
    }
}
