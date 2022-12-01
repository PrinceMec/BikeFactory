using BikeFactory.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFactory.Data
{
    public class UserData
    {
        private const string COLUMNSEP = ",";

        public static string GetFilePath()
        {
            return AppDomain.CurrentDomain.BaseDirectory + @"\Users.txt";
        }

        public static List<User> Load()
        {
            //creating list and getting filepath
            var listofusers = new List<User>();
            string filepath = GetFilePath();
            if (!File.Exists(filepath))
                return listofusers;

            //check the whitespaces
            string data = File.ReadAllText(filepath);
            if (data.Trim().Length == 0)
                return listofusers;

            //to create a new line
            string[] lines = data.Split(Environment.NewLine);
            //to seprate with coma
            foreach (string line in lines)
            {
                string[] lineFields = line.Split(COLUMNSEP);
                string username = lineFields[0];
                string password = lineFields[1];
                var user = new User(username, password);
                listofusers.Add(user);
            }

            return listofusers;
        }
    }
}
