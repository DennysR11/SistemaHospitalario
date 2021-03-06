﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
       static MisFunciones misFunciones = new MisFunciones();
        static void Main(string[] args)
        {
            Console.Title = "\t\t\tSISTEMA DE ADMINISTRACION HOSPITALARIO";
            Console.WriteLine("───────────────────────────────────────────────────────────────────");
            Console.WriteLine("─██████████████───██████████─██████████████─██████──────────██████─");
            Console.WriteLine("─██░░░░░░░░░░██───██░░░░░░██─██░░░░░░░░░░██─██░░██████████──██░░██─");
            Console.WriteLine("─██░░██████░░██───████░░████─██░░██████████─██░░░░░░░░░░██──██░░██─");
            Console.WriteLine("─██░░██──██░░██─────██░░██───██░░██─────────██░░██████░░██──██░░██─");
            Console.WriteLine("─██░░██████░░████───██░░██───██░░██████████─██░░██──██░░██──██░░██──██████──");
            Console.WriteLine("─██░░░░░░░░░░░░██───██░░██───██░░░░░░░░░░██─██░░██──██░░██──██░░██─");
            Console.WriteLine("─██░░████████░░██───██░░██───██░░██████████─██░░██──██░░██──██░░██─");
            Console.WriteLine("─██░░██────██░░██───██░░██───██░░██─────────██░░██──██░░██████░░██─");
            Console.WriteLine("─██░░████████░░██─████░░████─██░░██████████─██░░██──██░░░░░░░░░░██─");
            Console.WriteLine("─██░░░░░░░░░░░░██─██░░░░░░██─██░░░░░░░░░░██─██░░██──██████████░░██─");
            Console.WriteLine("─████████████████─██████████─██████████████─██████──────────██████─");
            Console.WriteLine("───────────────────────────────────────────────────────────────────");

            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────────────────────────────────────");
            Console.WriteLine("─██████──██████─██████████████─██████──────────██████─██████████─████████████───██████████████─██████████████─");
            Console.WriteLine("─██░░██──██░░██─██░░░░░░░░░░██─██░░██████████──██░░██─██░░░░░░██─██░░░░░░░░████─██░░░░░░░░░░██─██░░░░░░░░░░██─");
            Console.WriteLine("─██░░██──██░░██─██░░██████████─██░░░░░░░░░░██──██░░██─████░░████─██░░████░░░░██─██░░██████░░██─██░░██████████─");
            Console.WriteLine("─██░░██──██░░██─██░░██─────────██░░██████░░██──██░░██───██░░██───██░░██──██░░██─██░░██──██░░██─██░░██─────────");
            Console.WriteLine("─██░░██──██░░██─██░░██████████─██░░██──██░░██──██░░██───██░░██───██░░██──██░░██─██░░██──██░░██─██░░██████████─");
            Console.WriteLine("─██░░██──██░░██─██░░░░░░░░░░██─██░░██──██░░██──██░░██───██░░██───██░░██──██░░██─██░░██──██░░██─██░░░░░░░░░░██─");
            Console.WriteLine("─██░░██──██░░██─██░░██████████─██░░██──██░░██──██░░██───██░░██───██░░██──██░░██─██░░██──██░░██─██████████░░██─");
            Console.WriteLine("─██░░░░██░░░░██─██░░██─────────██░░██──██░░██████░░██───██░░██───██░░██──██░░██─██░░██──██░░██─────────██░░██─");
            Console.WriteLine("─████░░░░░░████─██░░██████████─██░░██──██░░░░░░░░░░██─████░░████─██░░████░░░░██─██░░██████░░██─██████████░░██─");
            Console.WriteLine("───████░░████───██░░░░░░░░░░██─██░░██──██████████░░██─██░░░░░░██─██░░░░░░░░████─██░░░░░░░░░░██─██░░░░░░░░░░██─");
            Console.WriteLine("─────██████─────██████████████─██████──────────██████─██████████─████████████───██████████████─██████████████─");
            Console.WriteLine("──────────────────────────────────────────────────────────────────────────────────────────────────────────────");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            ConsoleApplication1.
           
            //====================================================
            //INGRESO DE PACIENTES Y MEDICOS 
            //=====================================================

            Paciente paciente = new Paciente();
            paciente.nombre = "Michelle";
            paciente.apellido = "Jaramillo";
            paciente.cedulaIdentidad = "1726795709";
            paciente.Direccion = new Direccion();
            paciente.Direccion.callePrincipal = "Diego Montanero";
            paciente.direccion.calleSecundaria = "Jose Arellano Portilla";
            paciente.HistoriaClinica = new HistoriaClinica();
            paciente.HistoriaClinica.numeroSeguro = "1214334";
            paciente.HistoriaClinica.nombreMedico = "Omar Vallejo";
            paciente.HistoriaClinica.estado = "Enfermo";
            paciente.HistoriaClinica.alergia = "Penicilina";
            paciente.HistoriaClinica.tipoSeguro = "Publico";
            ///==========================================================
            paciente.Receta = new Receta();
            paciente.Receta.fecha = new Fecha();
            paciente.Receta.fecha.dia = 12;
            paciente.Receta.fecha.mes = "noviembre";
            paciente.Receta.fecha.anio = 2016;
            paciente.Receta.medicamento= "Peicilina";
            paciente.Receta.indicacion = "Administrar una dosis dos veces al dia";
            paciente.Seguro = new Seguro();
            paciente.Seguro.numeroSeguro = "100312";
            ///=============================================================
            misFunciones.CargarPacienteInicial(paciente);


            Paciente paciente2 = new Paciente();
            paciente2.nombre = "Karla";
            paciente2.apellido = "Vinueza";
            paciente2.cedulaIdentidad = "1707735112";
            paciente2.Direccion = new Direccion();
            paciente2.Direccion.callePrincipal = "San Jose de Monjas";
            paciente2.direccion.calleSecundaria = "Jose Arellano";
            paciente2.HistoriaClinica = new HistoriaClinica();
            paciente2.HistoriaClinica.numeroSeguro = "1214334";
            paciente2.HistoriaClinica.nombreMedico = "Jessica Altamirano";
            paciente2.HistoriaClinica.estado = "Enfermo";
            paciente2.HistoriaClinica.alergia = "Penicilina";
            paciente2.HistoriaClinica.tipoSeguro = "Privado";
            ///==========================================================
            
            paciente2.Receta = new Receta();
            paciente2.Receta.fecha = new Fecha();
            paciente2.Receta.fecha.dia = 18;
            paciente2.Receta.fecha.mes = "septiembre";
            paciente2.Receta.fecha.anio = 2016;
            paciente2.Receta.medicamento = "Metocarbamol";
            paciente2.Receta.indicacion = "Administrar una dosis tres veces al dia";
            paciente2.Seguro = new Seguro();
            paciente2.Seguro.numeroSeguro = "1214334";
            ///=============================================================

            misFunciones.CargarPacienteInicial(paciente2);

            Paciente paciente3 = new Paciente();
            paciente3.nombre = "Dennys";
            paciente3.apellido = "Rojas";
            paciente3.cedulaIdentidad = "1603401431";
            paciente3.Direccion = new Direccion();
            paciente3.Direccion.callePrincipal = "La Gasca";
            paciente3.direccion.calleSecundaria = "Atacames";
            paciente3.HistoriaClinica = new HistoriaClinica();
            paciente3.HistoriaClinica.numeroSeguro = "201582";
            paciente3.HistoriaClinica.nombreMedico = "Marilyn Guano";
            paciente3.HistoriaClinica.estado = "Critico";
            paciente3.HistoriaClinica.alergia = "Ninguna";
            paciente3.HistoriaClinica.tipoSeguro = "Privado";
             ///==========================================================

            paciente3.Receta = new Receta();
            paciente3.Receta.fecha = new Fecha();
            paciente3.Receta.fecha.dia = 24;
            paciente3.Receta.fecha.mes = "agosto";
            paciente3.Receta.fecha.anio = 2016;
            paciente3.Receta.medicamento = "Doxil";
            paciente3.Receta.indicacion = "Administrar una dosis dos veces al dia";
            paciente3.Seguro = new Seguro();
            paciente3.Seguro.numeroSeguro = "201582";
            ///=============================================================
            misFunciones.CargarPacienteInicial(paciente3);

            Paciente paciente4 = new Paciente();
            paciente4.nombre = "Victor";
            paciente4.apellido = "Proaño";
            paciente4.cedulaIdentidad = "1702564692";
            paciente4.Direccion = new Direccion();
            paciente4.Direccion.callePrincipal = "Av Maldonado";
            paciente4.direccion.calleSecundaria = "Brasil";
            paciente4.HistoriaClinica = new HistoriaClinica();
            paciente4.HistoriaClinica.numeroSeguro = "201328";
            paciente4.HistoriaClinica.nombreMedico = "Omar Vallejo";
            paciente4.HistoriaClinica.estado = "Enfermo";
            paciente4.HistoriaClinica.alergia = "amoxisilina";
            paciente4.HistoriaClinica.tipoSeguro = "Privado";
             ///==========================================================

            paciente4.Receta = new Receta();
            paciente4.Receta.fecha = new Fecha();
            paciente4.Receta.fecha.dia = 16;
            paciente4.Receta.fecha.mes = "octubre";
            paciente4.Receta.fecha.anio = 2016;
            paciente4.Receta.medicamento = "Ditropan";
            paciente4.Receta.indicacion = "Administrar una dosis tres veces al dia";
            paciente4.Seguro = new Seguro();
            paciente4.Seguro.numeroSeguro = "201328";
            ///=============================================================
            misFunciones.CargarPacienteInicial(paciente4);

            Paciente paciente5 = new Paciente();
            paciente5.nombre = "Karla";
            paciente5.apellido = "Maldonado";
            paciente5.cedulaIdentidad = "1704736856";
            paciente5.Direccion = new Direccion();
            paciente5.Direccion.callePrincipal = "La Ecuatpriana";
            paciente5.direccion.calleSecundaria = "Cosanga";
            paciente5.HistoriaClinica = new HistoriaClinica();
            paciente5.HistoriaClinica.numeroSeguro = "199509";
            paciente5.HistoriaClinica.nombreMedico = "Marilyn Guano";
            paciente5.HistoriaClinica.estado = "Critico";
            paciente5.HistoriaClinica.alergia = "Ninguna";
            paciente5.HistoriaClinica.tipoSeguro = "Privado";
            ///==========================================================

            paciente5.Receta = new Receta();
            paciente5.Receta.fecha = new Fecha();
            paciente5.Receta.fecha.dia = 16;
            paciente5.Receta.fecha.mes = "octubre";
            paciente5.Receta.fecha.anio = 2016;
            paciente5.Receta.medicamento = "Penicilina";
            paciente5.Receta.indicacion = "Administrar una dosis una vez al dia";
            paciente5.Seguro = new Seguro();
            paciente5.Seguro.numeroSeguro = "199509";
            ///=============================================================
            misFunciones.CargarPacienteInicial(paciente5);

            Paciente paciente6 = new Paciente();
            paciente6.nombre = "Monserath";
            paciente6.apellido = "Laferte";
            paciente6.cedulaIdentidad = "1284758936";
            paciente6.Direccion = new Direccion();
            paciente6.Direccion.callePrincipal = "La Patria";
            paciente6.direccion.calleSecundaria = "10 de Agosto";
            paciente6.HistoriaClinica = new HistoriaClinica();
            paciente6.HistoriaClinica.numeroSeguro = "199703";
            paciente6.HistoriaClinica.nombreMedico = "Jessica Altamirano";
            paciente6.HistoriaClinica.estado = "Enfermo";
            paciente6.HistoriaClinica.alergia = "Ninguna";
            paciente6.HistoriaClinica.tipoSeguro = "Privado";
             ///==========================================================

            paciente6.Receta = new Receta();
            paciente6.Receta.fecha = new Fecha();
            paciente6.Receta.fecha.dia = 22;
            paciente6.Receta.fecha.mes = "septiembre";
            paciente6.Receta.fecha.anio = 2016;
            paciente6.Receta.medicamento = "Amoxicilina";
            paciente6.Receta.indicacion = "Administrar una dosis tres veces al dia";
            paciente6.Seguro = new Seguro();
            paciente6.Seguro.numeroSeguro = "199703";
            ///=============================================================
            misFunciones.CargarPacienteInicial(paciente6);



            Medico medico = new Medico();
            medico.nombre = "Omar";
            medico.apellido = "Vallejo";
            medico.cedulaIdentidad = "1724977960";
            medico.especialidad = "Oftalmologo";
            misFunciones.CargarMedicoeInicial(medico);

            Medico medico2 = new Medico();
            medico2.nombre = "Marilyn";
            medico2.apellido = "Guano";
            medico2.cedulaIdentidad = "1704041001";
            medico2.especialidad = "Cardiologo";
            misFunciones.CargarMedicoeInicial(medico2);

            Medico medico3 = new Medico();
            medico3.nombre = "Jessica";
            medico3.apellido = "Altamirano";
            medico3.cedulaIdentidad = "1750392928";
            medico3.especialidad = "Oncologo";
            misFunciones.CargarMedicoeInicial(medico3);

            Funcionario funcionario = new Funcionario();
            funcionario.nombre = "Olga";
            funcionario.apellido = "Vinueza";
            funcionario.cedulaIdentidad = "1715827984";
            funcionario.contrasenia = "Ggx884";
            misFunciones.CargarFuncionarioInicial(funcionario);
            //==================================================
            //FIN INGRESO PACIENTES Y MEDICOS
            //=======================================================


             
           
            if (misFunciones.ImprimirMenu() < 3)
            {
                Console.Clear();
                misFunciones.ValidarMenu(misFunciones.ImprimirMenu());
            }
            else
            {
                Console.WriteLine("===============================================");
                Console.WriteLine("\t\tOPCION INCORRECTA!!!!!!");
                Console.WriteLine("===============================================\n\n\n");
                Console.WriteLine("PRESIONE UNA TECLA PARA REGRESAR AL MENU PRINCIPAL");
                Console.ReadKey();
                Console.Clear();
                misFunciones.ValidarMenu(misFunciones.ImprimirMenu());
                misFunciones.validacion(misFunciones.ImprimirMenu());
            }
        }

        

        //===========================================================================================
    }

}

