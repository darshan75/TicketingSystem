using FluentValidation;
using TicketingSystemMongo.Models;

public class CreateTicketValidator : AbstractValidator<CreateTicketDto>
{
    public CreateTicketValidator()
    {
        RuleFor(x => x.Title)
            .NotEmpty().WithMessage("Title is required");

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("Description is required");

        RuleFor(x => x.Priority)
            .Must(p => new[] { "Low", "Medium", "High" }.Contains(p))
            .WithMessage("Invalid Priority");

        RuleFor(x => x.CreatedByUserId)
            .NotEmpty().WithMessage("User is required");
    }
}