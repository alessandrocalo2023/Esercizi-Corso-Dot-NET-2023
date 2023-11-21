using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminFunctions
{
    public class euCitizen
    {
        public string _name;
        public string _birthday;
        public string _address;
        public string _city;
        public string _muniname;// name of Municipaly
        public euID _id;
        public string Name { get { return _name; } set { _name = value; } }
        public string Birthname { get { return _birthday; } set { _birthday = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        
        public euCitizen(string Name,string Birthday,string Address,
                         string City,string MuniName,euID ID)
        {   
            _name = Name;
            _birthday = Birthday;
            _address = Address;
            _city = City;
            _muniname = MuniName;
            _id = ID;
            
        }
    }
}
