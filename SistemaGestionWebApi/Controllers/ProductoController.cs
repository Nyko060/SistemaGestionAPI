using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet(Name = "ListarProducto")]
        public IEnumerable<Producto> Get()
        {
            return ProductoBussiness.ListarProductos();
        }

        [HttpDelete(Name = "EliminarProducto")]
        public void Delete([FromBody] Producto Producto)
        {
            ProductoBussiness.EliminarProducto(Producto);
        }


        [HttpPut(Name = "ModificarProducto")]
        public void Put([FromBody] Producto producto)
        {
            ProductoBussiness.ModificarProducto(producto);
        }


        [HttpPost(Name = "CrearProducto")]

        public void Post([FromBody] Producto producto)
        {
            ProductoBussiness.CrearProducto(producto);
        }
    }
}
