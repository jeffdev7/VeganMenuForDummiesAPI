using Domain.Entities;
using FluentValidation;

namespace Domain.Validator
{
    public class FoodValidator: AbstractValidator<Food>
    {
        public FoodValidator()
        {
            RuleFor(_ => _.Name).NotEmpty().WithMessage("Required field.");
            RuleFor(_ => _.Name).NotNull().WithMessage("Required field");
            RuleFor(_ => _.Ingredients).NotEmpty()
                .WithMessage("Please make sure to write all the ingredients.");
            RuleFor(_ => _.Day).NotNull();
            
        }
    }

    public class FoodUpdateValidator : AbstractValidator<Food>
    {
        public FoodUpdateValidator()
        {
            RuleFor(_ => _.Id).NotEmpty();
            RuleFor(_ => _.Name).NotEmpty().WithMessage("Required field.");
            RuleFor(_ => _.Name).NotNull().WithMessage("Required field");
            RuleFor(_ => _.Ingredients).NotEmpty()
                .WithMessage("Required field.");
            RuleFor(_ => _.Day).NotNull();
            RuleFor(_ => _.Day).NotEmpty().WithMessage("Required field");
        }
    }

    public class FoodRemoveValidator : AbstractValidator<Food>
    {
        public FoodRemoveValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
