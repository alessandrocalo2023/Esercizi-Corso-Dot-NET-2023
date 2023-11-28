using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
   public class Album
    { int i;
        int _choiceMenu;
        public string _nameLP;
        public string _nameAlbum;
        public string _genre;
        public string _releaseDate;
       public int _trackNum;
        int _rating;
        Group _groupAlbum;
        Artist _artistAlbum;
        bool _liveVers;
        List<Album> _Albums;
        List<Song> _AlbumSongs=new List<Song>();
        Mediacomponent Mediacomponent = new Mediacomponent();

        public Album(string nameAlbum, string releaseDate, int trackNum, string Genre,int Rating,
                     Group groupAlbum, Artist artistAlbum, bool liveVers, List<Song> Songs)
        { _nameAlbum = nameAlbum;
            _genre = Genre;
            _releaseDate = releaseDate;
            _trackNum = trackNum;
            _rating = Rating;
            _groupAlbum = groupAlbum;
            _artistAlbum = artistAlbum;
            _liveVers = liveVers;
            _AlbumSongs = Songs;



        }

        public void AlbumMenu(List<Album> AlbumList) {

          _Albums=AlbumList;
           
            


            Console.WriteLine("*****************************");
            Console.WriteLine("*****   Album - Menu ********");
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine("1) Show   - Albums");
            Console.WriteLine("2) Play   - Albums");
            Console.WriteLine("3) Add Song");
            Console.WriteLine("4) Remove Song");
           
            Console.WriteLine("0) User menu");
            _choiceMenu = Convert.ToInt16(Console.ReadLine());
            switch (_choiceMenu)
            {
                case 1:
                    {foreach (var Album in _Albums)
                        {
                            for (i = 0; i < _Albums.Count; i++)
                            { //Album._rating;
                            }


                            foreach (var Albums in _Albums)
                            {
                                if (Albums != null)

                                    Console.WriteLine(Albums._nameAlbum);
                                //insert function to write a log file to confirm correct print 
                            }
                        }
                    }
                    break;
                case 2:
                    //Console.WriteLine("Chooose your Album to play");
                    //_nameLP = Console.ReadLine();
                                                            
                     Mediacomponent.PlayAlbum(_AlbumSongs); 
                    break;
                case 3:
                    break;
                case 4:
                     break;
                case 0:
                    //UserMenu(User, Start, Song);
                    break;
            }
        }

        public string NameAlbum { get => _nameAlbum; set => _nameAlbum = value; }
        public string Genre { get => _genre; set => _genre = value; }
        public string ReleaseDate { get => _releaseDate; set => _releaseDate = value; }
        public int TrackNum { get => _trackNum; set => _trackNum = value; }
        internal List<Song> AlbumList { get => _AlbumSongs; set => _AlbumSongs = value; }
        internal Group GroupAlbum { get => _groupAlbum; set => _groupAlbum = value; }
        internal Artist ArtistAlbum { get => _artistAlbum; set => _artistAlbum = value; }

        public void AddSong(Song Song)
        { _AlbumSongs.Add(Song); }
        public void RemoveSong(Song Song)
        { _AlbumSongs.Remove(Song); }
    }
}
