using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminFunctions.Interfaces;
using AdminFunctions.Classes;


namespace AdminFunctions
{
    public class state : geoArea

    {
        internal string _flag;
        internal string _currency;
        internal string _army;
        internal string _constitution;
        internal string _border;
        public string Flag { get { return _flag; } set { _flag = value; } }
        public string Currency { get { return _currency; } set { _currency = value; } }
        public string Army { get { return _army; } set { _army = value; } }
        public string Constitution { get { return _constitution; } set { _constitution = value; } }
        public string Border { get { return _border; } set { _border = value; } }
        public state(string Flag, string Currency, string Army, string Constitution, string Border)
        {
            _flag = Flag;
            _currency = Currency;
            _army = Army;
            _constitution = Constitution;
            _border = Border;
        }
    }

}
