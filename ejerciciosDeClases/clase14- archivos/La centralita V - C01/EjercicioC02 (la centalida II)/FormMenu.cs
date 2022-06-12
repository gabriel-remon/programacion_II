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
    public partial class FormMenu : Form
    {
        Centralita centralita;
        

        public FormMenu()
        {
            centralita = new Centralita("Central telefonica");
            InitializeComponent();
        }

        private void btn_GenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLLamador llamador = new FrmLLamador(centralita);
            llamador.Show();
            centralita.OrdenarLlamadas();
            
        }

        private void btn_FacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralita);
            mostrar.TLlamada = TipoLlamada.Todas;
            mostrar.Show();
        }

        private void btn_FacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralita);
            mostrar.TLlamada = TipoLlamada.Local;
            mostrar.Show();

        }

        private void btn_FacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar mostrar = new FrmMostrar(centralita);
            mostrar.TLlamada = TipoLlamada.Provincial;
            mostrar.Show();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult salir = MessageBox.Show("Desea salir?", "Salir",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        
            if(salir == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show("Llamas realizadas: \n" + centralita.Leer());

            }
        }
    }
}
