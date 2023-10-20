using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        /**Se le tiene que decir que verbo se usa**/
        [HttpGet(Name = "ListarUsuarios")] /**Con esto se le dice que es un GET**/ /**OK**/
        /**El que use este metodo **/
        public IEnumerable<Usuario> Get() /**Para llamar este metodo se deve usar "GetClientes"**/
        {
            return UsuarioBussiness.ListarUsuarios().ToArray(); /**Luego devuelve el Array**/
        }/**ACA se puede agregar un TRY CATCH y si hay ERROR que devuelva un codigo especifico http, 
        * algo amistos al usuario comun**/

        [HttpDelete(Name = "EliminarUsuario")]

        public void Delete([FromBody] Usuario usuario) /**Los parametros cuando se haga la invocacion 
                                * se deberan pasarar por el body y no en la URL**/
        {
            UsuarioBussiness.EliminarUsuario(usuario);
        }


        [HttpPut(Name = "ModificarUsuario")] /**OK**/

        public void Put([FromBody] Usuario usuario)
        {
            UsuarioBussiness.ModificarUsuario(usuario);
        }



        [HttpPost(Name = "CrarUsuario")]  /**OK**/
        public void Post([FromBody] Usuario usuario)
        {
            UsuarioBussiness.CrearUsuario(usuario);
        }

        [HttpPost("{nombreUsuario},{contraseña}")] /**Get o Post**/

        public ActionResult<Usuario> Getby(string nombreUsuario,string contraseña)
        {
            return UsuarioBussiness.ObtenerUsuario(nombreUsuario,contraseña);
        }
    }
}
