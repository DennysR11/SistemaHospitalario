using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Fecha
    {
        public int dia;
        public int Dia
        {
            get
            {
                return this.dia;
            }

            set
            {
                this.dia = 0;
            }
        }
        public String mes;
        public String Mes
        {
            get
            {
                return this.mes;
            }

            set
            {
                this.mes = " ";
            }
        }
        public int anio;
        public int Anio
        {
            get
            {
                return this.anio;
            }

            set
            {
                this.anio = 0;
            }
        }
    }
}
