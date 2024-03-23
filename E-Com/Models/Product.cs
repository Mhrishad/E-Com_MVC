using System;
using System.Collections.Generic;

namespace E_Com.Models;

public partial class Product
{
    public long Id { get; set; }

    public long CategoryId { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? Details { get; set; }

    public sbyte? Status { get; set; }
}
