using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
    internal class Group
    {
        private string _name;
        private string _bio;
        Song _Song;
        Artist _Artist;
        Album _Album;
        int _SongDurat;
        private List<Artist> _artist;
        private List<Album> _album;
        private List<Song> _song;

        public string Name { get => _name; set => _name = value; }
        public string Bio { get => _bio; set => _bio = value; }
        internal List<Artist> Artist { get => _artist; set => _artist = value; }
        internal List<Album> Album { get => _album ; set => _album = value;}
        internal List<Song> Song { get => _song ; set => _song = value;}

        //class group constructor
        public Group() { }
        
            
        public void AddSong(Song Song) { }
        public void RemoveSong(Song Song) { }
        public void AddArtist(Artist Artist) { }
        public void RemoveArtist(Artist Artist) { }
        public void AddAlbum(Artist Album) { }
        public void RemoveAlbum(Artist Album) { }
    }
}


