using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace Pokladna
{
    public class JsonRepos : IRepos
    {
        private string datovySoubor;
        public JsonRepos(string soubor)
        {
            datovySoubor = soubor;
        }

        public void VytvorTestData()
        {
            List<PoklZaznam> ListData = new List<PoklZaznam>();
            ListData.Add(new PoklZaznam(1, 1, new DateTime(2020, 1, 3), "Příjem z banky",20000,20000,""));
            ListData.Add(new PoklZaznam(2, 2, new DateTime(2020, 1, 5), "Tenisové míče", -2356, ListData.Last().Zustatek-2356, ""));
            ListData.Add(new PoklZaznam(3, 3, new DateTime(2020, 1, 7), "Občerstvení", -8500, ListData.Last().Zustatek -8500, ""));
            ListData.Add(new PoklZaznam(4, 4, new DateTime(2020, 1, 9), "Pronájem hřiště", 10000, ListData.Last().Zustatek +10000, ""));
            ListData.Add(new PoklZaznam(5, 5, new DateTime(2020, 1, 11), "Platba zaměstnancům", -15000, ListData.Last().Zustatek -15000, ""));

            string json = JsonConvert.SerializeObject(ListData);
            File.WriteAllText(datovySoubor, json);
        }


        public List<PoklZaznam> NactiVse()
        {
            List<PoklZaznam> data;
            data = JsonConvert.DeserializeObject<List<PoklZaznam>>(File.ReadAllText(datovySoubor));
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
            List<PoklZaznam> data = NactiVse();
            //zazanm aje poslední
            if(data.Find(doklad => doklad.Datum > poklZaznam.Datum)==null)
            {
                data.Sort((a,b) => a.IdPoklZaznam.CompareTo(b.IdPoklZaznam));
                poklZaznam.IdPoklZaznam =data.Last().IdPoklZaznam+1;
                    data.Sort((a, b) => a.Datum.CompareTo(b.Datum));
                poklZaznam.Cislo = data.Last().Datum.Month==poklZaznam.Datum.Month? data.Last().Cislo + 1:1;
                poklZaznam.Zustatek = data.Last().Zustatek + poklZaznam.Castka;
                

            }
            //záznam není poslední
            else
            {
                //Id bude nejvyšší +1
                data.Sort((a, b) => a.IdPoklZaznam.CompareTo(b.IdPoklZaznam));
                poklZaznam.IdPoklZaznam = data.Last().IdPoklZaznam + 1;
                //cislo bude o jedna vyssi nez posledni ve stejnem mesici
                List<PoklZaznam> dataMesice = data.FindAll(doklad => doklad.Datum.Year == poklZaznam.Datum.Year
                                                                  && doklad.Datum.Month == poklZaznam.Datum.Month);
                dataMesice.Sort((a, b) => a.Datum.CompareTo(b.Datum));
                if (dataMesice.Count > 0)
                {
                    if (dataMesice.Find(doklad => doklad.Datum > poklZaznam.Datum) == null)
                    //je posledni v mesici
                    {
                        poklZaznam.Cislo = dataMesice.Last().Cislo + 1;
                    }
                    else
                    {
                        int index = dataMesice.FindIndex(doklad => doklad.Datum > poklZaznam.Datum);                       
                        poklZaznam.Cislo = dataMesice[index].Cislo;
                        for (int i = index; i < dataMesice.Count; i++)
                        {
                            dataMesice[i].Cislo++;
                        }

                    }
                }
                else
                {
                    poklZaznam.Cislo = 1;
                }
                //zustatek je 
            }
            data.Add(poklZaznam);

            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(datovySoubor, json);
            return poklZaznam;
        }

        public List<PoklZaznam> Nactimesic(int rok, int mesic)
        {
            List<PoklZaznam> data = NactiVse();
            data.FindAll(prvek => prvek.Datum.Year == rok && prvek.Datum.Month == mesic);
            data.Sort((a, b) => a.Datum.CompareTo(b.Datum));
            return data;
            

        }
    }
}
