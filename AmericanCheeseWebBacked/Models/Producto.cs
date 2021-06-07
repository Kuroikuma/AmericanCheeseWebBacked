using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AmericanCheeseWebBacked.Models
{
    public partial class Producto
    {
        public Producto()
        {
            CrearProducto = new HashSet<CrearProducto>();
        }

        public int IdProducto { get; set; }
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public decimal? Precio { get; set; }
        public decimal? Tamaño { get; set; }
        public string Imagen {get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual ICollection<CrearProducto> CrearProducto { get; set; }
    }
}
