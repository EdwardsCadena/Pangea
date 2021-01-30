using System;
using System.Collections.Generic;

#nullable disable

namespace Contrato.Models
{
    public partial class Producto
    {
        public Producto()
        {
            ContratoServicios = new HashSet<ContratoServicio>();
        }

        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal? Precio { get; set; }
        public double? Iva { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }

        public virtual ICollection<ContratoServicio> ContratoServicios { get; set; }
    }
}
