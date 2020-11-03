using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokladna
{
    public class SqlRepos : IRepos
    {
        private string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Pokladna;"+
                                    "Integrated Security=True;Connect Timeout=30;Encrypt=False;"+
                                    "TrustServerCertificate=False;ApplicationIntent=ReadWrite;"+
                                    "MultiSubnetFailover=False";

        public void VytvortestData(List<PoklZaznam> vychoziZaznamy)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                string dotaz = "DROP TABLE IF EXISTS [dbo].[PoklZaznamy] CREATE TABLE [dbo].[PoklZaznamy]([IdPoklZaznam] INT NOT NULL PRIMARY KEY,[Cislo] INT NOT NULL,[Datum] DATETIME NOT NULL,[Popis] VARCHAR(250) NOT NULL,[Castka] FLOAT NOT NULL,[Zustatek] FLOAT NOT NULL,[Poznamka] VARCHAR(50) NOT NULL)";
                foreach(var z in vychoziZaznamy)
                {
                    dotaz += $"insert into PoklZaznamy(Cislo, Datum,Popis,Castka, Zustatek,Poznamka)" + $"values({z.Cislo},{z.Datum.ToString("yyyyMMdd")},{z.Popis},{z.Castka},{z.Zustatek},{z.Poznamka})";
                }
                using (SqlCommand sqlCommand=new SqlCommand(dotaz,sqlConnection))
                {
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                }
                
            }

        }
        public List<PoklZaznam> Nactimesic(int rok, int mesic)
        {
            List<PoklZaznam> result = new List<PoklZaznam>();
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                string dotaz = $"select*from PoklZaznamy where YEAR(DFatum)={rok} and MONTH(Datum)={mesic}";
                using (SqlCommand sqlCommand = new SqlCommand(dotaz, sqlConnection))
                {
                    sqlConnection.Open();
                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        while (dataReader.Read())
                        {
                            result.Add(new PoklZaznam(Convert.ToInt32(dataReader["IdPoklZaznam"]),
                                                      Convert.ToInt32(dataReader["Cislo"]),
                                                      Convert.ToDateTime(dataReader["Datum"]),
                                                      dataReader["Popis"].ToString(),
                                                      Convert.ToDouble(dataReader["Castka"]),
                                                      Convert.ToDouble(dataReader["Zustatek"]),
                                                      dataReader["Poznamka"].ToString()));
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return result;
        }

        public List<PoklZaznam> NactiVse()
        {
            List<PoklZaznam> result = new List<PoklZaznam>();
            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("select*from PoklZaznamy", sqlConnection))
                {
                    sqlConnection.Open();
                   using(SqlDataReader dataReader= sqlCommand.ExecuteReader())
                    {
                        while(dataReader.Read())
                        {
                            result.Add(new PoklZaznam(Convert.ToInt32(dataReader["IdPoklZaznam"]),
                                                      Convert.ToInt32(dataReader["Cislo"]),
                                                      Convert.ToDateTime(dataReader["Datum"]),
                                                      dataReader["Popis"].ToString(),
                                                      Convert.ToDouble(dataReader["Castka"]),
                                                      Convert.ToDouble(dataReader["Zustatek"]),
                                                      dataReader["Poznamka"].ToString()));
                        }
                    }
                    sqlConnection.Close();
                }
            }
            return result;
        }

        public PoklZaznam NactiZaznam(int idPokladniZaznam)
        {
            
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
    }
}
