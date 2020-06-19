using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace cSharp_1
{
    public class Lekarz:Pracownik
    {
        public Lekarz(string imie, string nazwisko, double pesel, int telefon, string plec, Adres adr)
        {
            NumerId = Interlocked.Increment(ref _pracownikIdValue);
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
            Telefon telefon;
            Plec = plec;
            adres = adr;
        }

        public Wypis createWypis(int pesel)    
        {
            Wypis wypis = new Wypis();
            
            return wypis;
        }

        public void createWywiad(ref Pacjent pacjent)     
        {
            Wywiad wywiad = new Wywiad();
            pacjent.KartaPacjenta.wywiad = wywiad;
        }
        
        public void edytujWywiad(ref Pacjent pacjent, string choroba, bool whichChoroba)
        {
            if(whichChoroba)
                pacjent.KartaPacjenta.wywiad.przebyteChoroby.Remove(choroba);
            else if(!whichChoroba)
                pacjent.KartaPacjenta.wywiad.rodzinaChoroby.Remove(choroba);
        }
        
        public void dodajRodzinaChoroba(ref Pacjent pacjent, string choroba)
        {
            pacjent.KartaPacjenta.wywiad.dodajRodzinaChoroba(string);
        }
        
        public void dodajPrzebytaChoroba(ref Pacjent pacjent, string choroba)
        {
            pacjent.KartaPacjenta.wywiad.dodajPrzebytaChoroba(string);
        }

        public void edytujZlecenie(ref Zlecenie z, string tresc)
        {
            z.TrescZlecenia = tresc;
        }

        public void DodajZlecenieBadania(Pracownik pr, string _tresc, Pacjent pa, string nazwaBad, Status stat, string comment)
        {
            ZlecenieBadanie zlecenie = new ZlecenieBadanie(ref pr, _tresc, pa, nazwaBad);
            zlecenie.status = stat;
            zlecenie.logList.Add(new StatusLog(pr.NumerId, "Utworzenie Zlecenia - " + comment, stat, stat));
            Database.zlecenieList.Add(zlecenie);
        }

        public void OtworzZlecenieLeki(string _tresc, Pacjent pa, Status stat, string comment)
        {
            ZlecenieLeki zlecenie = new ZlecenieLeki(this, _tresc, pa);
            zlecenie.status = stat;
            zlecenie.dodajLek("Viagra", "1mg");
            zlecenie.dodajLek("Tajemniczna Niebieska Pastylka", "5mg");
            zlecenie.dodajLek("Blekitny Dropsik", "10mg");
            zlecenie.logList.Add(new StatusLog(NumerId, "Utworzenie Zlecenia - " + comment, stat, stat));
            Database.zlecenieList.Add(zlecenie);
        }

        public void anulujZlecenie(ref Zlecenie z, Pracownik _wykonujacy, string comment)
        {
            z.DataZakonczenia = DateTime.Now;
            z.logList.Add(new StatusLog(_wykonujacy.NumerId, "Anuluj Zlecenie - " + comment, z.status, Status.Anulowane));
            z.status = Status.Anulowane;
        }

        public void wykonajZlecenie(ref Zlecenie z, Pracownik _wykonujacy, string comment)
        {
            z.logList.Add(new StatusLog(_wykonujacy.NumerId, "Wykonano - " + comment); 
        }

    }
}
