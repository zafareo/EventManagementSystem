using MediatR;

namespace Application.UseCases.Customers.Commands;

public class CreateCustomerCommand : IRequest<Guid>
{
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
