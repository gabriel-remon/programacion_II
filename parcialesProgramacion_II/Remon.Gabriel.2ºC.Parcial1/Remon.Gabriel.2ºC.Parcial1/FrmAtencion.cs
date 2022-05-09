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

namespace Remon.Gabriel._2ºC.Parcial1
{
    public partial class FrmAtencion : Form
    {
        public FrmAtencion()
        {
            InitializeComponent();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            PersonalMedico medico = lstMedicos.SelectedItem as PersonalMedico;
            Paciente paciente = lstPacientes.SelectedItem as Paciente;

            if(medico != null && paciente !=null )
            {
                rtbInfoMedico.Clear();
                MessageBox.Show(((medico + paciente).ToString()), "Atencion Finalizada");
            }
            else
            {
                MessageBox.Show("Deve seleccionar un medico y un paciente para poder continuar", "Error de datos",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                lstMedicos.ClearSelected();
                lstPacientes.ClearSelected();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormParcial_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult salir = MessageBox.Show("¿Seguro que desea salir?", "Salir", 
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        
            if(salir == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FormAtencion_Load(object sender, EventArgs e)
        {
            lstMedicos.Items.Add(new PersonalMedico("Fede", "Dávila", new DateTime(1999, 12, 12), false));
            lstMedicos.Items.Add(new PersonalMedico("Esteban", "Prieto", new DateTime(1951, 11, 12), true));
            lstPacientes.Items.Add(new Paciente("Diego", "Cagna", new DateTime(1998, 6, 16), "Tigre"));
            lstPacientes.Items.Add(new Paciente("Alfredo", "Moreno", new DateTime(1989, 1, 21), "DF"));
            lstPacientes.Items.Add(new Paciente("Blas", "Giunta", new DateTime(1912, 12, 12), "La Boca"));
            lstPacientes.Items.Add(new Paciente("John Jairo", "Trelles", new DateTime(1978, 8, 30), "Medellín"));

        }

        private void lstMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lstMedicosAux = (ListBox)sender;
            Persona medico = lstMedicosAux.SelectedItem as PersonalMedico;

            rtbInfoMedico.Text = Persona.FichaPersona(medico);
        }
    }
}
