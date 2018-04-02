using Alumnos.Helpers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Alumnos.Datos
{
    public class AlumnoDatosJson : AlumnoDatos
    {
        public AlumnoDatosJson()
        {

        }

        /// <summary>
        /// Agrega el alumno pasado como parametro al archivo del formato json.
        /// Esto es asi, siempre y cuando no exista ya un alumno con los mismos atributos.
        /// </summary>        
        /// <param name="alumno">Alumno a guardar en el archivo.</param>        
        public override void Agregar(Alumno alumno)
        {            
            if (Buscar(alumno) == null)
            {
                var jsonData = File.ReadAllText(UtilidadesArchivos.Folder + "Alumnos.json");
                var listaAlumnos = JsonConvert.DeserializeObject<List<Alumno>>(jsonData) ?? new List<Alumno>(); ;
                listaAlumnos.Add(alumno);
                jsonData = JsonConvert.SerializeObject(listaAlumnos);
                File.WriteAllText(UtilidadesArchivos.Folder + "Alumnos.json", jsonData);
            }            
        }

        /// <summary>
        /// Busca el alumno especificado en el archivo del formato json.
        /// </summary>        
        /// <param name="alumno">Alumno a buscar en el archivo.</param>
        /// <returns>Devuelve el alumno si lo encuentra, o null en caso contrario.</returns>
        public override Alumno Buscar(Alumno alumno)
        {
            Alumno encontrado = null;            
            var jsonData = File.ReadAllText(UtilidadesArchivos.Folder + "Alumnos.json");
            var listaAlumnos = JsonConvert.DeserializeObject<List<Alumno>>(jsonData) ?? new List<Alumno>(); ;
            int i = 0;
            while (encontrado == null && i < listaAlumnos.Count)
            {
                if (alumno.Equals(listaAlumnos[i]))
                    encontrado = listaAlumnos[i];
                ++i;
            }            
            return encontrado;
        }
    }
}
