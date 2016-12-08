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
                   "\n2: Funcionario\n" +
                   " =======================================================================\n" +
                   "Si no se encuentra registrado ingrese la opcion 2(Funcionario)\n" +
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
            return 0;
        }
        public int menuBuscarFuncionario(int opcion)
        {
            string cedulabuscar=null;
           
            if(opcion <2)
                {
                Console.WriteLine("========================================================================\n"+
                                                 "\t\t\tIngrese el numero de cedula que desea buscar\n" +
                    "========================================================================\n");
                 cedulabuscar =Console.ReadLine();
            }

            
            switch (opcion)
            {
                case 0:
                    buscarMedico(listaMedico, cedulabuscar);
                    if(buscarMedico(listaMedico, cedulabuscar)==false)
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
     
       
        public void ValidarMenu(int elegir)
        {
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
                        Console.ReadKey();
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
                    buscarPaciente(listaPaciente,cedulaPaciente.ToString());
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
                    //contrasenia = Console.ReadLine();
                    Console.Clear();
                    Funcionario f = new Funcionario();
                    buscarFuncionario(listaFuncionario,cedulaFuncionario.ToString(),contrasenia);
                    break;
                    //==

            }
        }

        public void buscarPaciente (List<Paciente> listaPaciente, string cedula)
        {
            int contadorPaciente = 0;
            foreach(Paciente p in listaPaciente)
            {
                if (cedula == p.cedulaIdentidad)
                {
                    Console.WriteLine("Nombre : "+p.nombre);
                    //Console.ReadKey();
                    Console.WriteLine("Apellido : "+p.apellido);
                    //Console.ReadKey();
                    Console.WriteLine("Cedula de identidad : "+p.cedulaIdentidad);
                    //Console.ReadKey();
                    Console.WriteLine("Calle Principal : "+p.Direccion.callePrincipal);
                    //Console.ReadKey();
                    Console.WriteLine("Calle secundaria : "+p.direccion.calleSecundaria);
                    //Console.ReadKey();
                    Console.WriteLine("Numero de seguro : "+p.HistoriaClinica.numeroSeguro);
                    //Console.ReadKey();
                    Console.WriteLine("Nombre del medico : "+p.HistoriaClinica.nombreMedico);
                    //Console.ReadKey();
                    Console.WriteLine("Estado del paciente : "+p.HistoriaClinica.estado);
                    //Console.ReadKey();
                    Console.WriteLine("Alergia : " + p.HistoriaClinica.alergia);
                    //Console.ReadKey();
                    Console.WriteLine("Tipo de seguro : "+p.HistoriaClinica.tipoSeguro);
                    Console.ReadKey();
                }
                else
                {
                    contadorPaciente++;
                    if(contadorPaciente==listaPaciente.Count())
                    {
                        Console.WriteLine("======================================");
                        Console.WriteLine("EL PACENTE NO EXISTE");
                        Console.WriteLine("======================================");
                        Console.ReadKey();
                       
                    }
                }
            }

            
        }
        public void buscarFuncionario(List<Funcionario> listaFuncionario, string cedula,string contrasenia)
        {
            foreach (Funcionario f in listaFuncionario)
            {
                if (cedula == f.cedulaIdentidad && contrasenia==f.contrasenia)
                {
                    ImprimirTextoMenu();
                    Console.WriteLine("Ingrese una opcion a la que deasea acceder : \n"+
                        "0 : Buscar Medico\n"+
                        "1 : Buscar Paciente\n"+
                        "2 : Ingresar nuevo medico\n"+
                        "3 : Ingresar nuevo paciente");
                    int opcion = int.Parse(Console.ReadLine());
                    if(opcion==0)
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
                    Console.WriteLine("Usuario o clave incorrecta");
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
                    Console.WriteLine("Nombre : "+m.nombre);
                    Console.WriteLine("Apellido : "+m.apellido);
                    Console.WriteLine("Cedula de identidad : "+m.cedulaIdentidad);
                    Console.WriteLine("Especialidad : "+m.especialidad);
                    Console.ReadKey();
                    return true;
                }
                else
                {
                    contadorMedico++;
                    if(contadorMedico==listaMedico.Count())
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
            Console.WriteLine("Ingrese la direccion del paciente");
            paciente.apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la calle principal del domicilio del paciente");
            paciente.Direccion = new Direccion();
            paciente.Direccion.callePrincipal = Console.ReadLine();
            Console.WriteLine("Ingrese la calle segundaria del domicilio del paciente");
            paciente.Direccion.calleSecundaria = Console.ReadLine();
            Console.WriteLine("Ingrese la numeacion del domicilio del paciente");
            paciente.Direccion.numeracion = Console.ReadLine();
            listaPaciente.Add(paciente);
        }
        public  void CargarPacienteInicial(Paciente paciente)
        {
            listaPaciente.Add(paciente);
        }
        public void CargarFuncionarioInicial(Funcionario funcionario)
        {
            listaFuncionario.Add(funcionario);
        }
        public  void CargarMedicoeInicial(Medico medico)
        {
            listaMedico.Add(medico);
        }

        public  void CargarMedico()
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
        //==========================================================================================================================

    }
}
