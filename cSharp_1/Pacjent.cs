using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace cSharp_1
{
    public class Pacjent:Osoba
    {
        public KartaPacjenta? kartaPacjenta;
        public int numerId;
        public static int _pacjentIdValue = 0;

        public Pacjent(string imie, string nazwisko, long pesel, int telefon, string plec, Adres adr)
        {
            numerId = Interlocked.Increment(ref _pacjentIdValue);
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
            Telefon = telefon;
            Plec = plec;
            adres = adr;
            kartaPacjenta = null;
      
        }




    }
}
