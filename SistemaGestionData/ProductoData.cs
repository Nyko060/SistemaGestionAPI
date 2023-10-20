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
    public class ProductoData
    {
        #region Producto
        public static List<Producto> ListarProductos() /**ESTO DEVUELVE UNA LISTA DE OBJETOS**/
        {
            List<Producto> lista = new List<Producto>();/**SE CREA UNA INSTANCIA DE LA LISTA PARA PODER DEVOLVER LA MISMA se retorna en la 67**/
            /**---------------CADENA DE CONEXION--------------------------------------**/
            string connectionString = @"Server=DESKTOP-2903N9M\SQLEXPRESS;DataBase=SistemaGestion;
                                        Trusted_Connection=True"; /**<----Forma de conectarse**/
            string query = "SELECT Id,Descripciones,Costo,PrecioVenta,Stock,IdUsuario FROM Producto"; //CONSULTA SQL

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

                                    var producto = new Producto();//SE CREA UN PRODUCTO U OBJETO
                                    /**A ESTE MISMO SE LE ASIGNA LO QUE VENGA EN EL READER DE LA COLIMNA QUE CORRESPONDA**/
                                    /**SE MAPEARA ENTIDAD**/
                                    producto.Id = Convert.ToInt32(dr["Id"]);/**SE ASIGNA LO QUE SE LEE DE LA COLUMNA QUE CORRESPONDA, A LA PROPIEDAD QUE CORRESPONDA DEL PRODUCTO**/
                                    producto.Descripciones = dr["Descripciones"].ToString();
                                    producto.Costo = Convert.ToDecimal(dr["Costo"]);
                                    producto.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
                                    producto.Stock = Convert.ToInt32(dr["Stock"]);
                                    producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                    /**CUIDADO CON CONVERTIR LOS DATOS AL CORRESPONDIENTE**/

                                    /**FIN DE ENTIDAD MAPEADA**/
                                    lista.Add(producto);
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
                return null;
            }


        } //Es public ya que sera llamdo desde Form1
        public static Producto ObtenerProducto(int id)
        {
            Producto producto = new Producto();
            string connectionString = @"Server=DESKTOP-2903N9M\SQLEXPRESS;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
            string query = "SELECT Id,Descripciones,Costo,PrecioVenta,Stock,IdUsuario FROM Producto Where Id=@Id"; //SE LE AGREGA UN WHERE

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
                                    producto.Id = Convert.ToInt32(dr["Id"]);
                                    producto.Descripciones = dr["Descripciones"].ToString();
                                    producto.Costo = Convert.ToDecimal(dr["Costo"]);
                                    producto.PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"]);
                                    producto.Stock = Convert.ToInt32(dr["Stock"]);
                                    producto.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                }
                            }
                        }
                    }

                    // Opcional
                    conexion.Close();
                }
                return producto;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static void CrearProducto(Producto producto)/**METODO AL CUAL SE LE PASA EL PRODUCTO**/
        {
            string connectionString = @"Server=DESKTOP-2903N9M\SQLEXPRESS;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
            string query = "INSERT INTO PRODUCTO (Descripciones,Costo,PrecioVenta,Stock,IdUsuario)" + /**INSERT**/
                            "VALUES(@Descripciones,@Costo,@PrecioVenta,@Stock,@IdUsuario);";
            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString)) /**SE GENERA LA CONEXION**/
                {
                    conexion.Open();/**SE ABRE LA CONEXION**/
                    using (SqlCommand comando = new SqlCommand(query, conexion)) /**SE GENERA EL COMANDO**/
                    {   //se puede determinar si es Procedimiento,Tabla o Consulta.
                        //comando.CommandType = CommandType.Text; //CommandType TIENE 3 POSIBLES VALORES
                        /**SI SE USA UNA query EL QUE VALE ES Text, EN CASO DE QUE SE USE UN .StoredProcedure, SE PONDRA CommandType.StoreProcedure
                         * ENTONCES EN ARRIBA EN VEZ DE PONER IN INSERT SE TENDRA QUE PONER EL NOMBRE DE UN STOREPROCEDURE
                         * Y ACA ABAJO LOS PARAMETROS QUE TIENE ESE MISMO STOREPROCEDURE**/
                        /**TAMBIEN SE PUEDE PONER CommandType.TablesDirect PARA PODER TRAERTE DIRECTAMENTE LA TABLA
                         * ENTOCES ARRIBA SE PONE EL NOMBRE DE UNA TABLA, ESO TE TRAE TODAS LA COLUMNAS DE LA TABLA**/
                        comando.Parameters.Add(new SqlParameter("Descripciones",SqlDbType.VarChar) { Value = producto.Descripciones });
                        comando.Parameters.Add(new SqlParameter("Costo",SqlDbType.Decimal) { Value = producto.Costo });
                        comando.Parameters.Add(new SqlParameter("PrecioVenta",SqlDbType.Decimal) { Value = producto.PrecioVenta });
                        comando.Parameters.Add(new SqlParameter("Stock",SqlDbType.BigInt) { Value = producto.Stock });
                        comando.Parameters.Add(new SqlParameter("IdUsuario",SqlDbType.BigInt) { Value = producto.IdUsuario });
                        /**SE LE AGREGAN LOS PARAMETRO AL COMANDO**/
                        comando.ExecuteReader();/**SE EJECUTA EL COMANDO**/
                        /**ACA EN VEZ DE USAR .ExecuteReader(), se usa NonQuery() , ya que se podria utilizar 
                         * para traer la cantidad de actualizaciones que se hicieron en la base de datos.
                         * Esto te sirve cuando tenes que hacer actualizaciones masivas. A profundiar...**/
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void ModificarProducto(Producto producto)
        {                              //El servido-----------------------LA BASE DE DATOS
            string connectionString = @"Server=DESKTOP-2903N9M\SQLEXPRESS;DataBase=SistemaGestion;
                                        Trusted_Connection=True";//ACA EL COMO SE VA A CONECTAR /En caso que no sea asi se debera con un usuario y contraseña 
            string query = "UPDATE Producto " +
                "SET Descripciones = @Descripciones ,Costo = @Costo, PrecioVenta = @PrecioVenta," +
                "Stock = @Stock, IdUsuario=@IdUsuario " +
                " WHERE Id = @Id"; //CONSULTA 

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))//Establece la conexion
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = producto.Id });

                        comando.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.Descripciones });
                        comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = producto.Costo });
                        comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Decimal) { Value = producto.Stock });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });

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
        public static void EliminarProducto(Producto producto)
        {
            string connectionString = @"Server=DESKTOP-2903N9M\SQLEXPRESS;DataBase=SistemaGestion;
                                        Trusted_Connection=True";
            string query = "DELETE FROM Producto" +
                            " WHERE Id = @Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = producto.Id });

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
