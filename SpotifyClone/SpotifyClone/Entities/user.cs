using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
    internal class user:person
    {
        private string Username;
        private string Password;
        private List<song> _song;
        private List<album> _album;
        private List<playlist> _playlist;
        private List<radio> _radio;

        public string Username1 { get => Username; set => Username = value; }
        public string Password1 { get => Password; set => Password = value; }
        internal List<song> Song { get => _song; set => _song = value; }
        internal List<album> Album { get => _album; set => _album = value; }
        internal List<playlist> Playlist { get => _playlist; set => _playlist = value; }
        internal List<radio> Radio { get => _radio; set => _radio = value; }

        //metodo scelta del oggetto da
        //utilizzare nella riproduzione
    
    
    }
}
