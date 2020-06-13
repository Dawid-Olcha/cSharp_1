using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_1
{
    public class Recepta
    {
        public int nrRecepty;
        public Pacjent pacjent;
        public Lekarz lekarz;
        List<Lek> listLeki;
        public string refundacja;
        public int oddzialNfz;


        public Recepta(int nrRec, Pacjent p, Lekarz l, string refund, int nfz)
        {
            nrRecepty = nrRec;
            pacjent = p;
            lekarz = l;
            refundacja = refund;
            oddzialNfz = nfz;
            listLeki = new List<Lek>();
        }

        public void DodajLek(string nazwa, string dawka)
        {
            listLeki.Add(new Lek(nazwa, dawka));
        }

        public void GenerujRecepta()
        {
           //http://www.pdfsharp.net/wiki/HelloWorld-sample.ashx  mozna tego uzyc chyba do szybkiej implementacji generowania pdf recepty
        }
    }
}
