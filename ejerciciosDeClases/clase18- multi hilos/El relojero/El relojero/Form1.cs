using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace El_relojero
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken token;

        public Form1()
        {
            InitializeComponent();
        }


        delegate void callback();
        public void ActualizarHora()
        {
            if(this.InvokeRequired)
            {
                Action d = new Action(this.ActualizarHora);
                this.Invoke(d);
            }
            else
            { 
                label1.Text = DateTime.Now.ToString();
            }

                
            
        }
        Task t;

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                while(true)
                {
                    Thread.Sleep(1000);
                    ActualizarHora();
                }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarHora();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Dispose();
        }
    }
}
