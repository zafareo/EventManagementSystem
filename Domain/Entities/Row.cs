using Domain.Common;

namespace Domain.Entities;

public class Row : BaseAuditableEntity
{
    public Guid VenueId { get; set; }
    public int Number { get; set; }
    public int SeatsEachRow { get; set; }
    public virtual Venue Venue { get; set; }
}
