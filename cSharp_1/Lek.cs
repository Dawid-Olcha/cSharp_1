﻿using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_1
{
    public class Lek
    {
        public string NazwaLeku { get; set;}
        public string Dawkowanie { get; set; }

        public Lek(string _nazwa, string _dawka)
        {
            NazwaLeku = _nazwa;
            Dawkowanie = _dawka;
        }

        public void printLek()
        {
            Console.WriteLine("Lek: " + NazwaLeku + " Dawkowanie: " + Dawkowanie);
        }
    }
}
