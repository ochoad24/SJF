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
            miProceso.Temp_restante = 0;
            //Se agrega a la lista enlazada un elemento de tipo proceso
            misProcesos.Add(miProceso);
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
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
                Temp.Tiempo = Temp.tiempo_restante(Temp.Temp_restante, Temp.Tiempo_procesos);
                listBox1.Items.Add(string.Format("{0} Tiempo: {1} Estado: {2}", Temp.Nombre, Temp.Tiempo_procesos, Estado));
            }
            if (misProcesos.Count() == 0)
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
            //En este evento agreguen las condiciones y todo ya que se siempre se esta ejecutando
            if (misProcesos.Count() > 0)
            {
                //Variable de la clase Proceso para guardar que proceso se va a ejecutar
                Proceso enEjecucion = new Proceso();
                Proceso Ant = new Proceso();
                //Este linea ordena la lista ascendentemente
                Ant = misProcesos[0];
                misProcesos = misProcesos.OrderBy(Ord => Ord.Tiempo).ToList();
                if (misProcesos.Count() > 1)
                {
                    if (Ant.Nombre != misProcesos[0].Nombre)
                    {
                        misProcesos[1].Estado = 2;
                        misProcesos[1].Temp_restante = progressBar1.Value;
                    }
                }
                enEjecucion = misProcesos[0];
                textBox1.Text = enEjecucion.Nombre;
                textBox2.Text = enEjecucion.Tiempo.ToString();
                misProcesos[0].Estado = 1;
                if (enEjecucion.Estado == 1)
                {
                    progressBar1.Maximum = enEjecucion.Tiempo_procesos * 10;
                    progressBar1.Value = misProcesos[0].Temp_restante;
                    if (progressBar1.Value != enEjecucion.Tiempo_procesos * 10)
                    {
                        progressBar1.Value++;
                        misProcesos[0].Temp_restante = progressBar1.Value;
                    }
                    else
                    {
                        progressBar1.Value = 0;
                        enEjecucion.Estado = 3;
                    }
                }
                if (enEjecucion.Estado == 3)
                {
                    misProcesos.RemoveAt(0);
                }
            }
        }
    }
}
