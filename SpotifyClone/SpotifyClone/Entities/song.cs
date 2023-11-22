using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
    public class Song
    {
        public  string _title;
        public int _duration;
        private List<Artist> _artist;
        private List<Album> _album;
        private List<Group> _group;
        private string _genre;
        private string _releaseDate;


        public Song(string Title, int songDurat) {
            _title = Title;
            _duration = songDurat;
        }
      //  public song()
       // {
        //    _title = string.Empty;
            //_duration = 0;
          //  _releaseDate =string.Empty;
            //_artist = new List<artist>();
            //_album = new List<album>();
            //_group = new List<group>();
       // }
    }
}