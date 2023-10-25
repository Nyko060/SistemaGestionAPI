using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;

namespace SistemaGestionData
{
    
    public class UsuarioData
    {
        static string connectionString = @"Server=DESKTOP-2903N9M\SQLEXPRESS;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
        #region Usuario
        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            
            string query = "SELECT Id,Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM Usuario";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    var usuario = new Usuario();

                                    usuario.Id = Convert.ToInt32(dr["Id"]);
                                    usuario.Nombre = dr["Nombre"].ToString();
                                    usuario.Apellido = dr["Apellido"].ToString();
                                    usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                                    usuario.Contraseña = dr["Contraseña"].ToString();
                                    usuario.Mail = dr["Mail"].ToString();

                                    lista.Add(usuario);

                                }
                            }
                        }
                    }
                    conexion.Close();
                }
                return lista;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public static Usuario ObtenerUsuario(string nombreUsuario,string contraseña)
        {
            Usuario usuario = new Usuario();
            
            string query = "SELECT Id,Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM Usuario Where NombreUsuario=@NombreUsuario AND Contraseña=@Contraseña"; /**Se utiliza el AND**/

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open(); //SE ABRE CONEXION

                    using (SqlCommand comando = new SqlCommand(query, conexion)) /**EL COMANDO VA A SER LA query 
                                                                                  * Y OJO QUE TIENE UNA PARAMETRO
                                                                                  * Y SE LE PASA EL PARAMETRO LUEGO**/
                    {
                        comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = nombreUsuario });
                        comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = contraseña });
                        //comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = id });
                        /**AL SE LE AGREGA UN PARAMETRO, ACA SE TIENE QUE LLAMAR Id, EL TIPO DE DATO ES UN ENTERO, **/

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    usuario.Id = Convert.ToInt32(dr["Id"]);
                                    usuario.Nombre = dr["Nombre"].ToString();
                                    usuario.Apellido = dr["Apellido"].ToString();
                                    usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                                    usuario.Contraseña = dr["Contraseña"].ToString();
                                    usuario.Mail = dr["Mail"].ToString();
                                }
                            }
                        }
                    }
                    // Opcional
                    conexion.Close();
                }
                if ((usuario.Contraseña != null)||(usuario.NombreUsuario!=null) )
                {
                    return usuario;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static Usuario ObtenerNombre(string nombreUsuario)
        {
            Usuario usuario = new Usuario();
            
            string query = "SELECT Id,Nombre,Apellido,NombreUsuario,Contraseña,Mail FROM Usuario Where NombreUsuario=@NombreUsuario"; /**Se utiliza el AND**/

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open(); //SE ABRE CONEXION

                    using (SqlCommand comando = new SqlCommand(query, conexion)) /**EL COMANDO VA A SER LA query 
                                                                                  * Y OJO QUE TIENE UNA PARAMETRO
                                                                                  * Y SE LE PASA EL PARAMETRO LUEGO**/
                    {
                        comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = nombreUsuario });
                        /**AL SE LE AGREGA UN PARAMETRO, ACA SE TIENE QUE LLAMAR Id, EL TIPO DE DATO ES UN ENTERO, **/

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    usuario.Nombre = dr["Nombre"].ToString();
                                }
                            }
                        }
                    }
                    // Opcional
                    conexion.Close();
                }
                if (usuario.Nombre != null)
                {
                    return usuario;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void CrearUsuario(Usuario usuario)
        {
            //double IdUsuario = 0;
            
            string query = "INSERT INTO USUARIO (Nombre,Apellido,NombreUsuario,Contraseña,Mail)" +
                    " VALUES(@Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail); "; //select@@IDENTITY
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                        comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                        comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                        comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                        comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });
                       
                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
                
            }
            catch (Exception ex)
            {
                throw;
            }
            //return IdUsuario;
        }
        public static void ModificarUsuario(Usuario usuario)
        {
            
            string query = "UPDATE USUARIO " +
                    " SET Nombre = @Nombre,Apellido=@Apellido,NombreUsuario=@NombreUsuario,Contraseña = @Contraseña,Mail=@Mail " +
                    "WHERE Id=@Id";//CONSULTA
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = usuario.Id });
                        comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                        comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                        comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                        comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                        comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });

                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public static void EliminarUsuario(Usuario usuario)
        {
            
            string query = "DELETE FROM Usuario WHERE Id=@Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {

                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = usuario.Id });

                        comando.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        #endregion
    }
}
