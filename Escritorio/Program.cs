using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Mostrar primero el formulario de autenticación
            using (FrmLogincs login = new FrmLogincs())
            {
                // Solo si el usuario se autenticó correctamente (DialogResult.OK)
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // 2. Inicia la aplicación en el formulario principal MDI
                    Application.Run(new FrmPrincipal());
                }
                else
                {
                    // Si cerró la ventana o hizo clic en Salir, la aplicación termina
                    Application.Exit();
                }
            }
        }
    }
}
