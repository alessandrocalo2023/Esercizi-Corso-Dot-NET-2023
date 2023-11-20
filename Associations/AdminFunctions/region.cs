using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminFunctions.Interfaces;
using AdminFunctions.Classes;

namespace AdminFunctions
{
    public class region : geoArea
    {
        
        
        //blocco di codice per la suddivisione della provincia in comuni
        public string _name;
        public int numProv;
        public int numMuni;
        public string[] ListProv = new string[100];
        public int[] NumMuniProv = new int[100];
        public string[] NameMuni = new string[100];
            public string Name { get { return _name; } set { _name = value; } }
        public string[] _provinceSharePop = new string[10];
       
        public region(string Name)
        {
            _name = Name;
        
        }
    }
}
