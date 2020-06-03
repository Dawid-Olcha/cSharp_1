using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace cSharp_1
{
    public class Lekarz:Pracownik
    {
        public Lekarz()
        {
            NumerId = Interlocked.Increment(ref _pracownikIdValue);
            Imie = "John";
            Nazwisko = "Smith";
            Pesel = 12345678901;
        }

        public Wypis createWypis()     // Add arguemnents needed for constructor (not implemented at the moment)
        {
            Wypis wypis = new Wypis();
            return wypis;
        }

        public Wywiad createWywiad()     // Add arguemnents needed for constructor (not implemented at the moment)
        {
            Wywiad wywiad = new Wywiad();
            return wywiad;
        }

        public Wypis searchWypis()     // Add arguemnents needed for constructor (not implemented at the moment)
        {

            return wypis;
        }

        public Wywiad searchWywiad()     // Add arguemnents needed for constructor (not implemented at the moment)
        {

            return wywiad;
        }


    }
}
