using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


namespace cSharp_1
{
    public class Pracownik : Osoba
    {
        public int NumerId { get; set; }
        public static int _pracownikIdValue = 0;

        public void PrzekazZlecenie(Zlecenie zlecenie, Status stat)
        {
            zlecenie.logList.Add(new StatusLog(NumerId, "Przekazanie Zlecenia", zlecenie.status, stat));
            zlecenie.status = stat;
        }


        public Zlecenie WyszukajZlecenie(int? id = null, Status? stat = null)
        {
            if (id != null)
                return Database.zlecenieList.Find(item => item.NrZlecenia.Equals(id));
            else if (stat != null)
                return Database.zlecenieList.Find(item => item.status.Equals(stat));
            else
                return null;
        }

        public List<Zlecenie> wyszukajZleceniaByStatus(Status stat)
        {
            return new List<Zlecenie>(Database.zlecenieList.FindAll(item => item.status.Equals(stat)));
        }

        public void pokazZlecenie(Zlecenie zlecenie)
        {
            zlecenie.pokazZlecenie();
        }
        
        public Pacjent WyszukajPacjent(int id = null, double pesel= null)
        {
            if (id != null)
                return Database.pacjentList.Find(item => item.numerId.Equals(id));
            else if (stat != null)
                return Database.zlecenieList.Find(item => item.Pesel.Equals(pesel));
            else
                return null;
        }

    }
}
