using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
   public class Radio
    {
        int _choiceMenu;
        private string _nameRadio;
        private List<Album> AlbumList;
        private List<Song> Playlist;
        User _User;
        Start _Start;
        Song _Song;

        public string NameRadio { get => _nameRadio; set => _nameRadio = value; }
        internal List<Album> Album{ get => AlbumList; set => AlbumList = value; }
        internal List<Song> SongList { get => Playlist; set => Playlist = value; }
        //public Radio(string Name,string Freq) { }
        public Radio() { }
        public void RadioMenu(User User,List<Radio> Radio, Start Start, Song Song)
        {
            _User = User;
            _Start= Start;
            _Song= Song;
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
                    _User.UserMenu(User, _Start, _Song);
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
