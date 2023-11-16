using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminFunctions
{
    public class euCitizen
    {
        string _name;
        string _birthday;
        string _address;
        string _city;
        string _id;
        public string Name { get { return _name; } set { _name = value; } }
        public string Birthname { get { return _birthday; } set { _birthday = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        
        public euCitizen(string Name,string Birthday,string Address,string City,string ID)
        {   
            _name = Name;
            _birthday = Birthday;
            _address = Address;
            _city = City;
            _id = ID;
            
        }
    }
}
