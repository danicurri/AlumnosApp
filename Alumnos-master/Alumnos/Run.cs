using Alumnos.Datos;
using Alumnos.Helpers;
using System;
using static Alumnos.Constantes;

namespace Alumnos
{
    public class Run
    {
        /// <summary>
        /// Muestra el menu principal de la aplicacion.
        /// </summary>
        /// <returns>Devuelve la opcion del menu seleccionada.</returns>
        OpcionMenu MostrarMenu()
        {
            Console.WriteLine("¿Que operacion quiere realizar?");
            Console.WriteLine("1. Crear alumno");
            Console.WriteLine("2. Configuracion");
            Console.WriteLine("3. Salir");
            OpcionMenu opcion;
            if (Enum.TryParse(Console.ReadLine(), true, out opcion))
                return opcion;
            else return 0;
        }

        /// <summary>
        /// Muestra el menu de formato en el que guardar los alumnos.
        /// </summary>
        /// <returns>Devuelve la opcion del menu seleccionada.</returns>
        OpcionFormato MostrarFormato()
        {
            Console.WriteLine("1. txt");
            Console.WriteLine("2. json");
            OpcionFormato opcion;            
            if (Enum.TryParse(Console.ReadLine(), true, out opcion))
                return opcion;
            else return 0;
        }

        /// <summary>
        /// Lee los atributos de un alumno y genera un objeto Alumno nuevo.
        /// </summary>
        /// <returns>Devuelve un Alumno con los atributos leidos.</returns>
        Alumno LeerAlumno()
        {
            Console.WriteLine("id");
            int id;
            Int32.TryParse(Console.ReadLine(), out id);            
            Console.WriteLine("nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("apellidos");
            string apellidos = Console.ReadLine();
            Console.WriteLine("dni");
            string dni = Console.ReadLine();
            Guid guid = Guid.NewGuid();            
            Alumno alumno = new Alumno(id, nombre, apellidos, dni, guid.ToString());            
            return alumno;
        }
                
        public Run()
        {
            Alumno alumno;
            OpcionMenu opcionMenu;
            UtilidadesArchivos utilidadesArchivos = new UtilidadesArchivos();            
            OpcionFormato opcionFormato = utilidadesArchivos.InicializarConfiguracion();
            
            do
            {
                opcionMenu = MostrarMenu();
                switch (opcionMenu)
                {
                    case OpcionMenu.CrearAlumno:
                        alumno = LeerAlumno();
                        AlumnoDatos alumnoDatos;
                        if (opcionFormato == OpcionFormato.txt)
                            alumnoDatos = new AlumnoDatosTxt();                                 
                        else
                            alumnoDatos = new AlumnoDatosJson();                              
                        alumnoDatos.Agregar(alumno);
                        break;
                    case OpcionMenu.Configuracion:
                        opcionFormato = MostrarFormato();
                        switch (opcionFormato)
                        {
                            case OpcionFormato.txt:
                                utilidadesArchivos.CambiarConfiguracion(opcionFormato);                                
                                opcionFormato = OpcionFormato.txt;
                                Console.WriteLine("Formato escogido: txt");
                                break;
                            case OpcionFormato.json:
                                utilidadesArchivos.CambiarConfiguracion(opcionFormato);
                                opcionFormato = OpcionFormato.json;
                                Console.WriteLine("Formato escogido: json");                                
                                break;
                            default:
                                break;
                        }
                        break;
                    case OpcionMenu.Salir:
                        Console.WriteLine("Saliendo...");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            } while (opcionMenu != OpcionMenu.Salir);
        }
    }
}
