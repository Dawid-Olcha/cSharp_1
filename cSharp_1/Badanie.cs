using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_1
{
    public class Badanie
    {
        //public int Id { get; set; }
        public string NazwaBadania { get; set; }
        public float Koszt { get; set; }
        public WynikBadania? Wynik;
        //public bool Wykonanie { get; set; }



        public Badanie()
        {

        }
        
        public Badanie (string nB, float k = 0)
        {
            NazwaBadania = nB;
            Koszt = k;
            Wynik = null;
        }
        
        public pokazBadanieZlecenia()
        {
            Console.WriteLine("Nazwa badania: " + Nazwabadania + ", Koszt " + Koszt + "PLN"); 
            //string output = "Nazwa badania: " + Nazwabadania + ", Koszt " + Koszt + "PLN";  
            //return  output
        }
        
        

    }
}
