using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace cSharp_1
{
    [Flags]
    public enum Status
    {
        None            = 0,
        Lekarz          = 1 << 0,
        Pielegniarka    = 1 << 1,
        Radiolog        = 1 << 2,
        Laboratorium    = 1 << 3, 
    }
    
    public abstract class  Zlecenie
    {
        private static int _liczbaZlecen = 0;
        public Pracownik zleceniobiorca;
        public Pracownik zleceniodawca;
        public Pracownik wykonujacy;
        public Pacjent pacjent;
        Status status;

        public bool Aktywne { get; set; }
        public int NrZlecenia { get; set; }
        public string TrescZlecenia { get; set; }
        public DateTime DataZlecenia { get; set; }
        public DateTime? DataWykonania { get; set; }


    }

}
