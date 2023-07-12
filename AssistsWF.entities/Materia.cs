using System;
using System.Collections.Generic;

namespace AssistsWF.entities
{
    public class Materia
    {
        public Guid id_materia { get; set; }
        public string nombre_materia { get; set; }
        public List<Asistencia> asistencias_materia { get; set; }

        public Materia()
        {
            asistencias_materia = new List<Asistencia>();
        }
    }
}
    
