using System;
using System.Collections.Generic;

namespace WinFormsApp8.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }

    public int? Count { get; set; }

    public decimal? Amount { get; set; }

    public int IdProd { get; set; }

    public int IdCust { get; set; }

    public virtual Customer IdCustNavigation { get; set; } = null!;

    public virtual Product IdProdNavigation { get; set; } = null!;
}
