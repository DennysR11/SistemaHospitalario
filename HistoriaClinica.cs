using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HistoriaClinica
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
                this.apellido = " ";
            }
        }
        public int edad;
        public int Edad
        {
            get
            {
                return this.edad;
            }

            set
            {
                this.edad = 0;
            }
        }
        public String numeroSeguro;
        public String NumeroSeguro
        {
            get
            {
                return this.numeroSeguro;
            }

            set
            {
                this.numeroSeguro = " ";
            }
        }
        public String tipoSeguro;
        public String TipoSeguro
        {
            get
            {
                return this.tipoSeguro;
            }

            set
            {
                this.tipoSeguro = " ";
            }
        }
        public String estado;
        public String Estado 
        {
            get
            {
                return this.estado;
            }

            set
            {
                this.estado = " ";
            }
        }
        public String nombreMedico;
        public String NombreMedico
        {
            get
            {
                return this.nombreMedico;
            }

            set
            {
                this.nombreMedico = " ";
            }
        }
        public String alergia;
        public String Alergia
        {
            get
            {
                return this.alergia;
            }

            set
            {
                this.alergia = " ";
            }
        }
    }
}
