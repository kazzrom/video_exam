using System;
using System.Collections.Generic;

namespace MiniShop_.NET_6.AppData;

public partial class Order
{
    public int Id { get; set; }

    public int ClientId { get; set; }

    public int ProductId { get; set; }

    public virtual Client Client { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;
}
