using System;

namespace cSharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qrwa jestesmy w dupie ;)");

            Lekarz l1 = new Lekarz();
            Lekarz l2 = new Lekarz();
            Pacjent p1 = new Pacjent();
            Console.WriteLine(l1.Imie);
            Console.WriteLine(l1.NumerId);
            Console.WriteLine(p1.Imie);
            Console.WriteLine(p1.numerId);

            ZlecenieManager h1 = new ZlecenieManager();
            h1.DodajZlecenieBadania(l1, "Cos tam cos tam", p1, "Sztywnosc Paly", Status.Lekarz);
            h1.PrzekazZlecenie(l2, h1.zlecenieList[0], Status.Pielegniarka);
            h1.OtworzZlecenieLeki(l1, "Tabsy", p1, Status.Lekarz);
            h1.PrzekazZlecenie(l2, h1.zlecenieList[1], Status.Pielegniarka);
            h1.PrzekazZlecenie(l2, h1.zlecenieList[1], Status.Laboratorium);
            h1.pokazZlecenie(h1.zlecenieList[0]);
            h1.pokazZlecenie(h1.zlecenieList[1]);
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