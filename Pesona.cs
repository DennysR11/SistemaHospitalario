using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pesona
    {
      public String nombre;
        public String Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = " ";
            }
        }
        public String apellido;
        public String Apellido
        {
            get
            {
                return this.apellido;
            }

            set
            {
                this.apellido =" ";
            }
        }
        public String cedulaIdentidad;
        public String CedulaIdentidad
        {
            get
            {
                return this.cedulaIdentidad;
            }

            set
            {
                this.cedulaIdentidad =" ";
            }
        }
        public Direccion direccion;
        public Direccion Direccion
        {
            get
            {
                return this.direccion;
            }

            set
            {
                this.direccion =new Direccion();
            }
        }
         public String numeroTelefonico;
        public String NumeroTelefonico
        {
            get
            {
                return this.numeroTelefonico;
            }

            set
            {
                this.numeroTelefonico = " ";
            }
        }
    


    }
}
