using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminFunctions.Classes;

namespace AdminFunctions
{
    internal class citizen
    {
        string _name;
        string _birthdate;
        string _address;
        municipality _municipality;
         public void Citizen(string name,municipality Municipality)
        { _municipality = Municipality;
            
         _municipality.AddCitizen(this);
        }
    }
}
