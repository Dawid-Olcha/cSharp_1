using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace cSharp_1
{
    public class KartaPacjenta
    {
        public List<int> nrZlecenList = new List<int>();
        public List<string> przebyteChoroby = new List<string>();
        private static int _liczbaKP = 0;
        public Wywiad? wywiad;
        public Wypis? wypis;   
        public string Grupa_Krwi { get; set; }
        public int NrKP { get; set; }

        KartaPacjenta()
        {
            NrKP = Interlocked.Increment(ref _liczbaKP);


        }

    }
}
