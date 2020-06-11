using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_1
{
    public class WynikBadania
    {
        public string opis { get; set;}
        public DateTime dataWykonania;

        WynikBadania(string _opis)
        {
            opis = _opis;
            dataWykonania = DateTime.Now;
        }





    }
}
