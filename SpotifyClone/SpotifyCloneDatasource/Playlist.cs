using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyCloneDatasource.Users;

namespace SpotifyCloneDatasource
{
    public class Playlist
    {
        string _filepath = @"C:\Users\Tiziana\Desktop\Test";
        string _fileplaylist = "Playlist.csv";


        int _choiceMenu;
        string _name;
        string _choicePlaylist;
        public int _ListenTime;
        public string _cultureinfo;
         User _User;
       // Start _Start;
        // Song _Song;
        //int _SongDurat;
        List<Song> _SongList= new List<Song>();
        List<Playlist> _Playlist=new List<Playlist>();
        //Mediacomponent Mediacomponent = new Mediacomponent();

        public string Name { get => _name; set => _name = value; }
       // internal User User { get => _User; set => _User = value; }
        internal List<Song> SongList { get => _SongList; set => _SongList = value; }

        public Playlist(string Name,List<Song> Songs)
        { _name = Name;
            //_User = User;
            _SongList = Songs;
        }
        public void PlayListMenu(User User,int ListenTime)
        {
            //_Playlist = Playlist;
            _ListenTime= ListenTime;
            //_cultureinfo = cultureinfo;

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
                    Console.WriteLine("Chooose your Album to play");
                    _choicePlaylist = Console.ReadLine();
                    List<Playlist> _PlaylistChoice = _Playlist.Where(playlist => playlist._name.Equals(_choicePlaylist)).ToList().ToList();
                    foreach (var playlist in _PlaylistChoice)
                    {
                       // Mediacomponent.PlayList(User,_SongList, _ListenTime);
                    }
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 0:
                   _User.UserMenu(User, _ListenTime);
                    break;
            }
        }
     //   public void AddSong(Song Song)
       // {         
         //   _SongList.Add(Song); }
        //public void RemoveSong(Song Song)
        //{ _SongList.Remove(Song); }
       
    } }
