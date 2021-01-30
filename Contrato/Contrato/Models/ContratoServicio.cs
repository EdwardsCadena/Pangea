using System;
using System.Collections.Generic;

#nullable disable

namespace Contrato.Models
{
    public partial class ContratoServicio
    {
        public int IdContrato { get; set; }
        public int? FkIdProducto { get; set; }
        public int? FkIdCliente { get; set; }
        public string Nombre { get; set; }
        public string NumeroLicencia { get; set; }
        public string ClaveLicencia { get; set; }
        public DateTime? FechaLicencia { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }

        public virtual Cliente FkIdClienteNavigation { get; set; }
        public virtual Producto FkIdProductoNavigation { get; set; }
    }
}
