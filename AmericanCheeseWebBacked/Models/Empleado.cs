using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AmericanCheeseWebBacked.Models
{
    public partial class Empleado
    {
        public Empleado()
        {
            Factura = new HashSet<Factura>();
        }

        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public virtual ICollection<Factura> Factura { get; set; }
    }
}
