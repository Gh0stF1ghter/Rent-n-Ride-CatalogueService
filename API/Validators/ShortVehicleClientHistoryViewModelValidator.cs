using API.ViewModels.ShortViewModels;
using FluentValidation;

namespace API.Validators;

public class ShortVehicleClientHistoryViewModelValidator : AbstractValidator<ShortVchViewModel>
{
    public ShortVehicleClientHistoryViewModelValidator()
    {
        RuleFor(vch => vch.StartDate)
            .NotEmpty();

        RuleFor(vch => vch.EndDate)
            .GreaterThan(vch => vch.StartDate).WithMessage("End date cannot be less than start date");

        RuleFor(cm => cm.VehicleId)
            .NotEmpty().WithMessage("Car model should have a manufacturer");

        RuleFor(cm => cm.ClientId)
            .NotEmpty().WithMessage("Car model should have a manufacturer");
    }
}