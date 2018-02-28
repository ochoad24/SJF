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
    }
}
