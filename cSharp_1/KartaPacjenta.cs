using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace cSharp_1
{
    public class KartaPacjenta
    {

        public List<string> przebyteChoroby = new List<string>(); // w wywiadzie?
        public Wywiad? wywiad;
        public Wypis? wypis;   
        public string Grupa_Krwi { get; set; }

        KartaPacjenta()
        {
   
        }

    }
}
