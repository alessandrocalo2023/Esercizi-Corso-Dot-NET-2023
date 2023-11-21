using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
    internal class playlist
    {
        string _name;
        user User;
        song _Song;
        int _SongDurat;
        private List<song> _song;

        public string Name { get => _name; set => _name = value; }
        internal user User1 { get => User; set => User = value; }
        internal List<song> Song { get => _song; set => _song = value; }

        public void AddSong() { }
        public void RemoveSong() { }
        public void Play() { }
        public void Stop() { }
        public void Pause() { }

        public void Next() { }
        public void Previuos() { }
    }
}
