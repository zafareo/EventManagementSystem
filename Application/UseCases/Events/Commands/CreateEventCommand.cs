using MediatR;

namespace Application.UseCases.Events.Commands;

public class CreateEventCommand : IRequest<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }
}
