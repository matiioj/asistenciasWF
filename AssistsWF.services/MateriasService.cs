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
    }
}
