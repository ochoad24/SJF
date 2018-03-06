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
        private int tiempo;
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

        public int Tiempo
        {
            get
            {
                return tiempo;
            }

            set
            {
                tiempo = value;
            }
        }

        //Metodo para calcular el tiempo_restante
        public int tiempo_restante(int Corriendo, int Total)
        {
            int Resultado;
             Resultado= Total-(Corriendo/10);
            return Resultado;
        }
    }
}
