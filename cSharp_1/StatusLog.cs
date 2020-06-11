using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_1
{
    public class StatusLog
    {
        public int pracownikID { get; set; }
        public DateTime date { get; set; }
        public string comment { get; set; }

        public Status? from { get; set; }
        public Status? to { get; set; }


        public StatusLog(int id, string comm, Status statFrom, Status statTo)
        {
            pracownikID = id;
            date = DateTime.Now;
            comment = comm;
            from = statFrom;
            to = statTo;
        }

        public void printLog()
        {
            Console.WriteLine("Czas: " + date + " " + from + " -> " + to + " " + comment + " ID: " + pracownikID);
        }
    }

   
}
