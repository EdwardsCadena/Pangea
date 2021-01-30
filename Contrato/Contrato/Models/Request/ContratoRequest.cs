using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contrato.Models.Request
{
    public class ContratoRequest
    {
        public int IdContrato { get; set; }
        public int Fk_IdProducto { get; set; }
        public int Fk_IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Numero_Licencia { get; set; }
        public string Clave_Licencia { get; set; }
        public DateTime Fecha_Licencia { get; internal set; }
    }
}
