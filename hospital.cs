using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class hospital
    {
        private String nombre;
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
        private Direccion direccion;
        public Direccion Direccion
        {
            get
            {
                return this.direccion;
            }

            set
            {
                this.direccion = new Direccion();
            }
        }
        private int numeroHabitacion;
        public int NumeroHabitacion
        {
            get
            {
                return this.numeroHabitacion;
            }

            set
            {
                this.numeroHabitacion = 0;
            }
        }
        private Paciente paciente;
        public Paciente Paciente
        {
            get
            {
                return this.paciente;
            }

            set
            {
                this.paciente = new Paciente();
            }
        }
        private Medico medico;
        public Medico Medico
        {
            get
            {
                return this.medico;
            }

            set
            {
                this.medico = new Medico();
            }
        }
        private Funcionario funcionario;
        public Funcionario Funcionario
        {
            get
            {
                return this.funcionario;
            }

            set
            {
                this.funcionario = new Funcionario();
            }
        }
    }
    
}
