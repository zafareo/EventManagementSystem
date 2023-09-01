using Domain.Common;

namespace Domain.Entities;

public class Event : BaseAuditableEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual ICollection<ScheduledEvent> ScheduledEvents { get; set; }
}


