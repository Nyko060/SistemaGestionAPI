using SistemaGestionBussiness;
using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections;
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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();

        }
        private void CargarProductos()
        {
            List<Producto> producto = ProductoBussiness.ListarProductos();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = producto;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmAltaProducto frmAltaProducto = new frmAltaProducto();
            frmAltaProducto.FormClosed += FrmAltaProducto_FormClosed;
            frmAltaProducto.ShowDialog();
        }
        private void FrmAltaProducto_FormClosed(object? sender, FormClosedEventArgs e)//Cuando el otro formulario
                                                                                      //se CIERRE vendra aca y ACTUALIZARA LA LISTA
        {
            CargarProductos();//Se hace lo mismo que en el load
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return; //Se asegura que estemos tocando algo dentro de la grilla 

            int Id = (int)this.dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            Producto producto = ProductoData.ListarProductos().Where(x => x.Id == Id).FirstOrDefault();


            if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                frmModificarProducto modificar = new frmModificarProducto(producto);
                modificar.FormClosed += FrmAltaProducto_FormClosed;
                modificar.ShowDialog();
            }
            else if (this.dataGridView1.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                frmEliminarProducto eliminar = new frmEliminarProducto(producto);
                eliminar.FormClosed += FrmAltaProducto_FormClosed;
                eliminar.ShowDialog();
            }
        }
    }
}
