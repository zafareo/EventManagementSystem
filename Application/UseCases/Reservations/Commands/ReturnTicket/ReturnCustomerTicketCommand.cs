using MediatR;

namespace Application.UseCases.Reservations.Commands.ReturnTicket;

public class ReturnCustomerTicketCommand : IRequest<bool>
{
    public Guid ReservationId { get; set; }
}
