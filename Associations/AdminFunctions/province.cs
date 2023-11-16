using AdminFunctions.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace AdminFunctions
{
    internal class province:geoArea 
    {
        string _name;
        public string Name { get { return _name; } set { _name = value; } }
        municipality _municipality;

        public void Province(string Name)
        {
            _name = Name;
        }
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
