using Alumnos.Datos;
using Alumnos.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using static Alumnos.Constantes;

namespace Alumnos.Tests
{
    [TestClass()]
    public class ProgramTests
    {        
        [DataRow(1, "Pepe", "Ramirez", "4356789W", OpcionFormato.txt, "103C8287-30CB-4630-B3F2-978286F72BD7")]
        [DataRow(1, "Pepe", "Ramirez", "4356789W", OpcionFormato.json, "103C8287-30CB-4630-B3F2-978286F72BD6")]
        [DataRow(2, "Maria", "Delao", "435623429T", OpcionFormato.json, "103C8287-30CB-4630-B3F2-978286F72BD5")]
        [DataRow(1, "Pepe", "Ramirez", "4356789W", OpcionFormato.txt, "103C8287-30CB-4630-B3F2-978286F72BD7")]
        [DataTestMethod] // permite enviar datos al método de test (parametrizar)
        public void AgregarAlumnoTest(int id, string nombre, string apellidos, string dni, OpcionFormato opcionFormato, string guid)
        {            
            Alumno alumnoAgregado = new Alumno(id, nombre, apellidos, dni, guid);            
            UtilidadesArchivos utilidadesArchivos = new UtilidadesArchivos();            
            utilidadesArchivos.CambiarConfiguracion(opcionFormato);
            AlumnoDatos alumnoDatos;
            if (opcionFormato == OpcionFormato.txt)            
                alumnoDatos = new AlumnoDatosTxt();            
            else
                alumnoDatos = new AlumnoDatosJson();
            alumnoDatos.Agregar(alumnoAgregado);
            Alumno alumnoEncontrado = alumnoDatos.Buscar(alumnoAgregado);
            Assert.AreEqual(alumnoAgregado, alumnoEncontrado);
        }

        /// <summary>
        ///Initialize() is called once during test execution before
        ///test methods in this test class are executed.
        ///</summary>
        [TestInitialize()]
        public void Initialize()
        {
            //FileStream fs;            
            //if (!File.Exists("Alumnos.txt"))
            //    fs = new FileStream("Alumnos.txt", FileMode.CreateNew);
            //if (!File.Exists("Alumnos.json"))
            //    fs = new FileStream("Alumnos.json", FileMode.CreateNew);
        }

        /// <summary>
        ///Cleanup() is called once during test execution after
        ///test methods in this class have executed unless
        ///this test class' Initialize() method throws an exception.
        ///</summary>
        [TestCleanup()]
        public void Cleanup()
        {            
            if (File.Exists(UtilidadesArchivos.Folder + "Alumnos.txt"))
                File.Delete(UtilidadesArchivos.Folder + "Alumnos.txt");
            if (File.Exists(UtilidadesArchivos.Folder + "Alumnos.json"))
                File.Delete(UtilidadesArchivos.Folder + "Alumnos.json");
        }

    }
}