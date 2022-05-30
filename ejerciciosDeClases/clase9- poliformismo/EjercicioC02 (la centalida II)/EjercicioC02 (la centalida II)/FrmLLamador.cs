using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace EjercicioC02__la_centalida_II_
{
    public partial class FrmLLamador : Form
    {
        
        Centralita centralida;
        Random random = new Random();
        public FrmLLamador(Centralita entrada)
        {
            InitializeComponent();
            this.centralida = entrada;
        }


        private void FrmLLamador_Load(object sender, EventArgs e)
        {

            cmbFranja.DataSource = Enum.GetValues(typeof(Franja));
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNumeroDestino.Text += "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txtNumeroDestino.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txtNumeroDestino.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txtNumeroDestino.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txtNumeroDestino.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txtNumeroDestino.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txtNumeroDestino.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txtNumeroDestino.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txtNumeroDestino.Text += "9";
        }

        private void btn_asterisco_Click(object sender, EventArgs e)
        {
            txtNumeroDestino.Text += "*";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txtNumeroDestino.Text += "0";
        }

        private void btn_numeral_Click(object sender, EventArgs e)
        {
            txtNumeroDestino.Text += "#";
        }

        private void txtNumeroDestino_TextChanged(object sender, EventArgs e)
        {
       
            if(txtNumeroDestino.Text.Length == 1)
            if (txtNumeroDestino.Text[0] == '#')
            {
                cmbFranja.Enabled = true;
            }
        }

        private void btn_Llamar_Click(object sender, EventArgs e)
        {
            Franja franja;
            //Random random = new Random();
            Llamada nuevaLlamada;

            float duracion = (float) random.Next(1, 50);
            float costo = (float)random.Next(5, 56) / 10;

            Enum.TryParse<Franja>(cmbFranja.SelectedValue.ToString(), out franja);

            if (txtNumeroDestino.Text.Length >= 8 && txtNumeroOrigen.Text.Length >= 8)
            {
                if (txtNumeroDestino.Text[0] == '#')
                {
                    nuevaLlamada = new Provincial(txtNumeroOrigen.Text, franja, duracion, txtNumeroDestino.Text);
                }
                else
                {
                    nuevaLlamada = new Local(txtNumeroOrigen.Text, duracion, txtNumeroDestino.Text, costo);
                }

                MessageBox.Show("LLamada generada");
                centralida += nuevaLlamada;

                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese el numero de origen y de destino (minimo 8 caracteres)");
            }

        
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txtNumeroDestino.Text = String.Empty;
            txtNumeroOrigen.Text = String.Empty;
            cmbFranja.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLLamador_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult salir = MessageBox.Show("Seguro que desea salir?", "Salir",
                                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(salir == DialogResult.No)
            {
                e.Cancel = true;
            }
        
        }
    }
}
