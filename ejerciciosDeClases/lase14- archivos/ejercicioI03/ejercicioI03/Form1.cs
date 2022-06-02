using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ejercicioI03
{
    public partial class Form1 : Form
    {
        string pathGuardado;

        public Form1()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = "0 carcteres";
            pathGuardado = string.Empty;
            
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog arhivo = new SaveFileDialog())
            {
                arhivo.Filter = "Archivo e texto(*.txt)|*.txt|";
                if(arhivo.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(arhivo.FileName, richTextBox1.Text);
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            { 
                using (OpenFileDialog archivo = new OpenFileDialog())
                {
                    if (archivo.ShowDialog() == DialogResult.OK)
                    {
                        richTextBox1.Text = File.ReadAllText(archivo.FileName) + ".txt";
                    }
                }
            }
            catch(Exception ex)
            {
                ShowDialog();
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = richTextBox1.Text.Length.ToString() + " caracteres";
        }

        //private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
