using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_1
{
    public class ZlecenieManager
    {
        public List<Zlecenie> zlecenieList = new List<Zlecenie>();
        public List<Badanie> badanieList = new List<Badanie>();

        public ZlecenieManager()
        {
        }

        public void DodajZlecenieBadania(Pracownik pr, string _tresc, Pacjent pa, string nazwaBad, Status stat)
        {
            ZlecenieBadanie zlecenie = new ZlecenieBadanie(ref pr, _tresc, pa, nazwaBad);
            zlecenie.status = stat;
            zlecenie.logList.Add(new StatusLog(pr.NumerId, "Utworzenie Zlecenia", stat,stat));
            zlecenieList.Add(zlecenie);
        }

        public void OtworzZlecenieLeki(Pracownik pr, string _tresc, Pacjent pa, Status stat)
        {
            ZlecenieLeki zlecenie = new ZlecenieLeki(ref pr, _tresc, pa);
            zlecenie.status = stat;
            zlecenie.dodajLek("Viagra", "1mg");
            zlecenie.dodajLek("Tajemniczna Niebieska Pastylka", "5mg");
            zlecenie.dodajLek("Blekitny Dropsik", "10mg");
            zlecenie.logList.Add(new StatusLog(pr.NumerId, "Utworzenie Zlecenia", stat, stat));
            zlecenieList.Add(zlecenie);
        }



        public void PrzekazZlecenie(Pracownik pr, Zlecenie zlecenie, Status stat)
        {
            zlecenie.logList.Add(new StatusLog(pr.NumerId, "Przekazanie Zlecenia", zlecenie.status, stat));
            zlecenie.status = stat;
        }


        public Zlecenie WyszukajZlecenie(int? id = null, Status? stat = null)
        {
            if (id != null)
                return zlecenieList.Find(item => item.NrZlecenia.Equals(id));
            else if (stat != null)
                return zlecenieList.Find(item => item.status.Equals(stat));
            else
            return null;

        }

        public void zakonczZlecenie(Zlecenie z, Pracownik _wykonujacy)
        {
            z.DataZakonczenia = DateTime.Now;
            z.logList.Add(new StatusLog(_wykonujacy.NumerId, "Zakonczenie Zlecenia", z.status, Status.Lekarz));
        }
        
        public List<Zlecenie> wyszukajZleceniaByStatus(Status stat)
        {
            return new List<Zlecenie>(zlecenieList.FindAll(item => item.status.Equals(stat))); 
        }

        public void pokazZlecenie(Zlecenie zlecenie)
        {
            zlecenie.pokazZlecenie();
        }

    }
    

}
