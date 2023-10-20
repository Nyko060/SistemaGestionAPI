using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public static class ProductoBussiness
    {
        public static List<Producto> ListarProductos()
        {
            return ProductoData.ListarProductos();
        }
        public static Producto ObtenerProducto(int id)
        {
            return ProductoData.ObtenerProducto(id);
            
        }
        public static void CrearProducto(Producto producto)
        {
            ProductoData.CrearProducto(producto);
        }
        public static void ModificarProducto(Producto producto)
        {
            ProductoData.ModificarProducto(producto);
        }
        public static void EliminarProducto(Producto producto)
        {
            ProductoData.EliminarProducto(producto);
        }
    }
}
