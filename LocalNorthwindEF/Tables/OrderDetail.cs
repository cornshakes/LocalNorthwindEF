﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace LocalNorthwindEF.Tables;

public partial class OrderDetail
{
    public int OrderId { get; set; }

    public int ProductId { get; set; }

    public double UnitPrice { get; set; }

    public int Quantity { get; set; }

    public double Discount { get; set; }

    public virtual Order Order { get; set; }

    public virtual Product Product { get; set; }
}