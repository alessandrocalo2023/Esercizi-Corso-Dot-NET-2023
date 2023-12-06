using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SpotifyCloneDatasource;


namespace SpotifyCloneDatasource.Users
{
    public class User : Person
    {
        #region Attributes
        int _choiceMenu;
        public int _ListenTime;
        public string _userprofile;
        public string _dateFormatnow;
        public string _cultureinfo;
        User _UserLogin;
        Song _Song;
        Artist _Artist;
        Album _Album;
        Playlist Playlist;
        Radio _Radio;
 
       public bool _adminflag;
        #endregion
        public User() { }
 public User(string Name, string Surname, string Birthdate, bool AdminFlag)
                    : base(Name, Surname, Birthdate)
        { _adminflag = AdminFlag; }

        public void UserMenu(User UserLogin,int ListenTime)
        {           
            _UserLogin = UserLogin;
            _ListenTime= ListenTime;

            Console.WriteLine("-----------------------------");
            Console.WriteLine("------       Menu      ------");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("-- Welcome - " + _UserLogin.Name + " " + _UserLogin._surname);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Listen Time :"+ _UserLogin._ListenTime);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("--- choose you favorite : ---");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("(1)  PlayList");
            Console.WriteLine("(2)  Album");
            Console.WriteLine("(3)  Artist ");
            Console.WriteLine("(4)  Radio");
            Console.WriteLine("(5)  Movie");
            Console.WriteLine("(6)  Administrator");
            Console.WriteLine("(7)  Login");
            Console.WriteLine("(0)  Main Menu");

            _choiceMenu = Convert.ToInt16(Console.ReadLine());
            switch (_choiceMenu)
            {

                case 1:
                    Playlist.PlayListMenu(_UserLogin, _ListenTime);
                    break;
                case 2:
                    _Album.AlbumMenu(_UserLogin, _ListenTime);
                    break;
                case 3:
                    _Artist.ArtistMenu(_UserLogin);
                    break;
                case 4:
                    _Radio.RadioMenu(_UserLogin);
                    break;

                case 5:
                   // _Movie.MovieMenu(_UserLogin);
                    break;
                case 6:
                   // admin.AdminMenu(_UserLogin);
                    break;
                case 7:
                    //login menu
                    break;
                case 0:
                    //_Start.Menu();
                    break;
            }
           // if (_choiceMenu == 0 || _choiceMenu > 5) //Start.Menu();
        }
        // public void NewSong(string Artist, string Group, string Title, int songDurat,
        //                    string Genre, string RelDate,int Rating, bool AddedToPlaylist)
        // {
        //   Song newsong = new Song(Artist,Group,Title, songDurat,Genre,RelDate,Rating,AddedToPlaylist);
        //    _SongList.Add(newsong);
        //    }

        //public void AddSong(Song Song) 
        //      
        //  { _SongList.Add(Song); }
        //
        // public void RemoveSong(Song Song)
        //  { _SongList.Remove(Song); }

        //  public void AddPlaylist(Playlist Playlist) 
        // { _PlayList.Add(Playlist); }

        //public void RemovePlaylist(Playlist Playlist) 
        // { _PlayList.Add(Playlist); }

        //  public void AddRadio(Radio Radio) 
        //  { _RadioList.Add(Radio); }
        // //  public void RemoveRadio(Radio Radio)
        //   { _RadioList.Add(Radio); }



    }
}




