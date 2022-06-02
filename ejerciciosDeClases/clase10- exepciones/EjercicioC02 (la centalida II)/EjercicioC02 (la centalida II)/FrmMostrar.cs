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
    public partial class FrmMostrar : Form
    {
        private Centralita centralita;
        private TipoLlamada tipoLlamada;
        public FrmMostrar(Centralita centralitaIngreso)
        {
            InitializeComponent();
            this.centralita= centralitaIngreso;
        }
       
        public TipoLlamada TLlamada
        {
            set
            {
                this.tipoLlamada= value;
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            switch(tipoLlamada)
            {
                case TipoLlamada.Local:
                    this.Text = "Facturacion Local";
                    this.rtb_Mostrar.Text = $"La facturacion total es {centralita.GananciaPorLocal}";
                    break;

                case TipoLlamada.Provincial:
                    this.Text = "Facturacion Provincial";
                    this.rtb_Mostrar.Text = $"La facturacion total es {centralita.GananciaPorProvincial}";
                    break;
                default:
                    this.Text = "Facturacion total";
                    this.rtb_Mostrar.Text = $"La facturacion total es {centralita.GananciaPorTotal}";
                    break;
            }

            this.rtb_Mostrar.Text += centralita.ToString();
        }
    }
}
