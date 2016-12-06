using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Receta
    {
        public Fecha fecha;
        public Fecha Fecha
        {
            get
            {
                return this.fecha;
            }

            set
            {
                this.fecha = new Fecha();
            }
        }
        public String medicamento;
        public String Medicamento
        {
            get
            {
                return this.medicamento;
            }

            set
            {
                this.medicamento = " ";
            }
        }
        public String indicacion;
        public String Indicacion
        {
            get
            {
                return this.indicacion;
            }

            set
            {
                this.indicacion = " ";
            }
        }
        public Medico medico;
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
        public Paciente paciente;
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

    }
}
