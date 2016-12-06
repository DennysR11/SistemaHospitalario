using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Medico:Pesona
    {
        public String especialidad;
        public String Especialidad 
        {
            get
            {
                return this.especialidad;
            }

            set
            {
                this.especialidad = " ";
            }
        }
        public Receta receta;
        public Receta Receta
        {
            get
            {
                return this.receta;
            }

            set
            {
                this.receta = new Receta();
            }
        }
        public int oficina;
        public int Oficina
        {
            get
            {
                return this.oficina;
            }

            set
            {
                this.oficina = 0;
            }
        }
        

    }
}
