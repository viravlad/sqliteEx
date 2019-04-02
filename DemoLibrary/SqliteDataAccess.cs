using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeServer
{
    public class SQliteConnection
    {
        public static List<PersonModel> LoadPeople()
        {
            using (IDbConnection cnn = new SQliteConnection(LoadConnectionString()))
            {

            } 
        }

        public static void SavePerson(PersonModel person)
        {
            using (IDbConnection cnn = new SQliteConnection(LoadConnectionString()))
            {

            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
