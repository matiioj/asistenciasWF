using AssistsWF.entities;
using AssistsWF.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AssistsWF.Services
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
            string DataJson = dataService.GetDataFromFileJson("Estudiantes.json");
            if (DataJson != null)
            {
                Estudiantes = JsonSerializer.Deserialize<List<Estudiante>>(DataJson);
            }
            else
            {
                Estudiantes = new List<Estudiante>();
            }
        }

        public bool AddMedico(Estudiante estudiante)
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

        public List<Estudiante> GetEstudiantes()
        {
            InicializarLista();
            return Estudiantes;
        }

        public Estudiante GetEstudianteById(int Estudiante)
        {
            InicializarLista();
            Estudiante EstudianteFound = null;

            EstudianteFound = Estudiantes.FirstOrDefault(m => m.Id == id_estudiante);

            return EstudianteFound;
        }

        public bool EditMedico(Estudiante EstudianteEdit)
        {
            bool Success = false;
            InicializarLista();
            int Index = Estudiantes.FindIndex(m => m.id_estudiante == EstudianteEdit.id_estudiante);
            //Modificar el objeto
            Estudiantes[Index] = EstudianteEdit;

            var JsonData = JsonSerializer.Serialize(Estudiantes, new JsonSerializerOptions { WriteIndented = true });

            if (JsonData != null)
            {
                Success = dataService.SaveDataToFile(JsonData, "Medicos.json");
            }

            return Success;
        }

        public bool DeleteMedico(Guid IdMedico)
        {
            bool Success = false;
            InicializarLista();

            int Index = Medicos.FindIndex(m => m.Id == IdMedico);

            if (Index >= 0)
            {
                Medicos.RemoveAt(Index);
                var JsonData = JsonSerializer.Serialize(Medicos, new JsonSerializerOptions { WriteIndented = true });

                if (JsonData != null)
                {
                    Success = dataService.SaveDataToFile(JsonData, "Medicos.json");
                }
            }

            return Success;
        }

    }
}
