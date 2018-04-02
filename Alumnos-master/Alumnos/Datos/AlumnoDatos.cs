using Alumnos.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using static Alumnos.Constantes;

namespace Alumnos.Datos
{
    /// <summary>
    /// Clase encargada de acceder a los archivos de alumnos.
    /// </summary>
    public abstract class AlumnoDatos
    {
        public abstract void Agregar(Alumno alumno);
        public abstract Alumno Buscar(Alumno alumno);
    }
}
