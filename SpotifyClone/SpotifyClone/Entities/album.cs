using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
   public class Album
    {
        private string _nameAlbum;
        private string _genre;
        private string _releaseDate;
        private int _trackNum;
        Group _groupAlbum;
        Artist _artistAlbum;
        private List<Song> _song;

        public string NameAlbum { get => _nameAlbum; set => _nameAlbum = value; }
        public string Genre { get => _genre; set => _genre = value; }
        public string ReleaseDate { get => _releaseDate; set => _releaseDate = value; }
        public int TrackNum { get => _trackNum; set => _trackNum = value; }
        internal List<Song> Song { get => _song; set => _song = value; }
        internal Group GroupAlbum { get => _groupAlbum; set => _groupAlbum = value; }
        internal Artist ArtistAlbum { get => _artistAlbum; set => _artistAlbum = value; }
    }
}
