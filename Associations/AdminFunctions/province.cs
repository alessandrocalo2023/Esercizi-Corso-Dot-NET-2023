using AdminFunctions.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace AdminFunctions
{
   public class province:geoArea 
    {
        //blocco di codice per la suddivisione della provincia in comuni
        public string _name;
       
        
        public string Name { get { return _name; } set { _name = value; } }
        public string[] _municSharePop = new string[100] ;
      
        
        public province(string Name)
        {
              _name = Name;
             }
        //fine blocco
        
        
        municipality _municipality;
        
        public void AddMunicipality(municipality Municipality)
        { _municipality = Municipality; }
        public void removeMunicipality(municipality Municipality)
        { _municipality = null; }
        public void ChangeRegion() { }

        //metodi ereditati da EUPublicAdmin
        public void SSNAssistance() { }
        public void EDUSystem() { }
        public void WelfarServices() { }
    }
}
