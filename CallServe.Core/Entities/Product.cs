using CallServe.Core.Entities.Base;

namespace CallServe.Core.Entities;

public partial class Product : BaseEntity
{
    public string? Code { get; set; }

    public string? Name { get; set; }
}
