using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
   public class Playlist
    {
        string _name;
        User User;
        Song _Song;
        int _SongDurat;
        private List<Song> _song;

        public string Name { get => _name; set => _name = value; }
        internal User User1 { get => User; set => User = value; }
        internal List<Song> Song { get => _song; set => _song = value; }

        public void AddSong() { }
        public void RemoveSong() { }
        public void Play() { }
        public void Stop() { }
        public void Pause() { }

        public void Next() { }
        public void Previuos() { }
    }
}
