using SpotifyCloneDatasource;
using SpotifyCloneDatasource.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyCloneService.Interfaces
{
    internal interface Imedia
    {
        public void Play(User User ,Song Song);
       
        //la canzone riparte da capo
        public void Stop(Song Song);
       
        //la canzone riparte dal punto di interruzione
        public void Pause(Song Song);

        public void Next(Song Song);
        public void Previuos(Song Song);

    }
}
