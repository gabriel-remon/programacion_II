using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicoC02__atrapame_si_puedes_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            int kilometros;
            int litros;

            try
            {
                if (txt_kilometros.Text == string.Empty || txt_Litros.Text == string.Empty)
                {
                    throw new ParametroVacioExeption("Error alguno de los dos parametros esta vacio");
                }
                kilometros = int.Parse(txt_kilometros.Text);
                litros = int.Parse(txt_Litros.Text);
                rtb_Mostrar.Text += $"Consumo de {kilometros}km / {litros} litros: {Calculadora.calcular(kilometros, litros)}";
            }
            catch(ParametroVacioExeption ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Error ingrese solo numeros");
            }
            catch(DivideByZeroException ex)
            {
                MessageBox.Show("Error Litros no puede ser 0");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
