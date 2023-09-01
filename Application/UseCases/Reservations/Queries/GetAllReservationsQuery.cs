using Application.Commons.Models;
using MediatR;

namespace Application.UseCases.Reservations.Queries;

public class GetAllReservationsQuery : IRequest<PaginatedList<GetAllReservationsQueryResponse>>
{
    public string? SearchingText { get; set; }
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;
}
