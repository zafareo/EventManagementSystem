using MediatR;

namespace Application.UseCases.Reservations.Commands.CreateReservation;

public class CreateReservationCommand : IRequest<Guid>
{
    public Guid SeatId { get; set; }
    public Guid CustomerId { get; set; }
    public Guid ScheduledEventId { get; set; }
    public bool IsCancelled { get; set; } = false;
}
