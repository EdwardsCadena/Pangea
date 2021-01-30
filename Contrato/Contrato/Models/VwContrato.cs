using System;
using System.Collections.Generic;

#nullable disable

namespace Contrato.Models
{
    public partial class VwContrato
    {
        public int IdContrato { get; set; }
        public string IdentificacionCliente { get; set; }
        public int IdProducto { get; set; }
        public string Nombreproducto { get; set; }
        public string NombreContrato { get; set; }
        public string NumeroLicencia { get; set; }
        public string ClaveLicencia { get; set; }
        public DateTime? FechaLicencia { get; set; }
        public decimal? Precio { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    }
}
