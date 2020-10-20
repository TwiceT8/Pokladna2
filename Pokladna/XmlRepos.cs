using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Pokladna
{
    public class XmlRepos : IRepos
    {
        private string datovysoubor;
        public XmlRepos(string soubor)
        {
            datovysoubor = soubor;
        }

        public void VytvorTestData()
        {
            List<PoklZaznam> ListData = new List<PoklZaznam>();
            ListData.Add(new PoklZaznam(6, 6, new DateTime(2020, 1, 3), "Příjem z banky", 20000, 20000, ""));
            ListData.Add(new PoklZaznam(7, 7, new DateTime(2020, 1, 5), "Tenisové míče", -2356, ListData.Last().Zustatek - 2356, ""));
            ListData.Add(new PoklZaznam(8, 8, new DateTime(2020, 1, 7), "Občerstvení", -8500, ListData.Last().Zustatek - 8500, ""));
            ListData.Add(new PoklZaznam(9, 9, new DateTime(2020, 1, 9), "Pronájem hřiště", 10000, ListData.Last().Zustatek + 10000, ""));
            ListData.Add(new PoklZaznam(10, 10, new DateTime(2020, 1, 11), "Platba zaměstnancům", -15000, ListData.Last().Zustatek - 15000, ""));

            XmlSerializer ser = new XmlSerializer(typeof(List<PoklZaznam>));
            TextWriter textWriter = new StreamWriter(datovysoubor);

            ser.Serialize(textWriter,ListData);
            textWriter.Close();
        }

        public List<PoklZaznam> NactiVse()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<PoklZaznam>)); // instance (de)serializatoru pro urcity typ -->(List<PoklZaznam>)
            FileStream fileStream = new FileStream(datovysoubor, FileMode.Open); //instance dokumentu --> datovysoubor
            XmlReader xmlReader = XmlReader.Create(fileStream); //instance 
                                                                                    //https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer?view=netcore-3.1
            List<PoklZaznam> data = (List<PoklZaznam>)ser.Deserialize(xmlReader);

            return data;
        }

        public PoklZaznam NactiZaznam(int idPokladniZaznam)
        {
            throw new NotImplementedException();
        }

        public void SmazZaznam(PoklZaznam poklZaznam)
        {
            throw new NotImplementedException();
        }

        public void UpravZaznam(PoklZaznam poklZaznam)
        {
            throw new NotImplementedException();
        }

        public PoklZaznam Vytvorzaznam(PoklZaznam poklZaznam)
        {
            throw new NotImplementedException();
        }

        public List<PoklZaznam> Nactimesic(int rok, int mesic)
        {
            throw new NotImplementedException();
        }
    }
}
