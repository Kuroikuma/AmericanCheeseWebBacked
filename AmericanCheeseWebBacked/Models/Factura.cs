using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AmericanCheeseWebBacked.Models
{
    public partial class Factura
    {
        public int IdFactura { get; set; }
        public int IdEmpleado { get; set; }
        public string Cliente { get; set; }
        public decimal? Total { get; set; }
        public DateTime? Fecha { get; set; }

        public virtual Empleado IdEmpleadoNavigation { get; set; }
    }
}
