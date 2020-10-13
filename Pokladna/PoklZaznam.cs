﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokladna
{
    class PoklZaznam
    {
        public int IdPoklZaznam { get; set; }
        public int Cislo { get; set; }
        public DateTime Datum { get; set; }
        public string Popis { get; set; }
        public double Castka { get; set; }
        public double Zustatek { get; set; }
        public string Poznamka { get; set; }

        public PoklZaznam()
        {
        }

        public PoklZaznam(int idPoklZaznam, int cislo, DateTime datum, string popis, double castka, double zustatek, string poznamka)
        {
            IdPoklZaznam = idPoklZaznam;
            Cislo = cislo;
            Datum = datum;
            Popis = popis;
            Castka = castka;
            Zustatek = zustatek;
            Poznamka = poznamka;
        }
    }
}