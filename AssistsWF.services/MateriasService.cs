using AssistsWF.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AssistsWF.services
{
    public class MateriasService
    {
        DataService dataService = new DataService();

        public List<Materia> GetAllMaterias()
        {
            string DataJson = dataService.GetDataFromFileJson("materias.json");

            var Materias = JsonSerializer.Deserialize<List<Materia>>(DataJson);

            return Materias;
        }

        public Materia GetMateriaID(int materiaID)
        {
            Materia materiaSeleccionada = null;

            var Materias = GetAllMaterias()

            materiaSeleccionada = Materias.FirstOrDefault(u => u.id_materia == materiaID);

            return materiaSeleccionada;
        }
    }
}
