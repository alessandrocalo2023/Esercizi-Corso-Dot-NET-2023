using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Entities
{
    internal class Radio
    {
        private string _nameRadio;
        private List<Album> _album;
        private List<Song> _song;

        public string NameRadio { get => _nameRadio; set => _nameRadio = value; }
        internal List<Album> Album { get => _album; set => _album = value; }
        internal List<Song> Song { get => _song; set => _song = value; }
    public void PlayRadio()
        {
            //this function can excute a random PlayList
            //Or play a single song at the time 
        }
    public void StopRadio() { }
    }
}
