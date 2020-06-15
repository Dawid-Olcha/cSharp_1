using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace cSharp_1
{
    public class KartaPacjenta
    {

        public string przebiegChoroby;
        public Wywiad? wywiad;
        public Wypis? wypis;   
        public string Grupa_Krwi { get; set; }
        public Date dataPrzyjecia;
        public Date? dataWypisu;
        public int telOsobyKontaktowej;

        KartaPacjenta(string przebieg, string krew, int tel)
        {
            przebiegChoroby = przebieg;
            Grupa_Krwi = krew;
            dataPrzyjecia = Date.Now;
            telOsobyKontaktowej = tel;
            wywiad = null;
            wypis = null;
            dataWypisu = null;
        }
        
        edytujKartaPacjenta(int string przebieg, string krew, int tel)
        {
            przebiegChoroby = przebieg;
            Grupa_Krwi = krew;
            telOsobyKontaktowej = tel; 
        }
        
        

    }
}
