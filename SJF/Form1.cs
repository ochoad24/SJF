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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //En este boton se agrega un nuevo proceso al agregar un nuevo proceso se crea una variable de tipo de la clase Proceso
            //Se obtienen los datos de cada campo
            Proceso miProceso = new Proceso();
            miProceso.Nombre = nom.Text;
            miProceso.Tiempo_procesos = (int)Math.Round(numeric_time.Value);
            miProceso.Estado = 0;
            //Se agrega a la lista enlazada un elemento de tipo proceso
            misProcesos.Add(miProceso);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //En este evento agreguen las condiciones y todo ya que se siempre se esta ejecutando
            //Enseñando a Dany
            //Se limpia el list box
            listBox1.Items.Clear();
            //Este linea ordena la lista ascendentemente
            misProcesos = misProcesos.OrderBy(Ord=>Ord.Tiempo_procesos).ToList();
            foreach (Proceso Temp in misProcesos)
            {   
                if (Temp.Estado == 0)
                    Estado = "En Espera...";
                listBox1.Items.Add(Temp.Nombre + " Tiempo: " + Temp.Tiempo_procesos + " Estado: " + Estado);
            }
        }
    }
}
