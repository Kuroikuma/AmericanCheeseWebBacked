using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AmericanCheeseWebBacked.Models
{
    public partial class FacturaDetalle
    {
        public int IdProducto { get; set; }
        public int IdFactura { get; set; }
        public decimal CantidadVendido { get; set; }
        public decimal PrecioProducto { get; set; }
        public decimal Total { get; set; }
    }
}
