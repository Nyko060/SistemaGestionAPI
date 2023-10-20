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
    public partial class frmAltaProducto : Form
    {
        public frmAltaProducto()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();//Crea el nuevo producto
            /**Luego se le asignan todo los valores del formulario que pone la persona**/
            producto.Descripciones = txtDescripcion.Text;
            producto.Costo = numCosto.Value;
            producto.PrecioVenta = numPrecio.Value;
            producto.Stock = numStock.Value;
            producto.IdUsuario = int.Parse(txtUsuario.Text);

            ProductoData.CrearProducto(producto);

            MessageBox.Show("Se Creo Producto correctamente");
        }

        private void frmAltaProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
