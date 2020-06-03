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
            Console.WriteLine(l1.Imie);
            Console.WriteLine(l1.NumerId);
            Console.WriteLine(l2.Imie);
            Console.WriteLine(l2.NumerId);

            ZlecenieManager h1 = new ZlecenieManager();
            //h1.DodajZlecenieBadania(l1);
            Console.WriteLine(h1.zlecenieList[0].DataZlecenia);
            Console.WriteLine(h1.zlecenieList[0].NrZlecenia);
            Console.WriteLine(h1.zlecenieList[0].zleceniodawca.Imie);


        }
    }

}