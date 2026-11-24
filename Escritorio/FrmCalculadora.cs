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
    public partial class FrmCalculadora : Form
    {// Variables de cálculo
        private double primerNumero = 0;
        private string operacion = "";
        private bool esNuevaEntrada = true;

        // Variable para la memoria
        private double memoria = 0;

        // Instancia de tu clase de operadores
        private ClsOperacionesBasicas op = new ClsOperacionesBasicas();
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (esNuevaEntrada || txtPantalla.Text == "0")
            {
                txtPantalla.Text = btn0.Text;
                esNuevaEntrada = false;
            }
            else
            {
                txtPantalla.Text += btn0.Text;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (esNuevaEntrada || txtPantalla.Text == "1")
            {
                txtPantalla.Text = btn1.Text;
                esNuevaEntrada = false;
            }
            else
            {
                txtPantalla.Text += btn1.Text;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (esNuevaEntrada || txtPantalla.Text == "2")
            {
                txtPantalla.Text = btn2.Text;
                esNuevaEntrada = false;
            }
            else
            {
                txtPantalla.Text += btn2.Text;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (esNuevaEntrada || txtPantalla.Text == "3")
            {
                txtPantalla.Text = btn3.Text;
                esNuevaEntrada = false;
            }
            else
            {
                txtPantalla.Text += btn3.Text;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (esNuevaEntrada || txtPantalla.Text == "4")
            {
                txtPantalla.Text = btn4.Text;
                esNuevaEntrada = false;
            }
            else
            {
                txtPantalla.Text += btn4.Text;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (esNuevaEntrada || txtPantalla.Text == "5")
            {
                txtPantalla.Text = btn5.Text;
                esNuevaEntrada = false;
            }
            else
            {
                txtPantalla.Text += btn5.Text;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (esNuevaEntrada || txtPantalla.Text == "6")
            {
                txtPantalla.Text = btn6.Text;
                esNuevaEntrada = false;
            }
            else
            {
                txtPantalla.Text += btn6.Text;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (esNuevaEntrada || txtPantalla.Text == "7")
            {
                txtPantalla.Text = btn7.Text;
                esNuevaEntrada = false;
            }
            else
            {
                txtPantalla.Text += btn7.Text;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (esNuevaEntrada || txtPantalla.Text == "8")
            {
                txtPantalla.Text = btn8.Text;
                esNuevaEntrada = false;
            }
            else
            {
                txtPantalla.Text += btn8.Text;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (esNuevaEntrada || txtPantalla.Text == "9")
            {
                txtPantalla.Text = btn9.Text;
                esNuevaEntrada = false;
            }
            else
            {
                txtPantalla.Text += btn9.Text;
            }
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (btnPunto.Text == ".")
            {
                if (esNuevaEntrada)
                {
                    txtPantalla.Text = "0.";
                    esNuevaEntrada = false;
                    return;
                }
                if (!txtPantalla.Text.Contains("."))
                {
                    txtPantalla.Text += ".";
                }
                return;
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            Button btnSum = (Button)sender;

            if (double.TryParse(txtPantalla.Text, out primerNumero))
            {
                operacion = btnSum.Text;
                esNuevaEntrada = true;
            }
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            Button btnRes = (Button)sender;

            if (double.TryParse(txtPantalla.Text, out primerNumero))
            {
                operacion = btnRes.Text;
                esNuevaEntrada = true;
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            Button btnMult = (Button)sender;

            if (double.TryParse(txtPantalla.Text, out primerNumero))
            {
                operacion = btnMult.Text;
                esNuevaEntrada = true;
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Button btnDiv = (Button)sender;

            if (double.TryParse(txtPantalla.Text, out primerNumero))
            {
                operacion = btnDiv.Text;
                esNuevaEntrada = true;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtPantalla.Text, out double segundoNumero)) return;

            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = op.Sumar(primerNumero, segundoNumero);
                    break;
                case "-":
                    resultado = op.Restar(primerNumero, segundoNumero);
                    break;
                case "*":
                    resultado = op.Multiplicar(primerNumero, segundoNumero);
                    break;
                case "/":
                    if (segundoNumero == 0)
                    {
                        MessageBox.Show("No se puede dividir para cero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPantalla.Text = "0";
                        esNuevaEntrada = true;
                        return;
                    }
                    resultado = op.Dividir(primerNumero, segundoNumero);
                    break;
                default:
                    return;
            }

            txtPantalla.Text = resultado.ToString();
            primerNumero = resultado;
            esNuevaEntrada = true;
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (!esNuevaEntrada && txtPantalla.Text.Length > 0)
            {
                txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length - 1);
                if (txtPantalla.Text == "" || txtPantalla.Text == "-")
                {
                    txtPantalla.Text = "0";
                    esNuevaEntrada = true;
                }
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
            esNuevaEntrada = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
            primerNumero = 0;
            operacion = "";
            esNuevaEntrada = true;
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPantalla.Text, out double actual))
            {
                // Si hay una suma o resta previa, calcula el porcentaje del primer número
                if (operacion == "+" || operacion == "-")
                {
                    actual = primerNumero * (actual / 100.0);
                }
                else
                {
                    actual = actual / 100.0;
                }

                txtPantalla.Text = actual.ToString();
            }
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            double.TryParse(txtPantalla.Text, out memoria);
            esNuevaEntrada = true;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = memoria.ToString();
            esNuevaEntrada = true;
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            memoria = 0;
        }

        private void btnMplus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPantalla.Text, out double actual))
            {
                memoria += actual;
                esNuevaEntrada = true;
            }
        }

        private void btnMminus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPantalla.Text, out double actual))
            {
                memoria -= actual;
                esNuevaEntrada = true;
            }
        }
    }
    }
    
    

