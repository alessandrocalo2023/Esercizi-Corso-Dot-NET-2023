using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCloneDatasource.Users
{
    abstract public class Person
    {
        public string _name;
        public string _surname;
        public string _birthdate;

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Birthdate { get => _birthdate; set => _birthdate = value; }

        public Person() { }
        public Person(string Name, string Surname, string Birthdate)
        {
            _name = Name;
            _surname = Surname;
            _birthdate = Birthdate;
        }
    }
}