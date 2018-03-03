using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
namespace SJF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Proceso> misProcesos = new List<Proceso>();
        string Estado;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Este es el timer que empiza a contar desde el principio
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 100;
            progressBar1.Maximum = 10;
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //En este boton se agrega un nuevo proceso al agregar un nuevo proceso se crea una variable de tipo de la clase Proceso
            //Se obtienen los datos de cada campo
            Proceso miProceso = new Proceso();
            miProceso.Nombre = nom.Text;
            miProceso.Tiempo_procesos = (int)Math.Round(numeric_time.Value);
            miProceso.Estado = 0;
            miProceso.tiempo_restante();
            //Se agrega a la lista enlazada un elemento de tipo proceso
            misProcesos.Add(miProceso);
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            //En este evento agreguen las condiciones y todo ya que se siempre se esta ejecutando
            if (misProcesos.Count() > 0)
            {
                //Variable de la clase Proceso para guardar que proceso se va a ejecutar
                Proceso enEjecucion = new Proceso();
                Proceso Ant = new Proceso();
                //Este linea ordena la lista ascendentemente
                Ant = misProcesos[0];
                misProcesos = misProcesos.OrderBy(Ord => Ord.Tiempo_procesos).ToList();
                enEjecucion = misProcesos[0];
                if (misProcesos.Count() > 1)
                {
                    if(Ant.Nombre!=misProcesos[0].Nombre)
                    {
                        misProcesos[1].Estado = 2;
                    }
                }
                textBox1.Text = enEjecucion.Nombre;
                textBox2.Text = enEjecucion.Temp_restante.ToString();
                misProcesos[0].Estado = 1;
                
            }
            //Se limpia el list box
            listBox1.Items.Clear();
            foreach (Proceso Temp in misProcesos)
            {
                if (Temp.Estado == 0)
                    Estado = "En Espera...";
                if (Temp.Estado == 1)
                    Estado = "En Ejecucion";
                if (Temp.Estado == 2)
                    Estado = "Pausa";
                listBox1.Items.Add(string.Format("{0} Tiempo: {1} Estado: {2} {3}", Temp.Nombre, Temp.Tiempo_procesos, Estado, Temp.Temp_restante));
            }
        }
    }
}
