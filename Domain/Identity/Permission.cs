using Domain.Common;
using System.Text.Json.Serialization;

namespace Domain.Identity;

public class Permission : BaseAuditableEntity
{
    public string Name { get; set; }
    [JsonIgnore]
    public virtual ICollection<Role>? Roles { get; set; }
}
