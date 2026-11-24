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
    public partial class FrmBasica : Form
    {
        public FrmBasica()
        {
            InitializeComponent();
        }


        private void btnProcesar_Click(object sender, EventArgs e)
        {
            ClsOperacionesBasicas op = new ClsOperacionesBasicas();
            double a = Convert.ToDouble(txtN1.Text);
            double b = Convert.ToDouble(txtN2.Text);
            MessageBox.Show("El resultadod de la suma es igual a:" + op.Sumar(a, b).ToString() + "\n" +
                            "El resultadod de la resta es igual a:" + op.Restar(a, b).ToString() + "\n" +
                            "El resultadod de la multiplicacion es igual a:" + op.Multiplicar(a, b).ToString() + "\n" +
                            "El resultadod de la division es igual a:" + op.Dividir(a, b).ToString() + "\n");
        
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN1.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
