using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCloneDatasource
{ 
    public class Group
    {
        int _choiceMenu;
        public string _name;
        public string _bio;
        Song _Song;
        Artist _Artist;
        Album _Album;
        int _rating;
        string _genre;
       
        private List<Artist> _ArtistList = new List<Artist>();
        private List<Album> _AlbumList =new List<Album>();
        private List<Song> _SongList = new List<Song>();


        public Group(string Name,string Bio,string Genre, int Rating ,List<Song> Songs)
        {
            _name=Name;
            _bio=Bio;
            _SongList = Songs;
            _genre=Genre;
            _rating=Rating;


        }
        public void GroupMenu(){
            Console.WriteLine("*****************************");
            Console.WriteLine("*****   Group - Menu ********");
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine("(1) Show - Songs");
            Console.WriteLine("(2) Add ");
            Console.WriteLine("(3) Remove ");
            Console.WriteLine("(4) Artist - Show ");
            Console.WriteLine("(5) Add ");
            Console.WriteLine("(6) Remove ");
            Console.WriteLine("(7) Show   - Albums ");
            Console.WriteLine("(8) Add ");
            Console.WriteLine("(9) Remove");
            Console.WriteLine("(0) User menu");
            _choiceMenu = Convert.ToInt16(Console.ReadLine());
            switch (_choiceMenu)
            {
                case 1:
                    {
                        foreach (var Song in _SongList)
                        {
                            if (Song != null)
                                Console.WriteLine(Song);
                            //insert function to write a log file to confirm correct print 
                        }
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    {
                        foreach (var Song in _ArtistList)
                        {
                            if (Song != null)
                                Console.WriteLine(Song);
                        }
                        break;
                    }
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    {
                        foreach (var Song in _AlbumList)
                        {
                            if (Song != null)
                                Console.WriteLine(Song);
                        }
                    } 
                    break;
                case 8:
                    break;
                case 9:
                    break;
                   
                case 0:
                    //UserMenu(User, Start, Song);
                    break;
            }
        }
        public string Name { get => _name; set => _name = value; }
        public string Bio { get => _bio; set => _bio = value; }
        internal List<Artist> Artist { get => _ArtistList; set => _ArtistList = value; }
        internal List<Album> Album { get => _AlbumList; set => _AlbumList = value;}
        internal List<Song> Song { get => _SongList; set => _SongList = value;}

        //class group constructor
        public Group() { }
        
            
        public void AddSong(Song Song) 
        { }
        public void RemoveSong(Song Song) 
        { }
        public void AddArtist(Artist Artist) 
        { }
        public void RemoveArtist(Artist Artist) 
        { }
        public void AddAlbum(Album Album) 
        { }
        public void RemoveAlbum(Album Album) 
        { }
    }
}


