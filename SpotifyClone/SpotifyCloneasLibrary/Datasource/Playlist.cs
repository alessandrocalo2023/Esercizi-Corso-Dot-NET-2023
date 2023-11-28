using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
    public class Playlist
    {   int _choiceMenu;
        string _name;
       // User _User;
       // Song _Song;
        //int _SongDurat;
        List<Song> _SongList= new List<Song>();
        Mediacomponent Mediacomponent = new Mediacomponent();

        public string Name { get => _name; set => _name = value; }
       // internal User User { get => _User; set => _User = value; }
        internal List<Song> SongList { get => _SongList; set => _SongList = value; }

        public Playlist(string Name,List<Song> Songs)
        { _name = Name;
            //_User = User;
            _SongList = Songs;
        }
        public void PlayListMenu(List<Playlist> Playlist)
        {
          

            Console.WriteLine("*****************************");
            Console.WriteLine("*****   PlayList - Menu ********");
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine("1) Show   -Playlist");
            Console.WriteLine("2) Play   -Playlist");
            Console.WriteLine("3) Add    - Song");
            Console.WriteLine("4) Remove - Song");
            Console.WriteLine("0) User  menu");
            _choiceMenu = Convert.ToInt16(Console.ReadLine());
            switch (_choiceMenu)
            {
                case 1:
                    {
                        foreach (var Songs in _SongList)
                        {
                            if (Songs != null)
                                Console.WriteLine(Songs._title);
                            //insert function to write a log file to confirm correct print 
                        }
                    }
                    break;
                case 2:
                    Mediacomponent.PlayList(_SongList);
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 0:
                   // UserMenu(User, Start, Song);
                    break;
            }
        }
        public void AddSong(Song Song)
        {         
            _SongList.Add(Song); }
        public void RemoveSong(Song Song)
        { _SongList.Remove(Song); }
       
    } }
