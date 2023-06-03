using System;
using System.Collections.Generic;

namespace CallServe.Core.Entities;

public partial class Product
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public long? CreatedUserId { get; set; }

    public long? UpdatedUserId { get; set; }
}
