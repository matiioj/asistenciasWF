using AssistsWF.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AssistsWF.services
{
    public class MateriaPorID
    {
        DataService dataService = new DataService();

        public Materia GetMateriaID(int materiaID)
        {
            Materia materiaSeleccionada = null;

            var DataJson = dataService.GetDataFromFileJson("materias.json");

            //Deserialize
            List<Materia> Materias = JsonSerializer.Deserialize<List<Materia>>(DataJson);

            materiaSeleccionada = Materias.FirstOrDefault(u => u.id_materia == materiaID);

            return materiaSeleccionada;
        }
    }
}
