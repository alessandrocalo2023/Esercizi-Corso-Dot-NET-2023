using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyClone.Interfaces;

namespace SpotifyClone.Entities
{    public class Mediacomponent:Imedia
    {

        Song _Song;
        List<Song> _SongList;//serve per la gestione della riproduzione della coda di canzoni  
        Album _Album;
        Playlist _Playlist;

        int _SongDurat;
        int _TimeMin;
        int _TimeSec;
        int m;
        int s;
        int _min;
        int _sec;

        //implementazione metodi del Media player IMedia

        public void Play(Song Song) 
        {
            _Song = Song;
            _SongDurat = _Song._duration;
            //progettare conversione di _SongDurat da XXXsec a Min:Sec
            _TimeMin = _SongDurat / 60;
            _TimeSec = _SongDurat - (_TimeMin * 60);
            _min = _TimeMin;
            _sec=_TimeSec;
           Console.WriteLine("Play-> " + " " + _Song._title +" " +":" );
            for (m = 0; m > _min; m++) 
            {  for(s = 0; s > _sec; s++)
                {                   
                    Console.WriteLine(_TimeMin + ":" + _TimeSec);
                    
                    Task.Delay(100000);
                    _TimeSec--;
                    Console.WriteLine(_TimeMin);
                }
                _TimeMin--;
                _sec = 60;
                Console.WriteLine(_TimeMin);
            }

        }
  
        public void Play(Album Album) { }
        public void Play(Playlist Playlist) { }
        
        public void Stop(Song Song) { }
        public void Pause(Song Song) { }

        public void Next(Song Song) { }
        public void Previuos(Song Song) { }
    }

}
