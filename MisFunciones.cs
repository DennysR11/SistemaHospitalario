using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MisFunciones
    {
        public static List<Paciente> listaPaciente = new List<Paciente>();
        public static List<Medico> listaMedico = new List<Medico>();
        public static List<Funcionario> listaFuncionario = new List<Funcionario>();
        int cedulaFuncionarioGlobal = 0;
        string contraseñaGlobal = null;


        public void ImprimirTextoMenu()
        {

            Console.WriteLine("\n\n\t\t\t\t█▀▄▀█ █▀▀ █▀▀▄ █░░█");
            Console.WriteLine("\t\t\t\t█░▀░█ █▀▀ █░░█ █░░█");
            Console.WriteLine("\t\t\t\t▀░░░▀ ▀▀▀ ▀░░▀ ░▀▀▀ ");
        }
        public int ImprimirMenu()

        {
            try
            {
                String opcion;
                int elegir;
                ImprimirTextoMenu();
                Console.WriteLine(
                   "========================================================================\n" +
                   "\t\t\tELIJA SU CARGO\n" +
                   "========================================================================\n" +
                   "0: Medico" +
                   "\n1: Paciente" +
                   "\n2: Funcionario" +
                   "\n3: Imprimir lista paciente"+
                   "\n4: Imprimir lista medico\n" +
                   " =======================================================================\n" +
                   "\t\t\tSi no se encuentra registrado ingrese la opcion 2(Funcionario)!!!!!!\n" +
                   " =======================================================================\n");

                opcion = Console.ReadLine();
                elegir = int.Parse(opcion);


                return elegir;

            }

            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            return 10;
        }
        public int menuBuscarFuncionario(int opcion)
        {
            try
            {
                string cedulabuscar = null;

                if (opcion < 2)
                {
                    Console.WriteLine("========================================================================\n" +
                                                     "\t\t\tIngrese el numero de cedula que desea buscar\n" +
                        "========================================================================\n");
                    cedulabuscar = Console.ReadLine();
                }


                switch (opcion)
                {
                    case 0:
                        buscarMedico(listaMedico, cedulabuscar);
                        if (buscarMedico(listaMedico, cedulabuscar) == false)
                        {
                            Console.WriteLine("==============================================");
                            Console.WriteLine("NO EXISTEN REGISTROS DEL MEDICO SELECCIONADO");
                            Console.WriteLine("==============================================");
                            Console.ReadKey();
                        }
                        break;
                    case 1:
                        buscarPaciente(listaPaciente, cedulabuscar);
                        break;
                    case 2:
                        this.CargarMedico();
                        Console.WriteLine("MEDICO INGRESADO CON EXITO");
                        Console.ReadKey();
                        Console.Clear();
                        buscarFuncionario(listaFuncionario, cedulaFuncionarioGlobal.ToString(), contraseñaGlobal.ToString());

                        break;
                    case 3:
                        this.CargarPaciente();
                        Console.WriteLine("PACIENTE INGRESADO CON EXITO");
                        Console.ReadKey();
                        Console.Clear();
                        buscarFuncionario(listaFuncionario, cedulaFuncionarioGlobal.ToString(), contraseñaGlobal.ToString());

                        break;

                }
                return opcion;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return 0;
        }


        public void ValidarMenu(int elegir)
        {
            try
            {
                Console.Clear();
                switch (elegir)
                {
                    case 0:

                        Console.Title = "PERFIL : MEDICO";
                        Console.WriteLine("========================================================================\n");

                        String opcion;
                        int cedulaMedico;
                        Console.WriteLine(
                           "\t\t\tIngrese su numero de cedula\n" +
                           "========================================================================\n");
                        opcion = Console.ReadLine();
                        cedulaMedico = int.Parse(opcion);
                        if (buscarMedico(listaMedico, cedulaMedico.ToString()) == true)
                        {
                            Console.WriteLine("INGRESE EL NUMERO DE CEDULA DEL PACIENTE QUE DESEA CONSULTAR");
                            string cedulapaciente = Console.ReadLine();
                            this.buscarPaciente(listaPaciente, cedulapaciente);
                        }
                        else
                        {
                            Console.WriteLine("==============================================");
                            Console.WriteLine("NO EXISTEN REGISTROS DEL MEDICO SELECCIONADO");
                            Console.WriteLine("==============================================");
                            Console.WriteLine("Presione cualquier tecla para regresar a menu !!!!");
                            Console.ReadKey();
                            Console.Clear();


                            this.ValidarMenu(this.ImprimirMenu());

                        }
                        break;
                    case 1:
                        Console.Title = "PERFIL : PACIENTE";
                        Console.WriteLine("========================================================================\n");
                        int cedulaPaciente;
                        Console.WriteLine(
                           "========================================================================\n" +
                           "\t\t\tIngrese su numero de cedula\n" +
                           "========================================================================\n");
                        opcion = Console.ReadLine();
                        cedulaPaciente = int.Parse(opcion);
                        buscarPaciente(listaPaciente, cedulaPaciente.ToString());
                        break;
                    case 2:
                        Console.Title = "PERFIL : FUNCIONARIO";
                        Console.WriteLine("========================================================================\n");
                        int cedulaFuncionario;
                        Console.WriteLine(
                           "========================================================================\n" +
                           "\t\t\tIngrese su numero de cedula\n" +
                           "========================================================================\n");
                        cedulaFuncionario = int.Parse(Console.ReadLine());
                        cedulaFuncionarioGlobal = cedulaFuncionario;


                        Console.WriteLine(
                           "========================================================================\n" +
                           "\t\t\tIngrese su numero el password\n" +
                           "========================================================================\n");
                        ConsoleKeyInfo ultimaTecla;
                        bool continuar;
                        char mostrar;
                        continuar = true;
                        string contrasenia = "";
                        mostrar = '*';
                        while (continuar)
                        {
                            ultimaTecla = Console.ReadKey(true);
                            if (ultimaTecla.KeyChar != '\r')
                            {
                                contrasenia = contrasenia + ultimaTecla.KeyChar;
                                contraseñaGlobal = contrasenia;
                                Console.Write(mostrar);
                            }
                            else
                                continuar = false;
                        }
                        Console.Write('\n');
                        //===
                        Console.Clear();
                        Funcionario f = new Funcionario();
                        buscarFuncionario(listaFuncionario, cedulaFuncionario.ToString(), contrasenia);
                        break;
                    //==
                    case 3:
                        ImprimirListaPaciente(listaPaciente);
                        break;
                    case 4:
                        ImprimirListaeMedico(listaMedico);
                        break;

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                Console.Clear();
                ValidarMenu(ImprimirMenu());
            }

        }

        public void buscarPaciente(List<Paciente> listaPaciente, string cedula)
        {
            int contadorPaciente = 0;
            foreach (Paciente p in listaPaciente)
            {
                if (cedula == p.cedulaIdentidad)
                {
                    Console.WriteLine("Nombre : " + p.nombre);
                    Console.WriteLine("Apellido : " + p.apellido);
                    Console.WriteLine("Cedula de identidad : " + p.cedulaIdentidad);
                    Console.WriteLine("Calle Principal : " + p.Direccion.callePrincipal);
                    Console.WriteLine("Calle secundaria : " + p.direccion.calleSecundaria);
                    Console.WriteLine("Numero de seguro : " + p.HistoriaClinica.numeroSeguro);
                    Console.WriteLine("Nombre del medico : " + p.HistoriaClinica.nombreMedico);
                    Console.WriteLine("Estado del paciente : " + p.HistoriaClinica.estado);
                    Console.WriteLine("Alergia : " + p.HistoriaClinica.alergia);
                    Console.WriteLine("Tipo de seguro : " + p.HistoriaClinica.tipoSeguro);
                    Console.WriteLine("Fecha : " + p.Receta.Fecha.dia + " " + p.Receta.Fecha.mes + " " + p.Receta.Fecha.anio);
                    Console.WriteLine("Medicamento : " + p.Receta.medicamento);
                    Console.WriteLine("Indicaccion : " + p.Receta.indicacion);
                    Console.WriteLine("Numero de seguro : " + p.Seguro.numeroSeguro);
                    Console.ReadKey();
                }
                else
                {
                    contadorPaciente++;
                    if (contadorPaciente == listaPaciente.Count())
                    {
                        Console.WriteLine("======================================");
                        Console.WriteLine("EL PACENTE NO EXISTE");
                        Console.WriteLine("======================================");
                        Console.WriteLine("Presione cualquier tecla para regresar a menu !!!!!!!");
                        Console.ReadKey();
                        Console.Clear();
                        this.ValidarMenu(this.ImprimirMenu());

                    }
                }
            }


        }
        public void buscarFuncionario(List<Funcionario> listaFuncionario, string cedula, string contrasenia)
        {
            foreach (Funcionario f in listaFuncionario)
            {
                if (cedula == f.cedulaIdentidad && contrasenia == f.contrasenia)
                {
                    ImprimirTextoMenu();
                    Console.WriteLine("Ingrese una opcion a la que deasea acceder : \n" +
                        "0 : Buscar Medico\n" +
                        "1 : Buscar Paciente\n" +
                        "2 : Ingresar nuevo medico\n" +
                        "3 : Ingresar nuevo paciente");
                    int opcion = int.Parse(Console.ReadLine());
                    if (opcion == 0)
                    {
                        Console.Title = "FUNCIONARIO/ BUSCAR MEDICO";
                    }
                    if (opcion == 1)
                    {
                        Console.Title = "FUNCIONARIO/ BUSCAR PACIENTE";
                    }
                    if (opcion == 2)
                    {
                        Console.Title = "FUNCIONARIO/ INGRESAR MEDICO";
                    }
                    if (opcion == 3)
                    {
                        Console.Title = "FUNCIONARIO/ INGRESAR PACIENTE";
                    }
                    Console.Clear();
                    this.menuBuscarFuncionario(opcion);

                }
                else
                {
                    Console.WriteLine("=========================================================");
                    Console.WriteLine("Usuario o clave incorrecta !!!!!!!!!!!!!!");
                    Console.WriteLine("=========================================================\n\n\n");
                    Console.WriteLine("PRESIONE CULAQUIER TECLA PARA REGRESAR AL MENU PRINCIPAL !!!!!!!!!");
                    Console.ReadKey();
                    Console.Clear();
                    ValidarMenu(ImprimirMenu());
                }
            }


        }

        public Boolean buscarMedico(List<Medico> listaMedico, string cedula)


        {
            int contadorMedico = 0;
            foreach (Medico m in listaMedico)
            {
                if (cedula == m.cedulaIdentidad)
                {
                    Console.WriteLine("Nombre : " + m.nombre);
                    Console.WriteLine("Apellido : " + m.apellido);
                    Console.WriteLine("Cedula de identidad : " + m.cedulaIdentidad);
                    Console.WriteLine("Especialidad : " + m.especialidad);
                    Console.ReadKey();
                    return true;
                }
                else
                {
                    contadorMedico++;
                    if (contadorMedico == listaMedico.Count())
                    {

                        return false;
                    }

                }
            }
            return false;
        }
        public void CargarPaciente()
        {
            Paciente paciente = new Paciente();
            Console.WriteLine("Ingrese el nombre del paciente");
            paciente.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del paciente");
            paciente.apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la cedula del paciente");
            paciente.cedulaIdentidad = Console.ReadLine();
            Console.WriteLine("Ingrese la calle principal del domicilio del paciente");
            paciente.Direccion = new Direccion();
            paciente.Direccion.callePrincipal = Console.ReadLine();
            Console.WriteLine("Ingrese la calle segundaria del domicilio del paciente");
            paciente.Direccion.calleSecundaria = Console.ReadLine();
            Console.WriteLine("Ingrese la numeacion del domicilio del paciente");
            paciente.Direccion.numeracion = Console.ReadLine();
            paciente.Receta = new Receta();
            paciente.Receta.fecha = new Fecha();
            Console.WriteLine("Ingrese el dia de la receta");
            paciente.Receta.Fecha.dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el mes de la receta");
            paciente.Receta.Fecha.mes = Console.ReadLine();
            Console.WriteLine("Ingrese el año de la receta");
            paciente.Receta.Fecha.anio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el medicamento");
            paciente.Receta.medicamento = Console.ReadLine();
            Console.WriteLine("Ingrese las indicacciones de subministrar el medicamento");
            paciente.Receta.indicacion = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de seguro");
            paciente.Seguro.numeroSeguro = Console.ReadLine();
            listaPaciente.Add(paciente);
        }
        public void CargarPacienteInicial(Paciente paciente)
        {
            listaPaciente.Add(paciente);
        }
        public void CargarFuncionarioInicial(Funcionario funcionario)
        {
            listaFuncionario.Add(funcionario);
        }
        public void CargarMedicoeInicial(Medico medico)
        {
            listaMedico.Add(medico);
        }

        public void CargarMedico()
        {
            Medico medico = new Medico();
            Console.WriteLine("Ingrese el nombre del medico");
            medico.nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del medico");
            medico.apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la especialidad del medico");
            medico.especialidad = Console.ReadLine();
            Console.WriteLine("Ingrese la cedula de identidad del medico");
            medico.cedulaIdentidad = Console.ReadLine();
            listaMedico.Add(medico);
        }
        public void validacion(int dato)
        {
            if (dato < 3)
            {
                Console.Clear();
                ValidarMenu(dato);
            }
            else
            {
                Console.WriteLine("===============================================");
                Console.WriteLine("\t\tOPCION INCORRECTA!!!!!!");
                Console.WriteLine("===============================================\n\n\n");
                Console.WriteLine("PRESIONE UNA TECLA PARA REGRESAR AL MENU PRINCIPAL");
                Console.ReadKey();
                Console.Clear();
                ValidarMenu(dato);

            }
        }
        //==========================================================================================================================

        public void ImprimirListaPaciente(List<Paciente> listaPaciente)
        {
            foreach (Paciente p in listaPaciente)
            {

                Console.WriteLine("Nombre : " + p.nombre);
                Console.WriteLine("Apellido : " + p.apellido);
                Console.WriteLine("Cedula de identidad : " + p.cedulaIdentidad);
                Console.WriteLine("Calle Principal : " + p.Direccion.callePrincipal);
                Console.WriteLine("Calle secundaria : " + p.direccion.calleSecundaria);
                Console.WriteLine("Numero de seguro : " + p.HistoriaClinica.numeroSeguro);
                Console.WriteLine("Nombre del medico : " + p.HistoriaClinica.nombreMedico);
                Console.WriteLine("Estado del paciente : " + p.HistoriaClinica.estado);
                Console.WriteLine("Alergia : " + p.HistoriaClinica.alergia);
                Console.WriteLine("Tipo de seguro : " + p.HistoriaClinica.tipoSeguro);
                Console.WriteLine("Fecha : " + p.Receta.Fecha.dia + " " + p.Receta.Fecha.mes + " " + p.Receta.Fecha.anio);
                Console.WriteLine("Medicamento : " + p.Receta.medicamento);
                Console.WriteLine("Indicaccion : " + p.Receta.indicacion);
                Console.WriteLine("Numero de seguro : " + p.Seguro.numeroSeguro);
                Console.ReadKey();
            }
            Console.Clear();
            this.ValidarMenu(ImprimirMenu());
        }
        public void ImprimirListaeMedico(List<Medico> listaMedico)


        {
            foreach (Medico m in listaMedico)
            {

                Console.WriteLine("Nombre : " + m.nombre);
                Console.WriteLine("Apellido : " + m.apellido);
                Console.WriteLine("Cedula de identidad : " + m.cedulaIdentidad);
                Console.WriteLine("Especialidad : " + m.especialidad);
                Console.ReadKey();
            }
            Console.Clear();
            this.ValidarMenu(ImprimirMenu());
        }
    }

}