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
        Anulowane       = 1 << 4,
        Wykonane        = Lekarz
    }
    
    public abstract class  Zlecenie
    {
        protected static int _liczbaZlecen = 0;
        public Pracownik pracownik;
        public Pacjent pacjent;
        public Status status;
        public List<StatusLog> logList;

        public int NrZlecenia { get; set; }
        public string TrescZlecenia { get; set; }
        public DateTime DataZlecenia { get; set; }
        public DateTime? DataZakonczenia { get; set; }

        public virtual void pokazZlecenie()
        {
        }


    }

}
