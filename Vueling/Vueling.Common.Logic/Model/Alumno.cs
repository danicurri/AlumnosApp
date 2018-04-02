using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Common.Logic.Model
{
    public class Alumno : VuelingObject
    {
        #region Atributos
        private int idAlumno;
        private string nombre;
        #endregion

        #region Propiedades
        public int IdAlumno
        {
            get { return idAlumno; }
            set { idAlumno = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        } 
        #endregion
    }
}
