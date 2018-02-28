using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SJF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Proceso> misProcesos = new List<Proceso>();
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proceso miProceso = new Proceso();
            miProceso.Nombre = nom.Text;
            miProceso.Tiempo_procesos = (int)Math.Round(numeric_time.Value);
            miProceso.Estado = 0;
            misProcesos.Add(miProceso);
            listBox1.Items.Clear();
            for(int i=0; i<misProcesos.Count; i++)
            {
                listBox1.Items.Add(misProcesos[i].Nombre+"Tiempo:"+ misProcesos[i].Tiempo_procesos + "Estado"+ misProcesos[i].Estado);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
