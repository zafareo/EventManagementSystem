namespace Application.UseCases.Seats.Queries.AllSeats
{
    public class GetAllSeatsQueryResponse
    {
        public Guid Id { get; set; }
        public Guid RowId { get; set; }
        public int Number { get; set; }
    }
}
