using System;
using System.Collections.Generic;

namespace AssistsWF.entities
{
    public class Materia
    {
        public int id_materia { get; set; }
        public string nombre_materia { get; set; }
        public List<Estudiante> estudiantes { get; set; }        
        public List<Asistencia> asistencias { get; set; }
    }
}
    
