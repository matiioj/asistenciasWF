using System;


namespace AssistsWF.entities
{
    public class Asistencia
    {
        public Estudiante estudiante { get; set; }
        public Materia materia { get; set; }
        public DateTime fecha { get; set; }
        public bool presente { get; set; }
    }
}

