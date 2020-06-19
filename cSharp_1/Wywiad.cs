using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_1
{
    public class Wywiad
    {
        public List<string> przebyteChoroby; 
        public List<string> rodzinaChoroby; 

     public Wywiad()
     {
        przebyteChoroby = new List<string>(); 
        rodzinaChoroby = new List<string>();   
     }


    public void dodajPrzebytaChoroba(string pCh)
    {
        przebyteChoroby.Add(pCh);
    }
    
    public void dodajRodzinaChoroba(string rCh)
    {
        rodzinaChoroby.Add(rCh);
    }

        
    }
    

    
    
}
