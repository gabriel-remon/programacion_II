using System.Windows.Forms;
using System;
using System.Collections;
using System.IO;

namespace Presentacion
{
    public partial class FrmIdentificacionComputadora : Form
    {
        public FrmIdentificacionComputadora()
        {
            InitializeComponent();
        }

        private void FrmIdentificacionComputadora_Load(object sender, System.EventArgs e)
        {
            this.Text = $"Compu de {Environment.UserName}";
            this.ConfigurarLogoSistemaOperativo();
            this.lblSistemaOperativo.Text = $"Sistema operativo: {Environment.OSVersion} ";
            this.lblNombreMaquina.Text = $"Nombre de la maquina: {Environment.MachineName}";
            ConfigurarArquitectura();
            this.lblCantProcesadores.Text = $"Cant. procesadores: {Environment.ProcessorCount}";
            this.lblDirectorioActual.Text = $"Identificación ejecutada en: {Environment.NewLine} {Environment.CurrentDirectory}";
            this.ConfigurarEspacioTotalYDisponible();
        }

        private void ConfigurarLogoSistemaOperativo()
        {
            if(OperatingSystem.IsWindows())
            {
                this.picboxSistemaOperativo.Image=Properties.Resources.windows;
            }
            if (OperatingSystem.IsMacOS())
            {
                this.picboxSistemaOperativo.Image=Properties.Resources.linux;
            }
            if (OperatingSystem.IsLinux())
            {
                this.picboxSistemaOperativo.Image=Properties.Resources.mac;
            }
        }
        private void ConfigurarArquitectura()
        {
            if(Environment.Is64BitOperatingSystem)
            {
                this.lblArquitectura.Text = "Arquitectura: 64 bits";
            }
            else
            {
                this.lblArquitectura.Text = "Arquitectura: 32 bits";

            }
        }

        private void ConfigurarEspacioTotalYDisponible()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            long TotalEspacio=0;
            long TotalEspacioDisponible=0;

            foreach(DriveInfo unDrive in drives)
            {
                if(unDrive.IsReady)
                {
                    TotalEspacio = TotalEspacio + unDrive.TotalSize;
                    TotalEspacioDisponible= TotalEspacioDisponible + unDrive.TotalFreeSpace;
                }
            }

            this.lblEspacioDisponible.Text = $"Espacio total: {TotalEspacio/ 1073741824} Gigabytes"; 
            this.lblEspacioTotal.Text = $"Espacio total: {TotalEspacioDisponible/ 1073741824} Gigabytes";
        }
    }
}
