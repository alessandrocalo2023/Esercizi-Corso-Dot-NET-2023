using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace SpotifyClone.Entities
{    public class Mediacomponent
    {

        Song _Song;
        List<Song> _SongList =new List<Song>();//serve per la gestione della riproduzione della coda di canzoni  
        
        int _SongDurat;
        int _TimeMin;
        int _TimeSec;
        int m;
        int s;
        int _min;
        int _sec;
        bool _Play;

        //implementazione metodi del Media player IMedia
        public Mediacomponent() { }
        public void Play(Song Song)
        {
            _Song = Song;
            _SongDurat = _Song._duration;
            _Song._rating++;
            //progettare conversione di _SongDurat da XXXsec a Min:Sec
            _TimeMin = _SongDurat / 60;
            _TimeSec = _SongDurat - (_TimeMin * 60);
            _min = _TimeMin;
            _sec = _TimeSec;
            Console.WriteLine("Play-> " + " "+"< " + _Song._title + ">");
            Console.WriteLine("(S) - Stop" + "" + ":" + "(X) - Pause" + " "+ ":" 
                                           + "(N) - Next" + " "+":" + "(P) -Prev ");
           
                while (_min >= 0)
                {
                    while (_sec >= 0)
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
        //play di playlist
        public void PlayList(List<Song> Playlist)
        {
            _SongList = Playlist;
            foreach (var track in _SongList)
            {  track._rating++;
                Play(track);
            } }
        public void PlayAlbum(List<Song> Album)
        {
        
            foreach (var track in Album)
            {
                //Song's rating increase
                track._rating++;
                Play(track);
            }
        }

     


        public void Stop(Song Song) { }
        public void Pause(Song Song) {
    }
    

        public void Next(Song Song) { }
        public void Previuos(Song Song) { }

       
    }
}


