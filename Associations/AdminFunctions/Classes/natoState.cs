using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminFunctions.Interfaces;


namespace AdminFunctions.Classes
{
    internal class natoState : state, INATO
    {
        bool _nato;
        public natoState(string Flag, string Currency, string Army, string Constitution, string Border,bool Nato)
            : base(Flag,Currency,Army,Constitution,Border)
        {
            _nato = Nato;
        }
    }
}
