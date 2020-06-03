using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading;



namespace cSharp_1
{
    public class ZlecenieBadanie:Zlecenie
    {
        public Badanie badanie;
        public string Wynik { get; set; }

        public ZlecenieBadanie()
        {
            //nrZlecenia = data.Zlecenie.count;
            DataZlecenia = DateTime.Now; ;
            DataWykonania = null;
            zleceniobiorca = null;
            zleceniodawca = null;
            wykonujacy = null;
            Aktywne = true;
            TrescZlecenia = null;
            badanie = null;
            pacjent = null;
        }
    }
}
