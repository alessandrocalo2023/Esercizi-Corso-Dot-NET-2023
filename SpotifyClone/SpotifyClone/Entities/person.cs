using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
    abstract public class Person
    {
        private string _name;
        private string _surname;
        private string _birthdate;

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Birthdate { get => _birthdate; set => _birthdate = value; }
    }
}