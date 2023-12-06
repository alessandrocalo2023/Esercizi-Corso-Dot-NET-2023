using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SpotifyCloneDatasource.Users
{
    public class UserPremium : User
    {
        public string _userProfile="Premium";
        public int _listenTime= 3600000;
        public string _username= "premium";
        public string _password= "premium";

        public string UserProfile { get => _userProfile; set => _userProfile = value; }
        public int ListenTime { get => _listenTime; set => _listenTime = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }

        public UserPremium() { }
       // public UserPremium(string Name, string Surname, string Birthdate, bool AdminFlag)
         //          : base(Name, Surname, Birthdate, AdminFlag)
        //{
      
        //}
}
}

