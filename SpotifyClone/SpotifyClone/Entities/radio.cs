using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
    internal class radio
    {
        private string _nameRadio;
        private List<album> _album;
        private List<song> _song;

        public string NameRadio { get => _nameRadio; set => _nameRadio = value; }
        internal List<album> Album { get => _album; set => _album = value; }
        internal List<song> Song { get => _song; set => _song = value; }
    }
}
