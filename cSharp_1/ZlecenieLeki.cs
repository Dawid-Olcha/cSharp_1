using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace cSharp_1
{
    public class ZlecenieLeki:Zlecenie
    {
        public List<Lek> listPrzepisaneLeki;

        public ZlecenieLeki(ref Pracownik _pracownik, string tresc, Pacjent _pacjent)
        {
            NrZlecenia = Interlocked.Increment(ref _liczbaZlecen);
            DataZlecenia = DateTime.Now;
            DataZakonczenia = null;
            pracownik = _pracownik;
            TrescZlecenia = tresc;
            listPrzepisaneLeki = new List<Lek>();
            pacjent = _pacjent;
            logList = new List<StatusLog>();
        }

        public override void pokazZlecenie()
        {
            Console.WriteLine("Zlecenie nr: " + NrZlecenia);
            Console.WriteLine("Pacjent: " + pacjent.Imie + " " + pacjent.Nazwisko + " ID: " + pacjent.numerId);
            listPrzepisaneLeki.ForEach(item => item.printLek());
            Console.WriteLine("Aktualny Status: " + status);
            logList.ForEach(item => item.printLog());
        }

        public void dodajLek(string nazwa, string dawkowanie)
        {
            listPrzepisaneLeki.Add(new Lek(nazwa, dawkowanie));
        }



    }
}
