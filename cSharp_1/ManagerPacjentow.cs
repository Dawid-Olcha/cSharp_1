using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_1
{
    public class ManagerPacjentow
    {
        public List<Pacjent> zlecenieList = new List<Pacjent>();
        public Pacjent wyszukajPacjenta(long? pesel = null, int? id = null)
        {
            Pacjent result = new Pacjent();

            if (pesel!=null)
                result = zlecenieList.Find(item => item.Pesel.Equals(pesel));
            if (id != null)
                result = zlecenieList.Find(item => item.numerId.Equals(id));
            return result;
        }

    }
}
