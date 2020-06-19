using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_1
{
    public class Pielegniarka:Pracownik
    {
        public Pielegniarka(string imie, string nazwisko, double pesel, int telefon, string plec, Adres adr)
        {
            NumerId = Interlocked.Increment(ref _pracownikIdValue);
            Imie = imie;
            Nazwisko = nazwisko;
            Pesel = pesel;
            Telefon telefon;
            Plec = plec;
            adres = adr;
        }

        public void zakonczZlecenie(Zlecenie z, Pracownik _wykonujacy)
        {
            z.DataZakonczenia = DateTime.Now;
            z.logList.Add(new StatusLog(_wykonujacy.NumerId, "Zakonczenie Zlecenia", z.status, Status.Wykonane));
            z.status = Status.Wykonane;
        }
        
        public Pacjent rejestracjaPacjenta(string imie, string nazwisko, long pesel, int telefon, string plec,
                                            string ulica, string nrDomu, string miasto, string kodPocztowy, string panstwo)
        {
            Adres adr = new Adres(ulica, nrDomu, miasto, kodPocztowy, panstwo);
            Pacjent pacjent = new Pacjent(imie, nazwisko, pesel, telefon, plec, adr);
            pacjentList.Add(pacjent);
        }
        
        public void edytujPacjent(ref Pacjent pacjent, string imie, string nazwisko, int telefon, string plec)
        {
            pacjent.Imie = imie;
            pacjent.Nazwisko = nazwisko;
            pacjent.Telefon = telefon;
            pacjent.Plec = plec;
        }
        
        public return wyszukajPacjent(int id)
        {
           return Database.pacjentList.Find(item => item.numerId.Equals(id));
        }
        
        

    }
}
