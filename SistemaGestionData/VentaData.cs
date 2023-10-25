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
    public class VentaData
    {
        static string connectionString = @"Server=DESKTOP-2903N9M\SQLEXPRESS;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
        #region Venta
        public static List<Venta> ListarVentas()
        {
            List<Venta> lista = new List<Venta>();
            
            string query = "SELECT Id,Comentarios,IdUsuario FROM Venta";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString)) /**Se establece una conexion  //ACA SE CREA la conexion
                                                                                      * con SQL en memoria con la cadena conecctionString**/
                {
                    conexion.Open();/**ACA SE ABRE la conexion**/

                    using (SqlCommand comando = new SqlCommand(query, conexion))/**Una vez que la conexion esta abierta 
                                                                                 * se crea en memoria el COMANDO 
                                                                                 * En este caso la query con la lista sql**/
                    {
                        //Una vez que se tiene el comando en memoria, se va a ejecutar atraves del comando ExecuteReader()
                        using (SqlDataReader dr = comando.ExecuteReader()) //Una vez ejecutado el comando,
                                                                           //este devolvera un OBJETO de tipo SqlDataReader
                                                                           //El cual es una lista de objetos
                                                                           //OSEA QUE desde SQL se trae un SELECT y se guarda en la lista (dr) el cual es de objetos

                        {
                            if (dr.HasRows)// ACA SE PREGUNTA SI ES QUE HAY FILAS
                            {//EN EL CASO QUE HAYA FILAS 
                                while (dr.Read()) //SE LEE FILA POR FILA
                                {

                                    var venta = new Venta();//SE CREA UN PRODUCTO U OBJETO
                                    /**A ESTE MISMO SE LE ASIGNA LO QUE VENGA EN EL READER DE LA COLIMNA QUE CORRESPONDA**/
                                    /**SE MAPEARA ENTIDAD**/
                                    venta.Id = Convert.ToInt32(dr["Id"]);/**SE ASIGNA LO QUE SE LEE DE LA COLUMNA QUE CORRESPONDA, A LA PROPIEDAD QUE CORRESPONDA DEL PRODUCTO**/
                                    venta.Comentarios = dr["Comentarios"].ToString();
                                    venta.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                    /**CUIDADO CON CONVERTIR LOS DATOS AL CORRESPONDIENTE**/

                                    /**FIN DE ENTIDAD MAPEADA**/
                                    lista.Add(venta);
                                }
                            }
                        }
                    }
                    /**OPCIONAL**/
                    conexion.Close();/**POR BUENA PRACTICA CIERRA EL OBJETO CONEXION**/
                }//CUANDO SE CIERRA LA LLAVE MUERE LA CONEXION
                return lista;/**RETORNA LA LISTA**/
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static Venta ObtenerVenta(int id)
        {
            Venta venta = new Venta();
            
            string query = "SELECT Id,Comentarios,IdUsuario FROM Venta Where Id=@Id"; //SE LE AGREGA UN WHERE

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open(); //SE ABRE CONEXION

                    using (SqlCommand comando = new SqlCommand(query, conexion)) /**EL COMANDO VA A SER LA query 
                                                                                  * Y OJO QUE TIENE UNA PARAMETRO
                                                                                  * Y SE LE PASA EL PARAMETRO LUEGO**/
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = id });
                        /**AL SE LE AGREGA UN PARAMETRO, ACA SE TIENE QUE LLAMAR Id, EL TIPO DE DATO ES UN ENTERO, **/

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    venta.Id = Convert.ToInt32(dr["Id"]);
                                    venta.Comentarios = dr["Comentarios"].ToString();
                                    venta.IdUsuario = Convert.ToInt32(dr["Idusuario"]);
                                }
                            }
                        }
                    }
                    // Opcional
                    conexion.Close();
                }
                return venta;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static void CrearVenta(Venta venta)
        {
            string query = "INSERT INTO Venta (Comentarios,IdUsuario)" +
                    " VALUES(@Comentarios, @IdUsuario); "; //select@@IDENTITY 
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = venta.IdUsuario });
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
        public static void ModificarVenta(Venta venta)
        {                              //El servido-----------------------LA BASE DE DATOS
            //string connectionString = @"Server=DESKTOP-2903N9M\SQLEXPRESS;DataBase=SistemaGestion;
                                       // Trusted_Connection=True";//ACA EL COMO SE VA A CONECTAR /En caso que no sea asi se debera con un usuario y contraseña 
            string query = "UPDATE Venta " +
                "SET Comentarios = @Comentarios, IdUsuario=@IdUsuario " +
                " WHERE Id = @Id"; //CONSULTA 

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))//Establece la conexion
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = venta.Id });
                        comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = venta.IdUsuario });
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
        public static void EliminarVenta(Venta venta)
        {
            string query = "DELETE FROM Venta" +
                            " WHERE Id = @Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = venta.Id });

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
