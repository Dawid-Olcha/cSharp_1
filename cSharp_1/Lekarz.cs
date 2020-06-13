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

        public void edytujZlecenie(Zlecenie z, string tresc, string nazwa)
        {
            z.TrescZlecenia = tresc;
            
        }

        public void DodajZlecenieBadania(Pracownik pr, string _tresc, Pacjent pa, string nazwaBad, Status stat)
        {
            ZlecenieBadanie zlecenie = new ZlecenieBadanie(ref pr, _tresc, pa, nazwaBad);
            zlecenie.status = stat;
            zlecenie.logList.Add(new StatusLog(pr.NumerId, "Utworzenie Zlecenia", stat, stat));
            Database.zlecenieList.Add(zlecenie);
        }

        public void OtworzZlecenieLeki(string _tresc, Pacjent pa, Status stat)
        {
            ZlecenieLeki zlecenie = new ZlecenieLeki(this, _tresc, pa);
            zlecenie.status = stat;
            zlecenie.dodajLek("Viagra", "1mg");
            zlecenie.dodajLek("Tajemniczna Niebieska Pastylka", "5mg");
            zlecenie.dodajLek("Blekitny Dropsik", "10mg");
            zlecenie.logList.Add(new StatusLog(NumerId, "Utworzenie Zlecenia", stat, stat));
            Database.zlecenieList.Add(zlecenie);
        }

        public void anulujZlecenie(Zlecenie z, Pracownik _wykonujacy)
        {
            z.DataZakonczenia = DateTime.Now;
            z.logList.Add(new StatusLog(_wykonujacy.NumerId, "Anuluj Zlecenie", z.status, Status.Anulowane));
            z.status = Status.Anulowane;
        }

        //public Wypis searchWypis()     // Add arguemnents needed for constructor (not implemented at the moment)
        //{

        //    return wypis;
        //}

        //public Wywiad searchWywiad()     // Add arguemnents needed for constructor (not implemented at the moment)
        //{

        //    return wywiad;
        //}


    }
}
