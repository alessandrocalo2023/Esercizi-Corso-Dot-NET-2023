using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
    public class User : Person
    {
        public string _username = "admin";
        public string _password = "admin";
        internal string UserMenuTop = "1) Song - 2) PlayList - 3) Album - 4) Radio - 5)Search - 5) Main Menu";
        int _choiceMenu;
        private List<Song> _song;
        private List<Album> _album;
        private List<Playlist> _playlist;
        private List<Radio> _radio;

        //public string Username { get => Username; set => Username = value; }
        //public string Password { get => Password; set => Password = value; }
        internal List<Song> Song { get => _song; set => _song = value; }
        internal List<Album> Album { get => _album; set => _album = value; }
        internal List<Playlist> Playlist { get => _playlist; set => _playlist = value; }
        internal List<Radio> Radio { get => _radio; set => _radio = value; }

        //metodo scelta del oggetto da
        //utilizzare nella riproduzione
        public User() { }
        public void UserMenu(Start Start)
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("*****   Guest - Menu ********");
            Console.WriteLine("*****************************");
            Console.WriteLine("*** choose you favorite : ***");
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine("1) Song :");
            Console.WriteLine("2) PlayList");
            Console.WriteLine("3) Album");
            Console.WriteLine("4) Radio");
            Console.WriteLine("5) Main Menu");
            _choiceMenu = Convert.ToInt16(Console.ReadLine());
            switch (_choiceMenu)
            {
                case 1:

                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
                    if (_choiceMenu == 0 || _choiceMenu > 5) Start.Menu();
            }
        public void AddPlaylist() { }
        public void RemovePlaylist() { }


    }
}
  



