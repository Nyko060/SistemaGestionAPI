using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class frmEliminarProducto : Form
    {
        public frmEliminarProducto()
        {
            InitializeComponent();
        }


        private Producto _producto;//Se crea el objero producto donde se recibiran los datos

        public frmEliminarProducto(Producto producto)
        {
            InitializeComponent();
            _producto = producto;
        }

        private void frmEliminarProducto_Load(object sender, EventArgs e)
        {
            /**OSEA QUE CUANDO CARGA LA PANTALLA VAN A CARGAR LOS PRODUCTOS**/
            this.txtUsuario.Text = _producto.IdUsuario.ToString();
            this.txtDescripcion.Text = _producto.Descripciones;
            this.numCosto.Value = _producto.Costo;
            this.numPrecio.Value = _producto.PrecioVenta;
            this.numStock.Value = _producto.Stock;
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProductoData.EliminarProducto(_producto);/**SE ELIMINA EL PRODUCTO 
                                                  * USANDO EL METODO QUE ESTA EN CONTEXTO**/
            MessageBox.Show("Se elimino correctamente");
        }
    }
}
