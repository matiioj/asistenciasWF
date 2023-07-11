using System;


namespace AssistsWF.entities
{
    public class Estudiante
    {
        public int id_estudiante { get; set; }
        public string nombre_estudiante { get; set; }
        
        public string apellido_estudiante { get; set; }
        public List<Asistencia> asistencias_estudiante { get; set; }

        public Estudiante()
        {
            asistencias_estudiante = new List<Asistencia>();
        }
    }
}

