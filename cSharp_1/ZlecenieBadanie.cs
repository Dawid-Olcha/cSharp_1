using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading;



namespace cSharp_1
{
    public class ZlecenieBadanie:Zlecenie
    {
        public List<Badanie> listBadanie;

        public ZlecenieBadanie(ref Pracownik _pracownik, string tresc, Pacjent _pacjent, string nB, float k = 0)
        {
            NrZlecenia = Interlocked.Increment(ref _liczbaZlecen);
            DataZlecenia = DateTime.Now; ;
            DataZakonczenia = null;
            pracownik = _pracownik;
            TrescZlecenia = tresc;
            listBadanie.Add(new Badanie(nB, k));
            pacjent =_pacjent;
            logList = new List<StatusLog>();
        }

        public override void pokazZlecenie()
        {
            Console.WriteLine("Zlecenie nr: " + NrZlecenia);
            Console.WriteLine("Pacjent: " + pacjent.Imie + " " + pacjent.Nazwisko + " ID: " + pacjent.numerId);
            Console.WriteLine("Badania: " + badanie.NazwaBadania);
            Console.WriteLine("Aktualny Status: " + status);
            logList.ForEach(item => item.printLog());
            Console.WriteLine("");
        }

    }
}
