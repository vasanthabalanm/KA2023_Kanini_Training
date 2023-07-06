using System;
using System.Collections.Generic;

namespace APIProject.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public long? Phone { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<CustomerProd> CustomerProds { get; set; } = new List<CustomerProd>();
}
