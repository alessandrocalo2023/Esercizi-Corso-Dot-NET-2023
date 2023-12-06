using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SpotifyCloneDatasource.Users;

namespace SpotifyCloneDatasource
{   public class Radio
    {
        string _filepath = @"C:\Users\Tiziana\Desktop\Test";
        string _fileradio = "Radio.csv";



        int _choiceMenu;
        //public string _dateFormatnow;
        int _ListenTime;
        private string _nameRadio;
        private List<Album> AlbumList;
        private List<Song> Playlist;
        User _User;
        //Start _Start;
        Song _Song;

        public string NameRadio { get => _nameRadio; set => _nameRadio = value; }
        internal List<Album> Album{ get => AlbumList; set => AlbumList = value; }
        internal List<Song> SongList { get => Playlist; set => Playlist = value; }
        //public Radio(string Name,string Freq) { }
        public Radio() { }
        public void RadioMenu(User User)
        {
            _User = User;
            
            //_Song= Song;
           // _dateFormatnow= dateFormatnow;
            _ListenTime= User._ListenTime;
            Console.WriteLine("*****************************");
            Console.WriteLine("*****   Radio - Menu ********");
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine("1) Show   - Radio");
            Console.WriteLine("1) Play   - Radio");
            Console.WriteLine("2) Add    - Radio");
            Console.WriteLine("3) Remove - Radio");
            Console.WriteLine("0) User menu");
            _choiceMenu = Convert.ToInt16(Console.ReadLine());
            switch (_choiceMenu)
            {
                case 1:
                    break;
                case 0:
                    _User.UserMenu(User, _ListenTime);
                    break;
            }
        }
           public void PlayRadio()
        {
            //this function can excute a random PlayList
            //Or play a single song at the time 
        }
            public void StopRadio() { }
    }
}
