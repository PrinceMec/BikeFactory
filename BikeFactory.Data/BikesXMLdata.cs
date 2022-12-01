using BikeFactory.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BikeFactory.Data
{
    
    public class BikesXMLdata
    {
        public static string GetFilePath()
        {
            return AppDomain.CurrentDomain.BaseDirectory + @"BikesData.xml";
        }
        public static List<Bike> Load()
        {
            string filePath = GetFilePath();
            if (!File.Exists(filePath))
                return new List<Bike>();


            string filecontent = File.ReadAllText(filePath);
            if (filecontent == "")
                return new List<Bike>();
            using (var reader = new StringReader(filecontent))
            {
                var serializer = new XmlSerializer(typeof(List<Bike>));
                return (List<Bike>)serializer.Deserialize(reader);
            }


        }

        public static void Save(List<Bike> list)
        {
            string filepath = GetFilePath();
            using (var writer = new StreamWriter(filepath))
            {
                var serializer = new XmlSerializer(typeof(List<Bike>));
                serializer.Serialize(writer, list);
            }
        }

    }
}
