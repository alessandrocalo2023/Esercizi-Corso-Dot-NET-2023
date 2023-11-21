using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyClone.Interfaces;

namespace SpotifyClone.Entities
{    internal class mediacomponent:Imedia
    {

        song _Song; 
        int _SongDurat;
        //implementazione metodi del Media player IMedia

        public void Play(song Song) {
            _Song = Song;
            _SongDurat = _Song._duration;
            //execution
            while (_SongDurat > 0)
            {
                Console.WriteLine("Play-> " + " " + _Song._title + _SongDurat--);
                Task.Delay(1000);
            }


        }
        public void Stop() { }
        public void Pause() { }

        public void Next() { }
        public void Previuos() { }
    }

}
