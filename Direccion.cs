using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Direccion
    {
        public String callePrincipal;
        public String CallePrincipal
        {
            get
            {
                return this.callePrincipal;
            }

            set
            {
                this.callePrincipal = " ";
            }
        }
        public String calleSecundaria;
        public String CalleSecundaria
        {
            get
            {
                return this.calleSecundaria;
            }

            set
            {
                this.calleSecundaria = " ";
            }
        }
        public String numeracion;
        public String Numeracion
        {
            get
            {
                return this.numeracion;
            }

            set
            {
                this.numeracion = " ";
            }
        }
    }
}
