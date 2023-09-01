namespace Application.UseCases.Events.Queries;

public class GetAllEventsQueryResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
