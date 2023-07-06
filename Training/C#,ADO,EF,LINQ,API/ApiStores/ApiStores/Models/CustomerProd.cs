using System;
using System.Collections.Generic;

namespace ApiStores.Models;

public partial class CustomerProd
{
    public int? CustomerId { get; set; }

    public string? ProductId { get; set; }

    public int? ProductQuatity { get; set; }

    public decimal? Cost { get; set; }

    public int ItemNo { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual ProductDatum? Product { get; set; }
}
