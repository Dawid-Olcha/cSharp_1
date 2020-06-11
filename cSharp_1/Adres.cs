using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_1
{
    public class Adres
    {
        public string Ulica { get; set; }
        public string NrDomu { get; set; }
        public string Miasto { get; set; }
        public string KodPocztowy { get; set; }
        public string Panstwo { get; set; }

        public Adres(string ulica, string nrDomu, string miasto, string kodPocztowy, string panstwo)
        {
            Ulica = ulica;
            NrDomu = nrDomu;
            Miasto = miasto;
            KodPocztowy = kodPocztowy;
            Panstwo = panstwo;
        }


    }
}
