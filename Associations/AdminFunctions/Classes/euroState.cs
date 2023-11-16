using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminFunctions.Interfaces;


namespace AdminFunctions.Classes
{
    internal class euroState : state,IEU,IEUROzone
    {
        bool _euro;
        public bool Euro { get { return _euro; } set { _euro = value; } }

        public euroState(string Flag, string Currency, string Army, string Constitution, string Border, bool Euro)
           : base(Flag,Currency,Army,Constitution,Border)
        { _euro = Euro; }
    }
}
