using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "ListarVenta")] /**Con esto se le dice que es un GET**/ /**OK**/
        /**El que use este metodo **/
        public IEnumerable<Venta> Get() /**Para llamar este metodo se deve usar "GetClientes"**/
        {
            return VentaBussiness.ListarVentas().ToArray(); /**Luego devuelve el Array**/
        }/**ACA se puede agregar un TRY CATCH y si hay ERROR que devuelva un codigo especifico http, 
  * algo amistos al usuario comun**/

        [HttpDelete(Name = "EliminarVenta")]

        public void Delete([FromBody] Venta venta) /**Los parametros cuando se haga la invocacion 
                                * se deberan pasarar por el body y no en la URL**/
        {
            VentaBussiness.EliminarVenta(venta);
        }


        [HttpPut(Name = "ModificarVenta")] /**OK**/

        public void Put([FromBody] Venta venta)
        {
            VentaBussiness.ModificarVenta(venta);
        }



        [HttpPost(Name = "CrarVenta")]  
        public void Post([FromBody] Venta venta)
        {
            VentaBussiness.CrearVenta(venta);
        }
    }
}
