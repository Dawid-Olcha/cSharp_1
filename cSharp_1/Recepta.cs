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
            PdfDocument pdf = new PdfDocument();
            pdf.Info.Title = "Recepta";
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Verdana", 20, XFontStyle.Bold);
            string fullRecepta = 
            graph.DrawString(lekarz.Imie, font, XBrushes.Black, new XRect(0, 0, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.Center);
            string pdfFilename = "recepta.pdf";
            pdf.Save(pdfFilename);
            Process.Start(pdfFilename);
        }
    }
}
