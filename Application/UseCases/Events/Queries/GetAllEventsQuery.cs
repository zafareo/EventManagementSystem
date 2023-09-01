using Application.Commons.Models;
using MediatR;

namespace Application.UseCases.Events.Queries;

public class GetAllEventsQuery : IRequest<PaginatedList<GetAllEventsQueryResponse>>
{
    public string? SearchingText { get; set; }
    public int PageNumber { get; init; } = 1;
    public int PageSize { get; init; } = 10;

}
