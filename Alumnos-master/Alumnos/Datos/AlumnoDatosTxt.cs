using Alumnos.Helpers;
using System;
using System.IO;

namespace Alumnos.Datos
{
    public class AlumnoDatosTxt : AlumnoDatos
    {
        public AlumnoDatosTxt()
        {

        }

        /// <summary>
        /// Agrega el alumno pasado como parametro al archivo del formato txt.
        /// Esto es asi, siempre y cuando no exista ya un alumno con los mismos atributos.
        /// </summary> 
        /// <param name="alumno">Alumno a guardar en el archivo.</param>        
        public override void Agregar(Alumno alumno)
        {           
            if (Buscar(alumno) == null)
            {
                using (StreamWriter sw = File.AppendText(UtilidadesArchivos.Folder + "Alumnos.txt"))
                {
                    sw.WriteLine(alumno.ToString());
                }
            }
        }

        /// <summary>
        /// Busca el alumno especificado en el archivo del formato txt.
        /// </summary>        
        /// <param name="alumno">Alumno a buscar en el archivo.</param>
        /// <returns>Devuelve el alumno si lo encuentra, o null en caso contrario.</returns>
        public override Alumno Buscar(Alumno alumno)
        {
            Alumno encontrado = null;            
            string[] lines = File.ReadAllLines(UtilidadesArchivos.Folder + "Alumnos.txt");
            int i = 0;
            while (encontrado == null && i < lines.Length)
            {
                string[] atributosAlumno = lines[i].Split(',');
                Alumno alumnoAuxiliar = new Alumno(Convert.ToInt32(atributosAlumno[0]), atributosAlumno[1], atributosAlumno[2], atributosAlumno[3], atributosAlumno[4]);
                if (alumnoAuxiliar.Equals(alumno))
                    encontrado = alumnoAuxiliar;
                ++i;
            }                        
            return encontrado;
        }
    }
}
