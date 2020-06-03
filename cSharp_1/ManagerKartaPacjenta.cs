using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_1
{
    public class ManagerKartaPacjenta
    {

        public KartaPacjenta SearchKartaPacjenta(DatabaseSym db, KartaPacjenta kpID)
        {
            return db.kartaPacjentaList.Find(item => item.NrKP.Equals(kpID));
        }
        public void EditKartaPacjenta(KartaPacjenta kp)
        {
            


        }


    }
}
