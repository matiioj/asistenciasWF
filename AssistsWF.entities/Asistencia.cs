using System;


namespace AssistsWF.entities
{
    public class Asistencia
    {
        public Estudiante estudiante { get; set; }
        public string fecha { get; set; }
        public bool presente { get; set; }
    }
}

