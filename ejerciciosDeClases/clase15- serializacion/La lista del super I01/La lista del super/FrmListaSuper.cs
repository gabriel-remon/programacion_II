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
using System.Xml;
using System.Xml.Serialization;

namespace La_lista_del_super
{
    public partial class FrmListaSuper : Form
    {
        public List<string> listaSupermercado;

        public FrmListaSuper()
        {
            InitializeComponent();
            this.listaSupermercado = new List<string>();
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmAltaModificacion nuevoProducto = new FrmAltaModificacion("AgregarObjeto", string.Empty, "Agregar");

            nuevoProducto.ShowDialog();

            if (nuevoProducto.DialogResult == DialogResult.OK)
            {
                this.listaSupermercado.Add(nuevoProducto.TextoObjeto);
                this.GuardarArchivo();
                this.CargarArchivo();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.lstObjetos.SelectedItems.Count != 0)
            {
                this.listaSupermercado.Remove(this.lstObjetos.SelectedItem.ToString());
                this.GuardarArchivo();
                this.CargarArchivo();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.lstObjetos.SelectedItems.Count != 0)
            {
                this.Modificar();
                this.GuardarArchivo();
                this.CargarArchivo();
            }
        }

        private void FrmListaSuper_Load(object sender, EventArgs e)
        {
            this.CargarArchivo();
        }

        public void GuardarArchivo()
        {
            string rutaDestino = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "listaSupermercado.xml";
            

            using (StreamWriter archivo = new StreamWriter(rutaDestino))
            {
                XmlSerializer serializador = new XmlSerializer(typeof(List<string>));

                serializador.Serialize(archivo, this.listaSupermercado);
            }
        }

        public void CargarArchivo()
        {
            string rutaDestino = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "listaSupermercado.xml";

            if (File.Exists(rutaDestino))
            {
                using (StreamReader archivo = new StreamReader(rutaDestino))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<string>));

                    listaSupermercado = serializador.Deserialize(archivo) as List<string>;

                    this.lstObjetos.DataSource = listaSupermercado;
                }
            }
        }

        private void Modificar()
        {
            FrmAltaModificacion nuevoProducto = new FrmAltaModificacion("MOdificar objeto", this.lstObjetos.SelectedItem.ToString(), "Modificar");

            nuevoProducto.ShowDialog();

            if (nuevoProducto.DialogResult == DialogResult.OK)
            {
                this.listaSupermercado.Remove(this.lstObjetos.SelectedItem.ToString());
                this.listaSupermercado.Add(nuevoProducto.TextoObjeto);
            }
        }
    }
}
