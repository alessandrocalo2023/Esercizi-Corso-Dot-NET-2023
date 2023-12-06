using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCloneDatasource.Dto
{
    internal class SongViewDto
    {
        string _title;
        int _rating;
        public SongViewDto(Song Song)
        {
            _title = Song._title;
            _rating = Song._rating;
        }
    }
}
