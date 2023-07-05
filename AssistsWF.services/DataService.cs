using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistsWF.services

{
    public class DataService
    {
        private const string PathFiles = @"C:\Users\%USERPROFILE%\AsistenciasWF\AssistsWF.services\Data\";

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