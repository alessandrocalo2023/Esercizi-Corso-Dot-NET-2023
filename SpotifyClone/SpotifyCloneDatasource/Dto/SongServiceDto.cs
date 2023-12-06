using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCloneDatasource.Dto
{
    internal class SongServiceDto
    {   string _title;
        int _duration;

        public SongServiceDto(Song Song) 
        { _title = Song._title;
            _duration = Song._duration;
        }

    
    }
}
