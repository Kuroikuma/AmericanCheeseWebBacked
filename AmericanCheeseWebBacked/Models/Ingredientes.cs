using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AmericanCheeseWebBacked.Models
{
    public partial class Ingredientes
    {
        public Ingredientes()
        {
            CrearProducto = new HashSet<CrearProducto>();
        }

        public int IdIngrediente { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        public virtual ICollection<CrearProducto> CrearProducto { get; set; }
    }
}
