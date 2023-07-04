using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistsWF.Services

{
    public class DataService
    {
        private const string PathFiles = @"\AppClinica.Services\Data\";

        //Traer los datos del Archivo Json
        public string GetDataFromFileJson(string FileName)
        {
            string DataReturn;

            using (var reader = new StreamReader(PathFiles + FileName))
            {
                DataReturn = reader.ReadToEnd();
            }

            return DataReturn;
        }
    }
}