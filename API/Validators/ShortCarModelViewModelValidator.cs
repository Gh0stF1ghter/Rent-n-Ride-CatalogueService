using API.ViewModels.ShortViewModels;
using FluentValidation;

namespace API.Validators;

public class ShortCarModelViewModelValidator : AbstractValidator<ShortCarModelViewModel>
{
    public ShortCarModelViewModelValidator()
    {
        RuleFor(cm => cm.ManufacturerId)
            .NotEmpty().WithMessage("Car model should have a manufacturer");

        RuleFor(cm => cm.Name)
            .NotEmpty()
            .MaximumLength(30).WithMessage("Car model name length should not exceed 30 characters");
    }
}