using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminFunctions.Interfaces;

namespace AdminFunctions.Classes
{
    internal class deathState : state, IDEATH
    {
        bool _death;
        public bool Death { get { return _death; } set { _death = value; } }

        public deathState(string Flag, string Currency, string Army, string Constitution, string Border, bool Death)
            : base(Flag,Currency,Army,Constitution,Border)
            
        {

            _death = Death;
        }
    }
}
