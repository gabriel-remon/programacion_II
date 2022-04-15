using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace TP1
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

        }
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = String.Empty;
            txtNumero2.Text = String.Empty;
            lblResultado.Text = String.Empty;
            cmbOperador.Text = String.Empty;
        }
        private void btnOperar_Click(object sender, EventArgs e)
        {

        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operandoNumero1 = new Operando(numero1);
            Operando operandoNumero2 = new Operando(numero2);

    

        }




    }
}
