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
        
    }
}
