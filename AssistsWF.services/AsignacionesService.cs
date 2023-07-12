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

        public List<Materia> GetAllMaterias()
        {
            string DataJson = dataService.GetDataFromFileJson("asignaciones.json");

            var asignaciones = JsonSerializer.Deserialize<List<Materia>>(DataJson);

            return Materias;
        }

        public Materia GetMateriaID(int materiaID)
        {
            Materia materiaSeleccionada = null;

            var Materias = GetAllMaterias();

            materiaSeleccionada = Materias.FirstOrDefault(u => u.id_materia == materiaID);

            return materiaSeleccionada;
        }
    }
}
