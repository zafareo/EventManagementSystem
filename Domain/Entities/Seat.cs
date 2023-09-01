﻿using Domain.Common;

namespace Domain.Entities;

public class Seat :BaseAuditableEntity
{
    public Guid RowId { get; set; }
    public int Number { get; set; }
    public virtual Row Row { get; set; }
    public virtual ICollection<Reservation> Reservations { get; set; }
}
