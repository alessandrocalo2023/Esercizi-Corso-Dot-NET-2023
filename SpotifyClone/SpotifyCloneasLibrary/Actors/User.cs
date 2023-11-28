using System;
using System.Collections;
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
        User _UserLogin;
        Song _Song;
        Start _Start;
        Album _Album;
        Playlist _Playlist;
        Radio _Radio;
        Administrator admin = new Administrator();
        internal bool _adminflag;
        Mediacomponent _Mediacomponent = new Mediacomponent();
       //Administrator _admin =new Administrator () ;

         List<Song> _SongList= new List<Song>();
        

         List<Album> _AlbumList =new List<Album>();
         List<Playlist> _PlayList = new List<Playlist>();
         List<Radio> _RadioList = new List<Radio>();
      
        //public string Username { get => Username; set => Username = value; }
        //public string Password { get => Password; set => Password = value; }
        internal List<Song> SongList { get => _SongList; set => _SongList = value; }
        internal List<Album> AlbumList { get => _AlbumList; set => _AlbumList = value; }
        internal List<Playlist> Playlist { get => _PlayList; set => _PlayList = value; }
        internal List<Radio> Radio { get => _RadioList; set => _RadioList = value; }

        //metodo scelta del oggetto da
        //utilizzare nella riproduzione
       
        public User(string Name, string Surname, string Birthdate,bool AdminFlag):base(Name,Surname,Birthdate )
        { _adminflag = AdminFlag; }

      
        public void UserMenu(User UserLogin,Start Start,Song Song)
        {
           
            
            //_PlayList = new List<Playlist>(); 
            _UserLogin = UserLogin;
            _Song = Song;
            _Start = Start;
           

            Console.WriteLine("*****************************");
            Console.WriteLine("*****   User - Menu ********");
            Console.WriteLine("*****************************");
            Console.WriteLine("** Welcome - "+_UserLogin.Name + " "+ _UserLogin._surname);
            Console.WriteLine("*****************************");
            Console.WriteLine("*** choose you favorite : ***");
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine("1)  Play - Song ");
            Console.WriteLine("2)  PlayList");
            Console.WriteLine("3)  Album");
            Console.WriteLine("4)  Radio");
            Console.WriteLine("5)  Administrator");
            Console.WriteLine("6)  Login");
            Console.WriteLine("0)  Main Menu");
           
            _choiceMenu = Convert.ToInt16(Console.ReadLine());
            switch (_choiceMenu)
            {
                case 1:
                    _Song.SongMenu(_Song, _UserLogin, _Start) ;
                    break;
                case 2:
                        _Playlist.PlayListMenu(_PlayList);
                    break;
                case 3:
                        _Album.AlbumMenu(_AlbumList);
                    break;
                case 4:
                         _Radio.RadioMenu(UserLogin, _RadioList, _Start, _Song);
                    break;
                    case 5:
                    admin.AdminMenu(_UserLogin,_Start,_Song) ;
                    break;
                    case 0:
                          _Start.Menu();
                    break;
            }
                    if (_choiceMenu == 0 || _choiceMenu > 5) Start.Menu();
            }
        public void NewSong(string Artist, string Group, string Title, int songDurat, string Genre, string RelDate,int Rating, bool AddedToPlaylist)
        {
            Song newsong = new Song(Artist,Group,Title, songDurat,Genre,RelDate,Rating,AddedToPlaylist);
            _SongList.Add(newsong);
            }
      
        public void AddSong(Song Song) 
           
        { _SongList.Add(Song); }

        public void RemoveSong(Song Song)
        { _SongList.Remove(Song); }

        public void AddPlaylist(Playlist Playlist) 
        { _PlayList.Add(Playlist); }
        
        public void RemovePlaylist(Playlist Playlist) 
        { _PlayList.Add(Playlist); }
        
        public void AddRadio(Radio Radio) 
        { _RadioList.Add(Radio); }
        public void RemoveRadio(Radio Radio)
        { _RadioList.Add(Radio); }



    }
}
  



