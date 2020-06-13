using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace cSharp_1
{
    public abstract class Osoba
    {

        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public long Pesel { get; set; }

        public int Telefon { get; set; }
        public string Plec { get; set; }
        public Adres adres;


    }
}
