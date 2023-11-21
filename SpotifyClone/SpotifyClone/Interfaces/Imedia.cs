using SpotifyClone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyClone.Interfaces
{
    internal interface Imedia
    {
        public void Play(song Song);
       
        //la canzone riparte da capo
        public void Stop();
       
        //la canzone riparte dal punto di interruzione
        public void Pause();

        public void Next();
        public void Previuos();

    }
}
