using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Paciente:Pesona
    {
        private String diagnostico;
        public String diagnotico
        {
            get
            {
                return this.diagnostico;
            }

            set
            {
                this.diagnostico = " ";
            }
        }
        private Seguro seguro;
        public Seguro Seguro
        {
            get
            {
                return this.seguro;
            }

            set
            {
                this.seguro = new Seguro();
            }
        }
        private HistoriaClinica historiaClinica;
        public HistoriaClinica HistoriaClinica
        {
            get
            {
                return this.historiaClinica;
            }

            set
            {
                this.historiaClinica = new HistoriaClinica();
            }
        }
        
        public Paciente()
        {
            Console.Write("\t\t\tDAROS PERSONALES\n\n");
            Pesona pa = new Pesona();
            pa.cedulaIdentidad = " ";
            pa.nombre = " ";
            pa.apellido = " ";
            diagnostico = " ";
            HistoriaClinica hClinica = new HistoriaClinica();
            Console.WriteLine("========================================================================\n" +
                "\t\t\tHISTORIA CLINICA\n\n");
            hClinica.nombre = " ";           
            hClinica.apellido = " ";
            hClinica.edad = 0;
            hClinica.numeroSeguro = " ";
            hClinica.nombreMedico = " ";
            hClinica.estado = " ";
            hClinica.alergia = " ";
            Console.WriteLine("========================================================================\n" +
                "\t\t\tRECETA\n\n");
            Receta receta = new Receta();
            receta.fecha = new Fecha();
            receta.fecha.dia = 0;
            receta.fecha.mes = " ";
            receta.fecha.anio = 0;
            receta.medicamento = " ";

            
            

        }
    }
}
