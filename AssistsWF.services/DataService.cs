using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistsWF.services

{
    public class DataService
    {
        private const string PathFiles = @"C:\Users\Franco Sistemas\Desktop\asistenciaspa\AssistsWF.services\Data\";

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

        public bool SaveDataToFile(string JsonData, string FileName)
        {
            bool Success = false;
            FileName = PathFiles + FileName;

            if (File.Exists(FileName))
            {
                File.WriteAllText(FileName, JsonData);
                Success = true;
            }

            return Success;
        }
    }
}