using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_delegado_I01
{
    public partial class FrmPrincipal : Form
    {
        FrmTestDelegados frmTest ;
        FrmMostrar frmMostrar ;
       // El_delegado_I01.FrmTestDelegados.DelegadoActualizar DelegadoActualizar ;
        
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar();  
            frmMostrar.MdiParent = this;
            frmTest = new FrmTestDelegados(frmMostrar.ActualizarNombre);
            frmTest.MdiParent = this;
           
        }

        private void testAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTest.Show();

            mostrarToolStripMenuItem.Enabled = true;
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar.Show();
        }
    }
}
