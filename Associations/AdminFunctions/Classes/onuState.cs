using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminFunctions.Interfaces;

namespace AdminFunctions.Classes
{
    internal class onuState : state, IONU
    {
        bool _onu;
        public onuState(string Flag, string Currency, string Army, string Constitution, string Border, bool Onu)
            : base(Flag, Currency, Army, Constitution, Border)
        {
            _onu = Onu;
        }
    }
}