using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
    internal class group
    {
        private string _name;
        private string _bio;
        song _Song;
        int _SongDurat;
        private List<artist> _artist;
        private List<album> _album;
        private List<song> _song;

        public string Name { get => _name; set => _name = value; }
        public string Bio { get => _bio; set => _bio = value; }
        internal List<artist> Artist { get => _artist; set => _artist = value; }
        internal List<album> Album { get => _album; set => _album = value; }
        internal List<song> Song { get => _song; set => _song = value; }

        public void AddSong() { }
        public void RemoveSong() { }
        public void AddArtist() { }
        public void RemoveArtist() { }
        public void AddAlbum() { }
        public void RemoveAlbum() { }
    }
}
}
}
