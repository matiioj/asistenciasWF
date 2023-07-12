using AssistsWF.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AssistsWF.services
{
    public class AsignacionesService
    {
        DataService dataService = new DataService();
        List<AsignacionEstudianteMateria> Asignaciones;
        EstudianteService estudianteService = new();

        public AsignacionesService()
        {
            dataService = new();
            InicializarLista();
        }

        private void InicializarLista()
        {
            Asignaciones = null;
            string DataJson = dataService.GetDataFromFileJson("asignaciones.json");
            if (DataJson != null)
            {
                Asignaciones = JsonSerializer.Deserialize<List<AsignacionEstudianteMateria>>(DataJson);
            }
            else
            {
                Asignaciones = new List<AsignacionEstudianteMateria>();
            }
        }

        public List<AsignacionEstudianteMateria> GetAllAsignaciones()
        {
            string DataJson = dataService.GetDataFromFileJson("asignaciones.json");

            var Asignaciones = JsonSerializer.Deserialize<List<AsignacionEstudianteMateria>>(DataJson);

            return Asignaciones;
        }

        public bool AddAsignacion(AsignacionEstudianteMateria asignacion)
        {
            bool Success = false;

            Asignaciones.Add(asignacion);

            var JsonData = JsonSerializer.Serialize(Asignaciones, new JsonSerializerOptions { WriteIndented = true });

            if (JsonData != null)
            {
                Success = dataService.SaveDataToFile(JsonData, "asignaciones.json");
            }

            return Success;
        }

        public bool EditAsignacion(AsignacionEstudianteMateria asignacionEdit)
        {
            bool success = false;

            // Buscar la asignación existente por ID de estudiante
            AsignacionEstudianteMateria asignacionExistente = Asignaciones.FirstOrDefault(a => a.id_estudiante == asignacionEdit.id_estudiante);

            if (asignacionExistente != null)
            {
                // Actualizar los datos de la asignación
                asignacionExistente.id_materias = asignacionEdit.id_materias;

                // Guardar los cambios en el archivo
                string jsonData = JsonSerializer.Serialize(Asignaciones, new JsonSerializerOptions { WriteIndented = true });
                if (jsonData != null)
                {
                    success = dataService.SaveDataToFile(jsonData, "asignaciones.json");
                }
            }

            return success;
        }


        public bool DeleteAsignacionesEstudiante(Guid IDEstudiante)
        {
            bool Success = false;
            InicializarLista();

            Asignaciones.RemoveAll(a => a.id_estudiante == IDEstudiante);
    
            var JsonData = JsonSerializer.Serialize(Asignaciones, new JsonSerializerOptions { WriteIndented = true });
            
            if (JsonData != null)
            {
               Success = dataService.SaveDataToFile(JsonData, "asignaciones.json");
            }

            return Success;
        }

        public AsignacionEstudianteMateria GetAsignacionEstudianteByID(Guid IDEstudiante)
        {
            InicializarLista();
            AsignacionEstudianteMateria asignacionFound = null;

            asignacionFound = Asignaciones.FirstOrDefault(m => m.id_estudiante == IDEstudiante);

            return asignacionFound;
        }

        public List<Estudiante> GetEstudiantesByMateriaId(Guid materiaId)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            List<AsignacionEstudianteMateria> asignaciones = GetAllAsignaciones().Where(a => a.id_materias.Contains(materiaId)).ToList();

            
            foreach (AsignacionEstudianteMateria asignacion in asignaciones)
            {
                Estudiante estudiante = estudianteService.GetEstudianteById(asignacion.id_estudiante);
                if (estudiante != null)
                {
                    estudiantes.Add(estudiante);
                }
            }

            return estudiantes;
        }       


        
        
    }
}
