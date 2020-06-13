using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_1
{
    public class Pielegniarka:Pracownik
    {


        public void zakonczZlecenie(Zlecenie z, Pracownik _wykonujacy)
        {
            z.DataZakonczenia = DateTime.Now;
            z.logList.Add(new StatusLog(_wykonujacy.NumerId, "Zakonczenie Zlecenia", z.status, Status.Wykonane));
            z.status = Status.Wykonane;
        }


    }
}
