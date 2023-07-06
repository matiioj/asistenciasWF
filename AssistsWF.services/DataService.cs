using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistsWF.services

{
    public class DataService
    {
        private const string PathFiles = @"C:\Users\PC\Downloads\asistenciasWF-main\asistenciasWF\AssistsWF.services\Data\";

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