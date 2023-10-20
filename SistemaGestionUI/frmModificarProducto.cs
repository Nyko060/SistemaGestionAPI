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
    public partial class frmModificarProducto : Form
    {
        public frmModificarProducto()
        {
            InitializeComponent();
        }

        private Producto _producto;//Se crea el objero producto donde se recibiran los datos



        public frmModificarProducto(Producto producto)
        {
            InitializeComponent();
            _producto = producto;
        }
        /**Aca se va a necesitar que el otro Formulario le pase el producto 
         *  PARA PODER MODIFICARLO  **/
        private void btnModificar_Click(object sender, EventArgs e)
        {
            /**SE TOMA EL PRODUCTO CON SUS ATRIBUTOS DECLARADO ARRIBA (_producto)
             Y se modificara con los datos que el usuario pone en la pantalla */
            _producto.Descripciones = txtDescripcion.Text;
            _producto.Costo = numCosto.Value;
            _producto.PrecioVenta = numPrecio.Value;
            _producto.Stock = numStock.Value;
            _producto.IdUsuario = int.Parse(txtUsuario.Text);

            ProductoData.ModificarProducto(_producto);

            MessageBox.Show("Se Modifico correctamente");
        }
        private void frmModificarProducto_Load(object sender, EventArgs e)
        {
            /**OSEA QUE CUANDO CARGA LA PANTALLA VAN A CARGAR LOS PRODUCTOS**/
            this.txtUsuario.Text = _producto.IdUsuario.ToString();
            this.txtDescripcion.Text = _producto.Descripciones;
            this.numCosto.Value = _producto.Costo;
            this.numPrecio.Value = _producto.PrecioVenta;
            this.numStock.Value = _producto.Stock;
        }
    }
}
