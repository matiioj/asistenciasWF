using AssistsWF.entities;
using AssistsWF.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AssistsWF.services
{
    public class EstudianteService
    {
        DataService dataService;
        private List<Estudiante> Estudiantes;

        public EstudianteService()
        {
            dataService = new();
            InicializarLista();
        }

        private void InicializarLista()
        {
            Estudiantes = null;
            string DataJson = dataService.GetDataFromFileJson("estudiantes.json");
            if (DataJson != null)
            {
                Estudiantes = JsonSerializer.Deserialize<List<Estudiante>>(DataJson);
            }
            else
            {
                Estudiantes = new List<Estudiante>();
            }
        }

        public bool AddEstudiante(Estudiante estudiante)
        {
            bool Success = false;

            Estudiantes.Add(estudiante);

            var JsonData = JsonSerializer.Serialize(Estudiantes, new JsonSerializerOptions { WriteIndented = true });

            if (JsonData != null)
            {
                Success = dataService.SaveDataToFile(JsonData, "Estudiantes.json");
            }

            return Success;
        }

        public List<Estudiante> GetAllEstudiantes()
        {
            InicializarLista();
            return Estudiantes;
        }

        public Estudiante GetEstudianteById(Guid IDEstudiante)
        {
            InicializarLista();
            Estudiante EstudianteFound = null;

            EstudianteFound = Estudiantes.FirstOrDefault(m => m.id_estudiante == IDEstudiante);

            return EstudianteFound;
        }

        public bool EditEstudiante(Estudiante EstudianteEdit)
        {
            bool Success = false;
            InicializarLista();
            int Index = Estudiantes.FindIndex(m => m.id_estudiante == EstudianteEdit.id_estudiante);
            //Modificar el objeto
            Estudiantes[Index] = EstudianteEdit;

            var JsonData = JsonSerializer.Serialize(Estudiantes, new JsonSerializerOptions { WriteIndented = true });

            if (JsonData != null)
            {
                Success = dataService.SaveDataToFile(JsonData, "estudiantes.json");
            }

            return Success;
        }

        public bool DeleteEstudiante(Guid IDEstudiante)
        {
            bool Success = false;
            InicializarLista();

            int Index = Estudiantes.FindIndex(m => m.id_estudiante == IDEstudiante);

            if (Index >= 0)
            {
                Estudiantes.RemoveAt(Index);
                var JsonData = JsonSerializer.Serialize(Estudiantes, new JsonSerializerOptions { WriteIndented = true });

                if (JsonData != null)
                {
                    Success = dataService.SaveDataToFile(JsonData, "Estudiantes.json");
                }
            }

            return Success;
        }

    }
}
