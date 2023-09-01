using FluentValidation;

namespace Application.UseCases.Events.Commands;

public class CreateEventCommandValidation : AbstractValidator<CreateEventCommand>
{
    public CreateEventCommandValidation()
    {
        RuleFor(_event => _event.Description).NotEmpty().MinimumLength(3).MaximumLength(200);
        RuleFor(_event => _event.Name).NotEmpty().MinimumLength(3).MaximumLength(50).
            WithMessage("Name should not be null, enter the name at least with 3 and max 50 characters ");
    }
}
