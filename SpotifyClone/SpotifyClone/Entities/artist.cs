using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
    internal class artist
    {
        private string _name;
        private string _bio;
        group _group;
        private List<album> _album;
        private List<song> _songFavorite;

        public string Name { get => _name; set => _name = value; }
        public string Bio { get => _bio; set => _bio = value; }
        internal group Group { get => _group; set => _group = value; }
        internal List<album> Album { get => _album; set => _album = value; }
        internal List<song> Song { get => _songFavorite; set => _songFavorite = value; }

        public void AddSong() { }
        public void RemoveSong() { }
        public void AddAlbum() { }
        public void RemoveAlbum() { }
    }
}
