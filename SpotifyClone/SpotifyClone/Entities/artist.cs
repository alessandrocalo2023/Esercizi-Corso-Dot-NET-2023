using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
    internal class Artist
    {
        private string _name;
        private string _bio;
        Song _song;
        Group _group;
        private List<Album> _album;
        private List<Song> _songFavorite;

        public string Name { get => _name; set => _name = value; }
        public string Bio { get => _bio; set => _bio = value; }
        internal Group Group { get => _group; set => _group = value; }
        internal List<Album> Album { get => _album; set => _album = value; }
        internal List<Song> Song { get => _songFavorite; set => _songFavorite = value; }

        public void AddSong(Song Song) { }
        public void RemoveSong(Song Song) { }
        public void AddAlbum(Album Album) { }
        public void RemoveAlbum(Album Album) { }
    }
}
