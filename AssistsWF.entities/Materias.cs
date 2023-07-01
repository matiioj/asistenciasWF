using System;


namespace AssistsWF.entities
{
    public class Materias
    {
        public int id_materia { get; set; }
        public string Nombre { get; set; }
        public list<Estudiantes> estudiantes { get; set; }        
        public list<Asistencias> asistencias { get; set; }
    }
}
    
