using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
    internal class song
    {
        public  string _title;
        public int _duration;
        private List<artist> _artist;
        private List<album> _album;
        private List<group> _group;
        private string _genre;
        private string _releaseDate;


        public song(string Title, int songDurat) { }
        public song()
        {
            _title = string.Empty;
            _duration = 0;
            _releaseDate =string.Empty;
            _artist = new List<artist>();
            _album = new List<album>();
            _group = new List<group>();
        }
    }
}