using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicSerialization
{
    public static class SerializeCatalog
    {
        public static void Serialize(string outputFile, Catalog catalog)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Catalog));

            using (FileStream fs = new FileStream(outputFile, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, catalog);
            }
        }
        public static Catalog Deserialize(string inputFile)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Catalog));

            using (FileStream fs = new FileStream(inputFile, FileMode.OpenOrCreate))
            {
                return (Catalog)formatter.Deserialize(fs);
            }
        }
    }
}
