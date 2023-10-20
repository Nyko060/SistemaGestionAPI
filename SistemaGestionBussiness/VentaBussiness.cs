using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public static class VentaBussiness
    {
        public static List<Venta> ListarVentas()
        {
            return VentaData.ListarVentas();
        }
        public static Venta ObtenerVenta(int id)
        {
            return VentaData.ObtenerVenta(id);
        }
        public static void CrearVenta(Venta venta)
        {
            VentaData.CrearVenta(venta);
        }
        public static void ModificarVenta(Venta venta)
        {
            VentaData.ModificarVenta(venta);
        }
        public static void EliminarVenta(Venta venta)
        {
            VentaData.EliminarVenta(venta);
        }

    }
}
