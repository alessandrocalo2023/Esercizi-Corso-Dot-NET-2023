using AdminFunctions.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminFunctions.Interfaces;

namespace AdminFunctions
{
    abstract public class euPublicAdmin 
    {//
     //+ Wellfare Services(): abstract
     //+ HNS(EU ID)
     //+ Educational System(EU ID)
        public void SSNAssistance() { }
        public void LAWAssistance(){ }
        public void EDUSystem() { }
        public string BorderReDefinition(string B) { return B; }
        abstract public void WelfarServices();


    }
}
