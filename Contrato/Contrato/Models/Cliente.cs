using System;
using System.Collections.Generic;

#nullable disable

namespace Contrato.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            ContratoServicios = new HashSet<ContratoServicio>();
        }

        public int IdCliente { get; set; }
        public int? FkRowId { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public bool? Estado { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }

        public virtual ICollection<ContratoServicio> ContratoServicios { get; set; }
    }
}
