using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
    public class Song
    {
        public int _choiceMenu;
        //Attributes of single song
        public  string _title;
        public int _duration;
        public string _genre;
        public string _releaseDate;
        public string _artist;
        public string _group;
        public int _rating;
        public bool _AddedToPlaylist;
        
        //list of aggregators
        public List<Artist> ArtistList= new List<Artist>();
        public List<Album> AlbumList = new List<Album>();
        public List<Group> GroupList = new List<Group>();
        Song _song;
        User _User;
        Start _Start;
        Mediacomponent Mediacomponent = new Mediacomponent();



        public Song(string ArtistName, string GroupName, string Title, int songDurat, 
                    string Genre, string RelDate,int Rating,bool AddedToPlaylist ) {
            _artist=ArtistName;
            _group=GroupName;
            _title = Title;
            _duration = songDurat;
            _genre = Genre;
            _releaseDate = RelDate;
            _rating = Rating;
            _AddedToPlaylist = AddedToPlaylist;
        }
        public void SongMenu(Song Song,User User,Start Start) {
            _song = Song;
            _User = User;
            _Start = Start;
            Console.WriteLine("*****************************");
            Console.WriteLine("*****   Song - Menu ********");
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine("1) Play - Song");
            Console.WriteLine("0) User menu");
            _choiceMenu = Convert.ToInt16(Console.ReadLine());
            switch (_choiceMenu)
            {
                case 1:
                    //implementare ricerca per sorgente audio o verificare valore scelta da Menu start
                    Mediacomponent.Play(_song);
                    break;
                case 0:
                    _User.UserMenu(User, Start, Song);
                    break;
            }
        }


       
    }
}