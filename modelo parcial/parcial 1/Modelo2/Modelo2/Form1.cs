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

namespace Modelo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Vendedor vendedor = listBox1.SelectedItem as Vendedor;
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult salir = MessageBox.Show("texto", "titulo",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        
            if(salir == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
