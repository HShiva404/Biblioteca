using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class FrmLogincs : Form
    {
        public FrmLogincs()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            ClsAutenticacion login = new ClsAutenticacion();

            string user = txtUsuario.Text.Trim();
            string pass = txtClave.Text;

            if (login.Auntenticacion(user, pass))
            {
                MessageBox.Show("¡Bienvenido al sistema!", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Indica que la autenticación fue exitosa y cierra el diálogo
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClave.Clear();
                txtClave.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
