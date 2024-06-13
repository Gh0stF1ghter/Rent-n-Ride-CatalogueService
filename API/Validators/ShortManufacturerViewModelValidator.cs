using API.ViewModels.ShortViewModels;
using FluentValidation;

namespace API.Validators;

public class ShortManufacturerViewModelValidator : AbstractValidator<ShortManufacturerViewModel>
{
    public ShortManufacturerViewModelValidator()
    {
        RuleFor(cm => cm.Name)
            .NotEmpty()
            .MaximumLength(30).WithMessage("Car model name length should not exceed 30 characters");
    }
}