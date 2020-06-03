using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_1
{
    public class Pacjent:Osoba
    {
        public List<Adres> adresList = new List<Adres>();
        public KartaPacjenta kartaPacjenta;
        public int numerId;

    }
}
