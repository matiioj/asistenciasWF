using System;


namespace AssistsWF.entities
{
    public class AsignacionEstudianteMateria
    {
        public Guid id_estudiante { get; set; }
        public List<Guid> id_materias { get; set; }
    }
}

