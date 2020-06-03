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
        public string WynikBadania { get; set; }


        public Badanie()
        {

        }
        public Badanie (string nB, float k)
        {
            NazwaBadania = nB;
            Koszt = k;
            WynikBadania = null;
        }

    }
}
