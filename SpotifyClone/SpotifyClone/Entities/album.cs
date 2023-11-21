using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
    internal class album
    {
        private List<artist> _artist;
        private List<song> _song;

        internal List<artist> Artist { get => _artist; set => _artist = value; }
        internal List<song> Song { get => _song; set => _song = value; }
    }
}
