namespace Application.UseCases.Seats.Queries.EmptySeats;

public class GetAllEmptySeatsQueryResponse
{
    public Guid Id { get; set; }
    public Guid RowId { get; set; }
    public int Number { get; set; }
}
