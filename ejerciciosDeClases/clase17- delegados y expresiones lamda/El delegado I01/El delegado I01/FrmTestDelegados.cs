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
    public partial class FrmTestDelegados : Form
    {
        public delegate void DelegadoActualizar(string nombre);
        DelegadoActualizar delegadoActualizar;

        public FrmTestDelegados(DelegadoActualizar delegadoActualizar)
        {
            InitializeComponent();
            this.delegadoActualizar = delegadoActualizar;
        }        

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            delegadoActualizar.Invoke(txtNombre.Text);
        }

        private void FrmTestDelegados_Load(object sender, EventArgs e)
        {
            
        }
    }
}
