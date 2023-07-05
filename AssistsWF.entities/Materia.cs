using System;


namespace AssistsWF.entities
{
    public class Materia
    {
        public int id_materia { get; set; }
        public string nombre_materia { get; set; }
        public list<Estudiante> estudiantes { get; set; }        
        public list<Asistencia> asistencias { get; set; }
    }
}
    
