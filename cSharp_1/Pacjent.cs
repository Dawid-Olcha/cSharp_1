using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace cSharp_1
{
    public class Pacjent:Osoba
    {
        public List<Adres> adresList = new List<Adres>();
        public KartaPacjenta kartaPacjenta;
        public int numerId;
        public static int _pacjentIdValue = 0;

        public Pacjent()
        {
            numerId = Interlocked.Increment(ref _pacjentIdValue);
            Imie = "Konrad";
            Nazwisko = "Grzywa";
            Pesel = 12345678901;
        }




    }
}
