using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public static class UsuarioBussiness
    {
        public static List<Usuario> ListarUsuarios()
        {
            return UsuarioData.ListarUsuarios();
        }
        public static Usuario ObtenerUsuario(string nombreUsuario, string contraseña)
        {
            return UsuarioData.ObtenerUsuario(nombreUsuario,contraseña);
        }
        public static void CrearUsuario(Usuario usuario)
        {
            UsuarioData.CrearUsuario(usuario);
        }
        public static void ModificarUsuario(Usuario usuario)
        {   
            UsuarioData.ModificarUsuario(usuario);
        }
        public static void EliminarUsuario(Usuario usuario)
        {
            UsuarioData.EliminarUsuario(usuario);
        }
    }
}
