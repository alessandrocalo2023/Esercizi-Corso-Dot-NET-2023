using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyCloneDatasource.Users;
 
namespace SpotifyCloneDatasource
{ 
    public class Artist

    {   string _filepath = @"C:\Users\Tiziana\Desktop\Test";
        string _fileartist = "Artist.csv";

        string _songOperation;
        int _choiceMenu;
        int _rating;
        string _genre;
        private string _Name;
        private string _Bio;
        private string _BirthDate;
        private List<Group> GroupList = new List<Group>();
        private List<Album> AlbumList = new List<Album>();
        private List<Song> AlbumSongs = new List<Song>();
        private List<Artist> ArtistList = new List<Artist>();
        public Artist(string Name, string Bio, string Date, string Genre, int Rating)

        {
            _Name = Name;
            _Bio = Bio;
            _BirthDate = Date;
            _rating = Rating;
            _genre = Genre;
            

        }

        public void ArtistMenu(User User)
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("*****   Artist - Menu ********");
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine("1) Show      - Artist ");
            Console.WriteLine("2) Show      - Songs");
            Console.WriteLine("3) Add ");
            Console.WriteLine("4) Remove ");
            Console.WriteLine("5) Show      - Album");
            Console.WriteLine("6) Add  ");
            Console.WriteLine("7) Remove");
            Console.WriteLine("8) Show      - Group");
            Console.WriteLine("9) Add  ");
            Console.WriteLine("10) Remove  ");
            Console.WriteLine("0) User menu");
            _choiceMenu = Convert.ToInt16(Console.ReadLine());
            switch (_choiceMenu)
            {
                case 1:
                    foreach (var Artist in ArtistList)
                    {
                        if (Artist != null)
                            Console.WriteLine(Artist._Name);
                        //insert function to write a log file to confirm correct print 
                    }
                    break;
                case 2:
                    {
                        foreach (var Song in AlbumSongs)
                        {
                            if (Song != null)
                                Console.WriteLine(Song._title);
                            //insert function to write a log file to confirm correct print 
                        }
                    }
                    break;
                          //recall metod AddSong
                case 3:
                    break;
                case 4:
                     //recall metod RemoveSong with search option
                    break;
                case 5:
                    foreach (var Album in AlbumList)
                    {
                        if (Album != null)
                            Console.WriteLine(Album._nameAlbum);
                    }

                        break;
                case 6:
                    break;
                case 7:
                    break;
                case 8: {
                        foreach (var Group in GroupList)
                      
                            if (Group != null)
                                Console.WriteLine(Group._name);
                        }
                        break;
                          case 9:
                            break;
                        case 10:
                            break;
                       
                case 0:
                    //UserMenu(User, Start, Song);
                    break;
            }
        }

        public void AddSong(Song Song)
        { AlbumSongs.Add(Song); }
        public void RemoveSong(List<Song> AlbumSongs)
        {
            Console.WriteLine("***** type song's title ****");
            _songOperation = Console.ReadLine();
            foreach (Song song in AlbumSongs)
            {
                if (song != null)
                {
                    if (song._title == _songOperation)
                    {
                        AlbumSongs.Remove(song);
                    }
                }
            }
        }          
        //all functions below can be implemented as Addsong e RemoveSong function
                    public void AddAlbum(Album Album)
                    { AlbumList.Add(Album); }
                    public void RemoveAlbum(Album Album)
                    { AlbumList.Remove(Album); }

                    public void AddGroup(Group Group)
                    { GroupList.Add(Group); }
                    public void RemoveGroup(Group Group)
                    { GroupList.Remove(Group); }

                
            


        public string Name { get => _Name; set => _Name = value; }
        public string Bio { get => _Bio; set => _Bio = value; }
       
        internal List<Album> Album { get => AlbumList; set => AlbumList = value; }
        internal List<Song> Songs { get => AlbumSongs; set => AlbumSongs = value; }
        internal List<Group> Group { get => GroupList; set => GroupList = value; }
    }
        
}

