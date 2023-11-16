using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminFunctions.Interfaces;

namespace AdminFunctions.Classes
{
    internal class euState : state,IEU
    {
        bool _eu;
        public euState(string Flag, string Currency, string Army, string Constitution, string Border,bool Eu)
            : base(Flag, Currency, Army, Constitution, Border)
        {
            _eu = Eu;
        }
    }
}
