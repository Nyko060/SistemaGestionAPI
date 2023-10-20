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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos frmProductos = new frmProductos();
            frmProductos.ShowDialog();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmVentaCrear frmVenta = new frmVentaCrear();
            frmVenta.ShowDialog();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmModificarUsuario frmModificarUsuario = new frmModificarUsuario();
            frmModificarUsuario.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            frmReportesVentas frmReportesVentas = new frmReportesVentas();
            frmReportesVentas.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmIniciarSesionPrincipal frmIniciarSesionPrincipal=new frmIniciarSesionPrincipal();
            frmIniciarSesionPrincipal.ShowDialog();
        }
    }
}
