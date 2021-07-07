using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AmericanCheeseWebBacked.Models
{
    public partial class CrearProducto
    {
        public int IdCrearProducto { get; set; }
        public int IdProducto { get; set; }
        public int IdIngrediente { get; set; }
        public decimal CantidadIngrediente { get; set; }
        public decimal PrecioIngrediente { get; set; }

        public virtual Ingredientes IdIngredienteNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
       
    }
}
