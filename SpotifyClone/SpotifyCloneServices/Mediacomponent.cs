using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using SpotifyCloneDatasource;
using SpotifyCloneDatasource.Users;
using SpotifyCloneService.Interfaces;


namespace SpotifyCloneServices
{
    public class Mediacomponent : Imedia
    {
        #region Attributes
        Song _Song;
        //string _cultureinfo;
        //string Dateformat = "dddd, dd MMMM yyyy HH:mm";
        //DateTime output;
         User _User;
       // string Time;
        string TimeConv;
        int _TimeLeft;
        int _TimeLeftSec;
        int _TimeLeftMin;
        int _TimeLeftHour;
        int _TimeLeftDays;
        int _SongDurat;
        int _TimeMin;
        int _TimeSec;
        int m;
        int s;
        int _min;
        int _sec;
        bool _Play;
        #endregion

        //implementazione metodi del Media player IMedia
        public Mediacomponent() { }
        #region Play Function
        public void Play(User User,Song Song)
        {
            _Song = Song;
            _SongDurat = _Song._duration;
            _Song._rating++;
            //conversione di _SongDurat da XXXsec a Min:Sec
            _TimeMin = _SongDurat / 60;
            _TimeSec = _SongDurat - (_TimeMin * 60);
            _min = _TimeMin;
            _sec = _TimeSec;
            TimeLeft(User, Song);
            Console.WriteLine("Play-> " + " " + "< " + _Song._title + ">");
            Console.WriteLine("(S) - Stop" + "" + ":" + "(X) - Pause" + " " + ":"
                                           + "(N) - Next" + " " + ":" + "(P) -Prev ");
                  while (_min >= 0)
            {
                while (_sec > 0)
                {
                    Console.Write("\r ");
                    Console.Write(_min + ":");
                    Console.Write(_sec);

                    System.Threading.Thread.Sleep(1000);
                    _sec--;
                }
                _sec = 0;
                _min--;
                _sec = 59;
            }
        }
        #endregion
        #region Play Playlist
        public void PlayList(User User ,List<Song> Playlist)
        {

            foreach (var track in Playlist)
            {
                track._rating++;
                Play(User,track);
            }
        }
        #endregion
        #region Play Album
        public void PlayAlbum(User User, List<Song> AlbumSong)
        {

            foreach (var track in AlbumSong)
            {
                //Song's rating increase
                track._rating++;
                Play(User, track);
            }
        }
        #endregion

        #region Other Song Functions
        public void Stop(Song Song) { }
        public void Pause(Song Song) { }

        public void Next(Song Song) { }
        public void Previuos(Song Song) { }
        #endregion
        #region Listen Time Managing
        public void TimeLeft(User User, Song song)
        {
            _User = User;
            _Song = song;
            // _cultureinfo = cultureinfo;
            if (User._ListenTime >= _Song._duration)
            {
                _TimeLeft = User._ListenTime - _Song._duration;
                _User._ListenTime = _TimeLeft;
                //need to convert TimeLeft in ("MM/dd/yyyy HH:mm:ss")
                string Time = TimeConvert(_TimeLeft);
                // Console.WriteLine($"Listen time left :{output.ToString("dddd, dd MMMM yyyy HH:mm")}");
                Console.WriteLine($"Listen time left :{Time}");
                // string input2 = "mercoledì, 29 marzo 2023 02:30"; // > input utente
                //string Dateformat = "dddd, dd MMMM yyyy HH:mm"; // Formato
                // CultureInfo culture = new CultureInfo(_cultureinfo); // > culture input
                // DateTime output;
            }
            else
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("--------- Warning - listening time is over --------");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("you can only listen to automatically selected songs");
                Console.WriteLine("---------------------------------------------------");
                RandomSongs();
            }
        }
        #endregion
        #region Song Time Convert
        public string TimeConvert(int TimeLeft)
        {
            //_TimeLeftSec = TimeLeft- _TimeLeftMin*60 ;
            _TimeLeftMin = TimeLeft / 60;
            _TimeLeftSec = TimeLeft - _TimeLeftMin * 60;
            _TimeLeftHour = _TimeLeftMin / 60;
            _TimeLeftDays = _TimeLeftHour / 24;
            return TimeConv = "" + _TimeLeftDays + " days:" + _TimeLeftHour + " hours:" + _TimeLeftMin + " mins:" + _TimeLeftSec + " secs";
        }
        #endregion
        #region Play Songs Randomly
        public void RandomSongs()
        {
            //create a random list of songs to play
            List<Song> RandomSonglist = new List<Song>();
            //Mediacomponent.PlayList(RandomSongList)}  
        }
        #endregion
        #region Show Movie List
        public void ShowMovie(User User, List<Movie> MovieList) { }
        #endregion
        #region Play Movie
        public void PlayMovie(User User, Movie Movie) { }
        #endregion

    }
}



