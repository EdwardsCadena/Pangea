using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Contrato.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratoController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            using (Models.edwardContext dn = new Models.edwardContext())
            {
                var lst = (from d in dn.VwContratos
                           select d).ToList();
                return Ok(lst);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] Models.Request.ContratoRequest model)
        {
            using (Models.edwardContext dn = new Models.edwardContext())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Nuevo_Contrato"))
                {
                    cmd.Parameters.Add(new SqlParameter("@ClienteId", model.Fk_IdCliente));
                    cmd.Parameters.Add(new SqlParameter("@ProductoId", model.Fk_IdProducto));
                    cmd.Parameters.Add(new SqlParameter("@FechaLicencia", model.Fecha_Licencia));
                    cmd.ExecuteNonQuery();
                    return Ok(cmd);
                } 
                                 
                
            }
        }

        [HttpDelete]
        public ActionResult Post(int id)
        {
            using (Models.edwardContext dn = new Models.edwardContext())
            {
                using (SqlCommand cmd = new SqlCommand("sp_Eliminar_Conmtrato"))
                {
                    cmd.Parameters.Add(new SqlParameter("@ContraID", id));
                    cmd.ExecuteNonQuery();
                    return Ok(cmd);
                }
            }
        }
    }
}
