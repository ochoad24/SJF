using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJF
{
    class Proceso
    {
        private string nombre;
        private int tiempo_procesos;
        private int estado;
        private int temp_restante;
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public int Tiempo_procesos
        {
            get
            {
                return tiempo_procesos;
            }

            set
            {
                tiempo_procesos = value;
            }
        }

        public int Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public int Temp_restante
        {
            get
            {
                return temp_restante;
            }

            set
            {
                temp_restante = value;
            }
        }
        //Metodo para calcular el tiempo_restaste
        public void tiempo_restante()
        {
            Temp_restante = Tiempo_procesos;
        }
    }
}
