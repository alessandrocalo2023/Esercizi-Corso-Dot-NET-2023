﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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
        
        //*** tempo di ascolto **
        public int _ListenTime;
        //***********************

       // public string _dateFormatnow;
        public string _cultureinfo;


        User _UserLogin;
        Song _Song;
        Start _Start;
        Album _Album;
        Playlist Playlist;
        Artist _Artist;
        Radio _Radio;
        Administrator admin = new Administrator();
        internal bool _adminflag;
        Mediacomponent _Mediacomponent = new Mediacomponent();
        //Administrator _admin =new Administrator () ;
      
        List<Song> _SongList = new List<Song>();
      //  _SongList.Add({"Pink Floyd","Pink Floyd","Coming Back to life", 380, "Rock", "1993",1,false});
    //Console.WriteLine("");
        
        
        List<Album> _AlbumList = new List<Album>();
        List<Playlist> _PlayList = new List<Playlist>();
       
         
            List<Radio> _RadioList = new List<Radio>();
      
        //public string Username { get => Username; set => Username = value; }
        //public string Password { get => Password; set => Password = value; }
        internal List<Song> SongList { get => _SongList; set => _SongList = value; }
        internal List<Album> AlbumList { get => _AlbumList; set => _AlbumList = value; }
        internal List<Playlist> PlayList { get => _PlayList; set => _PlayList = value; }
        internal List<Radio> Radio { get => _RadioList; set => _RadioList = value; }

        //metodo scelta del oggetto da
        //utilizzare nella riproduzione
       
        public User(string Name, string Surname, string Birthdate,bool AdminFlag)
                    :base(Name,Surname,Birthdate )

        { _adminflag = AdminFlag; }
              
        public void UserMenu(User UserLogin,Start Start,Song Song,string cultureinfo)
        {
                       
            _PlayList = new List<Playlist>(); 
            _UserLogin = UserLogin;
            _Song = Song;
            _Start = Start;
           // _dateFormatnow = dateFormatnow;
            _cultureinfo = cultureinfo;
            _ListenTime = _UserLogin._ListenTime;

            Console.WriteLine("*****************************");
            Console.WriteLine("*****    Menu ********");
            Console.WriteLine("*****************************");
            Console.WriteLine("** Welcome - "+_UserLogin.Name + " "+ _UserLogin._surname);
            Console.WriteLine("*****************************");
            Console.WriteLine("*** choose you favorite : ***");
            Console.WriteLine("*****************************");
            Console.WriteLine();
            Console.WriteLine("(1)  Play - Song  - active ");
            Console.WriteLine("(2)  PlayList");
            Console.WriteLine("(3)  Album");
            Console.WriteLine("(4)  Artist ");
            Console.WriteLine("(5)  Radio");
            Console.WriteLine("(6)  Administrator");
            Console.WriteLine("(7)  Login");
            Console.WriteLine("(0)  Main Menu");
           
            _choiceMenu = Convert.ToInt16(Console.ReadLine());
            switch (_choiceMenu)
            {
                case 1:
                    _Song.SongMenu(_Song, _UserLogin, _Start,_cultureinfo );
                    break;
                case 2:
                    Playlist.PlayListMenu(_UserLogin, _PlayList,_ListenTime, _cultureinfo);
                    break;
                case 3:
                        _Album.AlbumMenu(_UserLogin,_AlbumList, _ListenTime,_cultureinfo);
                    break;
                    case 4:
                    _Artist.ArtistMenu(UserLogin);
                    break;
                case 5:
                         _Radio.RadioMenu(_UserLogin, _RadioList, _Start, _Song);
                    break;
                    case 6:
                    admin.AdminMenu(_UserLogin,_Start,_Song,_cultureinfo);
                    break;
                    case 7:
                    //login menu
                    break;
                    case 0:
                          _Start.Menu();
                    break;
            }
                    if (_choiceMenu == 0 || _choiceMenu > 5) Start.Menu();
            }
        public void NewSong(string Artist, string Group, string Title, int songDurat,
                            string Genre, string RelDate,int Rating, bool AddedToPlaylist)
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
  



