using SistemaGestionBussiness;
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
    public partial class frmIniciarSesionPrincipal : Form
    {
        public frmIniciarSesionPrincipal()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.NombreUsuario = txtNombreUsuario.Text;
            usuario.Contraseña = txtContraseña.Text;
            if (UsuarioBussiness.ObtenerUsuario(usuario.NombreUsuario, usuario.Contraseña) == null) /**Si no es null entonces**/
            {
                MessageBox.Show("Error con los datos ingresados");

            }
            else
            {
                frmMenuPrincipal frmMenuPrincipal = new frmMenuPrincipal();
                frmMenuPrincipal.ShowDialog();
            }
        }

        private void frmIniciarSesionPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistroUsuario frmRegistroUsuario = new frmRegistroUsuario();
            frmRegistroUsuario.ShowDialog();
        }
    }
}
