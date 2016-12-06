using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Funcionario:Pesona
    {
        private String listaPaciente;
        public String ListaPaciente
        {
            get
            {
                return this.listaPaciente;
            }

            set
            {
                this.listaPaciente = " ";
            }
        }
        private String listaMedico;
        public String ListaMedico
        {
            get
            {
                return this.listaMedico;
            }

            set
            {
                this.listaMedico = " ";
            }
        }
    }
}
