using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyCloneDatasource.Users;

namespace SpotifyCloneDatasource.Dto
{
    internal class UserPlayDto
            {
        string _name;
        string _surname;
        string _userprofile;

        public UserPlayDto(User User) 
        {
            _name = User._name;
            _surname= User._surname;
            _userprofile = User._userprofile;
        }   
    }
}
