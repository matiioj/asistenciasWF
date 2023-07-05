using AppClinica.Entities;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AssistsWF.services
{
    public class SecurityService
    {
        DataService dataService = new DataService();

        public Usuario Login(string username, string password)
        {
            Usuario UserFound = null;

            var DataJson = dataService.GetDataFromFileJson("user_sessions.json");

            //Deserialize
            List<Usuario> Usuarios = JsonSerializer.Deserialize<List<Usuario>>(DataJson);

            UserFound = Usuarios.Find(u => u.userName == username && u.userPassword == password);

            return UserFound;
        }
    }
}