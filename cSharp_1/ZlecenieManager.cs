﻿using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_1
{
    public class ZlecenieManager
    {
        public List<Zlecenie> zlecenieList = new List<Zlecenie>();
        public List<Badanie> badanieList = new List<Badanie>();

        public ManagerPacjentow manPacj;
        public ZlecenieManager()
        {
        }

        public void DodajZlecenieBadania(Pracownik pr, Badanie b, Pacjent pa, string tresc)
        {
            ZlecenieBadanie _zlecenie = new ZlecenieBadanie
            {
                zleceniodawca = pr,
                pacjent = pa,
                badanie = b,
                TrescZlecenia = tresc,
            };
            zlecenieList.Add(_zlecenie);
        }

        public Badanie WyszukajBadanie(int? id = null, string nazwa = null)
        {
            Badanie result = new Badanie();

            if (id != null)
                result = badanieList.Find(item => item.Id.Equals(id));
            if (nazwa != null)
                result = badanieList.Find(item => item.NazwaBadania.Equals(id));
            return result;

        }

        public void przypnijZlecenie(Zlecenie z, Pracownik _zleceniobiorca = null)
        {
            if (_zleceniobiorca != null)
                z.zleceniobiorca = _zleceniobiorca;


        }

        public void wykonajZlecenie(Zlecenie z, Pracownik _wykonujacy = null)
        {
            z.DataWykonania = DateTime.Now;
            if (_wykonujacy != null)
                z.wykonujacy = _wykonujacy;
            z.Aktywne = false;
            // DODAC IMPLEMENTACJE DODANIA WYKONANEGO ZLECENIA (NR ZLECENIA) DO KARTY PACJENTA ?????
        }

        //public Zlecenie wyszukajZlecenie();
        //public void edytujZlecenie();
        //public void listaZlecen();
        //public void anulujZlecenie();




    }
}
