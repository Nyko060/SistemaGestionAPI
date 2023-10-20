using SistemaGestionBussiness;
using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class frmVentaCrear : Form
    {
        public frmVentaCrear()
        {
            InitializeComponent();
        }
        private void frmProducto_Load(object sender, EventArgs e)
        {
            CargarVenta();
        }
        private void CargarVenta()
        {
            List<Venta> venta = VentaBussiness.ListarVentas();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = venta;
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            frmVentaAgregarProducto frmVentaAgregarProducto = new frmVentaAgregarProducto();
            frmVentaAgregarProducto.FormClosed += FrmVentaAgregarProducto_FormClosed;
            frmVentaAgregarProducto.ShowDialog();
        }
        private void FrmVentaAgregarProducto_FormClosed(object? sender, FormClosedEventArgs e)//Cuando el otro formulario
                                                                                              //se CIERRE vendra aca y ACTUALIZARA LA LISTA
        {
            CargarVenta();//Se hace lo mismo que en el load
        }
        private void frmVentaCrear_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }
        private void CargarVentas()
        {
            List<Venta> venta = VentaBussiness.ListarVentas();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = venta;
        }

    }
}
