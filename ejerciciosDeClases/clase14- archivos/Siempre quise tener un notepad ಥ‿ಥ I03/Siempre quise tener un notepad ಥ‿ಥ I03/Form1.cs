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

namespace Siempre_quise_tener_un_notepad_ಥ‿ಥ_I03
{
    public partial class Form1 : Form
    {
        SaveFileDialog saveFileDialog;
        public Form1()
        {
            InitializeComponent();
            saveFileDialog = new SaveFileDialog();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "txt files (*.txt)|*.txt";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rtxtSalidaTexto.Text = File.ReadAllText(openFileDialog.FileName);
                }
            }
            
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(saveFileDialog.FileName))
            {
                using (StreamWriter archivo = new StreamWriter(saveFileDialog.FileName, true))
                {
                    archivo.WriteLine(rtxtSalidaTexto.Text);
                }
            }
            else
            {
                guardarComoToolStripMenuItem_Click(sender, e);
            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.Filter = "Archivo de texto |*.txt";
                saveFileDialog.ShowDialog();
                if (saveFileDialog.FileName != String.Empty)
                using (StreamWriter archivo = new StreamWriter(saveFileDialog.FileName))
                {
                    archivo.WriteLine(rtxtSalidaTexto.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+ex.StackTrace);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = $"{this.rtxtSalidaTexto.Text.Replace(" ",string.Empty).Length} Caracteres";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "0 Caracteres";
        }
    }
}
