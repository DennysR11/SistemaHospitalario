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
        public Medico() {
            Console.Write("\t\t\tDAROS PERSONALES\n\n");
            Pesona p = new Pesona();
            p.cedulaIdentidad = "1724977960";
            System.Console.WriteLine("Cedula de identidad : " + p.cedulaIdentidad);
            p.nombre = "Omar";
            System.Console.WriteLine("Nombre : " + p.nombre);
            p.apellido = "Vallejo";
            System.Console.WriteLine("Apellido : " + p.apellido);
            especialidad = "Oftalmologia";
            System.Console.WriteLine("Especialidad : " + especialidad);
            
        }

    }
}
