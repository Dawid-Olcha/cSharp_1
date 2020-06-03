using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace cSharp_1
{
    public class Pracownik : Osoba
    {
        public List<Adres> adresList = new List<Adres>();
        public int NumerId { get; set; }



    }
}
