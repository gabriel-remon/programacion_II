using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_lista_del_super
{
    public partial class FrmAltaModificacion : Form
    {
        public string TextoObjeto
        {
            get
            {
                return this.txtObjeto.Text;
            }
        }

        public FrmAltaModificacion(string titulo, string producto, string confirmar)
        {
            InitializeComponent();

            this.btnConfirmar.Text = confirmar;
            this.Text = titulo;
            this.txtObjeto.Text = producto;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Confirmar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Cancelar();
        }

        private void txtObjeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                this.Confirmar();
            }
            if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                this.Cancelar();
            }

        }

        private void Confirmar()
        {
            if (this.txtObjeto.Text != String.Empty)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ingrese un producto");
            }
        }

        private void Cancelar()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
