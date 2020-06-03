using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace cSharp_1
{
    public abstract class Osoba
    {

        public static int _pracownikIdValue = 0;
        public static int _pacjentIdValue = 0;
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public long Pesel { get; set; }

        public int Telefon { get; set; }
        public string Plec { get; set; }


    }
}
