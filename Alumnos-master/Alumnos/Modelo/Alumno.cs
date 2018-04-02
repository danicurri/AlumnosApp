namespace Alumnos
{
    public class Alumno
    {
        public Alumno()
        {

        }
        
        public Alumno(int id, string nombre, string apellidos, string dni, string guid)
        {
            Id = id;
            Nombre = nombre;
            Apellidos = apellidos;
            Dni = dni;
            GUID = guid;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string GUID { get; set; }


        // override object.Equals
        public override bool Equals(object obj)
        {            
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
                        
            Alumno alumno = (Alumno)obj;
            if (GUID == alumno.GUID && Id == alumno.Id && Nombre == alumno.Nombre && Apellidos == alumno.Apellidos && Dni == alumno.Dni)
                return true;
            
            return false;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {            
            return Id.GetHashCode() * 17 + Nombre.GetHashCode() + Apellidos.GetHashCode()+ Dni.GetHashCode() + GUID.GetHashCode();
        }

        /// <summary>
        /// deberia haber un metodo tostring para txt, json y este ser usado para escribir en los archivos de distinto formato
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Id.ToString() + "," + Nombre + "," + Apellidos + "," + Dni + "," + GUID;
        }


    }
}
