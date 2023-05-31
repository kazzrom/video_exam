using System;
using System.Collections.Generic;

namespace MiniShop_.NET_6.AppData;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public decimal Cost { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
