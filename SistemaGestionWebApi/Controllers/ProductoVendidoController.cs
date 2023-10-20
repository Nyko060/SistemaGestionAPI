using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "ListarProductoVendido")]
        public IEnumerable<ProductoVendido> Get()
        {
            return ProductoVendidoBussiness.ListarProductosVendidos();
        }

        [HttpDelete(Name = "EliminarProductoVendido")]
        public void Delete([FromBody] ProductoVendido ProductoVendido)
        {
            ProductoVendidoBussiness.EliminarProductoVendido(ProductoVendido);
        }


        [HttpPut(Name = "ModificarProductoVendido")]
        public void Put([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.ModificarProductoVendi(productoVendido);
        }


        [HttpPost(Name = "CrearProductoVendido")]

        public void Post([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.CrearProductoVendido(productoVendido);
        }
    }
}
