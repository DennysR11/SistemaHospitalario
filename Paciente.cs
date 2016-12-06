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
            pa.cedulaIdentidad = "1726795709";
            System.Console.WriteLine("Cedula de identidad : " + pa.cedulaIdentidad);
            pa.nombre = "Javier";
            System.Console.WriteLine("Nombre : " + pa.nombre);
            pa.apellido = "Jaramillo";
            System.Console.WriteLine("Apellido: " + pa.apellido);
            diagnostico = "Gripe ";
            System.Console.WriteLine("Diagnostico : " + diagnostico);
            HistoriaClinica hClinica = new HistoriaClinica();
            Console.WriteLine("========================================================================\n" +
                "\t\t\tHISTORIA CLINICA\n\n");
            hClinica.nombre = "Javier";
            System.Console.WriteLine("Nombre paciente : " + hClinica.nombre);
            hClinica.apellido = "Jaramillo";
            System.Console.WriteLine("Nombre paciente : " + hClinica.apellido);
            hClinica.edad = 25;
            System.Console.WriteLine("Edad paciente : " + hClinica.edad);
            hClinica.numeroSeguro = "1222324";
            System.Console.WriteLine("Numero de seguro : " + hClinica.numeroSeguro);
            hClinica.nombreMedico = "Omar Vallejo";
            System.Console.WriteLine("Nombre del medico : " + hClinica.nombreMedico);
            hClinica.estado = "Enfermo";
            System.Console.WriteLine("Estado de salud : " + hClinica.estado);
            hClinica.alergia = "Penicilina";
            System.Console.WriteLine("Alergias : " + hClinica.alergia);
            Console.WriteLine("========================================================================\n" +
                "\t\t\tRECETA\n\n");
            Receta receta = new Receta();
            receta.fecha = new Fecha();
            receta.fecha.dia = 11;
            receta.fecha.mes = "Noviembre";
            receta.fecha.anio = 2016;
            System.Console.WriteLine("Fecha : " + receta.fecha.dia + " " + receta.fecha.mes + " " + receta.fecha.anio);
            receta.medicamento = "Lagrimas artificiales";
            System.Console.WriteLine("Medicamento : " + receta.medicamento);
            
            

        }
    }
}
