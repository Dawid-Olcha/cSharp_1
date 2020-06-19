using System;
using System.Collections.Generic;

namespace cSharp_1
{
    class Program
    {
        static void Main(string[] args)
        {


            Lekarz l1 = new Lekarz(Tomasz, Nowak, 00000000002,222222222,Mezczyzna, new Adres( Czarna, 2, Szczecin,71-056, Polska));
            Lekarz l2 = new Lekarz(Adam, Nowak, 00000000003,333333333,Mezczyzna, new Adres( Czerwona, 3, Szczecin,71-088, Polska));
            Pielegniarka p1 = new Pielegniarka(Anna, Nowak, 00000000001,111111111,Kobieta, new Adres( Biala, 1, Szczecin,71-004, Polska));
            p1.rejestracjapacjenta(Tomasz, Obolaly, 00000000004,444444444,Mezczyna, Zielona, 4, Szczecin,71-001, Polska);
            pacjent1 = p1.WyszukajPacjent(pesel = 000000004);
            p1.dodajKartaPacjenta(pacjent1, "Boli glowa od tygodnia", "AB Rh-", 987654321);
            
            
            pacjent1 = l1.WyszukajPacjent(pesel = 000000004);
            l1.createWywiad(pacjent1);
            l1.dodajRodzinaChoroba(pacjent1, "Jaskra");
            l1.dodajRodzinaChoroba(pacjent1, "Alergia")
            l1.dodajPrzebytaChoroba(pacjent1, "Rozyczka");
            l1.dodajPrzebytaChoroba(pacjent1, "Ospa");
            
            l1.DodajZlecenieBadania(l1, "Pobranie krwi", pacjent1, "Morfologia", Status.Lekarz);
            l1.DodajZlecenieBadania(l1, "Rentgen kregoslupa", pacjent1, "Rentgen", Status.Lekarz);
            OtworzZlecenieLeki(string _tresc, Pacjent pa, Status stat, string comment = "")
            Zlecenie zlecenie1 = l1.WyszukajZlecenie(1);
            l1.DodajKolejneBadanie(zlecenie1, "Zmierzenie ciśnieni", "mierzenie ciśni", string comment="");
            l1.PrzekazZlecenie(zlecenie1, Status.Pielegniarka);
            p1.WykonajZlecenie(zlecenie1, p1, "Zmierzono Cisnineie");
            p1.
            


  
            l1.DodajZlecenieBadania(l1, "Cos tam cos tam", p1, "Sztywnosc Paly", Status.Lekarz);
            l1.PrzekazZlecenie(Database.zlecenieList[0], Status.Pielegniarka);
            l1.OtworzZlecenieLeki("Tabsy", p1, Status.Lekarz);
            l2.PrzekazZlecenie(Database.zlecenieList[1], Status.Pielegniarka);
            l2.PrzekazZlecenie(Database.zlecenieList[1], Status.Laboratorium);
            l1.pokazZlecenie(Database.zlecenieList[0]);
            l1.pokazZlecenie(Database.zlecenieList[1]);
            var status = Status.Laboratorium;
            if(status.HasFlag(Status.Laboratorium))
                Console.WriteLine("labo " + l1.Imie);
            if (status.HasFlag(Status.Laboratorium))
                Console.WriteLine("labo " + l1.Imie);


        }
    }


    //[Flags]
    //public enum Status
    //{
    //    None = 0,
    //    Lekarz = 1 << 0,
    //    Pielegniarka = 1 << 1,
    //    Laboratorium = 1 << 2,
    //    Radiolog = 1 << 3,
    //}


}
