using Microsoft.AspNetCore.Connections.Features;
using Microsoft.AspNetCore.Diagnostics;
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

        [HttpGet("{nombreUsuario},{contraseña}")] /**Validacion de Usuario y Contraseña en caso error de uno se muestra 
                                                   * (204) significa que el servidor ha procesado con éxito la solicitud, pero no va a devolver ningún contenido**/

        public ActionResult<Usuario> Getby(string nombreUsuario,string contraseña)
        {
            return UsuarioBussiness.ObtenerUsuario(nombreUsuario, contraseña); //Ok
        }

        [HttpGet("{nombreUsuario}")] /**Validacion de Usuario y Contraseña en caso error de uno se muestra 
                                                   * (204) significa que el servidor ha procesado con éxito la solicitud, pero no va a devolver ningún contenido**/
        public ActionResult<Usuario> Getby(string nombreUsuario) /**Obtener el Nombre mediante el ingreso del nombre de Usuario en caso de no estar 204**/
        {
            return UsuarioBussiness.ObtenerNombre(nombreUsuario); //Ok
        }


    }
}
