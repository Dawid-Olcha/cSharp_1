using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_1
{
    public class Badanie
    {
        public int Id { get; set; }
        public string NazwaBadania { get; set; }
        public float Koszt { get; set; }
        public WynikBadania? Wynik;
        public bool Wykonanie { get; set; }
        public bool Wynik { get; set; }


        public Badanie()
        {

        }
        
        public Badanie (string nB, float k = null)
        {
            NazwaBadania = nB;
            Koszt = k;
            Wynik = null;
            Wykonanie = False;
            Wynik = False;
        }
        
        

    }
}
