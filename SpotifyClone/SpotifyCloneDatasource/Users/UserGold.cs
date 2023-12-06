using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCloneDatasource.Users
{
    public class UserGold : User
    {
        private string userProfile = "Gold";
        private int listenTime = 360000000;
        private string username = "gold";
        private string password = "gold";

public string UserProfile { get => userProfile; set => userProfile = value; }
        public int ListenTime { get => listenTime; set => listenTime = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public UserGold() { }
        //public UserGold(string Name, string Surname, string Birthdate, bool AdminFlag) :
          //  base(Name, Surname, Birthdate, AdminFlag)
        //{
            
        //}
    }
}
